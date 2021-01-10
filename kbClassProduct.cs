using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Bak48678
{
    class kbClassProduct
    {
        string kbName;
        string kbCategory;
        float kbPriceInPLN;
        float kbPriceInEUR;
        float kbPriceInUSD;

        public kbClassProduct(string kbName, string kbCategory, float kbPriceInPLN)
        {
            this.kbName = kbName;
            this.kbCategory = kbCategory;
            this.kbPriceInPLN = kbPriceInPLN;
            this.kbPriceInUSD = kbRoundPrice(kbPriceInPLN * 0.26F);
            this.kbPriceInEUR = kbRoundPrice(kbPriceInPLN * 0.22F);
        }
        public string KBName
        {
            get { return kbName; }
            set { kbName = value; }
        }
        public string KBCategory
        {
            get { return kbCategory; }
            set { kbCategory = value; }
        }
        public float KBPriceInPLN
        {
            get { return kbPriceInPLN; }          
        }
        public float KBPriceInEUR
        {
            get { return kbPriceInEUR; }
            set { kbPriceInEUR = value; }
        }
        public float KBPriceInUSD
        {
            get { return kbPriceInUSD; }
            set { kbPriceInUSD = value; }
        }

        public float KBgetPrice(string kbCurrency)
        {
            switch (kbCurrency)
            {
                case "PLN":
                    {
                        return KBPriceInPLN;
                    }
                case "USD":
                    {
                        return KBPriceInUSD;
                    }
                case "EUR":
                    {
                        return KBPriceInEUR;
                    }
                default:
                    {
                        return KBPriceInPLN;
                    }
            }
        }

        private float kbRoundPrice(float kbPrice)
        {
            if (kbPrice - Math.Truncate(kbPrice) < 0.25)
            {
                return (float)Math.Truncate(kbPrice);
            }
            else if (kbPrice - Math.Truncate(kbPrice) >= 0.25 && kbPrice - Math.Truncate(kbPrice) < 0.75)
            {
                return (float)Math.Truncate(kbPrice) + 0.5f;
            }
            else
            {
                return (float)Math.Round(kbPrice);
            }
        }
    }
}
