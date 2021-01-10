using System;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace Projekt_Bak48678
{
    public partial class kbForm : Form  
    {
        private string kbCurrency;
        kbClassProduct kbProduct;
        kbClassProduct kbCola;
        kbClassProduct kbPepsi;
        kbClassProduct kbRedBull;
        kbClassProduct kbCookies;
        kbClassProduct kbChips;
        kbClassProduct kbChocolate;
        kbClassProduct kbCoffee;
        kbClassProduct kbTea;
        kbClassProduct kbHotChocolate;
        kbClassProduct kbWater;
        kbClassProduct kbCashewNuts;
        kbClassProduct kbAlmonds;
        System.Timers.Timer kbTimer;
        UserControl kbTempUC;

        public kbForm()
        {
            InitializeComponent();

            kbPlaceTheControls();          

            kbUserControlCurrency1.kbbtnConfirmClick += new EventHandler(kbUserControlCurrency1_ButtonConfirmClick);
            kbUserControlColdDrinks1.kbbtnPay += new EventHandler(kbUserControlColdDrink1_ButtonPayClick);
            kbUserControlSnacks1.kbbtnPay += new EventHandler(kbUserControlSnacks1_ButtonPayClick);
            kbUserControlHealthy1.kbbtnPay += new EventHandler(kbUserControlHealthy1_ButtonPayClick);
            kbUserControlHotDrinks1.kbbtnPay += new EventHandler(kbUserControlHotDrinks1_ButtonPayClick);
            kbUserControlPay1.kbPaymentFinished += new EventHandler(kbUserControlPay1_PaymentFinished);

            kbTimer = new System.Timers.Timer(500);
            kbTimer.Elapsed += new ElapsedEventHandler(kbOnTimeEvent);

            kbCreateProducts();
        }

        private void kbPlaceTheControls()
        {
            //Form
            this.StartPosition = FormStartPosition.Manual;
            this.Size = new Size(1105, 633);

            //Header
            kbpanelHeader.Size = new Size(Width, kbIntVal(this.Size.Height * 0.16));
            kbpanelHeader.Dock = DockStyle.Top;

            //Menu
            kbpanelMenu.Location = new Point(0, kbpanelHeader.Height);
            kbpanelMenu.Size = new Size(2 * kbpanelHeader.Height, Height - kbpanelHeader.Height);

            //Other form's elements
            kbpictureBoxVM.Size = new Size(kbIntVal(Width * 0.1276), kbIntVal(Height * 0.12));
            kbpictureBoxVM.Location = new Point(kbpanelMenu.Width / 2 - kbpictureBoxVM.Width / 2, kbpanelHeader.Height / 2 - kbpictureBoxVM.Height / 2);
            kblabelVendingMachine.Size = new Size(kbIntVal(kbpictureBoxVM.Width * 0.85), kbpictureBoxVM.Height - kbIntVal(0.01 * Width));
            kblabelVendingMachine.Location = new Point(kbpictureBoxVM.Right + kbIntVal(0.02 * Width), kbpictureBoxVM.Location.Y + kbpictureBoxVM.Height / 2 - kblabelVendingMachine.Height / 2);
            kblabelCategories.Size = kblabelVendingMachine.Size;
            kblabelCategories.Location = new Point(kbpanelMenu.Width / 2 - kblabelCategories.Width / 2, kbIntVal(0.047 * kbpanelMenu.Height));
            kbbuttonCold.Size = new Size(kbpanelMenu.Width, kbIntVal(0.125 * kbpanelMenu.Height));
            kbbuttonCold.Location = new Point(kbpanelMenu.Left, kblabelCategories.Bottom + kbIntVal(0.08 * kbpanelMenu.Height));
            kbbuttonHot.Size = kbbuttonCold.Size;
            kbbuttonHot.Location = new Point(kbbuttonCold.Location.X, kbbuttonCold.Bottom + kbIntVal(0.025 * kbpanelMenu.Height));
            kbbuttonSnacks.Size = kbbuttonCold.Size;
            kbbuttonSnacks.Location = new Point(kbbuttonCold.Location.X, kbbuttonHot.Bottom + kbIntVal(0.025 * kbpanelMenu.Height));
            kbbuttonHealthy.Size = kbbuttonCold.Size;
            kbbuttonHealthy.Location = new Point(kbbuttonCold.Location.X, kbbuttonSnacks.Bottom + kbIntVal(0.025 * kbpanelMenu.Height));
            kbbuttonAboutMe.Size = kbbuttonCold.Size;
            kbbuttonAboutMe.Location = new Point(kbbuttonCold.Location.X, kbbuttonHealthy.Bottom + kbIntVal(0.025 * kbpanelMenu.Height));
            kbbuttonCurrency.Size = new Size(kbIntVal(0.2 * Width), kbIntVal(1.5 * kblabelVendingMachine.Height));
            kbbuttonCurrency.Location = new Point(kblabelVendingMachine.Right + kbIntVal(0.05 * Width), kbpanelHeader.Height / 2 - kbbuttonCurrency.Height / 2);
            kbpanelChosenButton.Size = new Size(kbbuttonCurrency.Width, kbIntVal(0.1 * kbpanelHeader.Height));
            kbpanelChosenButton.Location = new Point(kbbuttonCurrency.Left, kbbuttonCurrency.Bottom);
            kbbuttonChooseProduct.Size = kbbuttonCurrency.Size;
            kbbuttonChooseProduct.Location = new Point(kbbuttonCurrency.Right + kbIntVal(0.025 * Width), kbbuttonCurrency.Location.Y);
            kbbuttonPayment.Size = new Size(kbbuttonCurrency.Width / 2, kbbuttonCurrency.Height);
            kbbuttonPayment.Location = new Point(kbbuttonChooseProduct.Right + kbIntVal(0.025 * Width), kbbuttonCurrency.Location.Y);
            kbbuttonReset.Size = new Size(kbbuttonCurrency.Width / 3, kbbuttonCurrency.Height);
            kbbuttonReset.Location = new Point(kbbuttonPayment.Right + kbIntVal(0.025 * Width), kbbuttonCurrency.Location.Y);
            kbbuttonExit.Size = new Size(kbIntVal(0.032 * Width), kbIntVal(0.032 * Width));
            kbbuttonExit.Location = new Point(Width - kbbuttonExit.Width - kbIntVal(0.01 * Width), kbpanelHeader.Location.Y + kbIntVal(0.007 * Width));

            //UserControls
            kbpanelChosenButton.Width = kbbuttonCurrency.Width;
            kbUserControlCurrency1.Visible = true;
            kbUserControlCurrency1.Left = kbpanelMenu.Right;
            kbUserControlCurrency1.Top = kbpanelHeader.Bottom;
            kbUserControlCurrency1.Width = Width - kbpanelMenu.Width;
            kbUserControlCurrency1.Height = Height - kbpanelHeader.Height;

            foreach (UserControl kbUC in Controls.OfType<UserControl>())
            {
                kbUC.Width = kbUserControlCurrency1.Width;
                kbUC.Height = kbUserControlCurrency1.Height;
                kbUC.Left = kbUserControlCurrency1.Left;
                kbUC.Top = kbUserControlCurrency1.Top;
            }

            kbUserControlCurrency1.kbPlaceControls();
            kbUserControlColdDrinks1.kbPlaceControls();
            kbUserControlHealthy1.kbPlaceControls();
            kbUserControlHotDrinks1.kbPlaceControls();
            kbUserControlSnacks1.kbPlaceControls();
        }

        private int kbIntVal(double kbValue)
        {
            return (int)kbValue;
        }

        private void kbCreateProducts()
        {
            kbCola = new kbClassProduct("Cola", "ColdDrinks", 4);
            kbPepsi = new kbClassProduct("Pepsi", "ColdDrinks", 4);
            kbRedBull = new kbClassProduct("Red Bull", "ColdDrinks", 7.5f);
            kbCookies = new kbClassProduct("Cookies", "Snacks", 5.5f);
            kbChips = new kbClassProduct("Chips", "Snacks", 9.5f);
            kbChocolate = new kbClassProduct("Chocolate", "Snacks", 6.5f);
            kbCoffee = new kbClassProduct("Coffee", "HotDrinks", 4.5f);
            kbTea = new kbClassProduct("Tea", "HotDrinks", 4);
            kbHotChocolate = new kbClassProduct("Hot Chocolate", "HotDrinks", 4.5f);
            kbWater = new kbClassProduct("Coffee", "Healthy", 3.5f);
            kbCashewNuts = new kbClassProduct("Cashew Nuts", "Healthy", 10.5f);
            kbAlmonds = new kbClassProduct("Almonds", "Healthy", 10.5f);
        }

        private void kbHideOtherUserControls(UserControl kbUC)
        {
            foreach (UserControl kbOtherUC in this.Controls.OfType<UserControl>())
            {
                kbOtherUC.Visible = false;
            }
            kbUC.Visible = true;
            kbUC.BringToFront();
        }

        private void kbEnableCategories()
        {
            kbbuttonCold.Enabled = true;
            kbbuttonHealthy.Enabled = true;
            kbbuttonSnacks.Enabled = true;
            kbbuttonHot.Enabled = true;
        }

        private void kbDisableCategories()
        {
            kbbuttonCold.Enabled = false;
            kbbuttonHealthy.Enabled = false;
            kbbuttonSnacks.Enabled = false;
            kbbuttonHot.Enabled = false;
        }

        private void kbSetTextsInUserControlPay(kbClassProduct kbProduct)
        {
            switch (kbCurrency)
            {
                case "PLN":
                    {
                        kbUserControlPay1.kbSetTexts(kbProduct.KBName, kbProduct.KBPriceInPLN, kbCurrency);
                        break;
                    }
                case "USD":
                    {
                        kbUserControlPay1.kbSetTexts(kbProduct.KBName, kbProduct.KBPriceInUSD, kbCurrency);
                        break;
                    }
                case "EUR":
                    {
                        kbUserControlPay1.kbSetTexts(kbProduct.KBName, kbProduct.KBPriceInEUR, kbCurrency);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            kbUserControlPay1.kbPlaceControls();
        }

        protected void kbUserControlCurrency1_ButtonConfirmClick(object sender, EventArgs e)
        {
            var kbButtons = kbUserControlCurrency1.KBgbCurency.Controls.OfType<RadioButton>()
                .FirstOrDefault(n => n.Checked);
            switch (kbButtons.Name)
            {
                case "kbradioButtonPLN":
                    {
                        kbCurrency = "PLN";
                        break;
                    }
                case "kbradioButtonEUR":
                    {
                        kbCurrency = "EUR";
                        break;
                    }
                case "kbradioButtonUSD":
                    {
                        kbCurrency = "USD";
                        break;
                    }
                default:
                    {
                        kbCurrency = "PLN";
                        break;
                    }
            }
           
            kbpanelChosenButton.Width = kbbuttonChooseProduct.Width;
            kbpanelChosenButton.Left = kbbuttonChooseProduct.Left;
            kbHideOtherUserControls(kbUserControlColdDrinks1);
            kbEnableCategories();
            kbUpdatePriceLabels();
        }

        protected void kbUserControlColdDrink1_ButtonPayClick(object sender, EventArgs e)
        {
            var kbButtons = kbUserControlColdDrinks1.KBgbColdDrinks.Controls.OfType<RadioButton>()
                .FirstOrDefault(n => n.Checked);
            switch (kbButtons.Name)
            {
                case "kbradioButtonCola":
                    {
                        kbProduct = kbCola;                       
                        break;
                    }
                case "kbradioButtonPepsi":
                    {
                        kbProduct = kbPepsi;
                        break;
                    }
                case "kbradioButtonRedBull":
                    {
                        kbProduct = kbRedBull;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            kbSetTextsInUserControlPay(kbProduct);
            kbHideOtherUserControls(kbUserControlPay1);
            kbDisableCategories();
            kbpanelChosenButton.Width = kbbuttonPayment.Width;
            kbpanelChosenButton.Left = kbbuttonPayment.Left;
            kbbuttonChooseProduct.Enabled = false;
            kbbuttonCurrency.Enabled = false;
        }

        protected void kbUserControlSnacks1_ButtonPayClick(object sender, EventArgs e)
        {
            var kbButtons = kbUserControlSnacks1.KBgbSnacks.Controls.OfType<RadioButton>()
                .FirstOrDefault(n => n.Checked);
            switch (kbButtons.Name)
            {
                case "kbradioButtonChips":
                    {
                        kbProduct = kbChips;
                        break;
                    }
                case "kbradioButtonCookies":
                    {
                        kbProduct = kbCookies;
                        break;
                    }
                case "kbradioButtonChocolate":
                    {
                        kbProduct = kbChocolate;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            kbSetTextsInUserControlPay(kbProduct);
            kbHideOtherUserControls(kbUserControlPay1);
            kbDisableCategories();
            kbpanelChosenButton.Width = kbbuttonPayment.Width;
            kbpanelChosenButton.Left = kbbuttonPayment.Left;
            kbbuttonChooseProduct.Enabled = false;
            kbbuttonCurrency.Enabled = false;
        }

        protected void kbUserControlHealthy1_ButtonPayClick(object sender, EventArgs e)
        {
            var kbButtons = kbUserControlHealthy1.KBgbHealthy.Controls.OfType<RadioButton>()
                .FirstOrDefault(n => n.Checked);
            switch (kbButtons.Name)
            {
                case "kbradioButtonWater":
                    {
                        kbProduct = kbWater;
                        break;
                    }
                case "kbradioButtonNuts":
                    {
                        kbProduct = kbCashewNuts;
                        break;
                    }
                case "kbradioButtonAlmonds":
                    {
                        kbProduct = kbAlmonds;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            kbSetTextsInUserControlPay(kbProduct);
            kbHideOtherUserControls(kbUserControlPay1);
            kbDisableCategories();
            kbpanelChosenButton.Width = kbbuttonPayment.Width;
            kbpanelChosenButton.Left = kbbuttonPayment.Left;
            kbbuttonChooseProduct.Enabled = false;
            kbbuttonCurrency.Enabled = false;
        }

        protected void kbUserControlHotDrinks1_ButtonPayClick(object sender, EventArgs e)
        {
            var kbButtons = kbUserControlHotDrinks1.KBgbHotDrinks.Controls.OfType<RadioButton>()
                .FirstOrDefault(n => n.Checked);
            switch (kbButtons.Name)
            {
                case "kbradioButtonCoffee":
                    {
                        kbProduct = kbCoffee;
                        break;
                    }
                case "kbradioButtonTea":
                    {
                        kbProduct = kbTea;
                        break;
                    }
                case "kbradioButtonHotChocolate":
                    {
                        kbProduct = kbHotChocolate;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            kbSetTextsInUserControlPay(kbProduct);
            kbHideOtherUserControls(kbUserControlPay1);
            kbDisableCategories();
            kbpanelChosenButton.Width = kbbuttonPayment.Width;
            kbpanelChosenButton.Left = kbbuttonPayment.Left;
            kbbuttonChooseProduct.Enabled = false;
            kbbuttonCurrency.Enabled = false;
        }

        protected void kbUserControlPay1_PaymentFinished(object sender, EventArgs e)
        {
            kbbuttonReset.FlatAppearance.BorderColor = Color.FromArgb(203, 145, 167);           
            kbTimer.Enabled = true;
            MessageBox.Show("You may now reset the form or exit the program.");
        }

        private void kbOnTimeEvent(object source, ElapsedEventArgs e)
        {
            if (kbbuttonReset.FlatAppearance.BorderSize == 3)
            {                
                kbbuttonReset.FlatAppearance.BorderSize = 0;
            }
            else
            {              
                kbbuttonReset.FlatAppearance.BorderSize = 3;
            }
        }

        private void kbbuttonCurrency_Click(object sender, EventArgs e)
        {
            kbpanelChosenButton.Width = kbbuttonCurrency.Width;
            kbpanelChosenButton.Left = kbbuttonCurrency.Left;
            kbHideOtherUserControls(kbUserControlCurrency1);
            kbDisableCategories();
        }

        private void kbbuttonChooseProduct_Click(object sender, EventArgs e)
        {
            kbUserControlCurrency1_ButtonConfirmClick(sender, e);
            kbUpdatePriceLabels();
        }

        private void kbbuttonPayment_Click(object sender, EventArgs e)
        {
            kbpanelChosenButton.Width = kbbuttonPayment.Width;
            kbpanelChosenButton.Left = kbbuttonPayment.Left;
            kbHideOtherUserControls(kbUserControlPay1);
            kbDisableCategories();
        }

        private void kbbuttonAboutMe_Click(object sender, EventArgs e)
        {
            if (kbUserControlAboutMe1.Visible == false)
            {
                kbTempUC = this.Controls.OfType<UserControl>().FirstOrDefault(n => n.Visible == true);
                kbHideOtherUserControls(kbUserControlAboutMe1);                
            } 
            else
            {
                kbHideOtherUserControls(kbTempUC);
            }
        }

        private void kbbuttonCold_Click(object sender, EventArgs e)
        {
            kbHideOtherUserControls(kbUserControlColdDrinks1);
        }

        private void kbbuttonHot_Click(object sender, EventArgs e)
        {
            kbHideOtherUserControls(kbUserControlHotDrinks1);
        }

        private void kbbuttonSnacks_Click(object sender, EventArgs e)
        {
            kbHideOtherUserControls(kbUserControlSnacks1);
        }

        private void kbbuttonHealthy_Click(object sender, EventArgs e)
        {
            kbHideOtherUserControls(kbUserControlHealthy1);
        }

        private void kbbuttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You sure?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }      
        }

        private void kbUpdatePriceLabels()
        {
            kbUserControlColdDrinks1.kbGetLabelCola.Text = kbGetCorrectPriceCurrency(kbCola);
            kbUserControlColdDrinks1.kbGetLabelPepsi.Text = kbGetCorrectPriceCurrency(kbPepsi);
            kbUserControlColdDrinks1.kbGetLabelRedBull.Text = kbGetCorrectPriceCurrency(kbRedBull);

            kbUserControlHealthy1.kbGetLabelAlmonds.Text = kbGetCorrectPriceCurrency(kbAlmonds);
            kbUserControlHealthy1.kbGetLabelNuts.Text = kbGetCorrectPriceCurrency(kbCashewNuts);
            kbUserControlHealthy1.kbGetLabelWater.Text = kbGetCorrectPriceCurrency(kbWater);

            kbUserControlHotDrinks1.kbGetLabelCoffee.Text = kbGetCorrectPriceCurrency(kbCoffee);
            kbUserControlHotDrinks1.kbGetLabelHotChocolate.Text = kbGetCorrectPriceCurrency(kbHotChocolate);
            kbUserControlHotDrinks1.kbGetLabelTea.Text = kbGetCorrectPriceCurrency(kbTea);

            kbUserControlSnacks1.kbGetLabelChips.Text = kbGetCorrectPriceCurrency(kbChips);
            kbUserControlSnacks1.kbGetLabelChocolate.Text = kbGetCorrectPriceCurrency(kbChocolate);
            kbUserControlSnacks1.kbGetLabelCookies.Text = kbGetCorrectPriceCurrency(kbCookies);
        }

        private string kbGetCorrectPriceCurrency(kbClassProduct kbProduct)
        {
            switch (kbCurrency) {
                case "PLN":
                    {
                        return kbProduct.KBPriceInPLN.ToString() + " " + kbCurrency;
                    }
                case "USD":
                    {
                        return kbProduct.KBPriceInUSD.ToString() + " " + kbCurrency;
                    }
                case "EUR":
                    {
                        return kbProduct.KBPriceInEUR.ToString() + " " + kbCurrency;
                    }
                default:
                    {
                        return 0.0f.ToString() + " " + kbCurrency;
                    }
            }
        }

        private void kbbuttonReset_Click(object sender, EventArgs e)
        {
            kbTimer = null;
            Application.Restart();
        }
    }
}
