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
            ReadAndCalculateSquarePerimeter();
            */

            //////////////////////////////////
            // 9 uzduotis ////////////////////
            //////////////////////////////////

            /*
            double Base = 0;
            double Height = 0;
            ReadTriangleData(ref Base, ref Height);
            CalculateTriangleArea(ref Base, ref Height);
            */

            //////////////////////////////////
            // 10 uzduotis ///////////////////
            //////////////////////////////////

            /*
            CalculateCircleAreaAndPerimeter(ReadCircleRadius());
            */

            //////////////////////////////////
            // 11 uzduotis ///////////////////
            //////////////////////////////////

            /*
            ReadAndCalculateCubeContent();
            */

            //////////////////////////////////
            // 12 uzduotis ///////////////////
            //////////////////////////////////

            /*
            ReadAndCalculateTemperature();
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
            Console.WriteLine("Iveskite kvadrato krastines ilgi:");
            if (!double.TryParse(Console.ReadLine(), out double Number) || Number <= 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            Number *= 4;
            Console.WriteLine($"Kvadrato perimetras: {Number}");
        }

        /// <summary>
        /// Nuskaito trikampio pagridno ilgi ir auksti
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="Height"></param>
        public static void ReadTriangleData(ref double Base, ref double Height)
        {
            Console.WriteLine("Iveskite trikampio pagrindo ilgi:");
            if (!double.TryParse(Console.ReadLine(), out double BaseValue) || BaseValue <= 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            Console.WriteLine("Iveskite trikampio pagrindo auksti:");
            if (!double.TryParse(Console.ReadLine(), out double HeightValue) || HeightValue <= 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            Base = BaseValue;
            Height = HeightValue;
        }

        /// <summary>
        /// Apskaiciuoja trikampio plota ir atspausdina rezultata
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="Height"></param>
        public static void CalculateTriangleArea(ref double Base, ref double Height)
        {
            if (Base > 0 && Height > 0)
            {
                Base = Base * Height * 0.5;
                Console.WriteLine($"Trikampio plotas: {Base}");
            }
        }

        /// <summary>
        /// Nuskaito apskritimo spinduli
        /// </summary>
        /// <returns></returns>
        public static double ReadCircleRadius()
        {
            Console.WriteLine("Iveskite apskritimo spinduli ilgi:");
            if (!double.TryParse(Console.ReadLine(), out double Value) || Value <= 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return 0;
            }
            return Value;
        }

        /// <summary>
        /// Apskaiciuoja apskritimo plota ir perimetra. Rezultatus atspausdina.
        /// </summary>
        /// <param name="Radius"></param>
        public static void CalculateCircleAreaAndPerimeter(double Radius)
        {
            if(Radius > 0)
            {
                double Value = Math.PI * Radius * Radius;
                Console.WriteLine($"Apskritimo plotas: {Value}");
                Value = 2.0 * Math.PI * Radius;
                Console.WriteLine($"Apskritimo plotas: {Value}");
            }
        }

        /// <summary>
        /// Nuskaito, apskaiciuoja kubo turi ir atspausdina rezultata
        /// </summary>
        public static void ReadAndCalculateCubeContent()
        {
            Console.WriteLine("Iveskite kubo krastines ilgi:");
            if (!double.TryParse(Console.ReadLine(), out double Number) || Number <= 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            Number = Number * Number * Number;
            Console.WriteLine($"Kubo turis: {Number}");
        }

        /// <summary>
        /// Nuskaito, konvertuoja temperatura is Celsijaus i Farenheita ir atspausdina rezultata
        /// </summary>
        public static void ReadAndCalculateTemperature()
        {
            Console.WriteLine("Iveskite temperatura Celsijaus skaleje:");
            if (!double.TryParse(Console.ReadLine(), out double Temp))
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            Temp = Math.Round(((Temp * 1.8) + 32.0), 1);
            Console.WriteLine($"Temperatura Farenheito skaleje: {Temp}");
        }
    }
}