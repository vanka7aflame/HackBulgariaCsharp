using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTaxCalculator
{
    public class Calculator
    {
        private List<CountryVatTax> country = new List<CountryVatTax>();

        public Calculator(List<CountryVatTax> countryList)
        {
            this.country = countryList;
        }

        public void Calc(double productPrize, int countryID)
        {
            foreach (var item in country)
            {
                if (item.CountryID == countryID)
                {
                    productPrize += (productPrize * item.VATTAX) / 100;
                    Console.WriteLine("Prize with VAT = {0}", productPrize);
                }
            }
        }
        public void Calc(double productPrize)
        {
            foreach (var item in country)
            {
                if (item.IsDefault)
                {
                    productPrize += (productPrize * item.VATTAX) / 100;
                    Console.WriteLine("Prize with VAT = {0}", productPrize);
                }
            }
        }
    }
}
