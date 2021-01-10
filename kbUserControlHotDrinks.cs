using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projekt_Bak48678
{

    public partial class kbUserControlHotDrinks : UserControl
    {
        public event EventHandler kbbtnPay;
        public kbUserControlHotDrinks()
        {
            InitializeComponent();
        }
        public void kbPlaceControls()
        {
            kbpanelHotDrinks.Size = this.Size;
            kbpanelHotDrinks.Location = new Point(0, 0);
            kbpictureBoxCoffee.Size = new Size(Width / 4, Width / 4);
            kbpictureBoxCoffee.Location = new Point(Width / 16, Height / 10);
            kbpictureBoxTea.Size = kbpictureBoxCoffee.Size;
            kbpictureBoxTea.Location = new Point(kbpictureBoxCoffee.Right + Width / 16, kbpictureBoxCoffee.Location.Y);
            kbpictureBoxHotChocolate.Size = kbpictureBoxCoffee.Size;
            kbpictureBoxHotChocolate.Location = new Point(kbpictureBoxTea.Right + Width / 16, kbpictureBoxCoffee.Location.Y);
            kblabelPriceOfCoffee.Location = new Point(kbpictureBoxCoffee.Left + kbpictureBoxCoffee.Width / 2 - kblabelPriceOfCoffee.Width / 2, kbpictureBoxCoffee.Bottom + Width / 26);
            kblabelPriceOfTea.Location = new Point(kbpictureBoxTea.Left + kbpictureBoxTea.Width / 2 - kblabelPriceOfTea.Width / 2, kbpictureBoxTea.Bottom + Width / 26);
            kblabelPriceOfHotChocolate.Location = new Point(kbpictureBoxHotChocolate.Left + kbpictureBoxHotChocolate.Width / 2 - kblabelPriceOfHotChocolate.Width / 2, kbpictureBoxHotChocolate.Bottom + Width / 26);
            kbgroupBoxHotDrinks.Size = new Size(kbpictureBoxHotChocolate.Right - kbpictureBoxCoffee.Left, 3 * kbradioButtonCoffee.Height);
            kbgroupBoxHotDrinks.Location = new Point(kbpictureBoxCoffee.Left, kblabelPriceOfCoffee.Bottom + kblabelPriceOfCoffee.Height);
            kbradioButtonCoffee.Location = new Point(kbpictureBoxCoffee.Width / 2 - kbradioButtonCoffee.Width / 2, kbgroupBoxHotDrinks.Height / 2 - kbradioButtonCoffee.Height / 2);
            kbradioButtonTea.Location = new Point(kbpictureBoxTea.Width / 2 - kbradioButtonTea.Width / 2 + kbpictureBoxTea.Left - kbpictureBoxCoffee.Left,
                kbgroupBoxHotDrinks.Height / 2 - kbradioButtonTea.Height / 2);
            kbradioButtonHotChocolate.Location = new Point(kbpictureBoxHotChocolate.Width / 2 - kbradioButtonHotChocolate.Width / 2 + kbpictureBoxHotChocolate.Left - kbpictureBoxCoffee.Left,
                kbgroupBoxHotDrinks.Height / 2 - kbradioButtonHotChocolate.Height / 2);
            kbbuttonAcceptHD.Size = new Size(kbpictureBoxCoffee.Width, kblabelPriceOfCoffee.Height);
            kbbuttonAcceptHD.Location = new Point(Width - kbbuttonAcceptHD.Width - Width / 26, kbgroupBoxHotDrinks.Bottom + Width / 26);
        }
        public GroupBox KBgbHotDrinks
        {
            get { return kbgroupBoxHotDrinks; }
        }

        private void kbbuttonAcceptHD_Click_1(object sender, EventArgs e)
        {
            this.kbbtnPay?.Invoke(this, e);
        }

        public Label kbGetLabelCoffee
        {
            get
            {
                return kblabelPriceOfCoffee;
            }
        }
        public Label kbGetLabelTea
        {
            get
            {
                return kblabelPriceOfTea;
            }
        }
        public Label kbGetLabelHotChocolate
        {
            get
            {
                return kblabelPriceOfHotChocolate;
            }
        }
    }
}
