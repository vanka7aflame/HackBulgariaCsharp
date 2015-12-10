using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTaxCalculator
{
    public class CountryVatTax
    {
        private int countryID;
        private int VATTax;
        private bool isDefault = false;

        public CountryVatTax(int countryID, int VATTax, bool isDefault = false)
        {
            this.CountryID = countryID;
            this.VATTAX = VATTax;
            this.IsDefault = isDefault;
        }

        public int CountryID
        {
            get { return this.countryID; }
            set { this.countryID = value; }
        }
        public int VATTAX
        {
            get { return this.VATTax; }
            set { this.VATTax = value; }
        }
        public bool IsDefault
        {
            get { return this.isDefault; }
            set { this.isDefault = value; }
        }
    }
}
