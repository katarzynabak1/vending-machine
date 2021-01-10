using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projekt_Bak48678
{
    public partial class kbUserControlColdDrinks : UserControl
    {
        public event EventHandler kbbtnPay;
        public kbUserControlColdDrinks()
        {
            InitializeComponent();
        }
        public void kbPlaceControls()
        {
            kbpanelColdDrinks.Size = this.Size;
            kbpanelColdDrinks.Location = new Point(0, 0);
            kbpictureBoxCola.Size = new Size(Width / 4, Width / 4);
            kbpictureBoxCola.Location = new Point(Width / 16, Height / 10);
            kbpictureBoxPepsi.Size = kbpictureBoxCola.Size;
            kbpictureBoxPepsi.Location = new Point(kbpictureBoxCola.Right + Width / 16, kbpictureBoxCola.Location.Y);
            kbpictureBoxRedBull.Size = kbpictureBoxCola.Size;
            kbpictureBoxRedBull.Location = new Point(kbpictureBoxPepsi.Right + Width / 16, kbpictureBoxCola.Location.Y);
            kblabelPriceOfCola.Location = new Point(kbpictureBoxCola.Left + kbpictureBoxCola.Width / 2 - kblabelPriceOfCola.Width / 2, kbpictureBoxCola.Bottom + Width / 26);
            kblabelPriceOfPepsi.Location = new Point(kbpictureBoxPepsi.Left + kbpictureBoxPepsi.Width / 2 - kblabelPriceOfPepsi.Width / 2, kbpictureBoxPepsi.Bottom + Width / 26);
            kblabelPriceOfRedBull.Location = new Point(kbpictureBoxRedBull.Left + kbpictureBoxRedBull.Width / 2 - kblabelPriceOfRedBull.Width / 2, kbpictureBoxRedBull.Bottom + Width / 26);
            kbgroupBoxColdDrinks.Size = new Size(kbpictureBoxRedBull.Right - kbpictureBoxCola.Left, 3 * kbradioButtonCola.Height);
            kbgroupBoxColdDrinks.Location = new Point(kbpictureBoxCola.Left, kblabelPriceOfCola.Bottom + kblabelPriceOfCola.Height);
            kbradioButtonCola.Location = new Point(kbpictureBoxCola.Width / 2 - kbradioButtonCola.Width / 2, kbgroupBoxColdDrinks.Height / 2 - kbradioButtonCola.Height / 2);
            kbradioButtonPepsi.Location = new Point(kbpictureBoxPepsi.Width / 2 - kbradioButtonPepsi.Width / 2 + kbpictureBoxPepsi.Left - kbpictureBoxCola.Left, 
                kbgroupBoxColdDrinks.Height / 2 - kbradioButtonPepsi.Height / 2);
            kbradioButtonRedBull.Location = new Point(kbpictureBoxRedBull.Width / 2 - kbradioButtonRedBull.Width / 2 + kbpictureBoxRedBull.Left - kbpictureBoxCola.Left,
                kbgroupBoxColdDrinks.Height / 2 - kbradioButtonRedBull.Height / 2);
            kbbuttonAcceptCD.Size = new Size(kbpictureBoxCola.Width, kblabelPriceOfCola.Height);
            kbbuttonAcceptCD.Location = new Point(Width - kbbuttonAcceptCD.Width - Width / 26, kbgroupBoxColdDrinks.Bottom + Width / 26);
        }
        public GroupBox KBgbColdDrinks
        {
            get { return kbgroupBoxColdDrinks; }
        }
        private void kbbuttonAcceptCD_Click(object sender, EventArgs e)
        {
            this.kbbtnPay?.Invoke(this, e);
        }
        public Label kbGetLabelCola
        {
            get
            {
                return kblabelPriceOfCola;
            }
        }
        public Label kbGetLabelPepsi
        {
            get
            {
                return kblabelPriceOfPepsi;
            }
        }
        public Label kbGetLabelRedBull
        {
            get
            {
                return kblabelPriceOfRedBull;
            }
        }
    }
}
