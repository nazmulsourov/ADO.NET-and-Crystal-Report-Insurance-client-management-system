namespace InsuranceInfo
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClientEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPolicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policyDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durationEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claimTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.newClientToolStripMenuItem,
            this.policyToolStripMenuItem,
            this.policyDurationToolStripMenuItem,
            this.claimTypeToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // newClientToolStripMenuItem
            // 
            this.newClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClientEntryToolStripMenuItem});
            this.newClientToolStripMenuItem.Name = "newClientToolStripMenuItem";
            this.newClientToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newClientToolStripMenuItem.Text = "New Client";
            // 
            // newClientEntryToolStripMenuItem
            // 
            this.newClientEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryToolStripMenuItem});
            this.newClientEntryToolStripMenuItem.Name = "newClientEntryToolStripMenuItem";
            this.newClientEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newClientEntryToolStripMenuItem.Text = "New Client Entry";
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entryToolStripMenuItem.Text = "Entry";
            this.entryToolStripMenuItem.Click += new System.EventHandler(this.entryToolStripMenuItem_Click);
            // 
            // policyToolStripMenuItem
            // 
            this.policyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPolicyToolStripMenuItem});
            this.policyToolStripMenuItem.Name = "policyToolStripMenuItem";
            this.policyToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.policyToolStripMenuItem.Text = "Policy";
            // 
            // newPolicyToolStripMenuItem
            // 
            this.newPolicyToolStripMenuItem.Name = "newPolicyToolStripMenuItem";
            this.newPolicyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newPolicyToolStripMenuItem.Text = "New Policy";
            this.newPolicyToolStripMenuItem.Click += new System.EventHandler(this.newPolicyToolStripMenuItem_Click);
            // 
            // policyDurationToolStripMenuItem
            // 
            this.policyDurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durationEntryToolStripMenuItem});
            this.policyDurationToolStripMenuItem.Name = "policyDurationToolStripMenuItem";
            this.policyDurationToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.policyDurationToolStripMenuItem.Text = "Policy Duration";
            // 
            // durationEntryToolStripMenuItem
            // 
            this.durationEntryToolStripMenuItem.Name = "durationEntryToolStripMenuItem";
            this.durationEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.durationEntryToolStripMenuItem.Text = "Duration Entry";
            this.durationEntryToolStripMenuItem.Click += new System.EventHandler(this.durationEntryToolStripMenuItem_Click);
            // 
            // claimTypeToolStripMenuItem
            // 
            this.claimTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryToolStripMenuItem1});
            this.claimTypeToolStripMenuItem.Name = "claimTypeToolStripMenuItem";
            this.claimTypeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.claimTypeToolStripMenuItem.Text = "ClaimType";
            // 
            // entryToolStripMenuItem1
            // 
            this.entryToolStripMenuItem1.Name = "entryToolStripMenuItem1";
            this.entryToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.entryToolStripMenuItem1.Text = "Entry";
            this.entryToolStripMenuItem1.Click += new System.EventHandler(this.entryToolStripMenuItem1_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientInformationToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // clientInformationToolStripMenuItem
            // 
            this.clientInformationToolStripMenuItem.Name = "clientInformationToolStripMenuItem";
            this.clientInformationToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.clientInformationToolStripMenuItem.Text = "Client Information Report";
            this.clientInformationToolStripMenuItem.Click += new System.EventHandler(this.clientInformationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newClientEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPolicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policyDurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durationEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem claimTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientInformationToolStripMenuItem;
    }
}

