namespace Projekt_Bak48678
{
    partial class kbUserControlPay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kbUserControlPay));
            this.kblabelChosenProduct = new System.Windows.Forms.Label();
            this.kblabelReceipt = new System.Windows.Forms.Label();
            this.kblabelPaymentMethod = new System.Windows.Forms.Label();
            this.kbgroupBoxPaymentMethod = new System.Windows.Forms.GroupBox();
            this.kbradioButtonCash = new System.Windows.Forms.RadioButton();
            this.kbradioButtonCard = new System.Windows.Forms.RadioButton();
            this.kbpictureBoxCard = new System.Windows.Forms.PictureBox();
            this.kbbuttonCard = new System.Windows.Forms.Button();
            this.kblabelCoin = new System.Windows.Forms.Label();
            this.kbbuttonHalf = new System.Windows.Forms.Button();
            this.kbbuttonOne = new System.Windows.Forms.Button();
            this.kbbuttonFive = new System.Windows.Forms.Button();
            this.kbbuttonTwo = new System.Windows.Forms.Button();
            this.kblabelCredit = new System.Windows.Forms.Label();
            this.kbbuttonPay = new System.Windows.Forms.Button();
            this.kblabelMoneyLeft = new System.Windows.Forms.Label();
            this.kblabelChange = new System.Windows.Forms.Label();
            this.kberrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.kblabelAvailableDenominations = new System.Windows.Forms.Label();
            this.kbgroupBoxPaymentMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kbpictureBoxCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kberrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // kblabelChosenProduct
            // 
            this.kblabelChosenProduct.AutoSize = true;
            this.kblabelChosenProduct.Location = new System.Drawing.Point(49, 42);
            this.kblabelChosenProduct.Name = "kblabelChosenProduct";
            this.kblabelChosenProduct.Size = new System.Drawing.Size(232, 27);
            this.kblabelChosenProduct.TabIndex = 0;
            this.kblabelChosenProduct.Text = "Your chosen product: ";
            // 
            // kblabelReceipt
            // 
            this.kblabelReceipt.AutoSize = true;
            this.kblabelReceipt.Location = new System.Drawing.Point(497, 42);
            this.kblabelReceipt.Name = "kblabelReceipt";
            this.kblabelReceipt.Size = new System.Drawing.Size(92, 27);
            this.kblabelReceipt.TabIndex = 1;
            this.kblabelReceipt.Text = "It costs: ";
            // 
            // kblabelPaymentMethod
            // 
            this.kblabelPaymentMethod.AutoSize = true;
            this.kblabelPaymentMethod.Location = new System.Drawing.Point(267, 107);
            this.kblabelPaymentMethod.Name = "kblabelPaymentMethod";
            this.kblabelPaymentMethod.Size = new System.Drawing.Size(293, 27);
            this.kblabelPaymentMethod.TabIndex = 2;
            this.kblabelPaymentMethod.Text = "Choose a payment method:";
            // 
            // kbgroupBoxPaymentMethod
            // 
            this.kbgroupBoxPaymentMethod.Controls.Add(this.kbradioButtonCash);
            this.kbgroupBoxPaymentMethod.Controls.Add(this.kbradioButtonCard);
            this.kbgroupBoxPaymentMethod.Location = new System.Drawing.Point(248, 146);
            this.kbgroupBoxPaymentMethod.Name = "kbgroupBoxPaymentMethod";
            this.kbgroupBoxPaymentMethod.Size = new System.Drawing.Size(290, 79);
            this.kbgroupBoxPaymentMethod.TabIndex = 3;
            this.kbgroupBoxPaymentMethod.TabStop = false;
            // 
            // kbradioButtonCash
            // 
            this.kbradioButtonCash.AutoSize = true;
            this.kbradioButtonCash.Location = new System.Drawing.Point(175, 31);
            this.kbradioButtonCash.Name = "kbradioButtonCash";
            this.kbradioButtonCash.Size = new System.Drawing.Size(87, 31);
            this.kbradioButtonCash.TabIndex = 1;
            this.kbradioButtonCash.TabStop = true;
            this.kbradioButtonCash.Text = "Cash";
            this.kbradioButtonCash.UseVisualStyleBackColor = true;
            this.kbradioButtonCash.CheckedChanged += new System.EventHandler(this.kbradioButtonCash_CheckedChanged);
            // 
            // kbradioButtonCard
            // 
            this.kbradioButtonCard.AutoSize = true;
            this.kbradioButtonCard.Location = new System.Drawing.Point(24, 31);
            this.kbradioButtonCard.Name = "kbradioButtonCard";
            this.kbradioButtonCard.Size = new System.Drawing.Size(85, 31);
            this.kbradioButtonCard.TabIndex = 0;
            this.kbradioButtonCard.TabStop = true;
            this.kbradioButtonCard.Text = "Card";
            this.kbradioButtonCard.UseVisualStyleBackColor = true;
            this.kbradioButtonCard.CheckedChanged += new System.EventHandler(this.kbradioButtonCard_CheckedChanged);
            // 
            // kbpictureBoxCard
            // 
            this.kbpictureBoxCard.Enabled = false;
            this.kbpictureBoxCard.Image = ((System.Drawing.Image)(resources.GetObject("kbpictureBoxCard.Image")));
            this.kbpictureBoxCard.Location = new System.Drawing.Point(104, 277);
            this.kbpictureBoxCard.Name = "kbpictureBoxCard";
            this.kbpictureBoxCard.Size = new System.Drawing.Size(207, 120);
            this.kbpictureBoxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kbpictureBoxCard.TabIndex = 4;
            this.kbpictureBoxCard.TabStop = false;
            // 
            // kbbuttonCard
            // 
            this.kbbuttonCard.Enabled = false;
            this.kbbuttonCard.Location = new System.Drawing.Point(111, 418);
            this.kbbuttonCard.Name = "kbbuttonCard";
            this.kbbuttonCard.Size = new System.Drawing.Size(193, 51);
            this.kbbuttonCard.TabIndex = 5;
            this.kbbuttonCard.Text = "TAP CARD HERE";
            this.kbbuttonCard.UseVisualStyleBackColor = true;
            this.kbbuttonCard.Click += new System.EventHandler(this.kbbuttonCard_Click);
            // 
            // kblabelCoin
            // 
            this.kblabelCoin.AutoSize = true;
            this.kblabelCoin.Location = new System.Drawing.Point(486, 267);
            this.kblabelCoin.Name = "kblabelCoin";
            this.kblabelCoin.Size = new System.Drawing.Size(135, 27);
            this.kblabelCoin.TabIndex = 6;
            this.kblabelCoin.Text = "Insert a coin";
            // 
            // kbbuttonHalf
            // 
            this.kbbuttonHalf.Enabled = false;
            this.kbbuttonHalf.Location = new System.Drawing.Point(464, 311);
            this.kbbuttonHalf.Name = "kbbuttonHalf";
            this.kbbuttonHalf.Size = new System.Drawing.Size(76, 76);
            this.kbbuttonHalf.TabIndex = 7;
            this.kbbuttonHalf.Text = "0,50";
            this.kbbuttonHalf.UseVisualStyleBackColor = true;
            this.kbbuttonHalf.Click += new System.EventHandler(this.kbbuttonHalf_Click);
            // 
            // kbbuttonOne
            // 
            this.kbbuttonOne.Enabled = false;
            this.kbbuttonOne.Location = new System.Drawing.Point(566, 311);
            this.kbbuttonOne.Name = "kbbuttonOne";
            this.kbbuttonOne.Size = new System.Drawing.Size(76, 76);
            this.kbbuttonOne.TabIndex = 8;
            this.kbbuttonOne.Text = "1,00";
            this.kbbuttonOne.UseVisualStyleBackColor = true;
            this.kbbuttonOne.Click += new System.EventHandler(this.kbbuttonOne_Click);
            // 
            // kbbuttonFive
            // 
            this.kbbuttonFive.Enabled = false;
            this.kbbuttonFive.Location = new System.Drawing.Point(566, 393);
            this.kbbuttonFive.Name = "kbbuttonFive";
            this.kbbuttonFive.Size = new System.Drawing.Size(76, 76);
            this.kbbuttonFive.TabIndex = 9;
            this.kbbuttonFive.Text = "5,00";
            this.kbbuttonFive.UseVisualStyleBackColor = true;
            this.kbbuttonFive.Click += new System.EventHandler(this.kbbuttonFive_Click);
            // 
            // kbbuttonTwo
            // 
            this.kbbuttonTwo.Enabled = false;
            this.kbbuttonTwo.Location = new System.Drawing.Point(464, 393);
            this.kbbuttonTwo.Name = "kbbuttonTwo";
            this.kbbuttonTwo.Size = new System.Drawing.Size(76, 76);
            this.kbbuttonTwo.TabIndex = 10;
            this.kbbuttonTwo.Text = "2,00";
            this.kbbuttonTwo.UseVisualStyleBackColor = true;
            this.kbbuttonTwo.Click += new System.EventHandler(this.kbbuttonTwo_Click);
            // 
            // kblabelCredit
            // 
            this.kblabelCredit.AutoSize = true;
            this.kblabelCredit.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kblabelCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.kblabelCredit.Location = new System.Drawing.Point(463, 482);
            this.kblabelCredit.Name = "kblabelCredit";
            this.kblabelCredit.Size = new System.Drawing.Size(141, 27);
            this.kblabelCredit.TabIndex = 12;
            this.kblabelCredit.Text = "Your credit: ";
            // 
            // kbbuttonPay
            // 
            this.kbbuttonPay.Enabled = false;
            this.kbbuttonPay.Location = new System.Drawing.Point(678, 372);
            this.kbbuttonPay.Name = "kbbuttonPay";
            this.kbbuttonPay.Size = new System.Drawing.Size(171, 39);
            this.kbbuttonPay.TabIndex = 13;
            this.kbbuttonPay.Text = "PAY WITH CASH";
            this.kbbuttonPay.UseVisualStyleBackColor = true;
            this.kbbuttonPay.Click += new System.EventHandler(this.kbbuttonPay_Click);
            // 
            // kblabelMoneyLeft
            // 
            this.kblabelMoneyLeft.AutoSize = true;
            this.kblabelMoneyLeft.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kblabelMoneyLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.kblabelMoneyLeft.Location = new System.Drawing.Point(698, 418);
            this.kblabelMoneyLeft.Name = "kblabelMoneyLeft";
            this.kblabelMoneyLeft.Size = new System.Drawing.Size(65, 27);
            this.kblabelMoneyLeft.TabIndex = 14;
            this.kblabelMoneyLeft.Text = "Left: ";
            // 
            // kblabelChange
            // 
            this.kblabelChange.AutoSize = true;
            this.kblabelChange.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kblabelChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.kblabelChange.Location = new System.Drawing.Point(698, 454);
            this.kblabelChange.Name = "kblabelChange";
            this.kblabelChange.Size = new System.Drawing.Size(105, 27);
            this.kblabelChange.TabIndex = 15;
            this.kblabelChange.Text = "Change: ";
            // 
            // kberrorProvider1
            // 
            this.kberrorProvider1.ContainerControl = this;
            this.kberrorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("kberrorProvider1.Icon")));
            // 
            // kblabelAvailableDenominations
            // 
            this.kblabelAvailableDenominations.AutoSize = true;
            this.kblabelAvailableDenominations.Location = new System.Drawing.Point(561, 160);
            this.kblabelAvailableDenominations.Name = "kblabelAvailableDenominations";
            this.kblabelAvailableDenominations.Size = new System.Drawing.Size(268, 27);
            this.kblabelAvailableDenominations.TabIndex = 16;
            this.kblabelAvailableDenominations.Text = "Available Denominations:";
            // 
            // kbUserControlPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kblabelAvailableDenominations);
            this.Controls.Add(this.kblabelChange);
            this.Controls.Add(this.kblabelMoneyLeft);
            this.Controls.Add(this.kbbuttonPay);
            this.Controls.Add(this.kblabelCredit);
            this.Controls.Add(this.kbbuttonTwo);
            this.Controls.Add(this.kbbuttonFive);
            this.Controls.Add(this.kbbuttonOne);
            this.Controls.Add(this.kbbuttonHalf);
            this.Controls.Add(this.kblabelCoin);
            this.Controls.Add(this.kbbuttonCard);
            this.Controls.Add(this.kbpictureBoxCard);
            this.Controls.Add(this.kbgroupBoxPaymentMethod);
            this.Controls.Add(this.kblabelPaymentMethod);
            this.Controls.Add(this.kblabelReceipt);
            this.Controls.Add(this.kblabelChosenProduct);
            this.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kbUserControlPay";
            this.Size = new System.Drawing.Size(903, 522);
            this.kbgroupBoxPaymentMethod.ResumeLayout(false);
            this.kbgroupBoxPaymentMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kbpictureBoxCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kberrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kblabelChosenProduct;
        private System.Windows.Forms.Label kblabelPaymentMethod;
        private System.Windows.Forms.Label kblabelReceipt;
        private System.Windows.Forms.GroupBox kbgroupBoxPaymentMethod;
        private System.Windows.Forms.RadioButton kbradioButtonCash;
        private System.Windows.Forms.RadioButton kbradioButtonCard;
        private System.Windows.Forms.PictureBox kbpictureBoxCard;
        private System.Windows.Forms.Button kbbuttonCard;
        private System.Windows.Forms.Label kblabelCoin;
        private System.Windows.Forms.Button kbbuttonHalf;
        private System.Windows.Forms.Button kbbuttonOne;
        private System.Windows.Forms.Button kbbuttonFive;
        private System.Windows.Forms.Button kbbuttonTwo;
        private System.Windows.Forms.Label kblabelCredit;
        private System.Windows.Forms.Button kbbuttonPay;
        private System.Windows.Forms.Label kblabelMoneyLeft;
        private System.Windows.Forms.Label kblabelChange;
        private System.Windows.Forms.ErrorProvider kberrorProvider1;
        private System.Windows.Forms.Label kblabelAvailableDenominations;
    }
}
