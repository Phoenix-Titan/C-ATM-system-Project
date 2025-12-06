namespace ATM_System
{
    partial class Login
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
            this.LoginHeading = new System.Windows.Forms.Label();
            this.CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.Credit_CardNameHeading = new System.Windows.Forms.Label();
            this.PinNumberHeading = new System.Windows.Forms.Label();
            this.PinNumberTextbox = new System.Windows.Forms.TextBox();
            this.submit_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginHeading
            // 
            this.LoginHeading.AutoSize = true;
            this.LoginHeading.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginHeading.Location = new System.Drawing.Point(292, 74);
            this.LoginHeading.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LoginHeading.Name = "LoginHeading";
            this.LoginHeading.Size = new System.Drawing.Size(137, 46);
            this.LoginHeading.TabIndex = 2;
            this.LoginHeading.Text = "Login";
            this.LoginHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardNumberTextBox
            // 
            this.CardNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberTextBox.Location = new System.Drawing.Point(280, 189);
            this.CardNumberTextBox.Name = "CardNumberTextBox";
            this.CardNumberTextBox.Size = new System.Drawing.Size(366, 49);
            this.CardNumberTextBox.TabIndex = 3;
            // 
            // Credit_CardNameHeading
            // 
            this.Credit_CardNameHeading.AutoSize = true;
            this.Credit_CardNameHeading.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credit_CardNameHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Credit_CardNameHeading.Location = new System.Drawing.Point(62, 203);
            this.Credit_CardNameHeading.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Credit_CardNameHeading.Name = "Credit_CardNameHeading";
            this.Credit_CardNameHeading.Size = new System.Drawing.Size(208, 29);
            this.Credit_CardNameHeading.TabIndex = 4;
            this.Credit_CardNameHeading.Text = "Credit Number:";
            this.Credit_CardNameHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PinNumberHeading
            // 
            this.PinNumberHeading.AutoSize = true;
            this.PinNumberHeading.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinNumberHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PinNumberHeading.Location = new System.Drawing.Point(62, 320);
            this.PinNumberHeading.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PinNumberHeading.Name = "PinNumberHeading";
            this.PinNumberHeading.Size = new System.Drawing.Size(173, 29);
            this.PinNumberHeading.TabIndex = 6;
            this.PinNumberHeading.Text = "Pin Number:";
            this.PinNumberHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PinNumberTextbox
            // 
            this.PinNumberTextbox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinNumberTextbox.Location = new System.Drawing.Point(280, 306);
            this.PinNumberTextbox.MaxLength = 5;
            this.PinNumberTextbox.Name = "PinNumberTextbox";
            this.PinNumberTextbox.PasswordChar = '*';
            this.PinNumberTextbox.Size = new System.Drawing.Size(366, 49);
            this.PinNumberTextbox.TabIndex = 5;
            // 
            // submit_Btn
            // 
            this.submit_Btn.BackColor = System.Drawing.Color.LimeGreen;
            this.submit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit_Btn.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_Btn.Location = new System.Drawing.Point(454, 526);
            this.submit_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submit_Btn.Name = "submit_Btn";
            this.submit_Btn.Size = new System.Drawing.Size(222, 57);
            this.submit_Btn.TabIndex = 7;
            this.submit_Btn.Text = "Submit";
            this.submit_Btn.UseVisualStyleBackColor = false;
            this.submit_Btn.Click += new System.EventHandler(this.submit_Btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(770, 655);
            this.Controls.Add(this.submit_Btn);
            this.Controls.Add(this.PinNumberHeading);
            this.Controls.Add(this.PinNumberTextbox);
            this.Controls.Add(this.Credit_CardNameHeading);
            this.Controls.Add(this.CardNumberTextBox);
            this.Controls.Add(this.LoginHeading);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginHeading;
        private System.Windows.Forms.TextBox CardNumberTextBox;
        private System.Windows.Forms.Label Credit_CardNameHeading;
        private System.Windows.Forms.Label PinNumberHeading;
        private System.Windows.Forms.TextBox PinNumberTextbox;
        private System.Windows.Forms.Button submit_Btn;
    }
}