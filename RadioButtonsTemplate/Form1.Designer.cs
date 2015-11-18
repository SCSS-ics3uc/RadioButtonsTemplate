namespace RadioButtonsTemplate
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
            this.smallRadio = new System.Windows.Forms.RadioButton();
            this.mediumRadio = new System.Windows.Forms.RadioButton();
            this.sizeBox = new System.Windows.Forms.GroupBox();
            this.largeRadio = new System.Windows.Forms.RadioButton();
            this.payBox = new System.Windows.Forms.GroupBox();
            this.creditRadio = new System.Windows.Forms.RadioButton();
            this.cashRadio = new System.Windows.Forms.RadioButton();
            this.debitRadio = new System.Windows.Forms.RadioButton();
            this.confirmButton = new System.Windows.Forms.Button();
            this.sizeBox.SuspendLayout();
            this.payBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // smallRadio
            // 
            this.smallRadio.AutoSize = true;
            this.smallRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallRadio.Location = new System.Drawing.Point(28, 32);
            this.smallRadio.Name = "smallRadio";
            this.smallRadio.Size = new System.Drawing.Size(52, 17);
            this.smallRadio.TabIndex = 2;
            this.smallRadio.TabStop = true;
            this.smallRadio.Text = "Small";
            this.smallRadio.UseVisualStyleBackColor = true;
            // 
            // mediumRadio
            // 
            this.mediumRadio.AutoSize = true;
            this.mediumRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumRadio.Location = new System.Drawing.Point(28, 56);
            this.mediumRadio.Name = "mediumRadio";
            this.mediumRadio.Size = new System.Drawing.Size(67, 17);
            this.mediumRadio.TabIndex = 3;
            this.mediumRadio.TabStop = true;
            this.mediumRadio.Text = "Medium";
            this.mediumRadio.UseVisualStyleBackColor = true;
            // 
            // sizeBox
            // 
            this.sizeBox.Controls.Add(this.largeRadio);
            this.sizeBox.Controls.Add(this.smallRadio);
            this.sizeBox.Controls.Add(this.mediumRadio);
            this.sizeBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeBox.Location = new System.Drawing.Point(45, 28);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(179, 118);
            this.sizeBox.TabIndex = 4;
            this.sizeBox.TabStop = false;
            this.sizeBox.Text = "Size";
            // 
            // largeRadio
            // 
            this.largeRadio.AutoSize = true;
            this.largeRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeRadio.Location = new System.Drawing.Point(28, 79);
            this.largeRadio.Name = "largeRadio";
            this.largeRadio.Size = new System.Drawing.Size(53, 17);
            this.largeRadio.TabIndex = 4;
            this.largeRadio.TabStop = true;
            this.largeRadio.Text = "Large";
            this.largeRadio.UseVisualStyleBackColor = true;
            // 
            // payBox
            // 
            this.payBox.Controls.Add(this.creditRadio);
            this.payBox.Controls.Add(this.cashRadio);
            this.payBox.Controls.Add(this.debitRadio);
            this.payBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBox.Location = new System.Drawing.Point(45, 166);
            this.payBox.Name = "payBox";
            this.payBox.Size = new System.Drawing.Size(179, 118);
            this.payBox.TabIndex = 5;
            this.payBox.TabStop = false;
            this.payBox.Text = "Payment Method";
            // 
            // creditRadio
            // 
            this.creditRadio.AutoSize = true;
            this.creditRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditRadio.Location = new System.Drawing.Point(28, 79);
            this.creditRadio.Name = "creditRadio";
            this.creditRadio.Size = new System.Drawing.Size(56, 17);
            this.creditRadio.TabIndex = 7;
            this.creditRadio.TabStop = true;
            this.creditRadio.Text = "Credit";
            this.creditRadio.UseVisualStyleBackColor = true;
            // 
            // cashRadio
            // 
            this.cashRadio.AutoSize = true;
            this.cashRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashRadio.Location = new System.Drawing.Point(28, 32);
            this.cashRadio.Name = "cashRadio";
            this.cashRadio.Size = new System.Drawing.Size(50, 17);
            this.cashRadio.TabIndex = 5;
            this.cashRadio.TabStop = true;
            this.cashRadio.Text = "Cash";
            this.cashRadio.UseVisualStyleBackColor = true;
            // 
            // debitRadio
            // 
            this.debitRadio.AutoSize = true;
            this.debitRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitRadio.Location = new System.Drawing.Point(28, 56);
            this.debitRadio.Name = "debitRadio";
            this.debitRadio.Size = new System.Drawing.Size(53, 17);
            this.debitRadio.TabIndex = 6;
            this.debitRadio.TabStop = true;
            this.debitRadio.Text = "Debit";
            this.debitRadio.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(86, 308);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(97, 33);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(269, 370);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.payBox);
            this.Controls.Add(this.sizeBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Palace";
            this.sizeBox.ResumeLayout(false);
            this.sizeBox.PerformLayout();
            this.payBox.ResumeLayout(false);
            this.payBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton smallRadio;
        private System.Windows.Forms.RadioButton mediumRadio;
        private System.Windows.Forms.GroupBox sizeBox;
        private System.Windows.Forms.RadioButton largeRadio;
        private System.Windows.Forms.GroupBox payBox;
        private System.Windows.Forms.RadioButton creditRadio;
        private System.Windows.Forms.RadioButton cashRadio;
        private System.Windows.Forms.RadioButton debitRadio;
        private System.Windows.Forms.Button confirmButton;
    }
}

