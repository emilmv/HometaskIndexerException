using HometaskIndexerException.Enums;
namespace HometaskIndexerException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Console.WriteLine("EXCHANGE RATE TO AZN");
        CurrencyInput:
            Console.WriteLine("===========================");
            Console.WriteLine("PLEASE ENTER THE CURRENCY YOU WANT TO EXCHANGE");
            Console.WriteLine("===========================");
            Console.WriteLine("TYPE USD FOR US DOLLARS");
            Console.WriteLine("TYPE EUR FOR US EURO");
            Console.WriteLine("TYPE TRY FOR TURKISH LIRA");
            string? currency = Console.ReadLine();
            if (string.IsNullOrEmpty(currency))
            {
                Console.WriteLine("INCORRECT CURRENCY, PLEASE TRY AGAIN");
                goto CurrencyInput;
            }
        AmountInput:
            Console.WriteLine("PLEASE ENTER AMOUNT TO CONVERT TO AZN");
            bool isCorrectInput = double.TryParse(Console.ReadLine(), out double input);
            if (!isCorrectInput)
            {
                Console.WriteLine("INCORRECT INPUT, PLEASE TRY AGAIN");
                goto AmountInput;
            }

            currency = currency.ToUpper();
            switch (currency)
            {
                case "USD":
                    Exchange(Currency.USD, input); break;
                case "EUR":
                    Exchange(Currency.EUR, input); break;
                case "TRY":
                    Exchange(Currency.TRY, input); break;
                default:
                    Console.WriteLine("INCORRECT CURRENCY, PLEASE TRY AGAIN"); goto CurrencyInput;
            }



            #endregion
            #region Task2
            //Student firstStudent = new Student();
            //firstStudent.Surname = "Rashford";
            //firstStudent.Name = "Marcus";
            //Student secondStudent = new Student();
            //secondStudent.Surname = "De Bruyne";
            //secondStudent.Name = "Kevin";
            //Student thirdStudent = new Student();
            //thirdStudent.Surname = "Haaland";
            //thirdStudent.Name = "Erling";
            //Group Players = new(3);
            //Players.Name = "Englis Premier League";
            //Players[0] = firstStudent;
            //Players[1] = secondStudent;
            //Players[2] = thirdStudent;
            //Players[0].Info();
            //Console.WriteLine("===========================");
            //Players[1].Info();
            //Console.WriteLine("===========================");
            //Players[2].Info();
            #endregion
        }
        public static void Exchange(Enum currency, double azn)
        {
            double exchangeRate;

            switch (currency)
            {
                case Currency.USD:
                    exchangeRate = 0.59;
                    Console.WriteLine($"{azn} Manat = " + azn * exchangeRate + " USD"); break;
                case Currency.TRY:
                    exchangeRate = 18.88;
                    Console.WriteLine($"{azn} Manat = " + azn * exchangeRate + " TURK LIRESI"); break;
                case Currency.EUR:
                    exchangeRate = 0.54;
                    Console.WriteLine($"{azn} Manat = " + azn * exchangeRate + " EURO"); break;
                default:
                    Console.WriteLine("Not correct currency"); break;
            }
        }
    }
}
