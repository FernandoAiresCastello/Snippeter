using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snippeter
{
    public class SnippetTreeLoader
    {
        private readonly string SnippetFolder;
        private readonly string FilenameSeparator;
        private const int FolderIcon = 0;
        private const int SnippetIcon = 1;

        private readonly TreeView TreeView;

        public SnippetTreeLoader(TreeView treeView, string snippetFolder, string filenameSeparator)
        {
            TreeView = treeView;
            SnippetFolder = snippetFolder;
            FilenameSeparator = filenameSeparator;
        }

        public void Load()
        {
            List<SnippetTreeEntry> treeDefinition = LoadTreeDefinition();
            List<TreeNode> nodes = new List<TreeNode>();

            // Add categories
            foreach (SnippetTreeEntry entry in treeDefinition)
            {
                if (GetCategoryNode(nodes, entry.Category) == null)
                {
                    TreeNode categoryNode = new TreeNode(entry.Category, FolderIcon, FolderIcon);
                    categoryNode.Tag = new SnippetTreeEntry(entry.Category);
                    nodes.Add(categoryNode);
                }
            }

            // Add snippets to categories
            foreach (SnippetTreeEntry entry in treeDefinition)
            {
                TreeNode categoryNode = GetCategoryNode(nodes, entry.Category);
                TreeNode snippetNode = new TreeNode(entry.SnippetName, SnippetIcon, SnippetIcon);
                snippetNode.Tag = entry;
                categoryNode.Nodes.Add(snippetNode);
            }

            TreeNode categoryNodeToExpand = null;
            TreeNode selectedNode = TreeView.SelectedNode;
            if (selectedNode != null && selectedNode.Parent != null)
            {
                SnippetTreeEntry selectedEntry = selectedNode.Tag as SnippetTreeEntry;
                categoryNodeToExpand = GetCategoryNode(nodes, selectedEntry.Category);
            }

            TreeView.Nodes.Clear();
            TreeView.Nodes.AddRange(nodes.ToArray());
            TreeView.Refresh();

            if (categoryNodeToExpand != null)
                categoryNodeToExpand.Expand();
        }

        private TreeNode GetSnippetNode(List<TreeNode> nodes, string snippetInternalName)
        {
            foreach (TreeNode node in nodes)
            {
                SnippetTreeEntry entry = node.Tag as SnippetTreeEntry;
                if (entry.InternalName == snippetInternalName)
                    return node;
            }

            return null;
        }

        private TreeNode GetCategoryNode(List<TreeNode> nodes, string category)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text == category)
                    return node;
            }

            return null;
        }

        private List<SnippetTreeEntry> LoadTreeDefinition()
        {
            List<SnippetTreeEntry> treeDefinition = new List<SnippetTreeEntry>();
            string[] files = Directory.EnumerateFiles(SnippetFolder).ToArray();

            foreach (string file in files)
            {
                string filename = Path.GetFileNameWithoutExtension(file);
                string[] categoryAndName = filename.Split(FilenameSeparator.ToCharArray());
                string category = categoryAndName[0];
                string name = categoryAndName[1];

                treeDefinition.Add(new SnippetTreeEntry(category, name, file));
            }

            return treeDefinition;
        }
    }
}
