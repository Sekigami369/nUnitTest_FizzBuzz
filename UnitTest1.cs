using FizzBuzz;

namespace nUnitTest
{
    public class CalcNum_Test
    {        

        private CalcNum calcNum { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            calcNum = new CalcNum();
        }

        [TestCase(3)]
        [TestCase(66)]
        [TestCase(99)]
        [TestCase(12)]
        [TestCase(72)]
        public void GetFizzBuzz_calc_Test3(int num)
        {

            var ansNum = calcNum.GetFizzBuzz_calc(num);

            Assert.AreEqual("Fizz", ansNum);
        }

        [TestCase(5)]
        [TestCase(25)]
        [TestCase(45)]
        [TestCase(55)]
        [TestCase(95)]
        public void GetFizzBuzz_calc_Test5(int num)
        {

            var ansNum = calcNum.GetFizzBuzz_calc(num);

            Assert.AreEqual("Buzz", ansNum);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(60)]
        [TestCase(75)]
        [TestCase(90)]
        public void GetFizzBuzz_calc_Test_3_5(int num)
        {

            var ansNum = calcNum.GetFizzBuzz_calc(num);

            Assert.AreEqual("Buzz", ansNum);
        }
    }
}