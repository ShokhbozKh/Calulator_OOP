namespace calculyator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Password password = new Password();
           CalcInput calcInput = new CalcInput();

            password.PasswordCheak();
            calcInput.CalculatorInput();

            //xabar berish
            if (!calcInput.IsFirstNumberPositive())
            {
                Console.WriteLine("birinchi son Musbat emas");
            }
            else
            {
                Console.WriteLine("Birinchi son manfiy emas");
            }
            if (!calcInput.IsSecondNumberPositive())
            {
                Console.WriteLine("Ikkinchi son Musbat emas");
            }
            else
            {
                Console.WriteLine("Ikkinchi son manfiy emas");
            }

            calcInput.RaqamlarniSolishtirish();

            calcInput.CalcTwoNumber();

            calcInput.JuftSonlar();
            calcInput.KarraJadval();
        }
    }
}