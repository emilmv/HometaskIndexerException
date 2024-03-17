using HometaskIndexerException.Enums;
namespace HometaskIndexerException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Exchange(Currency.USD, 10);
            //Exchange(Currency.TRY, 10);
            //Exchange(Currency.EUR, 10);
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
                    Console.WriteLine(azn * exchangeRate); break;
                case Currency.TRY:
                    exchangeRate = 18.88;
                    Console.WriteLine(azn * exchangeRate); break;
                case Currency.EUR:
                    exchangeRate = 0.54;
                    Console.WriteLine(azn * exchangeRate); break;
                default:
                    Console.WriteLine("Not correct currency"); break;
            }
        }
    }
}
