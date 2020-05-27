using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snippeter
{
    public partial class ProcessSelector : Form
    {
        public string ProcessName { get; private set; }

        public ProcessSelector()
        {
            InitializeComponent();
            ProcList.DoubleClick += ProcList_DoubleClick;

            Process[] procs = Process.GetProcesses();
            Array.Sort(procs, (p1, p2) => p1.ProcessName.CompareTo(p2.ProcessName));

            foreach (Process proc in procs)
                ProcList.Items.Add($"[{proc.Id}] {proc.ProcessName}");
        }

        private void ProcList_DoubleClick(object sender, EventArgs e)
        {
            if (ProcList.SelectedItems.Count > 0)
            {
                ProcessName = ProcList.SelectedItem as string;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
