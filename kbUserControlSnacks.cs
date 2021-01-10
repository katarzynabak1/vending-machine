using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projekt_Bak48678
{
    public partial class kbUserControlSnacks : UserControl
    {
        public event EventHandler kbbtnPay;
        public kbUserControlSnacks()
        {
            InitializeComponent();
        }
        public void kbPlaceControls()
        {
            kbpanelSnacks.Size = this.Size;
            kbpanelSnacks.Location = new Point(0, 0);
            kbpictureBoxChips.Size = new Size(Width / 4, Width / 4);
            kbpictureBoxChips.Location = new Point(Width / 16, Height / 10);
            kbpictureBoxCookies.Size = kbpictureBoxChips.Size;
            kbpictureBoxCookies.Location = new Point(kbpictureBoxChips.Right + Width / 16, kbpictureBoxChips.Location.Y);
            kbpictureBoxChocolate.Size = kbpictureBoxChips.Size;
            kbpictureBoxChocolate.Location = new Point(kbpictureBoxCookies.Right + Width / 16, kbpictureBoxChips.Location.Y);
            kblabelPriceOfChips.Location = new Point(kbpictureBoxChips.Left + kbpictureBoxChips.Width / 2 - kblabelPriceOfChips.Width / 2, kbpictureBoxChips.Bottom + Width / 26);
            kblabelPriceOfCookies.Location = new Point(kbpictureBoxCookies.Left + kbpictureBoxCookies.Width / 2 - kblabelPriceOfCookies.Width / 2, kbpictureBoxCookies.Bottom + Width / 26);
            kblabelPriceOfChocolate.Location = new Point(kbpictureBoxChocolate.Left + kbpictureBoxChocolate.Width / 2 - kblabelPriceOfChocolate.Width / 2, kbpictureBoxChocolate.Bottom + Width / 26);
            kbgroupBoxSnacks.Size = new Size(kbpictureBoxChocolate.Right - kbpictureBoxChips.Left, 3 * kbradioButtonChips.Height);
            kbgroupBoxSnacks.Location = new Point(kbpictureBoxChips.Left, kblabelPriceOfChips.Bottom + kblabelPriceOfChips.Height);
            kbradioButtonChips.Location = new Point(kbpictureBoxChips.Width / 2 - kbradioButtonChips.Width / 2, kbgroupBoxSnacks.Height / 2 - kbradioButtonChips.Height / 2);
            kbradioButtonCookies.Location = new Point(kbpictureBoxCookies.Width / 2 - kbradioButtonCookies.Width / 2 + kbpictureBoxCookies.Left - kbpictureBoxChips.Left,
                kbgroupBoxSnacks.Height / 2 - kbradioButtonCookies.Height / 2);
            kbradioButtonChocolate.Location = new Point(kbpictureBoxChocolate.Width / 2 - kbradioButtonChocolate.Width / 2 + kbpictureBoxChocolate.Left - kbpictureBoxChips.Left,
                kbgroupBoxSnacks.Height / 2 - kbradioButtonChocolate.Height / 2);
            kbbuttonAcceptSN.Size = new Size(kbpictureBoxChips.Width, kblabelPriceOfChips.Height);
            kbbuttonAcceptSN.Location = new Point(Width - kbbuttonAcceptSN.Width - Width / 26, kbgroupBoxSnacks.Bottom + Width / 26);
        }
        public GroupBox KBgbSnacks
        {
            get { return kbgroupBoxSnacks; }
        }

        private void kbbuttonAcceptSN_Click(object sender, EventArgs e)
        {
            this.kbbtnPay?.Invoke(this, e);
        }

        public Label kbGetLabelChips
        {
            get
            {
                return kblabelPriceOfChips;
            }
        }
        public Label kbGetLabelCookies
        {
            get
            {
                return kblabelPriceOfCookies;
            }
        }
        public Label kbGetLabelChocolate
        {
            get
            {
                return kblabelPriceOfChocolate;
            }
        }
    }
}
