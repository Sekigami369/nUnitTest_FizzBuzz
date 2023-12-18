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
        [TestCase(70)]
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

            Assert.AreEqual("FizzBuzz", ansNum);
        }


        [TestCase(1)]
        [TestCase(19)]
        [TestCase(62)]
        [TestCase(94)]
        [TestCase(68)]


        public void Not_GetFizzBuzz_calc_Test3(int num)
        {
            //3と5の倍数でないとき整数が返されるかテスト
            var ansNum = calcNum.GetFizzBuzz_calc(num);

            Assert.AreNotEqual("Fizz", ansNum);
        }

        [TestCase(8)]
        [TestCase(26)]
        [TestCase(56)]
        [TestCase(71)]
        [TestCase(46)]
        public void Not_GetFizzBuzz_calc_Test5(int num)
        {
            //3と5の倍数でないとき整数が返されるかテスト
            var ansNum = calcNum.GetFizzBuzz_calc(num);

            Assert.AreNotEqual("Buzz", ansNum);
        }

        [TestCase(98)]
        [TestCase(7)]
        [TestCase(17)]
        [TestCase(14)]
        [TestCase(91)]
        public void Not_GetFizzBuzz_calc_Test3_5(int num)
        {
            //3と5の倍数でないとき整数が返されるかテスト
            var ansNum = calcNum.GetFizzBuzz_calc(num);

            Assert.AreNotEqual("FizzBuzz", ansNum);
        }
    }
}