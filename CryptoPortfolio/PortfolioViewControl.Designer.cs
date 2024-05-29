namespace CryptoPortfolio
{
    partial class PortfolioViewControl
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
            this.coinBSPrice = new System.Windows.Forms.Label();
            this.coinAmount = new System.Windows.Forms.Label();
            this.coinType = new System.Windows.Forms.Label();
            this.coinPNL = new System.Windows.Forms.Label();
            this.coinPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coinPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // coinPicture
            // 
            this.coinPicture.Location = new System.Drawing.Point(22, 15);
            this.coinPicture.Name = "coinPicture";
            this.coinPicture.Size = new System.Drawing.Size(51, 46);
            this.coinPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coinPicture.TabIndex = 1;
            this.coinPicture.TabStop = false;
            // 
            // coinName
            // 
            this.coinName.AutoSize = true;
            this.coinName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinName.Location = new System.Drawing.Point(79, 15);
            this.coinName.Name = "coinName";
            this.coinName.Size = new System.Drawing.Size(103, 24);
            this.coinName.TabIndex = 2;
            this.coinName.Text = "coinName";
            // 
            // coinPrice
            // 
            this.coinPrice.AutoSize = true;
            this.coinPrice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinPrice.Location = new System.Drawing.Point(188, 28);
            this.coinPrice.Name = "coinPrice";
            this.coinPrice.Size = new System.Drawing.Size(98, 24);
            this.coinPrice.TabIndex = 3;
            this.coinPrice.Text = "coinPrice";
            // 
            // coinBSPrice
            // 
            this.coinBSPrice.AutoSize = true;
            this.coinBSPrice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinBSPrice.Location = new System.Drawing.Point(342, 28);
            this.coinBSPrice.Name = "coinBSPrice";
            this.coinBSPrice.Size = new System.Drawing.Size(126, 24);
            this.coinBSPrice.TabIndex = 4;
            this.coinBSPrice.Text = "coinBSPrice";
            // 
            // coinAmount
            // 
            this.coinAmount.AutoSize = true;
            this.coinAmount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinAmount.Location = new System.Drawing.Point(498, 28);
            this.coinAmount.Name = "coinAmount";
            this.coinAmount.Size = new System.Drawing.Size(118, 24);
            this.coinAmount.TabIndex = 5;
            this.coinAmount.Text = "coinAmount";
            // 
            // coinType
            // 
            this.coinType.AutoSize = true;
            this.coinType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinType.Location = new System.Drawing.Point(80, 39);
            this.coinType.Name = "coinType";
            this.coinType.Size = new System.Drawing.Size(70, 18);
            this.coinType.TabIndex = 6;
            this.coinType.Text = "coinType";
            // 
            // coinPNL
            // 
            this.coinPNL.AutoSize = true;
            this.coinPNL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinPNL.Location = new System.Drawing.Point(630, 15);
            this.coinPNL.Name = "coinPNL";
            this.coinPNL.Size = new System.Drawing.Size(89, 24);
            this.coinPNL.TabIndex = 7;
            this.coinPNL.Text = "coinPNL";
            // 
            // coinPercent
            // 
            this.coinPercent.AutoSize = true;
            this.coinPercent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinPercent.Location = new System.Drawing.Point(631, 43);
            this.coinPercent.Name = "coinPercent";
            this.coinPercent.Size = new System.Drawing.Size(91, 18);
            this.coinPercent.TabIndex = 8;
            this.coinPercent.Text = "coinPercent";
            // 
            // PortfolioViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.coinPercent);
            this.Controls.Add(this.coinPNL);
            this.Controls.Add(this.coinType);
            this.Controls.Add(this.coinAmount);
            this.Controls.Add(this.coinBSPrice);
            this.Controls.Add(this.coinPrice);
            this.Controls.Add(this.coinName);
            this.Controls.Add(this.coinPicture);
            this.Name = "PortfolioViewControl";
            this.Size = new System.Drawing.Size(765, 75);
            ((System.ComponentModel.ISupportInitialize)(this.coinPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coinPicture;
        private System.Windows.Forms.Label coinName;
        private System.Windows.Forms.Label coinPrice;
        private System.Windows.Forms.Label coinBSPrice;
        private System.Windows.Forms.Label coinAmount;
        private System.Windows.Forms.Label coinType;
        private System.Windows.Forms.Label coinPNL;
        private System.Windows.Forms.Label coinPercent;
    }
}
