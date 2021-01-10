using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projekt_Bak48678
{
    public partial class kbUserControlPay : UserControl
    {
        private float kbInsertedMoney = 0.0f;
        private string kbCurrency;
        private float kbChoicePrice, kbCard;
        public event EventHandler kbPaymentFinished;
        int kbMaxDenominations;
        float[] kbDenominationValues = { 5.00f, 2.00f, 1.00f, 0.50f };
        kbDenomination[] kbDenominationsContainers;
        public kbUserControlPay()
        {
            InitializeComponent();
            kbMaxDenominations = 50;
            kbDenominationsContainers = new kbDenomination[kbDenominationValues.Length];

            Random kbRandom = new Random();
            for (int i = 0; i < kbDenominationsContainers.Length; i++)
            {
                kbDenominationsContainers[i].kbQuantity = kbRandom.Next(1, kbMaxDenominations);
                kbDenominationsContainers[i].kbValue = kbDenominationValues[i];
            }
            kbCard = kbRandom.Next(1, kbMaxDenominations);
        }
        public void kbPlaceControls()
        {
            kblabelChosenProduct.Location = new Point(Width / 32, Width / 32);
            kblabelReceipt.Location = new Point(kblabelChosenProduct.Left, kblabelChosenProduct.Bottom + kblabelReceipt.Height / 2);
            kblabelPaymentMethod.Location = new Point(Width / 2 - kblabelPaymentMethod.Width / 2, kblabelReceipt.Bottom + kblabelPaymentMethod.Height);
            kbgroupBoxPaymentMethod.Size = new Size(kbradioButtonCard.Width * 4, kbradioButtonCard.Height * 2);
            kbgroupBoxPaymentMethod.Location = new Point(Width / 2 - kbgroupBoxPaymentMethod.Width / 2, kblabelPaymentMethod.Bottom + kblabelPaymentMethod.Height);
            kbradioButtonCard.Location = new Point(kbgroupBoxPaymentMethod.Width / 8, kbgroupBoxPaymentMethod.Height / 2 - kbradioButtonCard.Height / 2);
            kbradioButtonCash.Location = new Point(kbgroupBoxPaymentMethod.Width - kbgroupBoxPaymentMethod.Width / 8 - kbradioButtonCash.Width, kbradioButtonCard.Location.Y);
            kblabelAvailableDenominations.Location = new Point(31 * Width / 32 - kblabelAvailableDenominations.Width, kblabelChosenProduct.Location.Y);
            kbpictureBoxCard.Size = new Size(Width / 4, Height / 4);
            kbpictureBoxCard.Location = new Point(kbgroupBoxPaymentMethod.Left + kbradioButtonCard.Left + kbradioButtonCard.Width / 2 - kbpictureBoxCard.Width, Height / 2);
            kbbuttonCard.Size = new Size((int)(0.22 * Width), Height / 10);
            kbbuttonCard.Location = new Point(kbpictureBoxCard.Left + kbpictureBoxCard.Width / 2 - kbbuttonCard.Width / 2, kbpictureBoxCard.Bottom + kbbuttonCard.Height / 2);
            kblabelCoin.Location = new Point(kbgroupBoxPaymentMethod.Left + kbradioButtonCash.Left + kbradioButtonCash.Width / 2, kbpictureBoxCard.Location.Y);
            kbbuttonHalf.Size = new Size((int)(0.085 * Width), (int)(0.085 * Width));
            kbbuttonHalf.Location = new Point(kblabelCoin.Left - kbbuttonHalf.Width / 2, kblabelCoin.Bottom + kblabelCoin.Height / 2);
            kbbuttonOne.Size = kbbuttonHalf.Size;
            kbbuttonOne.Location = new Point(kblabelCoin.Right - kbbuttonOne.Width / 2, kbbuttonHalf.Location.Y);
            kbbuttonTwo.Size = kbbuttonHalf.Size;
            kbbuttonTwo.Location = new Point(kbbuttonHalf.Location.X, kbbuttonHalf.Bottom + kbbuttonOne.Left - kbbuttonHalf.Right);
            kbbuttonFive.Size = kbbuttonHalf.Size;
            kbbuttonFive.Location = new Point(kbbuttonOne.Left, kbbuttonTwo.Location.Y);
            kblabelCredit.Location = new Point(kbbuttonTwo.Left, kbbuttonTwo.Bottom + kblabelCredit.Height);
            kbbuttonPay.Size = kbbuttonCard.Size;
            kbbuttonPay.Location = new Point(kbbuttonOne.Right + kbbuttonOne.Left - kbbuttonHalf.Right, kbbuttonOne.Bottom - kbbuttonPay.Height / 2 + (kbbuttonOne.Left - kbbuttonHalf.Right) / 2);
            kblabelMoneyLeft.Location = new Point(kbbuttonPay.Left, kbbuttonPay.Bottom + kblabelMoneyLeft.Height / 2);
            kblabelChange.Location = new Point(kbbuttonPay.Left, kblabelMoneyLeft.Bottom + kblabelChange.Height / 2);
        }
        public void kbSetTexts(string kbChosenProduct, float kbReceipt, string kbCurrency)
        {
            this.kbCurrency = kbCurrency;
            this.kblabelChosenProduct.Text += kbChosenProduct;
            this.kblabelReceipt.Text += kbReceipt + " " + kbCurrency;
            kblabelCredit.Text += kbInsertedMoney + " " + kbCurrency;
            kbChoicePrice = kbReceipt;
            kblabelMoneyLeft.Text = "Left: " + kbReceipt.ToString() + " " + kbCurrency;
            kblabelChange.Text = "Change: " + 0.0f.ToString() + " " + kbCurrency;

            string kbTemp = "Available denominations:\n\n";
            for (int i = 0; i < kbDenominationsContainers.Length; i++)
            {
                kbTemp += kbDenominationValues[i].ToString() + " " + kbCurrency + ": " + kbDenominationsContainers[i].kbQuantity + "\n";
            }
            kblabelAvailableDenominations.Text = kbTemp;
        }

        private void kbUpdateLabels()
        {
            if ((kbChoicePrice - kbInsertedMoney) > 0)
            {
                kblabelMoneyLeft.Text = "Left: " + (kbChoicePrice - kbInsertedMoney).ToString() + " " + kbCurrency;
            }
            else
            {
                kbbuttonPay.Enabled = true;
                kblabelMoneyLeft.Text = "Left: " + 0.0f.ToString() + " " + kbCurrency;
                kblabelChange.Text = "Change: " + Math.Abs(kbChoicePrice - kbInsertedMoney) + " " + kbCurrency;
            }
        }

        public float kbGetInsertedMoney
        {
            get
            {
                return kbInsertedMoney;
            }
        }
        public float kbSetChoicePrice
        {
            set
            {
                kbChoicePrice = value;
            }
        }

        private void kbradioButtonCard_CheckedChanged(object sender, EventArgs e)
        {
            if (kbradioButtonCard.Checked)
            {
                kbpictureBoxCard.Enabled = true;
                kbbuttonCard.Enabled = true;
            } 
            else
            {
                kbpictureBoxCard.Enabled = false;
                kbbuttonCard.Enabled = false;
            }
        }
        private void kbradioButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            if (kbradioButtonCash.Checked)
            {
                kbbuttonHalf.Enabled = true;
                kbbuttonOne.Enabled = true;
                kbbuttonTwo.Enabled = true;
                kbbuttonFive.Enabled = true;
                if ((kbChoicePrice - kbInsertedMoney) <= 0)
                {
                    kbbuttonPay.Enabled = true;
                }
            }
            else
            {
                kbbuttonHalf.Enabled = false;
                kbbuttonOne.Enabled = false;
                kbbuttonTwo.Enabled = false;
                kbbuttonFive.Enabled = false;
                kbbuttonPay.Enabled = false;
            }
        }

        private void kbbuttonHalf_Click(object sender, EventArgs e)
        {
            kbInsertedMoney += 0.5f;
            kblabelCredit.Text = "Your credit: " + kbInsertedMoney + " " + kbCurrency;
            kbUpdateLabels();
        }

        private void kbbuttonOne_Click(object sender, EventArgs e)
        {
            kbInsertedMoney += 1.0f;
            kblabelCredit.Text = "Your credit: " + kbInsertedMoney + " " + kbCurrency;
            kbUpdateLabels();
        }

        private void kbbuttonTwo_Click(object sender, EventArgs e)
        {
            kbInsertedMoney += 2.0f;
            kblabelCredit.Text = "Your credit: " + kbInsertedMoney + " " + kbCurrency;
            kbUpdateLabels();
        }

        private void kbbuttonFive_Click(object sender, EventArgs e)
        {
            kbInsertedMoney += 5.0f;
            kblabelCredit.Text = "Your credit: " + kbInsertedMoney + " " + kbCurrency;
            kbUpdateLabels();
        }

        private void kbbuttonCard_Click(object sender, EventArgs e)
        {
            if (kbChoicePrice > kbCard)
            {
                MessageBox.Show("You don't have enough money on Your card." +
                    "\nMoney on the card: " + kbCard + " " + kbCurrency + 
                    "\nPlease top up the card or pay with cash!");
                kbradioButtonCard.Checked = false;
                kbradioButtonCash.Checked = true;
            }
            else
            {
                MessageBox.Show("Payment successful!\n" +
                    "Money left on Your card: " + (kbCard - kbChoicePrice) + " " + kbCurrency);
                this.kbPaymentFinished?.Invoke(this, e);
            }
        }

        private void kbbuttonPay_Click(object sender, EventArgs e)
        {
            float kbChange = kbInsertedMoney - kbChoicePrice;
            if (kbChange == 0.0f)
            {
                MessageBox.Show("Payment successful! No change...");
                this.kbPaymentFinished?.Invoke(this, e);
                return;
            }

            if(!kbChangePossibility(kbDenominationsContainers, kbChange))
            {
                kberrorProvider1.SetError(kbbuttonPay, "The amount of change is not available! Come back later!");
                this.kbPaymentFinished?.Invoke(this, e);
                return;
            }
            else
            {
                float kbChangeAmount = kbChange;
                int kbDenominationContainerIndex = 0;
                int kbDenominationsCount;
                int[] kbPaidDenominationsCount = new int[kbDenominationValues.Length];

                while (kbChangeAmount > 0.0f && kbDenominationContainerIndex < kbDenominationsContainers.Length)
                {
                    kbDenominationsCount = (int)(kbChangeAmount / kbDenominationsContainers[kbDenominationContainerIndex].kbValue);

                    if(kbDenominationsCount > kbDenominationsContainers[kbDenominationContainerIndex].kbQuantity)
                    {
                        kbDenominationsCount = kbDenominationsContainers[kbDenominationContainerIndex].kbQuantity;
                        kbDenominationsContainers[kbDenominationContainerIndex].kbQuantity = 0;
                    }
                    else
                    {
                        kbDenominationsContainers[kbDenominationContainerIndex].kbQuantity =
                            kbDenominationsContainers[kbDenominationContainerIndex].kbQuantity - kbDenominationsCount;
                    }

                    kbPaidDenominationsCount[kbDenominationContainerIndex] = kbDenominationsCount;
                    kbChangeAmount -= kbDenominationsCount * kbDenominationsContainers[kbDenominationContainerIndex].kbValue;
                    kbDenominationContainerIndex++;
                }

                if (kbChangeAmount > 0.0f)
                {
                    kberrorProvider1.SetError(kbbuttonPay, "We are sorry, there is no right amount of denominations!");
                    this.kbPaymentFinished?.Invoke(this, e);
                }
                else
                {
                    string kbTemp = "Change was properly paid out! Here is a list of denominations:\n\n ";
                    for (int i = 0; i < kbPaidDenominationsCount.Length; i++)
                    {
                        kbTemp += "\t" + kbDenominationValues[i].ToString() + " " + kbCurrency + ": " + kbPaidDenominationsCount[i] + "\n";
                    }
                    kbTemp += "\nClick OK button to end the transaction!";
                    MessageBox.Show(kbTemp);
                    this.kbPaymentFinished?.Invoke(this, e);
                }
            }
        }

        private static bool kbChangePossibility(kbDenomination[] kbDenominationsContainers, float kbChange)
        {
            float kbCapital = 0.0f;
            for (int i = 0; i < kbDenominationsContainers.Length; i++)
            {
                if (kbDenominationsContainers[i].kbQuantity > 0)
                {
                    kbCapital += kbDenominationsContainers[i].kbQuantity * kbDenominationsContainers[i].kbValue;
                }
            }
            return kbCapital >= kbChange;
        }
    }
}
