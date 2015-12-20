using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame
{
    class LottoResult<T, U>
        where T : IComparable<T>
        where U : IComparable<U>
    {
        private bool isWinning;
        private byte countMatchedNumbers;

        public LottoResult(Combination<T, U> winComb, Combination<T, U> userComb)
        {
            byte numbers;
            IsWinning = Combination<T, U>.GetMatchedNumbers(winComb, userComb, out numbers);

            CountMatchedNumbers = numbers;
            Console.WriteLine(isWinning);
            Console.WriteLine(CountMatchedNumbers);
        }

        public bool IsWinning
        {
            get { return this.isWinning; }
            set { this.isWinning = value; }
        }
        public byte CountMatchedNumbers
        {
            get { return this.countMatchedNumbers; }
            set { this.countMatchedNumbers = value; }
        }
    }
}
