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
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTime = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelClock = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerServiceToolStripMenuItem,
            this.tellerToolStripMenuItem,
            this.nasabahToolStripMenuItem,
            this.managerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1551, 42);
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
            this.customerServiceToolStripMenuItem.Size = new System.Drawing.Size(220, 36);
            this.customerServiceToolStripMenuItem.Text = "Customer Service";
            // 
            // createNewAccountToolStripMenuItem
            // 
            this.createNewAccountToolStripMenuItem.Name = "createNewAccountToolStripMenuItem";
            this.createNewAccountToolStripMenuItem.Size = new System.Drawing.Size(365, 44);
            this.createNewAccountToolStripMenuItem.Text = "Create New Account";
            this.createNewAccountToolStripMenuItem.Click += new System.EventHandler(this.createNewAccountToolStripMenuItem_Click);
            // 
            // updateAccountToolStripMenuItem
            // 
            this.updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            this.updateAccountToolStripMenuItem.Size = new System.Drawing.Size(365, 44);
            this.updateAccountToolStripMenuItem.Text = "Update Account";
            this.updateAccountToolStripMenuItem.Click += new System.EventHandler(this.updateAccountToolStripMenuItem_Click);
            // 
            // DisplayAccountToolStripMenuItem
            // 
            this.DisplayAccountToolStripMenuItem.Name = "DisplayAccountToolStripMenuItem";
            this.DisplayAccountToolStripMenuItem.Size = new System.Drawing.Size(365, 44);
            this.DisplayAccountToolStripMenuItem.Text = "Display Account";
            this.DisplayAccountToolStripMenuItem.Click += new System.EventHandler(this.DisplayAccountToolStripMenuItem_Click);
            // 
            // tellerToolStripMenuItem
            // 
            this.tellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withdrawalToolStripMenuItem});
            this.tellerToolStripMenuItem.Name = "tellerToolStripMenuItem";
            this.tellerToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.tellerToolStripMenuItem.Text = "Teller";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(266, 44);
            this.depositToolStripMenuItem.Text = "Deposit";
            // 
            // withdrawalToolStripMenuItem
            // 
            this.withdrawalToolStripMenuItem.Name = "withdrawalToolStripMenuItem";
            this.withdrawalToolStripMenuItem.Size = new System.Drawing.Size(266, 44);
            this.withdrawalToolStripMenuItem.Text = "Withdrawal";
            // 
            // nasabahToolStripMenuItem
            // 
            this.nasabahToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferToolStripMenuItem,
            this.transactionHistoryToolStripMenuItem});
            this.nasabahToolStripMenuItem.Name = "nasabahToolStripMenuItem";
            this.nasabahToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
            this.nasabahToolStripMenuItem.Text = "Nasabah";
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(349, 44);
            this.transferToolStripMenuItem.Text = "Transfer";
            // 
            // transactionHistoryToolStripMenuItem
            // 
            this.transactionHistoryToolStripMenuItem.Name = "transactionHistoryToolStripMenuItem";
            this.transactionHistoryToolStripMenuItem.Size = new System.Drawing.Size(349, 44);
            this.transactionHistoryToolStripMenuItem.Text = "Transaction History";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAccToolStripMenuItem});
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(129, 36);
            this.managerToolStripMenuItem.Text = "Manager";
            // 
            // displayAccToolStripMenuItem
            // 
            this.displayAccToolStripMenuItem.Name = "displayAccToolStripMenuItem";
            this.displayAccToolStripMenuItem.Size = new System.Drawing.Size(318, 44);
            this.displayAccToolStripMenuItem.Text = "Display Account";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(4, 233);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1546, 1373);
            this.panelMain.TabIndex = 1;
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.Lavender;
            this.panelTime.Controls.Add(this.labelDate);
            this.panelTime.Controls.Add(this.labelClock);
            this.panelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTime.Location = new System.Drawing.Point(1167, 50);
            this.panelTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(300, 173);
            this.panelTime.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDate.Location = new System.Drawing.Point(82, 95);
            this.labelDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(130, 62);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "date";
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.BackColor = System.Drawing.Color.Transparent;
            this.labelClock.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelClock.Location = new System.Drawing.Point(64, 15);
            this.labelClock.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(171, 80);
            this.labelClock.TabIndex = 3;
            this.labelClock.Text = "time";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1551, 1648);
            this.ControlBox = false;
            this.Controls.Add(this.panelTime);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
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
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAccToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}