using net_calculator_tester;
using Newtonsoft.Json.Bson;

namespace CalculatorTestProject
{
    [TestFixture]
    public class Tests
    {
        Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }


        // testo la funzione Add della classe Calculator

        [Test]
        public void TestAdd()
        {
            // dichiaro input
            float x = 4.30f;
            float y = 3.50f;

            // dichiaro output atteso
            float outputAtteso = 7.8f;

            // chiamo la funzione e salvo il risultato
            float outputReale = calculator.Add(x, y);

            // confronto output funzione con output atteso
            Assert.True(outputReale == outputAtteso, $"Il risultato atteso era {outputAtteso} mentre invece abbiamo {outputReale}");     

        }

        // testo la funzione Subtract della classe Calculator

        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(2, -4, 8)]
        [TestCase(2, -8, 3)]
        public void TestSubstract(float x, float y, float result)
        {
            Assert.That(calculator.Subtract(x, y), Is.EqualTo(result));
        }


        // testo la funzione Divide della classe Calculator 

        [Test]
        [TestCase(20, 0)]
        [TestCase(0, 0)]
        public void TestDivideZero(float x, float y)
        {
            Assert.Throws<ArgumentException>(() =>  calculator.Divide(x, y));

        }

        [Test]
        [TestCase(16, 2, 8)]
        [TestCase(20, 2, 10)]
        [TestCase(20, 5, 8)]

        public void TestDivide(float x, float y, float result)
        {
            Assert.That(calculator.Divide(x, y), Is.EqualTo(result));
        }


        // testo la funzione Multiply della classe Calculator

        [Test]
        [TestCase(8, 2, 16)]
        [TestCase(5, 3, 15)]
        [TestCase(7, 9, 20)]

        public void TestMultiply(float x, float y, float result)
        {
            Assert.That(calculator.Multiply(x, y), Is.EqualTo(result));
        }
    }
}