using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame
{
    public class LottoGame<T, U>
        where T : IComparable<T>
        where U : IComparable<U>
    {
        private Combination<T, U> userComb;
        private Combination<T, U> winComb;

        public LottoGame(Combination<T, U> winningCombination)
        {
            this.GetWinning = winningCombination;
        }

        public void AddUserCombination(Combination<T, U> usersCombination)
        {
            this.userComb = usersCombination;
        }

        private Combination<T, U> GetWinning
        {
            get { return this.winComb; }
            set { this.winComb = value; }
        }
    }
}
