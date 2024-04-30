namespace ISA_BANK
{
    partial class FormMain
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
            this.customerServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasabahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.addKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerServiceToolStripMenuItem,
            this.tellerToolStripMenuItem,
            this.nasabahToolStripMenuItem,
            this.managerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1283, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerServiceToolStripMenuItem
            // 
            this.customerServiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewAccountToolStripMenuItem,
            this.updateAccountToolStripMenuItem,
            this.DisplayAccountToolStripMenuItem});
            this.customerServiceToolStripMenuItem.Name = "customerServiceToolStripMenuItem";
            this.customerServiceToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.customerServiceToolStripMenuItem.Text = "Customer Service";
            // 
            // createNewAccountToolStripMenuItem
            // 
            this.createNewAccountToolStripMenuItem.Name = "createNewAccountToolStripMenuItem";
            this.createNewAccountToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.createNewAccountToolStripMenuItem.Text = "Create New Account";
            this.createNewAccountToolStripMenuItem.Click += new System.EventHandler(this.createNewAccountToolStripMenuItem_Click);
            // 
            // updateAccountToolStripMenuItem
            // 
            this.updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            this.updateAccountToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.updateAccountToolStripMenuItem.Text = "Update Account";
            this.updateAccountToolStripMenuItem.Click += new System.EventHandler(this.updateAccountToolStripMenuItem_Click);
            // 
            // DisplayAccountToolStripMenuItem
            // 
            this.DisplayAccountToolStripMenuItem.Name = "DisplayAccountToolStripMenuItem";
            this.DisplayAccountToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.DisplayAccountToolStripMenuItem.Text = "Display Account";
            this.DisplayAccountToolStripMenuItem.Click += new System.EventHandler(this.DisplayAllAccountToolStripMenuItem_Click);
            // 
            // tellerToolStripMenuItem
            // 
            this.tellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withdrawalToolStripMenuItem});
            this.tellerToolStripMenuItem.Name = "tellerToolStripMenuItem";
            this.tellerToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.tellerToolStripMenuItem.Text = "Teller";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawalToolStripMenuItem
            // 
            this.withdrawalToolStripMenuItem.Name = "withdrawalToolStripMenuItem";
            this.withdrawalToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.withdrawalToolStripMenuItem.Text = "Withdrawal";
            this.withdrawalToolStripMenuItem.Click += new System.EventHandler(this.withdrawalToolStripMenuItem_Click);
            // 
            // nasabahToolStripMenuItem
            // 
            this.nasabahToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferToolStripMenuItem,
            this.transactionHistoryToolStripMenuItem,
            this.infoAccountToolStripMenuItem});
            this.nasabahToolStripMenuItem.Name = "nasabahToolStripMenuItem";
            this.nasabahToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.nasabahToolStripMenuItem.Text = "Nasabah";
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // transactionHistoryToolStripMenuItem
            // 
            this.transactionHistoryToolStripMenuItem.Name = "transactionHistoryToolStripMenuItem";
            this.transactionHistoryToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.transactionHistoryToolStripMenuItem.Text = "Transaction History";
            this.transactionHistoryToolStripMenuItem.Click += new System.EventHandler(this.transactionHistoryToolStripMenuItem_Click);
            // 
            // infoAccountToolStripMenuItem
            // 
            this.infoAccountToolStripMenuItem.Name = "infoAccountToolStripMenuItem";
            this.infoAccountToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.infoAccountToolStripMenuItem.Text = "Info Account";
            this.infoAccountToolStripMenuItem.Click += new System.EventHandler(this.infoAccountToolStripMenuItem_Click);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAccToolStripMenuItem,
            this.addKaryawanToolStripMenuItem});
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.managerToolStripMenuItem.Text = "Manager";
            // 
            // displayAccToolStripMenuItem
            // 
            this.displayAccToolStripMenuItem.Name = "displayAccToolStripMenuItem";
            this.displayAccToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.displayAccToolStripMenuItem.Text = "Display All Account";
            this.displayAccToolStripMenuItem.Click += new System.EventHandler(this.displayAccToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(486, 89);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1131, 971);
            this.panelMain.TabIndex = 1;
            // 
            // addKaryawanToolStripMenuItem
            // 
            this.addKaryawanToolStripMenuItem.Name = "addKaryawanToolStripMenuItem";
            this.addKaryawanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addKaryawanToolStripMenuItem.Text = "Add Karyawan";
            this.addKaryawanToolStripMenuItem.Click += new System.EventHandler(this.addKaryawanToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank ISA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisplayAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nasabahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAccToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addKaryawanToolStripMenuItem;
    }
}