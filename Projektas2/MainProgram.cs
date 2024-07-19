using System.Reflection.Metadata.Ecma335;

namespace MainSpace
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            // Slack uzduotys/////////////////
            // 1 uzduotis ////////////////////
            //////////////////////////////////

            /*
            Console.WriteLine("Iveskite skaiciu:");
            Console.WriteLine("Skaicius yra " + ReadAndGetNumberKind());
            */

            //////////////////////////////////
            // 2 uzduotis ////////////////////
            //////////////////////////////////

            /*
            Console.WriteLine("Iveskite pirma skaiciu:");
            int.TryParse(Console.ReadLine(), out int Number1);
            Console.WriteLine("Iveskite antra skaiciu:");
            int.TryParse(Console.ReadLine(), out int Number2);
            Console.WriteLine("Iveskite trecia skaiciu:");
            int.TryParse(Console.ReadLine(), out int Number3);
            Console.WriteLine("Didziausias skaicius: " + GetHighestNumber(Number1, Number2, Number3));
            */

            //////////////////////////////////
            // 3 uzduotis ////////////////////
            //////////////////////////////////

            /*
            Console.WriteLine("Iveskite simboli: ");
            Console.WriteLine("Sis simbolis " + ReadAndGetCharKind());
            */

            //////////////////////////////////
            // 4 uzduotis ////////////////////
            //////////////////////////////////

            /*
            Console.WriteLine("Iveskite metus:");
            ReadAndCheckIfLeapYear();
            */

            //////////////////////////////////
            // 5 uzduotis ////////////////////
            //////////////////////////////////

            /*
            Console.WriteLine("Iveskite simboli:");
            Console.WriteLine("Simbolis " + ReadAndCheckIfNumber());
            */

            //////////////////////////////////
            // 6 uzduotis ////////////////////
            //////////////////////////////////

            /*
            if(ReadAndCheckIfTimeIsCorrect())
                Console.WriteLine("Ivestis yra teisinga");
            else
                Console.WriteLine("Ivestis yra neteisinga");
            */

            //////////////////////////////////
            // 7 uzduotis ////////////////////
            //////////////////////////////////

            /*
            Console.WriteLine("Iveskite skaiciu:");
            ReadAndCheckIfThreeDigit();
            */

            //////////////////////////////////
            // BONUS uzduotis ////////////////
            //////////////////////////////////

            /*
            Console.WriteLine("Iveskite simboli:");
            ReadAndCheckIfUpperCase();
            */

            //////////////////////////////////
            // 8 uzduotis ////////////////////
            //////////////////////////////////

            /*
            Console.WriteLine("Iveskite kvadrato krastines ilgi:");
            ReadAndCalculateSquarePerimeter();
            */
        }

        /// <summary>
        /// Nuskaito skaiciu ir patikrina ar tai yra teigiamas, neigiamas skaicius ar nulis
        /// </summary>
        /// <returns>Grazina skaicio tipa tekstu</returns>
        public static string ReadAndGetNumberKind()
        {
            int.TryParse(Console.ReadLine(), out int Number);
            if (Number > 0)
                return "teigiamas";
            else if (Number < 0)
                return "neigiamas";
            return "nulis";
        }

        /// <summary>
        /// Is triju skaiciu isrenka didziausia
        /// </summary>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        /// <param name="Number3"></param>
        /// <returns>Grazina didziausia skaiciu</returns>
        public static int GetHighestNumber(int Number1, int Number2, int Number3)
        {
            if (Number1 >= Number2 && Number1 >= Number3)
                return Number1;
            else if (Number2 >= Number1 && Number2 >= Number3)
                return Number2;
            return Number3;
        }

        /// <summary>
        /// Nuskaito simboli ir patikrina ar tai yra balsis ar priebalsis
        /// </summary>
        /// <returns>Grazina rezultata tekstu</returns>
        public static string ReadAndGetCharKind()
        {
            char.TryParse(Console.ReadLine(), out char Simbolis);
            if (!Char.IsLetter(Simbolis))
                return "nera raide!";
            else
            {
                Char.ToLower(Simbolis);
                if (Simbolis == 'a' || Simbolis == 'e' || Simbolis == 'y' || Simbolis == 'u' || Simbolis == 'i' || Simbolis == 'o')
                    return "yra balsis";
                return "yra priebalsis";
            }
        }

        /// <summary>
        /// Nuskaito, patikrina, ar ivesti metai yra keliamieji ir paraso rezultata i konsole
        /// </summary>
        public static void ReadAndCheckIfLeapYear()
        {
            if(!int.TryParse(Console.ReadLine(), out int Year) || Year < 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }


            if (Year % 4 == 0 )
            {
                if (Year % 100 == 0)
                {
                    if (Year % 400 == 0)
                    {
                        Console.WriteLine("Metai yra keliamieji");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Metai yra keliamieji");
                    return;
                }
            }
            Console.WriteLine("Metai yra nekeliamieji");
        }

        /// <summary>
        /// Nuskaito ir patikrina ar ivestas simbolis yra skaicius (0-9)
        /// </summary>
        /// <returns>Grazina rezultata tekstu</returns>
        public static string ReadAndCheckIfNumber()
        {
            if(byte.TryParse(Console.ReadLine(), out byte Number) && Number < 10)
                return "yra skaicius";
            return "nera skaicius";
        }

        /// <summary>
        /// Nuskaito ir patikrina ar ivestos valandos ir minutes yra teisingos ivestys
        /// </summary>
        /// <returns></returns>
        public static bool ReadAndCheckIfTimeIsCorrect()
        {
            Console.WriteLine("Iveskite valandas:");
            if (!byte.TryParse(Console.ReadLine(), out byte Hours) || Hours > 23)
                return false;
            Console.WriteLine("Iveskite minutes:");
            if(!byte.TryParse(Console.ReadLine(), out byte Minutes) || Minutes > 59)
                return false;
            return true;
        }

        /// <summary>
        /// Nuskaito skaiciu ir patikrina ar tai yra triju skaitmenu skaicius
        /// </summary>
        public static void ReadAndCheckIfThreeDigit()
        {
            if (!int.TryParse(Console.ReadLine(), out int Number))
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            if (Number > 99 && Number < 1000)
            {
                Console.WriteLine("Skaicius yra triju skaitmenu");
                return;
            }
            Console.WriteLine("Skaicius nera triju skaitmenu");
        }

        /// <summary>
        /// Nuskaito simboli, patikrina ar simbolis yra didzioji raide ir atspausdina rezultata
        /// </summary>
        public static void ReadAndCheckIfUpperCase()
        {
            char.TryParse(Console.ReadLine(), out char Simbolis);
            if (!char.IsLetter(Simbolis))
                Console.WriteLine("Simbolis nera raide!");
            else if( char.IsUpper(Simbolis) )
                Console.WriteLine("Simbolis yra didzioji raide");
            else
                Console.WriteLine("Simbolis nera didzioji raide"); 
        }

        /// <summary>
        /// Nuskaito skaiciu, apskaiciuoja kvadrato perimetra ir atspausdina rezultata 
        /// </summary>
        public static void ReadAndCalculateSquarePerimeter()
        {
            if (!int.TryParse(Console.ReadLine(), out int Number) || Number <= 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            Number *= 4;
            Console.WriteLine($"Kvadrato perimetras: {Number}");
        }
    }
}