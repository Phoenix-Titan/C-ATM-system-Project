namespace ATM_System
{
    partial class DepositForm
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
            this.Deposit_cash = new System.Windows.Forms.Button();
            this.USD_Value = new System.Windows.Forms.TextBox();
            this.LRD_Value = new System.Windows.Forms.TextBox();
            this.Deposit_heading = new System.Windows.Forms.Label();
            this.USD_Text = new System.Windows.Forms.Label();
            this.LRD_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Deposit_cash
            // 
            this.Deposit_cash.BackColor = System.Drawing.Color.LawnGreen;
            this.Deposit_cash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deposit_cash.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit_cash.Location = new System.Drawing.Point(235, 351);
            this.Deposit_cash.Name = "Deposit_cash";
            this.Deposit_cash.Size = new System.Drawing.Size(130, 35);
            this.Deposit_cash.TabIndex = 0;
            this.Deposit_cash.Text = "Deposit Cash";
            this.Deposit_cash.UseVisualStyleBackColor = false;
            this.Deposit_cash.Click += new System.EventHandler(this.Deposit_cash_Click);
            // 
            // USD_Value
            // 
            this.USD_Value.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USD_Value.Location = new System.Drawing.Point(148, 118);
            this.USD_Value.MaxLength = 327;
            this.USD_Value.Name = "USD_Value";
            this.USD_Value.Size = new System.Drawing.Size(204, 32);
            this.USD_Value.TabIndex = 1;
            // 
            // LRD_Value
            // 
            this.LRD_Value.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRD_Value.Location = new System.Drawing.Point(148, 189);
            this.LRD_Value.Name = "LRD_Value";
            this.LRD_Value.Size = new System.Drawing.Size(204, 32);
            this.LRD_Value.TabIndex = 2;
            // 
            // Deposit_heading
            // 
            this.Deposit_heading.AutoSize = true;
            this.Deposit_heading.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit_heading.ForeColor = System.Drawing.SystemColors.Control;
            this.Deposit_heading.Location = new System.Drawing.Point(162, 42);
            this.Deposit_heading.Name = "Deposit_heading";
            this.Deposit_heading.Size = new System.Drawing.Size(106, 31);
            this.Deposit_heading.TabIndex = 3;
            this.Deposit_heading.Text = "Deposit";
            // 
            // USD_Text
            // 
            this.USD_Text.AutoSize = true;
            this.USD_Text.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USD_Text.ForeColor = System.Drawing.SystemColors.Control;
            this.USD_Text.Location = new System.Drawing.Point(64, 118);
            this.USD_Text.Name = "USD_Text";
            this.USD_Text.Size = new System.Drawing.Size(77, 31);
            this.USD_Text.TabIndex = 5;
            this.USD_Text.Text = "USD:";
            // 
            // LRD_Text
            // 
            this.LRD_Text.AutoSize = true;
            this.LRD_Text.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRD_Text.ForeColor = System.Drawing.SystemColors.Control;
            this.LRD_Text.Location = new System.Drawing.Point(64, 190);
            this.LRD_Text.Name = "LRD_Text";
            this.LRD_Text.Size = new System.Drawing.Size(77, 31);
            this.LRD_Text.TabIndex = 6;
            this.LRD_Text.Text = "LRD:";
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.LRD_Text);
            this.Controls.Add(this.USD_Text);
            this.Controls.Add(this.Deposit_heading);
            this.Controls.Add(this.LRD_Value);
            this.Controls.Add(this.USD_Value);
            this.Controls.Add(this.Deposit_cash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DepositForm";
            this.Text = "Deposit_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Deposit_cash;
        private System.Windows.Forms.TextBox USD_Value;
        private System.Windows.Forms.TextBox LRD_Value;
        private System.Windows.Forms.Label Deposit_heading;
        private System.Windows.Forms.Label USD_Text;
        private System.Windows.Forms.Label LRD_Text;
    }
}