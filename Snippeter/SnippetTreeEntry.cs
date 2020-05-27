using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippeter
{
    public class SnippetTreeEntry
    {
        public string InternalName => Category + "/" + (SnippetName ?? "");
        public bool IsCategory => string.IsNullOrWhiteSpace(SnippetName);
        public bool IsSnippet => !IsCategory;

        public string Category { set; get; }
        public string SnippetName { set; get; }
        public string Path { set; get; }

        public SnippetTreeEntry(string category)
        {
            Category = category;
        }

        public SnippetTreeEntry(string category, string name, string path)
        {
            Category = category;
            SnippetName = name;
            Path = path;
        }
    }
}
