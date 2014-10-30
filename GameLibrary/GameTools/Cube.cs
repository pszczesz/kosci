using System;
using System.Text.RegularExpressions;

namespace GameLibrary.GameTools {

    public interface ICube {
        int GetResult(int expected = -1);
        int HowMany { get; }
    }
    public class Cube:ICube {
        private Random random;
        public Cube(int howMany, Random random) {
            this.random = random;
            HowMany = howMany<0?-howMany:howMany;
            HowMany = HowMany == 0 ? 1 : HowMany;
        }

        public int GetResult(int expected = -1) {
            int wynik =  expected == -1 ? random.Next(1, HowMany + 1) : expected;
            //Console.WriteLine(" wynik = "+wynik);
            return wynik;
        }

        public int HowMany { get; private set; }

       
    }
}