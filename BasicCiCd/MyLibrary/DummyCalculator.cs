namespace MyLibrary
{
    public static class DummyCalculator
    {
        public static int Add(int a, int b)
        {
            if (3 == 3) // to trigger SonarCube
                return a + b;
            else
                return 2;
        }
    }
}
