using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame
{
    public class Combination<T, U>
        where T : IComparable<T>
        where U : IComparable<U>
    {
        private T first, second, third;
        private U fourth, fifth, sixth;
        public Combination(T a, T b, T c, U d, U e, U f)
        {
            this.First = a;
            this.Second = b;
            this.Third = c;
            this.Fourth = d;
            this.Fifth = e;
            this.Sixth = f;
        }

        public T First
        {
            get { return this.first; }
                set { this.first = value; }
        }
        public T Second
        {
            private get { return this.second; }
            set { this.second = value; }
        }
        public T Third
        {
            private get { return this.third; }
            set { this.third = value; }
        }
        public U Fourth
        {
            private get { return this.fourth; }
            set { this.fourth = value; }
        }
        public U Fifth
        {
            private get { return this.fifth; }
            set { this.fifth = value; }
        }
        public U Sixth
        {
            private get { return this.sixth; }
            set { this.sixth = value; }
        }

        public override bool Equals(object obj)
        {
            byte number;
            return GetMatchedNumbers(this, obj as Combination<T, U>, out number);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + this.Fifth.GetHashCode();
                hash = hash * 23 + this.Second.GetHashCode();
                hash = hash * 23 + this.Third.GetHashCode();
                hash = hash * 23 + this.Fourth.GetHashCode();
                hash = hash * 23 + this.Fifth.GetHashCode();
                hash = hash * 23 + this.Sixth.GetHashCode();
                return hash;
            }
        }

        public static bool GetMatchedNumbers(Combination<T, U> comb1, Combination<T, U> comb2, out byte numberOfMatches)
        {
            numberOfMatches = 0;
            bool isWinning = false;

            if(comb1.First.CompareTo(comb2.First) == 0)
            {
                numberOfMatches++;
                isWinning = true;
            }

            if (comb1.Second.CompareTo(comb2.Second) == 0)
            {
                numberOfMatches++;
                isWinning = true;
            }

            if (comb1.Third.CompareTo(comb2.Third) == 0)
            {
                numberOfMatches++;
                isWinning = true;
            }

            if (comb1.Fourth.CompareTo(comb2.Fourth) == 0)
            {
                numberOfMatches++;
                isWinning = true;
            }

            if (comb1.Fifth.CompareTo(comb2.Fifth) == 0)
            {
                numberOfMatches++;
                isWinning = true;
            }

            if (comb1.Sixth.CompareTo(comb2.Sixth) == 0)
            {
                numberOfMatches++;
                isWinning = true;
            }

            return isWinning;
        }      
    }
}
