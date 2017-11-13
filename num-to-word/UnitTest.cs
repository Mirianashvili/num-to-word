using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace num_to_word
{
    [TestClass]
    public class UnitTest
    {
        NumberConverter con;

        [TestMethod]
        public void ZeroTest()
        {
            con = new NumberConverter(0);
            Assert.AreEqual("ნული", con.toWord());
        }
        [TestMethod]
        public void InvalidInput()
        {
            con = new NumberConverter(-3333);
            Assert.AreEqual("არასწორია ფორმატი!", con.toWord());
        }
        [TestMethod]
        public void ThreeTest()
        {
            con = new NumberConverter(3);
            Assert.AreEqual("სამი", con.toWord());
        }
        [TestMethod]
        public void EightTest()
        {
            con = new NumberConverter(8);
            Assert.AreEqual("რვა", con.toWord());
        }
        [TestMethod]
        public void ElevenTest()
        {
            con = new NumberConverter(11);
            Assert.AreEqual("თერთმეტი", con.toWord());
        }
        [TestMethod]
        public void EightTeenTest()
        {
            con = new NumberConverter(18);
            Assert.AreEqual("თვრამეტი", con.toWord());
        }
        [TestMethod]
        public void TwentyTest()
        {
            con = new NumberConverter(20);
            Assert.AreEqual("ოცი", con.toWord());
        }
        [TestMethod]
        public void TwentyTwoTest()
        {
            con = new NumberConverter(22);
            Assert.AreEqual("ოცდაორი", con.toWord());
        }
        [TestMethod]
        public void Test30()
        {
            con = new NumberConverter(30);
            Assert.AreEqual("ოცდაათი", con.toWord());
        }
        [TestMethod]
        public void ThirtyFourTest()
        {
            con = new NumberConverter(34);
            Assert.AreEqual("ოცდათოთხმეტი", con.toWord());
        }
        [TestMethod]
        public void FourtyTest()
        {
            con = new NumberConverter(40);
            Assert.AreEqual("ორმოცი", con.toWord());
        }
        [TestMethod]
        public void FourtySixTest()
        {
            con = new NumberConverter(46);
            Assert.AreEqual("ორმოცდაექვსი", con.toWord());
        }
        [TestMethod]
        public void FiftyTest()
        {
            con = new NumberConverter(50);
            Assert.AreEqual("ორმოცდაათი", con.toWord());
        }
        [TestMethod]
        public void SeventyEightTest()
        {
            con = new NumberConverter(78);
            Assert.AreEqual("სამოცდათვრამეტი", con.toWord());
        }
        [TestMethod]
        public void EightThreeTest()
        {
            con = new NumberConverter(83);
            Assert.AreEqual("ოთხმოცდასამი", con.toWord());
        }
        [TestMethod]
        public void NinetyFiveTest()
        {
            con = new NumberConverter(95);
            Assert.AreEqual("ოთხმოცდათხუთმეტი", con.toWord());
        }
        [TestMethod]
        public void HundredTest()
        {
            con = new NumberConverter(100);
            Assert.AreEqual("ასი", con.toWord());
        }
        [TestMethod]
        public void HundredOneTest()
        {
            con = new NumberConverter(101);
            Assert.AreEqual("ას ერთი", con.toWord());
        }
        [TestMethod]
        public void HundredFiftyFiveTest()
        {
            con = new NumberConverter(155);
            Assert.AreEqual("ას ორმოცდათხუთმეტი", con.toWord());
        }
        [TestMethod]
        public void ThousandTest()
        {
            con = new NumberConverter(1000);
            Assert.AreEqual("ათასი", con.toWord());
        }
        [TestMethod]
        public void ThousandTwentyNineTest()
        {
            con = new NumberConverter(1029);
            Assert.AreEqual("ათას ოცდაცხრა", con.toWord());
        }
        [TestMethod]
        public void ThousandFiveHundredTwentyNineTest()
        {
            con = new NumberConverter(1529);
            Assert.AreEqual("ათას ხუთ ას ოცდაცხრა", con.toWord());
        }
        [TestMethod]
        public void ThousandSevenHundredFiftySixTest()
        {
            con = new NumberConverter(1756);
            Assert.AreEqual("ათას შვიდ ას ორმოცდათექვსმეტი", con.toWord());
        }

        [TestMethod]
        public void ThousandNineHundredFiftyTest()
        {
            con = new NumberConverter(1950);
            Assert.AreEqual("ათას ცხრა ას ორმოცდაათი", con.toWord());
        }
        [TestMethod]
        public void FiveThousandNineHundredFiftyTest()
        {
            con = new NumberConverter(5950);
            Assert.AreEqual("ხუთი ათას ცხრა ას ორმოცდაათი", con.toWord());
        }
        [TestMethod]
        public void ThreeThousandHundredFiftyOneTest()
        {
            con = new NumberConverter(3151);
            Assert.AreEqual("სამი ათას ას ორმოცდათერთმეტი", con.toWord());
        }
        [TestMethod]
        public void Test()
        {
            con = new NumberConverter(6459);
            Assert.AreEqual("ექვსი ათას ოთხ ას ორმოცდაცხრამეტი", con.toWord());
        }
        [TestMethod]
        public void TenThousand()
        {
            con = new NumberConverter(10000);
            Assert.AreEqual("ათი ათასი", con.toWord());
        }

        [TestMethod]
        public void ThreeThousandTwentyTwo()
        {
            con = new NumberConverter(3022);
            Assert.AreEqual("სამი ათას ოცდაორი", con.toWord());
        }

        [TestMethod]
        public void NinetySeven()
        {
            con = new NumberConverter(97);
            Assert.AreEqual("ოთხმოცდაჩვიდმეტი", con.toWord());
        }

        [TestMethod]
        public void FiveHundredFive()
        {
            con = new NumberConverter(505);
            Assert.AreEqual("ხუთ ას ხუთი", con.toWord());
        }

        [TestMethod]
        public void SixThousandSevenHunderedFiftyFour()
        {
            con = new NumberConverter(6754);
            Assert.AreEqual("ექვსი ათას შვიდ ას ორმოცდათოთხმეტი", con.toWord());
        }

        [TestMethod]
        public void SixThosand()
        {
            con = new NumberConverter(6000);
            Assert.AreEqual("ექვსი ათასი", con.toWord());
        }
    }
}
