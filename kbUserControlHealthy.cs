using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projekt_Bak48678
{
    public partial class kbUserControlHealthy : UserControl
    {
        public event EventHandler kbbtnPay;
        public kbUserControlHealthy()
        {
            InitializeComponent();
        }
        public void kbPlaceControls()
        {
            kbpanelHealthy.Size = this.Size;
            kbpanelHealthy.Location = new Point(0, 0);
            kbpictureBoxWater.Size = new Size(Width / 4, Width / 4);
            kbpictureBoxWater.Location = new Point(Width / 16, Height / 10);
            kbpictureBoxNuts.Size = kbpictureBoxWater.Size;
            kbpictureBoxNuts.Location = new Point(kbpictureBoxWater.Right + Width / 16, kbpictureBoxWater.Location.Y);
            kbpictureBoxAlmonds.Size = kbpictureBoxWater.Size;
            kbpictureBoxAlmonds.Location = new Point(kbpictureBoxNuts.Right + Width / 16, kbpictureBoxWater.Location.Y);
            kblabelPriceOfWater.Location = new Point(kbpictureBoxWater.Left + kbpictureBoxWater.Width / 2 - kblabelPriceOfWater.Width / 2, kbpictureBoxWater.Bottom + Width / 26);
            kblabelPriceOfNuts.Location = new Point(kbpictureBoxNuts.Left + kbpictureBoxNuts.Width / 2 - kblabelPriceOfNuts.Width / 2, kbpictureBoxNuts.Bottom + Width / 26);
            kblabelPriceOfAlmonds.Location = new Point(kbpictureBoxAlmonds.Left + kbpictureBoxAlmonds.Width / 2 - kblabelPriceOfAlmonds.Width / 2, kbpictureBoxAlmonds.Bottom + Width / 26);
            kbgroupBoxHealthy.Size = new Size(kbpictureBoxAlmonds.Right - kbpictureBoxWater.Left, 3 * kbradioButtonWater.Height);
            kbgroupBoxHealthy.Location = new Point(kbpictureBoxWater.Left, kblabelPriceOfWater.Bottom + kblabelPriceOfWater.Height);
            kbradioButtonWater.Location = new Point(kbpictureBoxWater.Width / 2 - kbradioButtonWater.Width / 2, kbgroupBoxHealthy.Height / 2 - kbradioButtonWater.Height / 2);
            kbradioButtonNuts.Location = new Point(kbpictureBoxNuts.Width / 2 - kbradioButtonNuts.Width / 2 + kbpictureBoxNuts.Left - kbpictureBoxWater.Left,
                kbgroupBoxHealthy.Height / 2 - kbradioButtonNuts.Height / 2);
            kbradioButtonAlmonds.Location = new Point(kbpictureBoxAlmonds.Width / 2 - kbradioButtonAlmonds.Width / 2 + kbpictureBoxAlmonds.Left - kbpictureBoxWater.Left,
                kbgroupBoxHealthy.Height / 2 - kbradioButtonAlmonds.Height / 2);
            kbbuttonAcceptHT.Size = new Size(kbpictureBoxWater.Width, kblabelPriceOfWater.Height);
            kbbuttonAcceptHT.Location = new Point(Width - kbbuttonAcceptHT.Width - Width / 26, kbgroupBoxHealthy.Bottom + Width / 26);
        }
        public GroupBox KBgbHealthy
        {
            get { return kbgroupBoxHealthy; }
        }

        private void kbbuttonAcceptHT_Click(object sender, EventArgs e)
        {
            this.kbbtnPay?.Invoke(this, e);
        }

        public Label kbGetLabelWater
        {
            get
            {
                return kblabelPriceOfWater;
            }
        }
        public Label kbGetLabelNuts
        {
            get
            {
                return kblabelPriceOfNuts;
            }
        }
        public Label kbGetLabelAlmonds
        {
            get
            {
                return kblabelPriceOfAlmonds;
            }
        }
    }
}
