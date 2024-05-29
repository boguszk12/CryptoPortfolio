namespace CryptoPortfolio
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addCoin = new System.Windows.Forms.Button();
            this.coinLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.refreshPortfolio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.portfolioValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalPNL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Portfolio";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(765, 2);
            this.label2.TabIndex = 1;
            // 
            // addCoin
            // 
            this.addCoin.Location = new System.Drawing.Point(708, 92);
            this.addCoin.Name = "addCoin";
            this.addCoin.Size = new System.Drawing.Size(68, 23);
            this.addCoin.TabIndex = 2;
            this.addCoin.Text = "+";
            this.addCoin.UseVisualStyleBackColor = true;
            this.addCoin.Click += new System.EventHandler(this.addCoin_Click);
            // 
            // coinLayoutPanel
            // 
            this.coinLayoutPanel.AutoScroll = true;
            this.coinLayoutPanel.Location = new System.Drawing.Point(12, 168);
            this.coinLayoutPanel.Name = "coinLayoutPanel";
            this.coinLayoutPanel.Size = new System.Drawing.Size(765, 270);
            this.coinLayoutPanel.TabIndex = 1;
            // 
            // refreshPortfolio
            // 
            this.refreshPortfolio.Location = new System.Drawing.Point(709, 54);
            this.refreshPortfolio.Name = "refreshPortfolio";
            this.refreshPortfolio.Size = new System.Drawing.Size(68, 23);
            this.refreshPortfolio.TabIndex = 3;
            this.refreshPortfolio.Text = "Refresh";
            this.refreshPortfolio.UseVisualStyleBackColor = true;
            this.refreshPortfolio.Click += new System.EventHandler(this.refreshPortfolio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(35, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(201, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(351, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Entry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(509, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(640, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "PNL";
            // 
            // portfolioValue
            // 
            this.portfolioValue.AutoSize = true;
            this.portfolioValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portfolioValue.Location = new System.Drawing.Point(126, 59);
            this.portfolioValue.Name = "portfolioValue";
            this.portfolioValue.Size = new System.Drawing.Size(26, 18);
            this.portfolioValue.TabIndex = 9;
            this.portfolioValue.Text = "0$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(36, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total value:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(36, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total PNL:";
            // 
            // totalPNL
            // 
            this.totalPNL.AutoSize = true;
            this.totalPNL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalPNL.Location = new System.Drawing.Point(126, 97);
            this.totalPNL.Name = "totalPNL";
            this.totalPNL.Size = new System.Drawing.Size(26, 18);
            this.totalPNL.TabIndex = 12;
            this.totalPNL.Text = "0$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalPNL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.portfolioValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refreshPortfolio);
            this.Controls.Add(this.coinLayoutPanel);
            this.Controls.Add(this.addCoin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCoin;
        private System.Windows.Forms.FlowLayoutPanel coinLayoutPanel;
        private System.Windows.Forms.Button refreshPortfolio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label portfolioValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalPNL;
    }
}

