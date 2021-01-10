namespace Projekt_Bak48678
{
    partial class kbUserControlAboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kbUserControlAboutMe));
            this.kblabelName = new System.Windows.Forms.Label();
            this.kblabelAboutME = new System.Windows.Forms.Label();
            this.kbpictureBoxPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kbpictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // kblabelName
            // 
            this.kblabelName.AutoSize = true;
            this.kblabelName.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kblabelName.Location = new System.Drawing.Point(291, 82);
            this.kblabelName.Name = "kblabelName";
            this.kblabelName.Size = new System.Drawing.Size(298, 50);
            this.kblabelName.TabIndex = 0;
            this.kblabelName.Text = "Katarzyna Bąk";
            // 
            // kblabelAboutME
            // 
            this.kblabelAboutME.AutoSize = true;
            this.kblabelAboutME.Location = new System.Drawing.Point(295, 185);
            this.kblabelAboutME.Name = "kblabelAboutME";
            this.kblabelAboutME.Size = new System.Drawing.Size(347, 189);
            this.kblabelAboutME.TabIndex = 1;
            this.kblabelAboutME.Text = "Index Number: 48678\r\n\r\nField Of Study: Computer Science\r\n\r\nSemester: V\r\n\r\nSubject" +
    ": Algorytmy i złożoność\r\n";
            // 
            // kbpictureBoxPhoto
            // 
            this.kbpictureBoxPhoto.Image = ((System.Drawing.Image)(resources.GetObject("kbpictureBoxPhoto.Image")));
            this.kbpictureBoxPhoto.Location = new System.Drawing.Point(52, 82);
            this.kbpictureBoxPhoto.Name = "kbpictureBoxPhoto";
            this.kbpictureBoxPhoto.Size = new System.Drawing.Size(211, 227);
            this.kbpictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kbpictureBoxPhoto.TabIndex = 2;
            this.kbpictureBoxPhoto.TabStop = false;
            // 
            // kbUserControlAboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kbpictureBoxPhoto);
            this.Controls.Add(this.kblabelAboutME);
            this.Controls.Add(this.kblabelName);
            this.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kbUserControlAboutMe";
            this.Size = new System.Drawing.Size(896, 525);
            ((System.ComponentModel.ISupportInitialize)(this.kbpictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kblabelName;
        private System.Windows.Forms.Label kblabelAboutME;
        private System.Windows.Forms.PictureBox kbpictureBoxPhoto;
    }
}
