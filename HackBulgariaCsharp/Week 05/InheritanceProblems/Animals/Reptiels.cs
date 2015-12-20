using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Reptiels : Animal, ILandAnimals
    {
        private Random _temperature;

        public void Temperature(Random temp)
        {
            this._temperature = temp;
            Console.WriteLine("My current temperature is : {0}", this._temperature);
        }

        public override string Move()
        {
            return String.Format("I am a reptiel and my way of walking is crawling");
        }

        public virtual string Greet()
        {
            return String.Format("Hello from reptiels");
        }
    }
}
