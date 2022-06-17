using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Sc_58029_CiagWejsciowy
    {
        public static string sc_58029_WyborKodu()
        {
    
            string sc_58029_Source = "";


            string sc_58029_KodIndywidualny = "ABDDCACDCCDCAACADDBBACDCBDADCACACBCACDACCDAACCBCBABDABCDBBCAAADDBCBDDAADBABBABBDCBBADACAADBBAADDCDDABBABCBDACADBCDCABADBDDADBCCDDCBAAADABDBCCACABCCADCABAACBBDACDDBDCCBACDCCDCBADBDADCBBCCCCDAAABBCDCACBDAADAAACBADCBADDDABBDDAAD";
            string sc_58029_KodWykl = "DBCDDCBBBCDBADBADACBCABACBACDCBCACDACADDBAAADBDCBDDDABACBCCAAACBCDBCBDADDBBBBCCBDDDBBAADDCDCCDADBDCDCCACADCDCAADDCDBAAABBACCDBDABBDCDBCCBCADDDDACCCCCBCBADDCDDCDBBCDCCBDCDBDABDBBDAABBAACACABDACAAADACAABDBCAABADCCADDBCACACBAACA";

            Console.WriteLine("Jeśli chcesz użyć kodu przypisanego indywidualnie do studenta, wpisz 1");
            Console.WriteLine("Jeśli chcesz użyć kodu załączopnego na wykładzie wpisz 2");
            Console.WriteLine("Jeśli chcesz użyć własnego kodu, wpisz 3");
            Console.WriteLine("O autorze, wpisz 4");
            Console.WriteLine("Jeśli chcesz wyłączyć program, wpisz 0");

        
            string sc_58029_Wybor;

            sc_58029_Wybor = Console.ReadLine();

            while (sc_58029_Wybor != "1" && sc_58029_Wybor != "2" && sc_58029_Wybor != "3" && sc_58029_Wybor != "0")
            {

                if (sc_58029_Wybor == "4")
                {
                   
                    Console.Clear();
                    Console.WriteLine("Autor ćwiczenia:");
                    Console.WriteLine("Sebastian Chabowski");                

                    Console.ReadLine();
                }

                if (sc_58029_Wybor != "1" && sc_58029_Wybor != "2" && sc_58029_Wybor != "3" && sc_58029_Wybor != "0" && sc_58029_Wybor == "4")
                {

                   
                    Console.Clear();
                    Console.WriteLine("Jeśli chcesz użyć kodu przypisanego indywidualnie do studenta, wpisz 1");
                    Console.WriteLine("Jeśli chcesz użyć kodu załączopnego na wykładzie, wpisz 2");
                    Console.WriteLine("Jeśli chcesz użyć własnego kodu, wpisz 3");
                    Console.WriteLine("O autorze, wpisz 4");
                    Console.WriteLine("Jeśli chcesz wyłączyć program, wpisz 0");

                   
                    sc_58029_Wybor = Console.ReadLine();

                }

                if (sc_58029_Wybor != "1" && sc_58029_Wybor != "2" && sc_58029_Wybor != "3" && sc_58029_Wybor != "0" && sc_58029_Wybor != "4")
                {

                    Console.Clear();
                    Console.WriteLine("Wprowadzono złą wartość, spróbuj ponownie.");
                    Console.WriteLine("Jeśli chcesz użyć kodu przypisanego indywidualnie do studenta, wpisz 1");
                    Console.WriteLine("Jeśli chcesz użyć kodu załączopnego na wykładzie wpisz 2");
                    Console.WriteLine("Jeśli chcesz użyć własnego kodu, wpisz 3");
                    Console.WriteLine("O autorze, wpisz 4");
                    Console.WriteLine("Jeśli chcesz wyłączyć program, wpisz 0");

                    
                    sc_58029_Wybor = Console.ReadLine();

                }

            }


            if (sc_58029_Wybor == "1")
            {

                Console.Clear();
                sc_58029_Source = sc_58029_KodIndywidualny;

            }
            else if (sc_58029_Wybor == "2")
            {

                Console.Clear();
                sc_58029_Source = sc_58029_KodWykl;

            }
            else if (sc_58029_Wybor == "3")
            {

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Wpisz swój własny ciąg:");
                    sc_58029_Source = Console.ReadLine();
                    if (sc_58029_Source.Length > 1)
                        break;
                }

            }

            else if (sc_58029_Wybor == "0")
                Environment.Exit(0);

            return sc_58029_Source;


        }
    }

    class Sc_58029_Usuwanie
    {

        int _sc_58029_Dlugosc;
        string _sc_58029_Roboczy;

        public string sc_58029_SetRoboczy
        {
            set { _sc_58029_Roboczy = value; }
        }
        public int sc_58029_SetDlugosc
        {
            set { _sc_58029_Dlugosc = value; }
        }


        public string Sc_58029_UsuwanieZnaku()

        {
            string sc_58029_Pozostaly;
            string sc_58029_Roboczy = _sc_58029_Roboczy;
            int sc_58029_Dlugosc = _sc_58029_Dlugosc;
            sc_58029_Pozostaly = sc_58029_Roboczy.Remove(0, sc_58029_Dlugosc);

            return sc_58029_Pozostaly;
        }
    }


    class Sc_58029_Pobieranie
    {

        int _sc_58029_Dlugosc;
        string _sc_58029_Roboczy;

        public string sc_58029_SetRoboczy
        {
            set { _sc_58029_Roboczy = value; }
        }
        public int sc_58029_SetDlugosc
        {
            set { _sc_58029_Dlugosc = value; }
        }

        public string Sc_58029_PobieranieZnaku()
        {
            int sc_58029_Dlugosc = _sc_58029_Dlugosc;
            string sc_58029_Znak;
            string roboczy = _sc_58029_Roboczy;
            sc_58029_Znak = roboczy.Substring(0, sc_58029_Dlugosc);

            return sc_58029_Znak;
        }
    }

    class Sc_58029_Dodanie
    {
        public List<string> _sc_58029_Dictionary;
        public List<string> _sc_58029_ResultCode;
        string _sc_58029_PierwszeSlowoKodowe;
        string _sc_58029_DrugieSlowoKodowe;
        int _sc_58029_IndexNb;
        string _sc_58029_Znak;
        string _sc_58029_Tymczasowy;

        public string sc_58029_SetPierwszeSlowoKodowe
        {
            set { _sc_58029_PierwszeSlowoKodowe = value; }
        }
        public string sc_58029_SetDrugieSlowoKodowe
        {
            set { _sc_58029_DrugieSlowoKodowe = value; }
        }
        public int sc_58029_SetIndexNb
        {
            set { _sc_58029_IndexNb = value; }
        }
        public string sc_58029_SetZnak
        {
            set { _sc_58029_Znak = value; }
        }
        public string sc_58029_SetTymczasowy
        {
            set { _sc_58029_Tymczasowy = value; }
        }


        public List<string> Sc_58029_DodanieWynikuInt()

        {
            int sc_58029_IndexNb = _sc_58029_IndexNb;
            _sc_58029_ResultCode.Add(sc_58029_IndexNb.ToString());

            return _sc_58029_ResultCode;
        }

        public List<string> Sc_58029_BudowaSlownika()
        {
            string sc_58029_Znak = _sc_58029_Znak;
            _sc_58029_Dictionary.Add(sc_58029_Znak);

            return _sc_58029_Dictionary;
        }


        public string Sc_58029_BudowaSlowaKodowego()
        {
            string sc_58029_PierwszeSlowoKodowe;
            string sc_58029_Tymczasowy = _sc_58029_Tymczasowy;
            sc_58029_PierwszeSlowoKodowe = _sc_58029_Dictionary[Convert.ToInt32(sc_58029_Tymczasowy) - 1];

            return sc_58029_PierwszeSlowoKodowe;
        }


        public string Sc_58029_DodanieSlowKodowych()
        {
            string sc_58029_Temp;
            string sc_58029_PierwszeSlowoKodowe = _sc_58029_PierwszeSlowoKodowe;
            string sc_58029_DrugieSlowoKodowe = _sc_58029_DrugieSlowoKodowe;
            sc_58029_Temp = sc_58029_PierwszeSlowoKodowe + sc_58029_DrugieSlowoKodowe.Substring(0, 1);

            return sc_58029_Temp;
        }


        public static void Sc_58029_DodanieIReset
            (
            ref string sc_58029_Tymczasowy,
            ref string sc_58029_Znak,
            ref string sc_58029_Pozostaly,
            ref string sc_58029_Roboczy
            )
        {
            sc_58029_Tymczasowy += sc_58029_Znak;
            sc_58029_Roboczy = sc_58029_Pozostaly;
        }
    }


    class Sc_58029_Indeks
    {

        List<string> _sc_58029_Dictionary;
        int _sc_58029_Dlugosc;
        string _sc_58029_Roboczy;
        string _sc_58029_Znak;

        public List<string> sc_58029_SetDictionary
        {
            set { _sc_58029_Dictionary = value; }
        }
        public int sc_58029_SetDlugosc
        {
            set { _sc_58029_Dlugosc = value; }
        }
        public string sc_58029_SetRoboczy
        {
            set { _sc_58029_Roboczy = value; }
        }
        public string sc_58029_SetZnak
        {
            set { _sc_58029_Znak = value; }
        }


        public int Sc_58029_PrzypisanieWartosci()

        {
            List<string> sc_58029_Dictionary = _sc_58029_Dictionary;
            string sc_58029_Znak = _sc_58029_Znak;
            int sc_58029_IndexNb;
            sc_58029_IndexNb = sc_58029_Dictionary.IndexOf(sc_58029_Znak) + 1;

            return sc_58029_IndexNb;
        }

        public int Sc_58029_PrzypisanieWartosciPlus()

        {
            List<string> sc_58029_Dictionary = _sc_58029_Dictionary;
            int sc_58029_Dlugosc = _sc_58029_Dlugosc;
            string sc_58029_Roboczy = _sc_58029_Roboczy;
            int sc_58029_IndexNb;
            sc_58029_IndexNb = sc_58029_Dictionary.IndexOf(sc_58029_Roboczy.Substring(0, sc_58029_Dlugosc - 1)) + 1;

            return sc_58029_IndexNb;
        }
    }
}
