namespace TelCo.ColorCoder
{
    public static class TestExecuter
    {
        public static void ExecuteAllTests()
        {
            var tests = new ColorPairMapTests();
            tests.RunAllTests();
        }
    }
}
