namespace UI
{
    partial class LocalBankA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalBankA));
            this.label_greeting = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_CNY = new System.Windows.Forms.Label();
            this.label_ECNY = new System.Windows.Forms.Label();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ECNYBuy = new System.Windows.Forms.TextBox();
            this.label_exchangeResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_History = new System.Windows.Forms.Button();
            this.timer_autoRefresh = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_greeting
            // 
            this.label_greeting.AutoSize = true;
            this.label_greeting.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_greeting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_greeting.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label_greeting.Location = new System.Drawing.Point(3, 86);
            this.label_greeting.Name = "label_greeting";
            this.label_greeting.Size = new System.Drawing.Size(499, 42);
            this.label_greeting.TabIndex = 0;
            this.label_greeting.Text = "Hi, ";
            this.label_greeting.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "ECNY";
            // 
            // label_CNY
            // 
            this.label_CNY.AutoSize = true;
            this.label_CNY.Location = new System.Drawing.Point(250, 36);
            this.label_CNY.Name = "label_CNY";
            this.label_CNY.Size = new System.Drawing.Size(19, 18);
            this.label_CNY.TabIndex = 3;
            this.label_CNY.Text = "¥";
            // 
            // label_ECNY
            // 
            this.label_ECNY.AutoSize = true;
            this.label_ECNY.ForeColor = System.Drawing.Color.Red;
            this.label_ECNY.Location = new System.Drawing.Point(250, 72);
            this.label_ECNY.Name = "label_ECNY";
            this.label_ECNY.Size = new System.Drawing.Size(19, 18);
            this.label_ECNY.TabIndex = 4;
            this.label_ECNY.Text = "¥";
            // 
            // btn_Buy
            // 
            this.btn_Buy.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Buy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Buy.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btn_Buy.ForeColor = System.Drawing.Color.Black;
            this.btn_Buy.Location = new System.Drawing.Point(3, 74);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(240, 55);
            this.btn_Buy.TabIndex = 5;
            this.btn_Buy.Text = "Buy In";
            this.btn_Buy.UseVisualStyleBackColor = false;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.BackColor = System.Drawing.Color.Thistle;
            this.btn_Withdraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Withdraw.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btn_Withdraw.ForeColor = System.Drawing.Color.Black;
            this.btn_Withdraw.Location = new System.Drawing.Point(249, 74);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(241, 55);
            this.btn_Withdraw.TabIndex = 6;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = false;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_greeting, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_History, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 541);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 248);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.70707F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.29293F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(499, 173);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Withdraw, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btn_Buy, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox_ECNYBuy, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_exchangeResult, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.30769F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.69231F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(493, 132);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "ECNY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "CNY";
            // 
            // textBox_ECNYBuy
            // 
            this.textBox_ECNYBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ECNYBuy.Location = new System.Drawing.Point(249, 3);
            this.textBox_ECNYBuy.Name = "textBox_ECNYBuy";
            this.textBox_ECNYBuy.Size = new System.Drawing.Size(241, 29);
            this.textBox_ECNYBuy.TabIndex = 4;
            this.textBox_ECNYBuy.TextChanged += new System.EventHandler(this.textBox_ECNYBuy_TextChanged);
            // 
            // label_exchangeResult
            // 
            this.label_exchangeResult.AutoSize = true;
            this.label_exchangeResult.Location = new System.Drawing.Point(249, 37);
            this.label_exchangeResult.Name = "label_exchangeResult";
            this.label_exchangeResult.Size = new System.Drawing.Size(19, 18);
            this.label_exchangeResult.TabIndex = 5;
            this.label_exchangeResult.Text = "¥";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buyin / Withdraw";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.499F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.501F));
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label_ECNY, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label_CNY, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 131);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(499, 111);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Account Summary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "CNY";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(499, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_History
            // 
            this.btn_History.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_History.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btn_History.ForeColor = System.Drawing.Color.Black;
            this.btn_History.Location = new System.Drawing.Point(3, 479);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(499, 59);
            this.btn_History.TabIndex = 11;
            this.btn_History.Text = "History";
            this.btn_History.UseVisualStyleBackColor = false;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // timer_autoRefresh
            // 
            this.timer_autoRefresh.Interval = 3000;
            this.timer_autoRefresh.Tick += new System.EventHandler(this.timer_autoRefresh_Tick);
            // 
            // LocalBankA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 541);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LocalBankA";
            this.Text = "Local Bank A";
            this.Load += new System.EventHandler(this.AccountSummary_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_greeting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_CNY;
        private System.Windows.Forms.Label label_ECNY;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ECNYBuy;
        private System.Windows.Forms.Label label_exchangeResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Timer timer_autoRefresh;
    }
}