using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingGame
{
    public class Betters
    {
        public int Money;
        public int Bet;
        public int BettingChoice;

        public void Win()
        {
            this.Money =  (this.Money - this.Bet) + (this.Bet * 2);

        }

        public void Loose()
        {
            Money = Money - Bet;
        }
    }
}
