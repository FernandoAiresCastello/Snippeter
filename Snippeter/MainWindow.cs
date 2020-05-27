using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snippeter
{
    public partial class MainWindow : Form
    {
        private const string ConfigFile = "snippets.ini";
        private const string SnippetFolder = "snippets";
        private const string FilenameSeparator = "^";
        private const string FileExtension = ".txt";
        private const string DefaultCategory = "Default";
        private const string DefaultSnippetName = "Empty snippet";
        private SnippetTreeLoader TreeLoader;
        private string DestinationProcess = "";
        
        public MainWindow()
        {
            InitializeComponent();
            Shown += MainWindow_Shown;
            FormClosing += MainWindow_FormClosing;
            SnippetTreeView.NodeMouseClick += SnippetTreeView_NodeMouseClick;
            SnippetTreeView.KeyDown += SnippetTreeView_KeyDown;

            BtnOptionAlwaysOnTop.PerformClick();

            LoadConfig();
            LoadSnippetTree();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }

        private void LoadConfig()
        {
            if (!File.Exists(ConfigFile))
            {
                File.Create(ConfigFile).Close();
                return;
            }

            string[] config = File.ReadAllLines(ConfigFile);

            if (config.Length > 0)
                SetDestinationProcess(config[0].Trim());
        }

        private void SaveConfig()
        {
            if (!File.Exists(ConfigFile))
                File.Create(ConfigFile).Close();

            List<string> config = new List<string>
            {
                DestinationProcess
            };

            File.WriteAllLines(ConfigFile, config);
        }

        private void LoadSnippetTree()
        {
            if (!Directory.Exists(SnippetFolder))
            {
                Directory.CreateDirectory(SnippetFolder);
                File.Create(Path.Combine(SnippetFolder, 
                    $"{DefaultCategory}{FilenameSeparator}{DefaultSnippetName}{FileExtension}")).Close();
            }

            TreeLoader = new SnippetTreeLoader(SnippetTreeView, SnippetFolder, FilenameSeparator);
            TreeLoader.Load();
        }

        private void SnippetTreeView_KeyDown(object sender, KeyEventArgs e)
        {
            TreeNode node = SnippetTreeView.SelectedNode;
            if (node == null)
                return;

            if (e.KeyCode == Keys.Delete)
            {
                SnippetTreeEntry entry = node.Tag as SnippetTreeEntry;
                DeleteSnippet(entry);
            }
        }

        private void DeleteSnippet(SnippetTreeEntry entry)
        {
            if (entry.IsCategory)
            {
                MessageBox.Show("Categories are automatically deleted when it contains no snippets",
                    "Can't delete category", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            
            DialogResult result = MessageBox.Show("Delete the snippet " + entry.InternalName,
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                File.Delete(entry.Path);
                TreeLoader.Load();
            }
            
        }

        private void SnippetTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SnippetTreeEntry snippet = e.Node.Tag as SnippetTreeEntry;
            TxtName.Text = snippet.InternalName;

            if (!string.IsNullOrEmpty(snippet.Path))
            {
                TxtContents.Text = File.ReadAllText(snippet.Path);
                if (BtnCopyPasteOnClick.Checked)
                    PasteToApplication();
            }
            else
            {
                TxtContents.Text = "";
            }
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            TxtContents.Clear();
        }

        private void BtnPasteIntoEclipse_Click(object sender, EventArgs e)
        {
            PasteToApplication();
        }

        private void BtnToggleExpansion_Click(object sender, EventArgs e)
        {
            if (BtnToggleExpansion.Checked)
                SnippetTreeView.CollapseAll();
            else
                SnippetTreeView.ExpandAll();

            BtnToggleExpansion.Checked = !BtnToggleExpansion.Checked;
        }

        public void PasteToApplication()
        {
            if (string.IsNullOrWhiteSpace(DestinationProcess))
                SelectDestinationProcess();

            if (!string.IsNullOrWhiteSpace(DestinationProcess))
            {
                TxtContents.SelectAll();
                TxtContents.Copy();
                PasteToApplication(DestinationProcess);
            }
        }

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr hwnd);

        public void PasteToApplication(string appName)
        {
            var otherApp = Process.GetProcessesByName(appName).FirstOrDefault();

            if (otherApp != null)
            {
                var handle = otherApp.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("^v");
            }
            else
            {
                MessageBox.Show($"Process not found: {DestinationProcess}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string internalName = TxtName.Text.Trim();
            string[] categoryAndName = internalName.Split('/');
            bool internalNameOk = false;
            string filename = null;

            if (categoryAndName.Length == 2)
            {
                categoryAndName[0] = categoryAndName[0].Trim();
                categoryAndName[1] = categoryAndName[1].Trim();

                if (categoryAndName[0] != "" && categoryAndName[1] != "")
                {
                    internalNameOk = true;
                    filename = categoryAndName[0] + FilenameSeparator + categoryAndName[1] + FileExtension;
                }
            }

            if (internalNameOk)
            {
                string path = Path.Combine(SnippetFolder, filename);
                File.WriteAllText(path, TxtContents.Text);
                TreeLoader.Load();
            }
            else
            {
                MessageBox.Show("Invalid internal name: " + internalName, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOptionAlwaysOnTop_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            BtnOptionAlwaysOnTop.Checked = TopMost;
        }

        private void BtnRefreshTree_Click(object sender, EventArgs e)
        {
            TreeLoader.Load();
        }

        private void BtnCopyPasteOnClick_Click(object sender, EventArgs e)
        {
            BtnCopyPasteOnClick.Checked = !BtnCopyPasteOnClick.Checked;
        }

        private void BtnTrimLines_Click(object sender, EventArgs e)
        {
            List<string> trimmedLines = new List<string>();
            string[] lines = TxtContents.Lines;
            foreach (string line in lines)
                trimmedLines.Add(line.Trim());

            TxtContents.Text = string.Join("\r\n", trimmedLines);
        }

        private void BtnOpenSnippetsFolder_Click(object sender, EventArgs e)
        {
            Process.Start(SnippetFolder);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnToggleContentPanel_Click(object sender, EventArgs e)
        {
            Splitter.Panel2Collapsed = !Splitter.Panel2Collapsed;
            BtnToggleContentPanel.Checked = Splitter.Panel2Collapsed;
        }

        private void BtnSelectDestProc_Click(object sender, EventArgs e)
        {
            SelectDestinationProcess();
        }

        private void SelectDestinationProcess()
        {
            ProcessSelector selector = new ProcessSelector();
            if (selector.ShowDialog(this) == DialogResult.OK)
                SetDestinationProcess(selector.ProcessName);
        }

        private void SetDestinationProcess(string process)
        {
            if (process.StartsWith("["))
            {
                int indexOfProcName = process.IndexOf("]") + 1;
                process = process.Substring(indexOfProcName).Trim();
            }

            DestinationProcess = process;
            LblDestProc.Text = "Destination process: " + process;
        }
    }
}
