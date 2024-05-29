namespace CryptoPortfolio
{
    partial class CoinControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.coinPicture = new System.Windows.Forms.PictureBox();
            this.coinName = new System.Windows.Forms.Label();
            this.coinPrice = new System.Windows.Forms.Label();
            this.controlSelectBtn = new System.Windows.Forms.Button();
            this.coinId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coinPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // coinPicture
            // 
            this.coinPicture.Location = new System.Drawing.Point(39, 14);
            this.coinPicture.Name = "coinPicture";
            this.coinPicture.Size = new System.Drawing.Size(51, 46);
            this.coinPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coinPicture.TabIndex = 0;
            this.coinPicture.TabStop = false;
            // 
            // coinName
            // 
            this.coinName.AutoSize = true;
            this.coinName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinName.Location = new System.Drawing.Point(184, 24);
            this.coinName.Name = "coinName";
            this.coinName.Size = new System.Drawing.Size(103, 24);
            this.coinName.TabIndex = 1;
            this.coinName.Text = "coinName";
            // 
            // coinPrice
            // 
            this.coinPrice.AutoSize = true;
            this.coinPrice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinPrice.Location = new System.Drawing.Point(421, 24);
            this.coinPrice.Name = "coinPrice";
            this.coinPrice.Size = new System.Drawing.Size(98, 24);
            this.coinPrice.TabIndex = 2;
            this.coinPrice.Text = "coinPrice";
            // 
            // controlSelectBtn
            // 
            this.controlSelectBtn.Location = new System.Drawing.Point(585, 24);
            this.controlSelectBtn.Name = "controlSelectBtn";
            this.controlSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.controlSelectBtn.TabIndex = 3;
            this.controlSelectBtn.Text = "Select";
            this.controlSelectBtn.UseVisualStyleBackColor = true;
            this.controlSelectBtn.Click += new System.EventHandler(this.controlSelectBtn_Click);
            // 
            // coinId
            // 
            this.coinId.AutoSize = true;
            this.coinId.Location = new System.Drawing.Point(4, 33);
            this.coinId.Name = "coinId";
            this.coinId.Size = new System.Drawing.Size(0, 13);
            this.coinId.TabIndex = 4;
            this.coinId.Visible = false;
            // 
            // CoinControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.coinId);
            this.Controls.Add(this.controlSelectBtn);
            this.Controls.Add(this.coinPrice);
            this.Controls.Add(this.coinName);
            this.Controls.Add(this.coinPicture);
            this.Name = "CoinControl";
            this.Size = new System.Drawing.Size(687, 75);
            ((System.ComponentModel.ISupportInitialize)(this.coinPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coinPicture;
        private System.Windows.Forms.Label coinName;
        private System.Windows.Forms.Label coinPrice;
        private System.Windows.Forms.Button controlSelectBtn;
        private System.Windows.Forms.Label coinId;
    }
}
