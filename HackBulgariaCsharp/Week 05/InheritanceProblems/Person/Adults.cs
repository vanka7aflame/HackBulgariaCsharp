using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Adults : Person
    {
        public bool isBooring;
        protected string adultGender { get; set; }

        public Adults(string gender, bool isBooring)
        {
            this.adultGender = gender;
            this.IsBooring = isBooring;
        }

        public bool IsBooring
        {
            get { return this.isBooring; }
            set { this.isBooring = value; }
        }

        public override string Gender(string adultGender)
        {
            return base.Gender(adultGender);
        }

        public override string DailyStuff()
        {
            return string.Format("What i do for daily stuff is going to work");
        }

        public string HaveKids()
        {
            return string.Format("I can have kids!");
        }

        public override string ToString()
        {
            return string.Format("{0} , {1} and {2}", DailyStuff(), Gender(adultGender),HaveKids());
        }
    }
}
