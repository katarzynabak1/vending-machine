namespace Projekt_Bak48678
{
    partial class kbUserControlCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kbUserControlCurrency));
            this.kblabelChooseCurrency = new System.Windows.Forms.Label();
            this.kbgroupBoxCurrency = new System.Windows.Forms.GroupBox();
            this.kbpictureBoxUSD = new System.Windows.Forms.PictureBox();
            this.kbpictureBoxEUR = new System.Windows.Forms.PictureBox();
            this.kbpictureBoxPLN = new System.Windows.Forms.PictureBox();
            this.kbradioButtonUSD = new System.Windows.Forms.RadioButton();
            this.kbradioButtonEUR = new System.Windows.Forms.RadioButton();
            this.kbradioButtonPLN = new System.Windows.Forms.RadioButton();
            this.kbbuttonConfirm = new System.Windows.Forms.Button();
            this.kbgroupBoxCurrency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kbpictureBoxUSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbpictureBoxEUR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbpictureBoxPLN)).BeginInit();
            this.SuspendLayout();
            // 
            // kblabelChooseCurrency
            // 
            this.kblabelChooseCurrency.AutoSize = true;
            this.kblabelChooseCurrency.Font = new System.Drawing.Font("Montserrat ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kblabelChooseCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.kblabelChooseCurrency.Location = new System.Drawing.Point(301, 68);
            this.kblabelChooseCurrency.Name = "kblabelChooseCurrency";
            this.kblabelChooseCurrency.Size = new System.Drawing.Size(267, 39);
            this.kblabelChooseCurrency.TabIndex = 0;
            this.kblabelChooseCurrency.Text = "Choose currency";
            // 
            // kbgroupBoxCurrency
            // 
            this.kbgroupBoxCurrency.Controls.Add(this.kbpictureBoxUSD);
            this.kbgroupBoxCurrency.Controls.Add(this.kbpictureBoxEUR);
            this.kbgroupBoxCurrency.Controls.Add(this.kbpictureBoxPLN);
            this.kbgroupBoxCurrency.Controls.Add(this.kbradioButtonUSD);
            this.kbgroupBoxCurrency.Controls.Add(this.kbradioButtonEUR);
            this.kbgroupBoxCurrency.Controls.Add(this.kbradioButtonPLN);
            this.kbgroupBoxCurrency.Location = new System.Drawing.Point(66, 149);
            this.kbgroupBoxCurrency.Name = "kbgroupBoxCurrency";
            this.kbgroupBoxCurrency.Size = new System.Drawing.Size(765, 207);
            this.kbgroupBoxCurrency.TabIndex = 1;
            this.kbgroupBoxCurrency.TabStop = false;
            // 
            // kbpictureBoxUSD
            // 
            this.kbpictureBoxUSD.Image = ((System.Drawing.Image)(resources.GetObject("kbpictureBoxUSD.Image")));
            this.kbpictureBoxUSD.Location = new System.Drawing.Point(553, 39);
            this.kbpictureBoxUSD.Name = "kbpictureBoxUSD";
            this.kbpictureBoxUSD.Size = new System.Drawing.Size(151, 82);
            this.kbpictureBoxUSD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kbpictureBoxUSD.TabIndex = 5;
            this.kbpictureBoxUSD.TabStop = false;
            // 
            // kbpictureBoxEUR
            // 
            this.kbpictureBoxEUR.Image = ((System.Drawing.Image)(resources.GetObject("kbpictureBoxEUR.Image")));
            this.kbpictureBoxEUR.Location = new System.Drawing.Point(286, 39);
            this.kbpictureBoxEUR.Name = "kbpictureBoxEUR";
            this.kbpictureBoxEUR.Size = new System.Drawing.Size(151, 82);
            this.kbpictureBoxEUR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kbpictureBoxEUR.TabIndex = 4;
            this.kbpictureBoxEUR.TabStop = false;
            // 
            // kbpictureBoxPLN
            // 
            this.kbpictureBoxPLN.Image = ((System.Drawing.Image)(resources.GetObject("kbpictureBoxPLN.Image")));
            this.kbpictureBoxPLN.Location = new System.Drawing.Point(25, 39);
            this.kbpictureBoxPLN.Name = "kbpictureBoxPLN";
            this.kbpictureBoxPLN.Size = new System.Drawing.Size(151, 82);
            this.kbpictureBoxPLN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kbpictureBoxPLN.TabIndex = 3;
            this.kbpictureBoxPLN.TabStop = false;
            // 
            // kbradioButtonUSD
            // 
            this.kbradioButtonUSD.AutoSize = true;
            this.kbradioButtonUSD.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbradioButtonUSD.Location = new System.Drawing.Point(574, 127);
            this.kbradioButtonUSD.Name = "kbradioButtonUSD";
            this.kbradioButtonUSD.Size = new System.Drawing.Size(107, 43);
            this.kbradioButtonUSD.TabIndex = 2;
            this.kbradioButtonUSD.TabStop = true;
            this.kbradioButtonUSD.Text = "USD";
            this.kbradioButtonUSD.UseVisualStyleBackColor = true;
            // 
            // kbradioButtonEUR
            // 
            this.kbradioButtonEUR.AutoSize = true;
            this.kbradioButtonEUR.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbradioButtonEUR.Location = new System.Drawing.Point(302, 127);
            this.kbradioButtonEUR.Name = "kbradioButtonEUR";
            this.kbradioButtonEUR.Size = new System.Drawing.Size(106, 43);
            this.kbradioButtonEUR.TabIndex = 1;
            this.kbradioButtonEUR.TabStop = true;
            this.kbradioButtonEUR.Text = "EUR";
            this.kbradioButtonEUR.UseVisualStyleBackColor = true;
            // 
            // kbradioButtonPLN
            // 
            this.kbradioButtonPLN.AutoSize = true;
            this.kbradioButtonPLN.Checked = true;
            this.kbradioButtonPLN.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbradioButtonPLN.Location = new System.Drawing.Point(51, 127);
            this.kbradioButtonPLN.Name = "kbradioButtonPLN";
            this.kbradioButtonPLN.Size = new System.Drawing.Size(105, 43);
            this.kbradioButtonPLN.TabIndex = 0;
            this.kbradioButtonPLN.TabStop = true;
            this.kbradioButtonPLN.Text = "PLN";
            this.kbradioButtonPLN.UseVisualStyleBackColor = true;
            // 
            // kbbuttonConfirm
            // 
            this.kbbuttonConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.kbbuttonConfirm.FlatAppearance.BorderSize = 0;
            this.kbbuttonConfirm.Location = new System.Drawing.Point(351, 393);
            this.kbbuttonConfirm.Name = "kbbuttonConfirm";
            this.kbbuttonConfirm.Size = new System.Drawing.Size(152, 59);
            this.kbbuttonConfirm.TabIndex = 2;
            this.kbbuttonConfirm.Text = "Confirm";
            this.kbbuttonConfirm.UseVisualStyleBackColor = false;
            this.kbbuttonConfirm.Click += new System.EventHandler(this.kbbuttonConfirm_Click);
            // 
            // kbUserControlCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kbbuttonConfirm);
            this.Controls.Add(this.kbgroupBoxCurrency);
            this.Controls.Add(this.kblabelChooseCurrency);
            this.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "kbUserControlCurrency";
            this.Size = new System.Drawing.Size(871, 522);
            this.kbgroupBoxCurrency.ResumeLayout(false);
            this.kbgroupBoxCurrency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kbpictureBoxUSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbpictureBoxEUR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbpictureBoxPLN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kblabelChooseCurrency;
        private System.Windows.Forms.GroupBox kbgroupBoxCurrency;
        private System.Windows.Forms.PictureBox kbpictureBoxUSD;
        private System.Windows.Forms.PictureBox kbpictureBoxEUR;
        private System.Windows.Forms.PictureBox kbpictureBoxPLN;
        private System.Windows.Forms.RadioButton kbradioButtonUSD;
        private System.Windows.Forms.RadioButton kbradioButtonEUR;
        private System.Windows.Forms.RadioButton kbradioButtonPLN;
        private System.Windows.Forms.Button kbbuttonConfirm;
    }
}
