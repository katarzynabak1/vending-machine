namespace Projekt_Bak48678
{
    partial class kbForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kbForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.kbpanelHeader = new System.Windows.Forms.Panel();
            this.kbbuttonExit = new System.Windows.Forms.Button();
            this.kbpanelChosenButton = new System.Windows.Forms.Panel();
            this.kbbuttonReset = new System.Windows.Forms.Button();
            this.kbbuttonCurrency = new System.Windows.Forms.Button();
            this.kbbuttonPayment = new System.Windows.Forms.Button();
            this.kbbuttonChooseProduct = new System.Windows.Forms.Button();
            this.kblabelVendingMachine = new System.Windows.Forms.Label();
            this.kbpictureBoxVM = new System.Windows.Forms.PictureBox();
            this.kbpanelMenu = new System.Windows.Forms.Panel();
            this.kbbuttonAboutMe = new System.Windows.Forms.Button();
            this.kblabelCategories = new System.Windows.Forms.Label();
            this.kbbuttonHealthy = new System.Windows.Forms.Button();
            this.kbbuttonHot = new System.Windows.Forms.Button();
            this.kbbuttonCold = new System.Windows.Forms.Button();
            this.kbbuttonSnacks = new System.Windows.Forms.Button();
            this.kbUserControlPay1 = new Projekt_Bak48678.kbUserControlPay();
            this.kbUserControlSnacks1 = new Projekt_Bak48678.kbUserControlSnacks();
            this.kbUserControlHotDrinks1 = new Projekt_Bak48678.kbUserControlHotDrinks();
            this.kbUserControlHealthy1 = new Projekt_Bak48678.kbUserControlHealthy();
            this.kbUserControlAboutMe1 = new Projekt_Bak48678.kbUserControlAboutMe();
            this.kbUserControlColdDrinks1 = new Projekt_Bak48678.kbUserControlColdDrinks();
            this.kbUserControlCurrency1 = new Projekt_Bak48678.kbUserControlCurrency();
            this.kbpanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kbpictureBoxVM)).BeginInit();
            this.kbpanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // kbpanelHeader
            // 
            this.kbpanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.kbpanelHeader.Controls.Add(this.kbbuttonExit);
            this.kbpanelHeader.Controls.Add(this.kbpanelChosenButton);
            this.kbpanelHeader.Controls.Add(this.kbbuttonReset);
            this.kbpanelHeader.Controls.Add(this.kbbuttonCurrency);
            this.kbpanelHeader.Controls.Add(this.kbbuttonPayment);
            this.kbpanelHeader.Controls.Add(this.kbbuttonChooseProduct);
            this.kbpanelHeader.Controls.Add(this.kblabelVendingMachine);
            this.kbpanelHeader.Controls.Add(this.kbpictureBoxVM);
            this.kbpanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.kbpanelHeader.Location = new System.Drawing.Point(0, 0);
            this.kbpanelHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kbpanelHeader.Name = "kbpanelHeader";
            this.kbpanelHeader.Size = new System.Drawing.Size(1105, 777);
            this.kbpanelHeader.TabIndex = 0;
            // 
            // kbbuttonExit
            // 
            this.kbbuttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kbbuttonExit.FlatAppearance.BorderSize = 0;
            this.kbbuttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kbbuttonExit.Image = ((System.Drawing.Image)(resources.GetObject("kbbuttonExit.Image")));
            this.kbbuttonExit.Location = new System.Drawing.Point(1057, 12);
            this.kbbuttonExit.Name = "kbbuttonExit";
            this.kbbuttonExit.Size = new System.Drawing.Size(36, 35);
            this.kbbuttonExit.TabIndex = 6;
            this.kbbuttonExit.UseVisualStyleBackColor = true;
            this.kbbuttonExit.Click += new System.EventHandler(this.kbbuttonExit_Click);
            // 
            // kbpanelChosenButton
            // 
            this.kbpanelChosenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.kbpanelChosenButton.Location = new System.Drawing.Point(336, 83);
            this.kbpanelChosenButton.Name = "kbpanelChosenButton";
            this.kbpanelChosenButton.Size = new System.Drawing.Size(224, 10);
            this.kbpanelChosenButton.TabIndex = 5;
            // 
            // kbbuttonReset
            // 
            this.kbbuttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.kbbuttonReset.FlatAppearance.BorderSize = 0;
            this.kbbuttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kbbuttonReset.Font = new System.Drawing.Font("Montserrat ExtraBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbbuttonReset.Location = new System.Drawing.Point(978, 26);
            this.kbbuttonReset.Name = "kbbuttonReset";
            this.kbbuttonReset.Size = new System.Drawing.Size(110, 57);
            this.kbbuttonReset.TabIndex = 4;
            this.kbbuttonReset.Text = "Reset\r\nform";
            this.kbbuttonReset.UseVisualStyleBackColor = false;
            this.kbbuttonReset.Click += new System.EventHandler(this.kbbuttonReset_Click);
            // 
            // kbbuttonCurrency
            // 
            this.kbbuttonCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.kbbuttonCurrency.FlatAppearance.BorderSize = 0;
            this.kbbuttonCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kbbuttonCurrency.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbbuttonCurrency.Image = ((System.Drawing.Image)(resources.GetObject("kbbuttonCurrency.Image")));
            this.kbbuttonCurrency.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kbbuttonCurrency.Location = new System.Drawing.Point(336, 27);
            this.kbbuttonCurrency.Name = "kbbuttonCurrency";
            this.kbbuttonCurrency.Size = new System.Drawing.Size(225, 66);
            this.kbbuttonCurrency.TabIndex = 3;
            this.kbbuttonCurrency.TabStop = false;
            this.kbbuttonCurrency.Text = "Choose currency";
            this.kbbuttonCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kbbuttonCurrency.UseVisualStyleBackColor = false;
            this.kbbuttonCurrency.Click += new System.EventHandler(this.kbbuttonCurrency_Click);
            // 
            // kbbuttonPayment
            // 
            this.kbbuttonPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.kbbuttonPayment.Enabled = false;
            this.kbbuttonPayment.FlatAppearance.BorderSize = 0;
            this.kbbuttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kbbuttonPayment.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbbuttonPayment.Image = ((System.Drawing.Image)(resources.GetObject("kbbuttonPayment.Image")));
            this.kbbuttonPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kbbuttonPayment.Location = new System.Drawing.Point(844, 31);
            this.kbbuttonPayment.Name = "kbbuttonPayment";
            this.kbbuttonPayment.Size = new System.Drawing.Size(118, 52);
            this.kbbuttonPayment.TabIndex = 3;
            this.kbbuttonPayment.TabStop = false;
            this.kbbuttonPayment.Text = "Pay";
            this.kbbuttonPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kbbuttonPayment.UseVisualStyleBackColor = false;
            this.kbbuttonPayment.Click += new System.EventHandler(this.kbbuttonPayment_Click);
            // 
            // kbbuttonChooseProduct
            // 
            this.kbbuttonChooseProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.kbbuttonChooseProduct.FlatAppearance.BorderSize = 0;
            this.kbbuttonChooseProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kbbuttonChooseProduct.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbbuttonChooseProduct.Image = ((System.Drawing.Image)(resources.GetObject("kbbuttonChooseProduct.Image")));
            this.kbbuttonChooseProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kbbuttonChooseProduct.Location = new System.Drawing.Point(591, 27);
            this.kbbuttonChooseProduct.Name = "kbbuttonChooseProduct";
            this.kbbuttonChooseProduct.Size = new System.Drawing.Size(226, 60);
            this.kbbuttonChooseProduct.TabIndex = 2;
            this.kbbuttonChooseProduct.TabStop = false;
            this.kbbuttonChooseProduct.Text = "Choose product";
            this.kbbuttonChooseProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kbbuttonChooseProduct.UseVisualStyleBackColor = false;
            this.kbbuttonChooseProduct.Click += new System.EventHandler(this.kbbuttonChooseProduct_Click);
            // 
            // kblabelVendingMachine
            // 
            this.kblabelVendingMachine.AutoSize = true;
            this.kblabelVendingMachine.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kblabelVendingMachine.Location = new System.Drawing.Point(171, 21);
            this.kblabelVendingMachine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kblabelVendingMachine.Name = "kblabelVendingMachine";
            this.kblabelVendingMachine.Size = new System.Drawing.Size(121, 66);
            this.kblabelVendingMachine.TabIndex = 1;
            this.kblabelVendingMachine.Text = "Vending\r\nMachine";
            // 
            // kbpictureBoxVM
            // 
            this.kbpictureBoxVM.Image = ((System.Drawing.Image)(resources.GetObject("kbpictureBoxVM.Image")));
            this.kbpictureBoxVM.Location = new System.Drawing.Point(11, 17);
            this.kbpictureBoxVM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kbpictureBoxVM.Name = "kbpictureBoxVM";
            this.kbpictureBoxVM.Size = new System.Drawing.Size(141, 76);
            this.kbpictureBoxVM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kbpictureBoxVM.TabIndex = 0;
            this.kbpictureBoxVM.TabStop = false;
            // 
            // kbpanelMenu
            // 
            this.kbpanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.kbpanelMenu.Controls.Add(this.kbbuttonAboutMe);
            this.kbpanelMenu.Controls.Add(this.kblabelCategories);
            this.kbpanelMenu.Controls.Add(this.kbbuttonHealthy);
            this.kbpanelMenu.Controls.Add(this.kbbuttonHot);
            this.kbpanelMenu.Controls.Add(this.kbbuttonCold);
            this.kbpanelMenu.Controls.Add(this.kbbuttonSnacks);
            this.kbpanelMenu.Location = new System.Drawing.Point(-2, 99);
            this.kbpanelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kbpanelMenu.Name = "kbpanelMenu";
            this.kbpanelMenu.Size = new System.Drawing.Size(201, 534);
            this.kbpanelMenu.TabIndex = 1;
            // 
            // kbbuttonAboutMe
            // 
            this.kbbuttonAboutMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.kbbuttonAboutMe.FlatAppearance.BorderSize = 0;
            this.kbbuttonAboutMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kbbuttonAboutMe.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbbuttonAboutMe.Image = ((System.Drawing.Image)(resources.GetObject("kbbuttonAboutMe.Image")));
            this.kbbuttonAboutMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kbbuttonAboutMe.Location = new System.Drawing.Point(2, 433);
            this.kbbuttonAboutMe.Name = "kbbuttonAboutMe";
            this.kbbuttonAboutMe.Size = new System.Drawing.Size(197, 76);
            this.kbbuttonAboutMe.TabIndex = 5;
            this.kbbuttonAboutMe.Text = "About author";
            this.kbbuttonAboutMe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kbbuttonAboutMe.UseVisualStyleBackColor = false;
            this.kbbuttonAboutMe.Click += new System.EventHandler(this.kbbuttonAboutMe_Click);
            // 
            // kblabelCategories
            // 
            this.kblabelCategories.AutoSize = true;
            this.kblabelCategories.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kblabelCategories.Location = new System.Drawing.Point(25, 33);
            this.kblabelCategories.Name = "kblabelCategories";
            this.kblabelCategories.Size = new System.Drawing.Size(129, 66);
            this.kblabelCategories.TabIndex = 4;
            this.kblabelCategories.Text = "Choose \r\ncategory";
            this.kblabelCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kbbuttonHealthy
            // 
            this.kbbuttonHealthy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.kbbuttonHealthy.Enabled = false;
            this.kbbuttonHealthy.FlatAppearance.BorderSize = 0;
            this.kbbuttonHealthy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kbbuttonHealthy.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbbuttonHealthy.Image = ((System.Drawing.Image)(resources.GetObject("kbbuttonHealthy.Image")));
            this.kbbuttonHealthy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kbbuttonHealthy.Location = new System.Drawing.Point(3, 344);
            this.kbbuttonHealthy.Name = "kbbuttonHealthy";
            this.kbbuttonHealthy.Size = new System.Drawing.Size(194, 64);
            this.kbbuttonHealthy.TabIndex = 3;
            this.kbbuttonHealthy.Text = "Healthy";
            this.kbbuttonHealthy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kbbuttonHealthy.UseVisualStyleBackColor = false;
            this.kbbuttonHealthy.Click += new System.EventHandler(this.kbbuttonHealthy_Click);
            // 
            // kbbuttonHot
            // 
            this.kbbuttonHot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.kbbuttonHot.Enabled = false;
            this.kbbuttonHot.FlatAppearance.BorderSize = 0;
            this.kbbuttonHot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kbbuttonHot.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbbuttonHot.Image = ((System.Drawing.Image)(resources.GetObject("kbbuttonHot.Image")));
            this.kbbuttonHot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kbbuttonHot.Location = new System.Drawing.Point(4, 211);
            this.kbbuttonHot.Name = "kbbuttonHot";
            this.kbbuttonHot.Size = new System.Drawing.Size(194, 66);
            this.kbbuttonHot.TabIndex = 2;
            this.kbbuttonHot.Text = "Hot drinks";
            this.kbbuttonHot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kbbuttonHot.UseVisualStyleBackColor = false;
            this.kbbuttonHot.Click += new System.EventHandler(this.kbbuttonHot_Click);
            // 
            // kbbuttonCold
            // 
            this.kbbuttonCold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.kbbuttonCold.Enabled = false;
            this.kbbuttonCold.FlatAppearance.BorderSize = 0;
            this.kbbuttonCold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kbbuttonCold.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbbuttonCold.Image = ((System.Drawing.Image)(resources.GetObject("kbbuttonCold.Image")));
            this.kbbuttonCold.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kbbuttonCold.Location = new System.Drawing.Point(3, 150);
            this.kbbuttonCold.Name = "kbbuttonCold";
            this.kbbuttonCold.Size = new System.Drawing.Size(194, 55);
            this.kbbuttonCold.TabIndex = 1;
            this.kbbuttonCold.Text = "Fizzy drinks";
            this.kbbuttonCold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kbbuttonCold.UseVisualStyleBackColor = false;
            this.kbbuttonCold.Click += new System.EventHandler(this.kbbuttonCold_Click);
            // 
            // kbbuttonSnacks
            // 
            this.kbbuttonSnacks.AllowDrop = true;
            this.kbbuttonSnacks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.kbbuttonSnacks.Enabled = false;
            this.kbbuttonSnacks.FlatAppearance.BorderSize = 0;
            this.kbbuttonSnacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kbbuttonSnacks.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbbuttonSnacks.Image = ((System.Drawing.Image)(resources.GetObject("kbbuttonSnacks.Image")));
            this.kbbuttonSnacks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kbbuttonSnacks.Location = new System.Drawing.Point(4, 283);
            this.kbbuttonSnacks.Name = "kbbuttonSnacks";
            this.kbbuttonSnacks.Size = new System.Drawing.Size(194, 55);
            this.kbbuttonSnacks.TabIndex = 0;
            this.kbbuttonSnacks.Text = "Snacks";
            this.kbbuttonSnacks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kbbuttonSnacks.UseVisualStyleBackColor = false;
            this.kbbuttonSnacks.Click += new System.EventHandler(this.kbbuttonSnacks_Click);
            // 
            // kbUserControlPay1
            // 
            this.kbUserControlPay1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbUserControlPay1.Location = new System.Drawing.Point(196, 97);
            this.kbUserControlPay1.Margin = new System.Windows.Forms.Padding(4);
            this.kbUserControlPay1.Name = "kbUserControlPay1";
            this.kbUserControlPay1.Size = new System.Drawing.Size(915, 536);
            this.kbUserControlPay1.TabIndex = 8;
            this.kbUserControlPay1.Visible = false;
            // 
            // kbUserControlSnacks1
            // 
            this.kbUserControlSnacks1.Location = new System.Drawing.Point(199, 107);
            this.kbUserControlSnacks1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kbUserControlSnacks1.Name = "kbUserControlSnacks1";
            this.kbUserControlSnacks1.Size = new System.Drawing.Size(903, 523);
            this.kbUserControlSnacks1.TabIndex = 7;
            this.kbUserControlSnacks1.Visible = false;
            // 
            // kbUserControlHotDrinks1
            // 
            this.kbUserControlHotDrinks1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbUserControlHotDrinks1.Location = new System.Drawing.Point(196, 100);
            this.kbUserControlHotDrinks1.Margin = new System.Windows.Forms.Padding(4);
            this.kbUserControlHotDrinks1.Name = "kbUserControlHotDrinks1";
            this.kbUserControlHotDrinks1.Size = new System.Drawing.Size(903, 522);
            this.kbUserControlHotDrinks1.TabIndex = 6;
            this.kbUserControlHotDrinks1.Visible = false;
            // 
            // kbUserControlHealthy1
            // 
            this.kbUserControlHealthy1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbUserControlHealthy1.Location = new System.Drawing.Point(196, 103);
            this.kbUserControlHealthy1.Margin = new System.Windows.Forms.Padding(4);
            this.kbUserControlHealthy1.Name = "kbUserControlHealthy1";
            this.kbUserControlHealthy1.Size = new System.Drawing.Size(903, 522);
            this.kbUserControlHealthy1.TabIndex = 5;
            this.kbUserControlHealthy1.Visible = false;
            // 
            // kbUserControlAboutMe1
            // 
            this.kbUserControlAboutMe1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbUserControlAboutMe1.Location = new System.Drawing.Point(294, 150);
            this.kbUserControlAboutMe1.Margin = new System.Windows.Forms.Padding(4);
            this.kbUserControlAboutMe1.Name = "kbUserControlAboutMe1";
            this.kbUserControlAboutMe1.Size = new System.Drawing.Size(909, 530);
            this.kbUserControlAboutMe1.TabIndex = 4;
            this.kbUserControlAboutMe1.Visible = false;
            // 
            // kbUserControlColdDrinks1
            // 
            this.kbUserControlColdDrinks1.Location = new System.Drawing.Point(468, 243);
            this.kbUserControlColdDrinks1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kbUserControlColdDrinks1.Name = "kbUserControlColdDrinks1";
            this.kbUserControlColdDrinks1.Size = new System.Drawing.Size(2033, 1178);
            this.kbUserControlColdDrinks1.TabIndex = 3;
            this.kbUserControlColdDrinks1.Visible = false;
            // 
            // kbUserControlCurrency1
            // 
            this.kbUserControlCurrency1.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbUserControlCurrency1.Location = new System.Drawing.Point(202, 103);
            this.kbUserControlCurrency1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.kbUserControlCurrency1.Name = "kbUserControlCurrency1";
            this.kbUserControlCurrency1.Size = new System.Drawing.Size(903, 530);
            this.kbUserControlCurrency1.TabIndex = 2;
            // 
            // kbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 633);
            this.Controls.Add(this.kbUserControlPay1);
            this.Controls.Add(this.kbUserControlSnacks1);
            this.Controls.Add(this.kbUserControlHotDrinks1);
            this.Controls.Add(this.kbUserControlHealthy1);
            this.Controls.Add(this.kbUserControlAboutMe1);
            this.Controls.Add(this.kbUserControlColdDrinks1);
            this.Controls.Add(this.kbUserControlCurrency1);
            this.Controls.Add(this.kbpanelMenu);
            this.Controls.Add(this.kbpanelHeader);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "kbForm";
            this.Text = "Form1";
            this.kbpanelHeader.ResumeLayout(false);
            this.kbpanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kbpictureBoxVM)).EndInit();
            this.kbpanelMenu.ResumeLayout(false);
            this.kbpanelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel kbpanelHeader;
        private System.Windows.Forms.Panel kbpanelMenu;
        private System.Windows.Forms.PictureBox kbpictureBoxVM;
        private System.Windows.Forms.Label kblabelVendingMachine;
        private System.Windows.Forms.Button kbbuttonSnacks;
        private System.Windows.Forms.Button kbbuttonHealthy;
        private System.Windows.Forms.Button kbbuttonHot;
        private System.Windows.Forms.Button kbbuttonCold;
        private System.Windows.Forms.Label kblabelCategories;
        private System.Windows.Forms.Button kbbuttonAboutMe;
        private System.Windows.Forms.Button kbbuttonCurrency;
        private System.Windows.Forms.Button kbbuttonPayment;
        private System.Windows.Forms.Button kbbuttonChooseProduct;
        private System.Windows.Forms.Button kbbuttonReset;
        private System.Windows.Forms.Panel kbpanelChosenButton;
        private kbUserControlCurrency kbUserControlCurrency1;
        private kbUserControlColdDrinks kbUserControlColdDrinks1;
        private kbUserControlAboutMe kbUserControlAboutMe1;
        private kbUserControlSnacks kbUserControlSnacks1;
        private kbUserControlHotDrinks kbUserControlHotDrinks1;
        private kbUserControlHealthy kbUserControlHealthy1;
        private kbUserControlPay kbUserControlPay1;
        private System.Windows.Forms.Button kbbuttonExit;
    }
}

