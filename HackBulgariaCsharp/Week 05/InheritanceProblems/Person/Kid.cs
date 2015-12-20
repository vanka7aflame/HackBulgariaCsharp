using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Kid : Person
    {
        protected Toy hasToy { get; set; }
        protected string kidGender { get; set; }
        public Kid(Toy hasToy, string gender)
        {
            this.hasToy = hasToy;
            this.kidGender = gender;
        }

        public override string Gender(string kidGender)
        {
            return base.Gender(kidGender);
        }

        public override string DailyStuff()
        {
            return string.Format("play");
        }

        public override string ToString()
        {
            return string.Format("{0} and my daily stuff is to {1} and my toy has - {2}",Gender(kidGender), DailyStuff(), hasToy.ToString());
        }
    }
}
