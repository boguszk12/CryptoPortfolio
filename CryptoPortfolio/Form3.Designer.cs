namespace CryptoPortfolio
{
    partial class Form3
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
            this.coinPicture2 = new System.Windows.Forms.PictureBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.checkBuy = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkSell = new System.Windows.Forms.CheckBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coinPicture2)).BeginInit();
            this.SuspendLayout();
            // 
            // coinPicture2
            // 
            this.coinPicture2.Location = new System.Drawing.Point(261, 30);
            this.coinPicture2.Name = "coinPicture2";
            this.coinPicture2.Size = new System.Drawing.Size(129, 122);
            this.coinPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coinPicture2.TabIndex = 0;
            this.coinPicture2.TabStop = false;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(261, 203);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(129, 41);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(125, 31);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(107, 20);
            this.amountBox.TabIndex = 3;
            // 
            // checkBuy
            // 
            this.checkBuy.AutoSize = true;
            this.checkBuy.Location = new System.Drawing.Point(125, 128);
            this.checkBuy.Name = "checkBuy";
            this.checkBuy.Size = new System.Drawing.Size(15, 14);
            this.checkBuy.TabIndex = 4;
            this.checkBuy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buy: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sell:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkSell
            // 
            this.checkSell.AutoSize = true;
            this.checkSell.Location = new System.Drawing.Point(125, 176);
            this.checkSell.Name = "checkSell";
            this.checkSell.Size = new System.Drawing.Size(15, 14);
            this.checkSell.TabIndex = 7;
            this.checkSell.UseVisualStyleBackColor = true;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(125, 77);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(107, 20);
            this.priceBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(21, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 283);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkSell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBuy);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.coinPicture2);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.coinPicture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coinPicture2;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.CheckBox checkBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkSell;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label4;
    }
}