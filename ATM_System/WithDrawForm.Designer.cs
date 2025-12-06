using System;

namespace ATM_System
{
    partial class WithDrawForm
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
            this.USD_amount_value = new System.Windows.Forms.TextBox();
            this.USD_Amount_text = new System.Windows.Forms.Label();
            this.LRD_Amount_Text = new System.Windows.Forms.Label();
            this.LRD_amount_value = new System.Windows.Forms.TextBox();
            this.withdraw_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // USD_amount_value
            // 
            this.USD_amount_value.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USD_amount_value.Location = new System.Drawing.Point(177, 81);
            this.USD_amount_value.MaxLength = 20;
            this.USD_amount_value.Name = "USD_amount_value";
            this.USD_amount_value.Size = new System.Drawing.Size(180, 32);
            this.USD_amount_value.TabIndex = 0;
            // 
            // USD_Amount_text
            // 
            this.USD_Amount_text.AutoSize = true;
            this.USD_Amount_text.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USD_Amount_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.USD_Amount_text.Location = new System.Drawing.Point(28, 88);
            this.USD_Amount_text.Name = "USD_Amount_text";
            this.USD_Amount_text.Size = new System.Drawing.Size(143, 25);
            this.USD_Amount_text.TabIndex = 1;
            this.USD_Amount_text.Text = "USD Amount:";
            // 
            // LRD_Amount_Text
            // 
            this.LRD_Amount_Text.AutoSize = true;
            this.LRD_Amount_Text.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRD_Amount_Text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LRD_Amount_Text.Location = new System.Drawing.Point(28, 164);
            this.LRD_Amount_Text.Name = "LRD_Amount_Text";
            this.LRD_Amount_Text.Size = new System.Drawing.Size(143, 25);
            this.LRD_Amount_Text.TabIndex = 3;
            this.LRD_Amount_Text.Text = "LRD Amount:";
            // 
            // LRD_amount_value
            // 
            this.LRD_amount_value.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRD_amount_value.Location = new System.Drawing.Point(177, 163);
            this.LRD_amount_value.MaxLength = 20;
            this.LRD_amount_value.Name = "LRD_amount_value";
            this.LRD_amount_value.Size = new System.Drawing.Size(180, 32);
            this.LRD_amount_value.TabIndex = 4;
            // 
            // withdraw_btn
            // 
            this.withdraw_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.withdraw_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdraw_btn.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw_btn.Location = new System.Drawing.Point(230, 322);
            this.withdraw_btn.Name = "withdraw_btn";
            this.withdraw_btn.Size = new System.Drawing.Size(144, 42);
            this.withdraw_btn.TabIndex = 6;
            this.withdraw_btn.Text = "Widthdraw";
            this.withdraw_btn.UseVisualStyleBackColor = false;
            this.withdraw_btn.Click += new System.EventHandler(this.withdraw_btn_Click_1);
            // 
            // WithDrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(423, 422);
            this.Controls.Add(this.withdraw_btn);
            this.Controls.Add(this.LRD_amount_value);
            this.Controls.Add(this.LRD_Amount_Text);
            this.Controls.Add(this.USD_Amount_text);
            this.Controls.Add(this.USD_amount_value);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WithDrawForm";
            this.Text = "WithDrawForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.TextBox USD_amount_value;
        private System.Windows.Forms.Label USD_Amount_text;
        private System.Windows.Forms.Label LRD_Amount_Text;
        private System.Windows.Forms.TextBox LRD_amount_value;
        private System.Windows.Forms.Button withdraw_btn;
    }
}