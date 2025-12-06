namespace ATM_System
{
    partial class ATM
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
            this.Heading1 = new System.Windows.Forms.Label();
            this.Check_Balance = new System.Windows.Forms.Button();
            this.ButtonContainer = new System.Windows.Forms.GroupBox();
            this.Withdraw_Cash = new System.Windows.Forms.Button();
            this.Deposit_Cash = new System.Windows.Forms.Button();
            this.Welcome_Text = new System.Windows.Forms.Label();
            this.balance_text = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.USD_Text = new System.Windows.Forms.Label();
            this.USD_Value = new System.Windows.Forms.Label();
            this.LRD_value = new System.Windows.Forms.Label();
            this.LRD_Text = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Heading1
            // 
            this.Heading1.AutoSize = true;
            this.Heading1.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Heading1.Location = new System.Drawing.Point(253, 44);
            this.Heading1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Heading1.Name = "Heading1";
            this.Heading1.Size = new System.Drawing.Size(347, 41);
            this.Heading1.TabIndex = 0;
            this.Heading1.Text = "Hotail ATM Machine";
            // 
            // Check_Balance
            // 
            this.Check_Balance.BackColor = System.Drawing.SystemColors.Highlight;
            this.Check_Balance.FlatAppearance.BorderSize = 0;
            this.Check_Balance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check_Balance.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_Balance.ForeColor = System.Drawing.SystemColors.Control;
            this.Check_Balance.Location = new System.Drawing.Point(23, 49);
            this.Check_Balance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Check_Balance.Name = "Check_Balance";
            this.Check_Balance.Size = new System.Drawing.Size(169, 48);
            this.Check_Balance.TabIndex = 1;
            this.Check_Balance.Text = "Check Balance";
            this.Check_Balance.UseVisualStyleBackColor = false;
            this.Check_Balance.Click += new System.EventHandler(this.Check_Balance_Click);
            // 
            // ButtonContainer
            // 
            this.ButtonContainer.Controls.Add(this.Withdraw_Cash);
            this.ButtonContainer.Controls.Add(this.Deposit_Cash);
            this.ButtonContainer.Controls.Add(this.Check_Balance);
            this.ButtonContainer.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonContainer.Location = new System.Drawing.Point(28, 194);
            this.ButtonContainer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonContainer.Name = "ButtonContainer";
            this.ButtonContainer.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonContainer.Size = new System.Drawing.Size(397, 208);
            this.ButtonContainer.TabIndex = 2;
            this.ButtonContainer.TabStop = false;
            this.ButtonContainer.Text = "What would you like to do?";
            // 
            // Withdraw_Cash
            // 
            this.Withdraw_Cash.BackColor = System.Drawing.SystemColors.Highlight;
            this.Withdraw_Cash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Withdraw_Cash.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw_Cash.ForeColor = System.Drawing.SystemColors.Control;
            this.Withdraw_Cash.Location = new System.Drawing.Point(107, 123);
            this.Withdraw_Cash.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Withdraw_Cash.Name = "Withdraw_Cash";
            this.Withdraw_Cash.Size = new System.Drawing.Size(170, 47);
            this.Withdraw_Cash.TabIndex = 3;
            this.Withdraw_Cash.Text = "Withdraw Cash";
            this.Withdraw_Cash.UseVisualStyleBackColor = false;
            this.Withdraw_Cash.Click += new System.EventHandler(this.Withdraw_Cash_Click);
            // 
            // Deposit_Cash
            // 
            this.Deposit_Cash.BackColor = System.Drawing.SystemColors.Highlight;
            this.Deposit_Cash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deposit_Cash.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit_Cash.ForeColor = System.Drawing.SystemColors.Control;
            this.Deposit_Cash.Location = new System.Drawing.Point(202, 50);
            this.Deposit_Cash.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Deposit_Cash.Name = "Deposit_Cash";
            this.Deposit_Cash.Size = new System.Drawing.Size(169, 48);
            this.Deposit_Cash.TabIndex = 2;
            this.Deposit_Cash.Text = "Deposit Cash";
            this.Deposit_Cash.UseVisualStyleBackColor = false;
            this.Deposit_Cash.Click += new System.EventHandler(this.Deposit_Cash_Click);
            // 
            // Welcome_Text
            // 
            this.Welcome_Text.AutoSize = true;
            this.Welcome_Text.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_Text.ForeColor = System.Drawing.Color.Chartreuse;
            this.Welcome_Text.Location = new System.Drawing.Point(21, 45);
            this.Welcome_Text.Name = "Welcome_Text";
            this.Welcome_Text.Size = new System.Drawing.Size(105, 25);
            this.Welcome_Text.TabIndex = 3;
            this.Welcome_Text.Text = "Welcome:";
            // 
            // balance_text
            // 
            this.balance_text.AutoSize = true;
            this.balance_text.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_text.ForeColor = System.Drawing.Color.Chartreuse;
            this.balance_text.Location = new System.Drawing.Point(27, 90);
            this.balance_text.Name = "balance_text";
            this.balance_text.Size = new System.Drawing.Size(96, 25);
            this.balance_text.TabIndex = 4;
            this.balance_text.Text = "Balance:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserName.Location = new System.Drawing.Point(137, 45);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(190, 23);
            this.UserName.TabIndex = 5;
            this.UserName.Text = "_______________";
            // 
            // USD_Text
            // 
            this.USD_Text.AutoSize = true;
            this.USD_Text.ForeColor = System.Drawing.Color.LawnGreen;
            this.USD_Text.Location = new System.Drawing.Point(79, 130);
            this.USD_Text.Name = "USD_Text";
            this.USD_Text.Size = new System.Drawing.Size(61, 23);
            this.USD_Text.TabIndex = 6;
            this.USD_Text.Text = "USD:";
            // 
            // USD_Value
            // 
            this.USD_Value.AutoSize = true;
            this.USD_Value.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USD_Value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.USD_Value.Location = new System.Drawing.Point(144, 129);
            this.USD_Value.Name = "USD_Value";
            this.USD_Value.Size = new System.Drawing.Size(59, 23);
            this.USD_Value.TabIndex = 7;
            this.USD_Value.Text = "$0.00";
            // 
            // LRD_value
            // 
            this.LRD_value.AutoSize = true;
            this.LRD_value.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRD_value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LRD_value.Location = new System.Drawing.Point(144, 175);
            this.LRD_value.Name = "LRD_value";
            this.LRD_value.Size = new System.Drawing.Size(59, 23);
            this.LRD_value.TabIndex = 9;
            this.LRD_value.Text = "$0.00";
            // 
            // LRD_Text
            // 
            this.LRD_Text.AutoSize = true;
            this.LRD_Text.ForeColor = System.Drawing.Color.LawnGreen;
            this.LRD_Text.Location = new System.Drawing.Point(77, 174);
            this.LRD_Text.Name = "LRD_Text";
            this.LRD_Text.Size = new System.Drawing.Size(61, 23);
            this.LRD_Text.TabIndex = 8;
            this.LRD_Text.Text = "LRD:";
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout_btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.Location = new System.Drawing.Point(28, 472);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(105, 29);
            this.Logout_btn.TabIndex = 10;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LRD_value);
            this.groupBox1.Controls.Add(this.LRD_Text);
            this.groupBox1.Controls.Add(this.USD_Value);
            this.groupBox1.Controls.Add(this.USD_Text);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Controls.Add(this.balance_text);
            this.groupBox1.Controls.Add(this.Welcome_Text);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(469, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 387);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(878, 522);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonContainer);
            this.Controls.Add(this.Heading1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "ATM";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.ATM_Load);
            this.ButtonContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading1;
        private System.Windows.Forms.Button Check_Balance;
        private System.Windows.Forms.GroupBox ButtonContainer;
        private System.Windows.Forms.Button Withdraw_Cash;
        private System.Windows.Forms.Button Deposit_Cash;
        private System.Windows.Forms.Label Welcome_Text;
        private System.Windows.Forms.Label balance_text;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label USD_Text;
        private System.Windows.Forms.Label USD_Value;
        private System.Windows.Forms.Label LRD_value;
        private System.Windows.Forms.Label LRD_Text;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

