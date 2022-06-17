using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string sc_58029_Source = "";
                sc_58029_Source = Sc_58029_CiagWejsciowy.sc_58029_WyborKodu();
                Console.Clear();
                Console.WriteLine("Wybrany ciąg:\n");
                Console.WriteLine(sc_58029_Source);
                Console.WriteLine("\n-------------------------------------");


                List<string> sc_58029_Dictionary = new List<string>();
                List<string> sc_58029_Code = new List<string>();

 
                Sc_58029_KompresjaLZW(sc_58029_Source, ref sc_58029_Dictionary, ref sc_58029_Code);

                Console.WriteLine("\nWynik kompresji:");
                Console.WriteLine(string.Join(", ", sc_58029_Code) + ", EOF\n");
                Console.WriteLine("-------------------------------------\n");

                List<string> sc_58029_Dekompresja = new List<string>();
                List<string> doRaportu = new List<string>();
                Sc_58029_DekompresjaLZW(string.Join(" ", sc_58029_Code), sc_58029_Dictionary, ref sc_58029_Dekompresja, ref doRaportu);
                Console.WriteLine("Wynik dekompresji:");
                doRaportu.ForEach(Console.Write);
                sc_58029_Dekompresja.ForEach(Console.Write);

                Console.WriteLine("\n");
                Console.WriteLine("-------------------------------------\n");
                Console.WriteLine("Aby ponownie wyświetlić MENU wciśnij ENTER");
                Console.ReadLine();
                Console.Clear();


            }
        }
        public static void Sc_58029_KompresjaLZW(string sc_58029_Source, ref List<string> sc_58029_Dictionary, ref List<string> sc_58029_ResultCode)
        {
            string sc_58029_Znak = "";
            string sc_58029_Roboczy = "";
            string sc_58029_Pozostaly = "";


            sc_58029_Pozostaly = sc_58029_Source;
            do
            {
                sc_58029_Roboczy = sc_58029_Pozostaly;

                Sc_58029_Pobieranie Sc_58029_Znak = new Sc_58029_Pobieranie
                {
                    sc_58029_SetRoboczy = sc_58029_Roboczy,
                    sc_58029_SetDlugosc = 1
                };
                sc_58029_Znak = Sc_58029_Znak.Sc_58029_PobieranieZnaku();

                if (!sc_58029_Dictionary.Contains(sc_58029_Znak))
                {

                    Sc_58029_Dodanie Sc_58029_BudowaS = new Sc_58029_Dodanie
                    {
                        _sc_58029_Dictionary = sc_58029_Dictionary,
                        sc_58029_SetZnak = sc_58029_Znak
                    };
                    sc_58029_Dictionary = Sc_58029_BudowaS.Sc_58029_BudowaSlownika();
                }


                Sc_58029_Usuwanie Sc_58029_Usun = new Sc_58029_Usuwanie
                {
                    sc_58029_SetRoboczy = sc_58029_Roboczy,
                    sc_58029_SetDlugosc = 1
                };
                sc_58029_Pozostaly = Sc_58029_Usun.Sc_58029_UsuwanieZnaku();


            }
            while (sc_58029_Pozostaly.Length > 0);

            sc_58029_Pozostaly = sc_58029_Source;

            sc_58029_Pozostaly = sc_58029_Source;
            int sc_58029_SequenceLength = 1;
            int sc_58029_IndexNb = 0;
            do
            {
                sc_58029_Roboczy = sc_58029_Pozostaly;
                if (sc_58029_SequenceLength <= sc_58029_Roboczy.Length)
                {

                    Sc_58029_Pobieranie Sc_58029_Znak = new Sc_58029_Pobieranie
                    {
                        sc_58029_SetRoboczy = sc_58029_Roboczy,
                        sc_58029_SetDlugosc = sc_58029_SequenceLength
                    };
                    sc_58029_Znak = Sc_58029_Znak.Sc_58029_PobieranieZnaku();

                    if (sc_58029_Dictionary.Contains(sc_58029_Znak))
                    {
                        sc_58029_SequenceLength++;
                    }
                    else
                    {
                        Sc_58029_Indeks Sc_58029_WarPlu = new Sc_58029_Indeks
                        {
                            sc_58029_SetDictionary = sc_58029_Dictionary,
                            sc_58029_SetRoboczy = sc_58029_Roboczy,
                            sc_58029_SetDlugosc = sc_58029_SequenceLength
                        };
                        sc_58029_IndexNb = Sc_58029_WarPlu.Sc_58029_PrzypisanieWartosciPlus();

                        Sc_58029_Dodanie Sc_58029_Wynik = new Sc_58029_Dodanie
                        {
                            _sc_58029_ResultCode = sc_58029_ResultCode,
                            sc_58029_SetIndexNb = sc_58029_IndexNb
                        };
                        sc_58029_ResultCode = Sc_58029_Wynik.Sc_58029_DodanieWynikuInt();


                        Sc_58029_Dodanie Sc_58029_BudowaS = new Sc_58029_Dodanie
                        {
                            _sc_58029_Dictionary = sc_58029_Dictionary,
                            sc_58029_SetZnak = sc_58029_Znak
                        };
                        sc_58029_Dictionary = Sc_58029_BudowaS.Sc_58029_BudowaSlownika();


                        Sc_58029_Usuwanie Sc_58029_Usun = new Sc_58029_Usuwanie
                        {
                            sc_58029_SetRoboczy = sc_58029_Roboczy,
                            sc_58029_SetDlugosc = sc_58029_SequenceLength - 1
                        };
                        sc_58029_Pozostaly = Sc_58029_Usun.Sc_58029_UsuwanieZnaku();
                        sc_58029_SequenceLength = 1;
                    }
                }
                else
                {


                    Sc_58029_Pobieranie Sc_58029_Znak = new Sc_58029_Pobieranie
                    {
                        sc_58029_SetRoboczy = sc_58029_Roboczy,
                        sc_58029_SetDlugosc = 1
                    };
                    sc_58029_Znak = Sc_58029_Znak.Sc_58029_PobieranieZnaku();

                    if (sc_58029_Dictionary.Contains(sc_58029_Znak))
                    {


                        Sc_58029_Indeks Sc_58029_Wart = new Sc_58029_Indeks
                        {
                            sc_58029_SetDictionary = sc_58029_Dictionary,
                            sc_58029_SetZnak = sc_58029_Znak
                        };
                        sc_58029_IndexNb = Sc_58029_Wart.Sc_58029_PrzypisanieWartosci();


                        Sc_58029_Dodanie Sc_58029_Wynik = new Sc_58029_Dodanie
                        {
                            _sc_58029_ResultCode = sc_58029_ResultCode,
                            sc_58029_SetIndexNb = sc_58029_IndexNb
                        };
                        sc_58029_ResultCode = Sc_58029_Wynik.Sc_58029_DodanieWynikuInt();


                        Sc_58029_Usuwanie Sc_58029_Usun = new Sc_58029_Usuwanie
                        {
                            sc_58029_SetRoboczy = sc_58029_Roboczy,
                            sc_58029_SetDlugosc = 1
                        };
                        sc_58029_Pozostaly = Sc_58029_Usun.Sc_58029_UsuwanieZnaku();
                    }
                    else
                    {

                        Sc_58029_Dodanie Sc_58029_BudowaS = new Sc_58029_Dodanie
                        {
                            _sc_58029_Dictionary = sc_58029_Dictionary,
                            sc_58029_SetZnak = sc_58029_Znak
                        };
                        sc_58029_Dictionary = Sc_58029_BudowaS.Sc_58029_BudowaSlownika();


                        Sc_58029_Indeks Sc_58029_WarPlu = new Sc_58029_Indeks
                        {
                            sc_58029_SetDictionary = sc_58029_Dictionary,
                            sc_58029_SetRoboczy = sc_58029_Roboczy,
                            sc_58029_SetDlugosc = sc_58029_SequenceLength
                        };
                        sc_58029_IndexNb = Sc_58029_WarPlu.Sc_58029_PrzypisanieWartosciPlus();


                        Sc_58029_Dodanie Sc_58029_Wynik = new Sc_58029_Dodanie
                        {
                            _sc_58029_ResultCode = sc_58029_ResultCode,
                            sc_58029_SetIndexNb = sc_58029_IndexNb
                        };
                        sc_58029_ResultCode = Sc_58029_Wynik.Sc_58029_DodanieWynikuInt();


                        Sc_58029_Usuwanie Sc_58029_Usun = new Sc_58029_Usuwanie
                        {
                            sc_58029_SetRoboczy = sc_58029_Roboczy,
                            sc_58029_SetDlugosc = 1
                        };
                        sc_58029_Pozostaly = Sc_58029_Usun.Sc_58029_UsuwanieZnaku();
                    }
                }
            }
            while (sc_58029_Pozostaly.Length > 0);
        }
        public static void Sc_58029_DekompresjaLZW(string sc_58029_Source, List<string> sc_58029_Dictionary, ref List<string> sc_58029_ResultCode, ref List<string> sc_58029_DoRaportu)
        {

            string sc_58029_Znak = "";
            string sc_58029_PierwszeSlowoKodowe = "";
            string sc_58029_DrugieSlowoKodowe = "";
            string sc_58029_Roboczy = "";
            string sc_58029_Pozostaly = "";
            string sc_58029_Tymczasowy = "";
            string sc_58029_CodeTemp = "";


            sc_58029_Pozostaly = sc_58029_Source;
            sc_58029_Roboczy = sc_58029_Pozostaly;
            do
            {
                if (sc_58029_PierwszeSlowoKodowe == "")
                {
                    do
                    {
   
                        Sc_58029_Pobieranie Sc_58029_Znak = new Sc_58029_Pobieranie
                        {
                            sc_58029_SetRoboczy = sc_58029_Roboczy,
                            sc_58029_SetDlugosc = 1
                        };
                        sc_58029_Znak = Sc_58029_Znak.Sc_58029_PobieranieZnaku();

                        if (!Char.IsDigit(sc_58029_Znak[0]))
                        {
   
                            Sc_58029_Usuwanie Sc_58029_Usun = new Sc_58029_Usuwanie
                            {
                                sc_58029_SetRoboczy = sc_58029_Roboczy,
                                sc_58029_SetDlugosc = 1
                            };
                            sc_58029_Pozostaly = Sc_58029_Usun.Sc_58029_UsuwanieZnaku();

                            sc_58029_Roboczy = sc_58029_Pozostaly;
                        }
                    }
                    while (!Char.IsDigit(sc_58029_Znak[0]));
                    do
                    {
       
                        Sc_58029_Pobieranie Sc_58029_Znak = new Sc_58029_Pobieranie
                        {
                            sc_58029_SetRoboczy = sc_58029_Roboczy,
                            sc_58029_SetDlugosc = 1
                        };
                        sc_58029_Znak = Sc_58029_Znak.Sc_58029_PobieranieZnaku();

                        if (Char.IsDigit(sc_58029_Znak[0]))
                        {
  
                            Sc_58029_Usuwanie Sc_58029_Usun = new Sc_58029_Usuwanie
                            {
                                sc_58029_SetRoboczy = sc_58029_Roboczy,
                                sc_58029_SetDlugosc = 1
                            };
                            sc_58029_Pozostaly = Sc_58029_Usun.Sc_58029_UsuwanieZnaku();

                            Sc_58029_Dodanie.Sc_58029_DodanieIReset(ref sc_58029_Tymczasowy, ref sc_58029_Znak, ref sc_58029_Pozostaly, ref sc_58029_Roboczy);
                        }
                    }
                    while (Char.IsDigit(sc_58029_Znak[0]));

                    Sc_58029_Dodanie Sc_58029_Budowa = new Sc_58029_Dodanie
                    {
                        _sc_58029_Dictionary = sc_58029_Dictionary,
                        sc_58029_SetTymczasowy = sc_58029_Tymczasowy
                    };
                    sc_58029_PierwszeSlowoKodowe = Sc_58029_Budowa.Sc_58029_BudowaSlowaKodowego();
                    sc_58029_Tymczasowy = "";
                }
                do
                {

                    Sc_58029_Pobieranie Sc_58029_Znak = new Sc_58029_Pobieranie
                    {
                        sc_58029_SetRoboczy = sc_58029_Roboczy,
                        sc_58029_SetDlugosc = 1
                    };
                    sc_58029_Znak = Sc_58029_Znak.Sc_58029_PobieranieZnaku();

                    if (!Char.IsDigit(sc_58029_Znak[0]))
                    {


                        Sc_58029_Usuwanie Sc_58029_Usun = new Sc_58029_Usuwanie
                        {
                            sc_58029_SetRoboczy = sc_58029_Roboczy,
                            sc_58029_SetDlugosc = 1
                        };
                        sc_58029_Pozostaly = Sc_58029_Usun.Sc_58029_UsuwanieZnaku();
                        sc_58029_Roboczy = sc_58029_Pozostaly;
                    }
                }
                while (!Char.IsDigit(sc_58029_Znak[0]));
                do
                {
 
                    Sc_58029_Pobieranie Sc_58029_Znak = new Sc_58029_Pobieranie
                    {
                        sc_58029_SetRoboczy = sc_58029_Roboczy,
                        sc_58029_SetDlugosc = 1
                    };
                    sc_58029_Znak = Sc_58029_Znak.Sc_58029_PobieranieZnaku();

                    if (Char.IsDigit(sc_58029_Znak[0]))
                    {

                        Sc_58029_Usuwanie Sc_58029_Usun = new Sc_58029_Usuwanie
                        {
                            sc_58029_SetRoboczy = sc_58029_Roboczy,
                            sc_58029_SetDlugosc = 1
                        };
                        sc_58029_Pozostaly = Sc_58029_Usun.Sc_58029_UsuwanieZnaku();


                        Sc_58029_Dodanie.Sc_58029_DodanieIReset(ref sc_58029_Tymczasowy, ref sc_58029_Znak, ref sc_58029_Pozostaly, ref sc_58029_Roboczy);
                    }
                }
                while (Char.IsDigit(sc_58029_Znak[0]) && sc_58029_Roboczy.Length > 0);
                try
                {

                    Sc_58029_Dodanie Sc_58029_Budowa = new Sc_58029_Dodanie
                    {
                        _sc_58029_Dictionary = sc_58029_Dictionary,
                        sc_58029_SetTymczasowy = sc_58029_Tymczasowy
                    };
                    sc_58029_DrugieSlowoKodowe = Sc_58029_Budowa.Sc_58029_BudowaSlowaKodowego();

                    sc_58029_Tymczasowy = "";
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    sc_58029_DoRaportu.Add("> Argument Of Range Exception - " + sc_58029_Tymczasowy + ", ");
                    sc_58029_DrugieSlowoKodowe = sc_58029_PierwszeSlowoKodowe;
                    sc_58029_CodeTemp = sc_58029_Roboczy;
                    sc_58029_Tymczasowy = "";
                    do
                    {
                   
                        Sc_58029_Pobieranie Sc_58029_Znak2 = new Sc_58029_Pobieranie
                        {
                            sc_58029_SetRoboczy = sc_58029_Roboczy,
                            sc_58029_SetDlugosc = 1
                        };
                        sc_58029_Znak = Sc_58029_Znak2.Sc_58029_PobieranieZnaku();

                        if (!Char.IsDigit(sc_58029_Znak[0]))
                        {
                            
                            Sc_58029_Usuwanie Sc_58029_Usun = new Sc_58029_Usuwanie
                            {
                                sc_58029_SetRoboczy = sc_58029_Roboczy,
                                sc_58029_SetDlugosc = 1
                            };
                            sc_58029_Pozostaly = Sc_58029_Usun.Sc_58029_UsuwanieZnaku();

                            sc_58029_Roboczy = sc_58029_Pozostaly;
                        }
                    }
                    while (!Char.IsDigit(sc_58029_Znak[0]));
                    do
                    {
                    
                        Sc_58029_Pobieranie Sc_58029_Znak2 = new Sc_58029_Pobieranie
                        {
                            sc_58029_SetRoboczy = sc_58029_Roboczy,
                            sc_58029_SetDlugosc = 1
                        };
                        sc_58029_Znak = Sc_58029_Znak2.Sc_58029_PobieranieZnaku();

                        if (Char.IsDigit(sc_58029_Znak[0]))
                        {
                           
                            Sc_58029_Usuwanie Sc_58029_Usun = new Sc_58029_Usuwanie
                            {
                                sc_58029_SetRoboczy = sc_58029_Roboczy,
                                sc_58029_SetDlugosc = 1
                            };
                            sc_58029_Pozostaly = Sc_58029_Usun.Sc_58029_UsuwanieZnaku();

                    
                            Sc_58029_Dodanie.Sc_58029_DodanieIReset(ref sc_58029_Tymczasowy, ref sc_58029_Znak, ref sc_58029_Pozostaly, ref sc_58029_Roboczy);
                        }
                    }
                    while (Char.IsDigit(sc_58029_Znak[0]));

                    sc_58029_Znak = sc_58029_Dictionary[Convert.ToInt32(sc_58029_Tymczasowy)];

                  
                    Sc_58029_Pobieranie Sc_58029_Znak = new Sc_58029_Pobieranie
                    {
                        sc_58029_SetRoboczy = sc_58029_Roboczy,
                        sc_58029_SetDlugosc = 1
                    };
                    sc_58029_Znak = Sc_58029_Znak.Sc_58029_PobieranieZnaku();



                  
                    Sc_58029_Dodanie.Sc_58029_DodanieIReset(ref sc_58029_DrugieSlowoKodowe, ref sc_58029_Tymczasowy, ref sc_58029_CodeTemp, ref sc_58029_Roboczy);

                }
                Sc_58029_Dodanie Sc_58029_Slowo = new Sc_58029_Dodanie
                {
                    sc_58029_SetDrugieSlowoKodowe = sc_58029_DrugieSlowoKodowe,
                    sc_58029_SetPierwszeSlowoKodowe = sc_58029_PierwszeSlowoKodowe
                };
                string temp = Sc_58029_Slowo.Sc_58029_DodanieSlowKodowych();

                if (!sc_58029_Dictionary.Contains(temp))
                {
                    sc_58029_Dictionary.Add(temp);
                }


                Sc_58029_Dodanie Sc_58029_BudowaWyniku = new Sc_58029_Dodanie
                {
                    _sc_58029_Dictionary = sc_58029_ResultCode,
                    sc_58029_SetZnak = sc_58029_PierwszeSlowoKodowe
                };
                sc_58029_ResultCode = Sc_58029_BudowaWyniku.Sc_58029_BudowaSlownika();

                if (sc_58029_Tymczasowy.Length > 0)
                {
                    sc_58029_Tymczasowy = temp; 
                    sc_58029_PierwszeSlowoKodowe = sc_58029_Tymczasowy;
                    sc_58029_Roboczy = sc_58029_CodeTemp;
                    sc_58029_Tymczasowy = "";
                }
                else
                {
                    sc_58029_PierwszeSlowoKodowe = sc_58029_DrugieSlowoKodowe;
                    sc_58029_Roboczy = sc_58029_Pozostaly;
                }
                sc_58029_DrugieSlowoKodowe = "";
            }
            while (sc_58029_Pozostaly.Length > 0);

            Sc_58029_Dodanie Sc_58029_BudowaWyniku2 = new Sc_58029_Dodanie
            {
                _sc_58029_Dictionary = sc_58029_ResultCode,
                sc_58029_SetZnak = sc_58029_PierwszeSlowoKodowe
            };
            sc_58029_ResultCode = Sc_58029_BudowaWyniku2.Sc_58029_BudowaSlownika();
        }
    }
}
