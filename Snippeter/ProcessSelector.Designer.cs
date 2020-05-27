namespace Snippeter
{
    partial class ProcessSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProcList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ProcList
            // 
            this.ProcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcList.FormattingEnabled = true;
            this.ProcList.Location = new System.Drawing.Point(0, 0);
            this.ProcList.Name = "ProcList";
            this.ProcList.Size = new System.Drawing.Size(205, 321);
            this.ProcList.TabIndex = 0;
            // 
            // ProcessSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 321);
            this.Controls.Add(this.ProcList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select destination process";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProcList;
    }
}