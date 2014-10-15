namespace GameLibrary.GameTools {
    public class FakeCube :ICube{
    

        public FakeCube(int howMany) {
            howMany = howMany < 0 ? -howMany : howMany;
            HowMany = howMany == 0 ? 1 : howMany;
        }

        public int GetResult(int expected = -1) {
            return expected;
        }

        public int HowMany { get; private set; }
    }
}