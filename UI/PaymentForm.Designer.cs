namespace UI
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.textBox_receiver = new System.Windows.Forms.TextBox();
            this.textBox_transAmt = new System.Windows.Forms.TextBox();
            this.comboBox_bank = new System.Windows.Forms.ComboBox();
            this.label_currentECNY = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_accountNum = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_currentECNY, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_accountNum, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.69932F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.15034F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.15034F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 516);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.34533F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.65467F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_cancel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_pay, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox_receiver, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_transAmt, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_bank, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 180);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.67901F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.32099F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 333);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 91);
            this.label3.TabIndex = 0;
            this.label3.Text = "Payment Detail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 108);
            this.label4.TabIndex = 1;
            this.label4.Text = "Receiver";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.label5.Location = new System.Drawing.Point(3, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 63);
            this.label5.TabIndex = 2;
            this.label5.Text = "ECNY Amount";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cancel.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(3, 265);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(223, 49);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_pay.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.btn_pay.ForeColor = System.Drawing.Color.White;
            this.btn_pay.Location = new System.Drawing.Point(232, 265);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(236, 49);
            this.btn_pay.TabIndex = 4;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // textBox_receiver
            // 
            this.textBox_receiver.Location = new System.Drawing.Point(232, 94);
            this.textBox_receiver.Name = "textBox_receiver";
            this.textBox_receiver.Size = new System.Drawing.Size(239, 29);
            this.textBox_receiver.TabIndex = 5;
            // 
            // textBox_transAmt
            // 
            this.textBox_transAmt.Location = new System.Drawing.Point(232, 202);
            this.textBox_transAmt.Name = "textBox_transAmt";
            this.textBox_transAmt.Size = new System.Drawing.Size(239, 29);
            this.textBox_transAmt.TabIndex = 6;
            // 
            // comboBox_bank
            // 
            this.comboBox_bank.FormattingEnabled = true;
            this.comboBox_bank.Items.AddRange(new object[] {
            "LocalBankA",
            "ThaiBankB"});
            this.comboBox_bank.Location = new System.Drawing.Point(232, 3);
            this.comboBox_bank.Name = "comboBox_bank";
            this.comboBox_bank.Size = new System.Drawing.Size(239, 26);
            this.comboBox_bank.TabIndex = 7;
            // 
            // label_currentECNY
            // 
            this.label_currentECNY.AutoSize = true;
            this.label_currentECNY.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_currentECNY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_currentECNY.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.label_currentECNY.ForeColor = System.Drawing.Color.Red;
            this.label_currentECNY.Location = new System.Drawing.Point(3, 143);
            this.label_currentECNY.Name = "label_currentECNY";
            this.label_currentECNY.Size = new System.Drawing.Size(474, 34);
            this.label_currentECNY.TabIndex = 2;
            this.label_currentECNY.Text = "current ECNY: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label_accountNum
            // 
            this.label_accountNum.AutoSize = true;
            this.label_accountNum.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_accountNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_accountNum.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.label_accountNum.Location = new System.Drawing.Point(3, 109);
            this.label_accountNum.Name = "label_accountNum";
            this.label_accountNum.Size = new System.Drawing.Size(474, 34);
            this.label_accountNum.TabIndex = 4;
            this.label_accountNum.Text = "Account Number";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_currentECNY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.TextBox textBox_receiver;
        private System.Windows.Forms.TextBox textBox_transAmt;
        private System.Windows.Forms.ComboBox comboBox_bank;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_accountNum;
    }
}