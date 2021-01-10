using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projekt_Bak48678
{
    public partial class kbUserControlCurrency : UserControl
    {
        public event EventHandler kbbtnConfirmClick;
        public kbUserControlCurrency()
        {
            InitializeComponent();
        }
        public void kbPlaceControls()
        {
            kblabelChooseCurrency.Location = new Point(Width / 2 - kblabelChooseCurrency.Width / 2, Height / 10);
            kbgroupBoxCurrency.Size = new Size(7 * Width / 8, 2 * Height / 5);
            kbgroupBoxCurrency.Location = new Point(Width / 2 - kbgroupBoxCurrency.Width / 2, Height / 2 - kbgroupBoxCurrency.Height / 2);
            kbpictureBoxPLN.Size = new Size(kbgroupBoxCurrency.Width / 5, kbgroupBoxCurrency.Height / 3);
            kbpictureBoxPLN.Location = new Point(kbgroupBoxCurrency.Width / 20, kbgroupBoxCurrency.Height / 5);
            kbpictureBoxEUR.Size = kbpictureBoxPLN.Size;
            kbpictureBoxEUR.Location = new Point(kbgroupBoxCurrency.Width / 2 - kbpictureBoxEUR.Width / 2, kbpictureBoxPLN.Location.Y);
            kbpictureBoxUSD.Size = kbpictureBoxPLN.Size;
            kbpictureBoxUSD.Location = new Point(kbgroupBoxCurrency.Width - kbgroupBoxCurrency.Width / 20 - kbpictureBoxUSD.Width, kbpictureBoxPLN.Location.Y);
            kbradioButtonPLN.Location = new Point(kbpictureBoxPLN.Left + kbpictureBoxPLN.Width / 2 - kbradioButtonPLN.Width / 2, kbpictureBoxPLN.Bottom + kbradioButtonPLN.Height / 2);
            kbradioButtonEUR.Location = new Point(kbpictureBoxEUR.Left + kbpictureBoxEUR.Width / 2 - kbradioButtonEUR.Width / 2, kbpictureBoxEUR.Bottom + kbradioButtonEUR.Height / 2);
            kbradioButtonUSD.Location = new Point(kbpictureBoxUSD.Left + kbpictureBoxUSD.Width / 2 - kbradioButtonUSD.Width / 2, kbpictureBoxUSD.Bottom + kbradioButtonUSD.Height / 2);
            kbbuttonConfirm.Size = new Size(Width / 6, Height / 9);
            kbbuttonConfirm.Location = new Point(Width / 2 - kbbuttonConfirm.Width / 2, 9 * Height / 10 - kbbuttonConfirm.Height);
        }
        public GroupBox KBgbCurency
        {
            get { return kbgroupBoxCurrency; }
        }

        private void kbbuttonConfirm_Click(object sender, EventArgs e)
        {
            this.kbbtnConfirmClick?.Invoke(this, e);
        }
    }
}
