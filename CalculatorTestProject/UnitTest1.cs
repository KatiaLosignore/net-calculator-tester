using net_calculator_tester;

namespace CalculatorTestProject
{
    public class Tests
    {
  

        [Test]
        public void TestAdd()
        {
            // dichiaro input
            float x = 4.30f;
            float y = 3.50f;

            // dichiaro output atteso
            float outputAtteso = 7.8f;

            // chiamo la funzione e salvo il risultato
            float outputReale = Calculator.Add(x, y);

            // confronto output funzione con output atteso
            Assert.True(outputReale == outputAtteso, $"Il risultato atteso era {outputAtteso} mentre invece abbiamo {outputReale}");     

        }

        
    }
}