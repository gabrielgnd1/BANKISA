namespace ISA_BANK
{
    partial class FormTransactionHistory
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
            this.lblTransfer = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblTrfAmmount = new System.Windows.Forms.Label();
            this.lblTgl = new System.Windows.Forms.Label();
            this.lblUntil = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerUntil = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTransType = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.BackColor = System.Drawing.Color.Transparent;
            this.lblTransfer.CausesValidation = false;
            this.lblTransfer.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTransfer.Location = new System.Drawing.Point(32, 53);
            this.lblTransfer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(479, 50);
            this.lblTransfer.TabIndex = 10;
            this.lblTransfer.Text = "TRANSACTION HISTORY";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Enabled = false;
            this.txtCardNumber.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCardNumber.Location = new System.Drawing.Point(41, 196);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(549, 34);
            this.txtCardNumber.TabIndex = 18;
            // 
            // lblTrfAmmount
            // 
            this.lblTrfAmmount.AutoSize = true;
            this.lblTrfAmmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTrfAmmount.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrfAmmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTrfAmmount.Location = new System.Drawing.Point(35, 141);
            this.lblTrfAmmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrfAmmount.Name = "lblTrfAmmount";
            this.lblTrfAmmount.Size = new System.Drawing.Size(204, 36);
            this.lblTrfAmmount.TabIndex = 17;
            this.lblTrfAmmount.Text = "Card Number:\r\n";
            // 
            // lblTgl
            // 
            this.lblTgl.AutoSize = true;
            this.lblTgl.BackColor = System.Drawing.Color.Transparent;
            this.lblTgl.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTgl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTgl.Location = new System.Drawing.Point(35, 342);
            this.lblTgl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTgl.Name = "lblTgl";
            this.lblTgl.Size = new System.Drawing.Size(92, 36);
            this.lblTgl.TabIndex = 21;
            this.lblTgl.Text = "From:";
            // 
            // lblUntil
            // 
            this.lblUntil.AutoSize = true;
            this.lblUntil.BackColor = System.Drawing.Color.Transparent;
            this.lblUntil.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUntil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUntil.Location = new System.Drawing.Point(35, 443);
            this.lblUntil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUntil.Name = "lblUntil";
            this.lblUntil.Size = new System.Drawing.Size(84, 36);
            this.lblUntil.TabIndex = 23;
            this.lblUntil.Text = "Until:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(39, 392);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(551, 34);
            this.dateTimePickerFrom.TabIndex = 25;
            // 
            // dateTimePickerUntil
            // 
            this.dateTimePickerUntil.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerUntil.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerUntil.Location = new System.Drawing.Point(41, 482);
            this.dateTimePickerUntil.Name = "dateTimePickerUntil";
            this.dateTimePickerUntil.Size = new System.Drawing.Size(551, 34);
            this.dateTimePickerUntil.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(33, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Transaction Type:";
            // 
            // cbTransType
            // 
            this.cbTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransType.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransType.FormattingEnabled = true;
            this.cbTransType.Items.AddRange(new object[] {
            "Semua",
            "Pemasukan",
            "Pengeluaran"});
            this.cbTransType.Location = new System.Drawing.Point(39, 294);
            this.cbTransType.Name = "cbTransType";
            this.cbTransType.Size = new System.Drawing.Size(549, 35);
            this.cbTransType.TabIndex = 20;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(486, 545);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(102, 37);
            this.btnSend.TabIndex = 27;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(39, 605);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 312);
            this.panel1.TabIndex = 28;
            // 
            // FormTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(644, 942);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.dateTimePickerUntil);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.lblUntil);
            this.Controls.Add(this.lblTgl);
            this.Controls.Add(this.cbTransType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblTrfAmmount);
            this.Controls.Add(this.lblTransfer);
            this.Name = "FormTransactionHistory";
            this.Text = "Transaction History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblTrfAmmount;
        private System.Windows.Forms.Label lblTgl;
        private System.Windows.Forms.Label lblUntil;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerUntil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTransType;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel1;
    }
}