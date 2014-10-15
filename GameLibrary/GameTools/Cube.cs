using System;
using System.Text.RegularExpressions;

namespace GameLibrary.GameTools {

    public interface ICube {
        int GetResult(int expected = -1);
        int HowMany { get; }
    }
    public class Cube:ICube {
        public Cube(int howMany) {
            HowMany = howMany<0?-howMany:howMany;
            HowMany = HowMany == 0 ? 1 : HowMany;
        }

        public int GetResult(int expected = -1) {
            return expected == -1 ? new Random().Next(1, HowMany + 1) : expected;
        }

        public int HowMany { get; private set; }

       
    }
}