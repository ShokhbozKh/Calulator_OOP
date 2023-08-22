using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculyator
{
    internal class CalcInput
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public string Operators { get; set; }

        public void CalculatorInput()
        {
            Console.Write("FirsNumber:");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("SecondNumber:");
            SecondNumber = int.Parse(Console.ReadLine());

            Console.Write("Operator: ");
            Operators = Console.ReadLine();
        }
        public bool IsFirstNumberPositive()
        {
            return FirstNumber > 0;
        }
        public bool IsSecondNumberPositive()
        {
                return SecondNumber > 0;
        }

        public void RaqamlarniSolishtirish() 
        {
            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine("Birinchi raqam katta ");
            }
            else if(FirstNumber < SecondNumber)
            {
                Console.WriteLine("Ikkinchi raqam katta ");
            }
            else
            {
                Console.WriteLine("birinchi va ikkinchi raqamlar teng!");
            }
        }
        public void CalcTwoNumber()
        {
            switch (Operators)
            {
                case "+":
                    Console.WriteLine(FirstNumber + SecondNumber); break;
                case "-":
                    Console.WriteLine(FirstNumber - SecondNumber); break;
                case "*": 
                    Console.WriteLine(FirstNumber * SecondNumber); break;
                case "/":
                    Console.WriteLine(FirstNumber / SecondNumber); break;
                default:
                    Console.WriteLine("Xatolik bor"); break;
            }
        }
        public void JuftSonlar()
        {
            Console.WriteLine($"Birinchi kiritgan sonimiz {FirstNumber} gacha juft sonlar");
            int t = 0;
            for (int i=1; i<FirstNumber; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                    t++;
                }
            }
            Console.WriteLine("juft sonlar soni" +  t); 
        }
        public void KarraJadval()
        {
            for(int i=1; i<=10; i++)
            {
                for(int j=1; j<=10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {j*i}");
                }
                Console.WriteLine("----------------------");
            }
        }
    }
}
