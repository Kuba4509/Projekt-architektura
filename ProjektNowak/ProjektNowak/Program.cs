using System;
using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Projekt
{
    internal class Program
    {
        public class Zmienne
        {
            public static string AL, AH, BL, BH, CL, CH, DL, DH;
        }
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu)
            {
                Console.Clear();
                Console.WriteLine("Jaką operację chcesz wykonać?");
                Console.WriteLine("1.Wpisywanie wartości");
                Console.WriteLine("2.Wyświetlanie wartości");
                Console.WriteLine("3.Zamiana zawartości rejestru");
                Console.WriteLine("4.Zamiana zawartości rejestrów między sobą");
                Console.WriteLine("5.Odejmowanie DEC");
                Console.WriteLine("6.Inwersja NOT");
                Console.WriteLine("7.Dodawanie INC");
                Console.WriteLine("Wybrana opcja: ");
                string x = Console.ReadLine();
                switch (x)
                {
                    case "1":
                        wpisywanie();
                        break;
                    case "2":
                        wyswietlanie();
                        break;
                    case "3":
                        zamianazaw();
                        break;
                    case "4":
                        miedzysoba();
                        break;
                    case "5":
                        odejmowanie();
                        break;
                    case "6":
                        inwersja();
                        break;
                    case "7":
                        dodawanie();
                        break;
                }
            }
        }
        public static void wpisywanie()//wprowadzanie zawartości rejestrów
        {
            Console.Clear();
            char znak1, znak2;
            while (true)
            {
                Console.Write("Podaj zawartość rejestru AL: ");
                Zmienne.AL = Console.ReadLine();
                if (Zmienne.AL.Length == 2)
                {
                    znak1 = Zmienne.AL[0];
                    znak2 = Zmienne.AL[1];
                    if (znak1 == '0' || znak1 == '1' || znak1 == '2' || znak1 == '3' || znak1 == '4' || znak1 == '5' || znak1 == '6' || znak1 == '7' || znak1 == '8' || znak1 == '9' || znak1 == 'A' || znak1 == 'B' || znak1 == 'C' || znak1 == 'D' || znak1 == 'E' || znak1 == 'F')
                    {
                        if (znak2 == '0' || znak2 == '1' || znak2 == '2' || znak2 == '3' || znak2 == '4' || znak2 == '5' || znak2 == '6' || znak2 == '7' || znak2 == '8' || znak2 == '9' || znak2 == 'A' || znak2 == 'B' || znak2 == 'C' || znak2 == 'D' || znak2 == 'E' || znak2 == 'F')
                        {
                            break;
                        }
                    }
                    else Console.WriteLine("Źle wprowadzona wartość");
                }
                else Console.WriteLine("Źle wprowadzona wartość");
            }
            while (true)
            {
                Console.Write("Podaj zawartość rejestru AH: ");
                Zmienne.AH = Console.ReadLine();
                if (Zmienne.AH.Length == 2)
                {
                    znak1 = Zmienne.AH[0];
                    znak2 = Zmienne.AH[1];
                    if (znak1 == '0' || znak1 == '1' || znak1 == '2' || znak1 == '3' || znak1 == '4' || znak1 == '5' || znak1 == '6' || znak1 == '7' || znak1 == '8' || znak1 == '9' || znak1 == 'A' || znak1 == 'B' || znak1 == 'C' || znak1 == 'D' || znak1 == 'E' || znak1 == 'F')
                    {
                        if (znak2 == '0' || znak2 == '1' || znak2 == '2' || znak2 == '3' || znak2 == '4' || znak2 == '5' || znak2 == '6' || znak2 == '7' || znak2 == '8' || znak2 == '9' || znak2 == 'A' || znak2 == 'B' || znak2 == 'C' || znak2 == 'D' || znak2 == 'E' || znak2 == 'F')
                        {
                            break;
                        }
                    }
                    else Console.WriteLine("Źle wprowadzona wartość");
                }
                else Console.WriteLine("Źle wprowadzona wartość");
            }
            while (true)
            {
                Console.Write("Podaj zawartość rejestru BL: ");
                Zmienne.BL = Console.ReadLine();
                if (Zmienne.BL.Length == 2)
                {
                    znak1 = Zmienne.BL[0];
                    znak2 = Zmienne.BL[1];
                    if (znak1 == '0' || znak1 == '1' || znak1 == '2' || znak1 == '3' || znak1 == '4' || znak1 == '5' || znak1 == '6' || znak1 == '7' || znak1 == '8' || znak1 == '9' || znak1 == 'A' || znak1 == 'B' || znak1 == 'C' || znak1 == 'D' || znak1 == 'E' || znak1 == 'F')
                    {
                        if (znak2 == '0' || znak2 == '1' || znak2 == '2' || znak2 == '3' || znak2 == '4' || znak2 == '5' || znak2 == '6' || znak2 == '7' || znak2 == '8' || znak2 == '9' || znak2 == 'A' || znak2 == 'B' || znak2 == 'C' || znak2 == 'D' || znak2 == 'E' || znak2 == 'F')
                        {
                            break;
                        }
                    }
                    else Console.WriteLine("Źle wprowadzona wartość");
                }
                else Console.WriteLine("Źle wprowadzona wartość");
            }
            while (true)
            {
                Console.Write("Podaj zawartość rejestru BH: ");
                Zmienne.BH = Console.ReadLine();
                if (Zmienne.BH.Length == 2)
                {
                    znak1 = Zmienne.BH[0];
                    znak2 = Zmienne.BH[1];
                    if (znak1 == '0' || znak1 == '1' || znak1 == '2' || znak1 == '3' || znak1 == '4' || znak1 == '5' || znak1 == '6' || znak1 == '7' || znak1 == '8' || znak1 == '9' || znak1 == 'A' || znak1 == 'B' || znak1 == 'C' || znak1 == 'D' || znak1 == 'E' || znak1 == 'F')
                    {
                        if (znak2 == '0' || znak2 == '1' || znak2 == '2' || znak2 == '3' || znak2 == '4' || znak2 == '5' || znak2 == '6' || znak2 == '7' || znak2 == '8' || znak2 == '9' || znak2 == 'A' || znak2 == 'B' || znak2 == 'C' || znak2 == 'D' || znak2 == 'E' || znak2 == 'F')
                        {
                            break;
                        }
                    }
                    else Console.WriteLine("Źle wprowadzona wartość");
                }
                else Console.WriteLine("Źle wprowadzona wartość");
            }
            while (true)
            {
                Console.Write("Podaj zawartość rejestru CL: ");
                Zmienne.CL = Console.ReadLine();
                if (Zmienne.CL.Length == 2)
                {
                    znak1 = Zmienne.CL[0];
                    znak2 = Zmienne.CL[1];
                    if (znak1 == '0' || znak1 == '1' || znak1 == '2' || znak1 == '3' || znak1 == '4' || znak1 == '5' || znak1 == '6' || znak1 == '7' || znak1 == '8' || znak1 == '9' || znak1 == 'A' || znak1 == 'B' || znak1 == 'C' || znak1 == 'D' || znak1 == 'E' || znak1 == 'F')
                    {
                        if (znak2 == '0' || znak2 == '1' || znak2 == '2' || znak2 == '3' || znak2 == '4' || znak2 == '5' || znak2 == '6' || znak2 == '7' || znak2 == '8' || znak2 == '9' || znak2 == 'A' || znak2 == 'B' || znak2 == 'C' || znak2 == 'D' || znak2 == 'E' || znak2 == 'F')
                        {
                            break;
                        }
                    }
                    else Console.WriteLine("Źle wprowadzona wartość");
                }
                else Console.WriteLine("Źle wprowadzona wartość");
            }
            while (true)
            {
                Console.Write("Podaj zawartość rejestru CH: ");
                Zmienne.CH = Console.ReadLine();
                if (Zmienne.CH.Length == 2)
                {
                    znak1 = Zmienne.CH[0];
                    znak2 = Zmienne.CH[1];
                    if (znak1 == '0' || znak1 == '1' || znak1 == '2' || znak1 == '3' || znak1 == '4' || znak1 == '5' || znak1 == '6' || znak1 == '7' || znak1 == '8' || znak1 == '9' || znak1 == 'A' || znak1 == 'B' || znak1 == 'C' || znak1 == 'D' || znak1 == 'E' || znak1 == 'F')
                    {
                        if (znak2 == '0' || znak2 == '1' || znak2 == '2' || znak2 == '3' || znak2 == '4' || znak2 == '5' || znak2 == '6' || znak2 == '7' || znak2 == '8' || znak2 == '9' || znak2 == 'A' || znak2 == 'B' || znak2 == 'C' || znak2 == 'D' || znak2 == 'E' || znak2 == 'F')
                        {
                            break;
                        }
                    }
                    else Console.WriteLine("Źle wprowadzona wartość");
                }
                else Console.WriteLine("Źle wprowadzona wartość");
            }
            while (true)
            {
                Console.Write("Podaj zawartość rejestru DL: ");
                Zmienne.DL = Console.ReadLine();
                if (Zmienne.DL.Length == 2)
                {
                    znak1 = Zmienne.DL[0];
                    znak2 = Zmienne.DL[1];
                    if (znak1 == '0' || znak1 == '1' || znak1 == '2' || znak1 == '3' || znak1 == '4' || znak1 == '5' || znak1 == '6' || znak1 == '7' || znak1 == '8' || znak1 == '9' || znak1 == 'A' || znak1 == 'B' || znak1 == 'C' || znak1 == 'D' || znak1 == 'E' || znak1 == 'F')
                    {
                        if (znak2 == '0' || znak2 == '1' || znak2 == '2' || znak2 == '3' || znak2 == '4' || znak2 == '5' || znak2 == '6' || znak2 == '7' || znak2 == '8' || znak2 == '9' || znak2 == 'A' || znak2 == 'B' || znak2 == 'C' || znak2 == 'D' || znak2 == 'E' || znak2 == 'F')
                        {
                            break;
                        }
                    }
                    else Console.WriteLine("Źle wprowadzona wartość");
                }
                else Console.WriteLine("Źle wprowadzona wartość");
            }
            while (true)
            {
                Console.Write("Podaj zawartość rejestru DH: ");
                Zmienne.DH = Console.ReadLine();
                if (Zmienne.DH.Length == 2)
                {
                    znak1 = Zmienne.DH[0];
                    znak2 = Zmienne.DH[1];
                    if (znak1 == '0' || znak1 == '1' || znak1 == '2' || znak1 == '3' || znak1 == '4' || znak1 == '5' || znak1 == '6' || znak1 == '7' || znak1 == '8' || znak1 == '9' || znak1 == 'A' || znak1 == 'B' || znak1 == 'C' || znak1 == 'D' || znak1 == 'E' || znak1 == 'F')
                    {
                        if (znak2 == '0' || znak2 == '1' || znak2 == '2' || znak2 == '3' || znak2 == '4' || znak2 == '5' || znak2 == '6' || znak2 == '7' || znak2 == '8' || znak2 == '9' || znak2 == 'A' || znak2 == 'B' || znak2 == 'C' || znak2 == 'D' || znak2 == 'E' || znak2 == 'F')
                        {
                            break;
                        }
                    }
                    else Console.WriteLine("Źle wprowadzona wartość");
                }
                else Console.WriteLine("Źle wprowadzona wartość");
            }
        }
        static void wyswietlanie()//wyświetlanie zawartości rejestrów
        {
            Console.Clear();
            Console.WriteLine("Zmienna AL: " + Zmienne.AL);
            Console.WriteLine("Zmienna AH: " + Zmienne.AH);
            Console.WriteLine("Zmienna BL: " + Zmienne.BL);
            Console.WriteLine("Zmienna BH: " + Zmienne.BH);
            Console.WriteLine("Zmienna CL: " + Zmienne.CL);
            Console.WriteLine("Zmienna CH: " + Zmienne.CH);
            Console.WriteLine("Zmienna DL: " + Zmienne.DL);
            Console.WriteLine("Zmienna DH: " + Zmienne.DH);
            Console.ReadLine();
        }
        static void zamianazaw()//zamiana wartości rejestru
        {
            Console.Clear();
            Console.WriteLine("Którego rejestru zawartość chcesz zmienić (wpisz dużymi literami)?");
            Console.WriteLine("1.AL");
            Console.WriteLine("2.AH");
            Console.WriteLine("3.BL");
            Console.WriteLine("4.BH");
            Console.WriteLine("5.CL");
            Console.WriteLine("6.CH");
            Console.WriteLine("7.DL");
            Console.WriteLine("8.DH");
            string zamieniony = Console.ReadLine();

            Console.WriteLine("Na jaką wartość chcesz zamienić?");
            string nowa = Console.ReadLine();
            if (zamieniony == "AL" && nowa.Length == 2)
            {
                Zmienne.AL = nowa;
                Console.WriteLine("Nowa zawartość rejestru AL: " + nowa);
            }
            else if (zamieniony == "AH" && nowa.Length == 2)
            {
                Zmienne.AH = nowa;
                Console.WriteLine("Nowa zawartość rejestru AH: " + nowa);
            }
            else if (zamieniony == "BL" && nowa.Length == 2)
            {
                Zmienne.BL = nowa;
                Console.WriteLine("Nowa zawartość rejestru BL: " + nowa);
            }
            else if (zamieniony == "BH" && nowa.Length == 2)
            {
                Zmienne.BH = nowa;
                Console.WriteLine("Nowa zawartość rejestru BH: " + nowa);
            }
            else if (zamieniony == "CL" && nowa.Length == 2)
            {
                Zmienne.CL = nowa;
                Console.WriteLine("Nowa zawartość rejestru CL: " + nowa);
            }
            else if (zamieniony == "CH" && nowa.Length == 2)
            {
                Zmienne.CH = nowa;
                Console.WriteLine("Nowa zawartość rejestru CH: " + nowa);
            }
            else if (zamieniony == "DL" && nowa.Length == 2)
            {
                Zmienne.DL = nowa;
                Console.WriteLine("Nowa zawartość rejestru DL: " + nowa);
            }
            else if (zamieniony == "DH" && nowa.Length == 2)
            {
                Zmienne.DH = nowa;
                Console.WriteLine("Nowa zawartość rejestru DH: " + nowa);
            }
            else { Console.WriteLine("Błędne dane!"); }
        }
        static void miedzysoba() //zamiana wartości rejestrów między sobą
        {
            Console.Clear();
            Console.WriteLine("Zawartość którego rejestru chcesz zamienić?: ");
            Console.WriteLine("1.AL");
            Console.WriteLine("2.AH");
            Console.WriteLine("3.BL");
            Console.WriteLine("4.BH");
            Console.WriteLine("5.CL");
            Console.WriteLine("6.CH");
            Console.WriteLine("7.DL");
            Console.WriteLine("8.DH");
            string rejestr = Console.ReadLine();
            string rejestr2;
            Console.Clear();
            switch (rejestr)
            {
                case "1":
                    Console.WriteLine("Na który rejestr chcesz zamienić");
                    Console.WriteLine("1.AL");
                    Console.WriteLine("2.AH");
                    Console.WriteLine("3.BL");
                    Console.WriteLine("4.BH");
                    Console.WriteLine("5.CL");
                    Console.WriteLine("6.CH");
                    Console.WriteLine("7.DL");
                    Console.WriteLine("8.DH");
                    rejestr2 = Console.ReadLine();
                    switch (rejestr2)
                    {
                        case "1":
                            Zmienne.AL = Zmienne.AL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "2":
                            Zmienne.AL = Zmienne.AH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "3":
                            Zmienne.AL = Zmienne.BL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "4":
                            Zmienne.AL = Zmienne.BH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "5":
                            Zmienne.AL = Zmienne.CL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "6":
                            Zmienne.AL = Zmienne.CH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "7":
                            Zmienne.AL = Zmienne.DL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "8":
                            Zmienne.AL = Zmienne.DH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        default:
                            Console.WriteLine("Nie ma takiej opcji");
                            break;
                    }
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Na który rejestr chcesz zamienić");
                    Console.WriteLine("1.AL");
                    Console.WriteLine("2.AH");
                    Console.WriteLine("3.BL");
                    Console.WriteLine("4.BH");
                    Console.WriteLine("5.CL");
                    Console.WriteLine("6.CH");
                    Console.WriteLine("7.DL");
                    Console.WriteLine("8.DH");
                    rejestr2 = Console.ReadLine();
                    switch (rejestr2)
                    {
                        case "1":
                            Zmienne.AH = Zmienne.AL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "2":
                            Zmienne.AH = Zmienne.AH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "3":
                            Zmienne.AH = Zmienne.BL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "4":
                            Zmienne.AH = Zmienne.BH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "5":
                            Zmienne.AH = Zmienne.CL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "6":
                            Zmienne.AH = Zmienne.CH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "7":
                            Zmienne.AH = Zmienne.DL;
                            Console.WriteLine("Zamieniłem"); ;
                            break;
                        case "8":
                            Zmienne.AH = Zmienne.DH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        default:
                            Console.WriteLine("Nie ma takiej opcji");
                            break;
                    }
                    Console.WriteLine("Naciśnij dowolny klawisz aby kontynuować...");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Na który rejestr chcesz zamienić");
                    Console.WriteLine("1.AL");
                    Console.WriteLine("2.AH");
                    Console.WriteLine("3.BL");
                    Console.WriteLine("4.BH");
                    Console.WriteLine("5.CL");
                    Console.WriteLine("6.CH");
                    Console.WriteLine("7.DL");
                    Console.WriteLine("8.DH");
                    rejestr2 = Console.ReadLine();
                    switch (rejestr2)
                    {
                        case "1":
                            Zmienne.BL = Zmienne.AL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "2":
                            Zmienne.BL = Zmienne.AH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "3":
                            Zmienne.BL = Zmienne.BL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "4":
                            Zmienne.BL = Zmienne.BH;
                            Console.WriteLine("Akcja pomyślna!");
                            break;
                        case "5":
                            Zmienne.BL = Zmienne.CL;
                            Console.WriteLine("Akcja pomyślna!");
                            break;
                        case "6":
                            Zmienne.BL = Zmienne.CH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "7":
                            Zmienne.BL = Zmienne.DL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "8":
                            Zmienne.BL = Zmienne.DH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        default:
                            Console.WriteLine("Nie ma takiej opcji");
                            break;
                    }
                    Console.WriteLine("Naciśnij dowolny klawisz aby kontynuować...");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Na który rejestr chcesz zamienić");
                    Console.WriteLine("1.AL");
                    Console.WriteLine("2.AH");
                    Console.WriteLine("3.BL");
                    Console.WriteLine("4.BH");
                    Console.WriteLine("5.CL");
                    Console.WriteLine("6.CH");
                    Console.WriteLine("7.DL");
                    Console.WriteLine("8.DH");
                    rejestr2 = Console.ReadLine();
                    switch (rejestr2)
                    {
                        case "1":
                            Zmienne.BH = Zmienne.AL;
                            Console.WriteLine("Akcja pomyślna!");
                            break;
                        case "2":
                            Zmienne.BH = Zmienne.AH;
                            Console.WriteLine("Akcja pomyślna!");
                            break;
                        case "3":
                            Zmienne.BH = Zmienne.BL;
                            Console.WriteLine("Akcja pomyślna!");
                            break;
                        case "4":
                            Zmienne.BH = Zmienne.BH;
                            Console.WriteLine("Akcja pomyślna!");
                            break;
                        case "5":
                            Zmienne.BH = Zmienne.CL;
                            Console.WriteLine("Akcja pomyślna!");
                            break;
                        case "6":
                            Zmienne.BH = Zmienne.CH;
                            Console.WriteLine("Akcja pomyślna!");
                            break;
                        case "7":
                            Zmienne.BH = Zmienne.DL;
                            Console.WriteLine("Akcja pomyślna!");
                            break;
                        case "8":
                            Zmienne.BH = Zmienne.DH;
                            Console.WriteLine("Akcja pomyślna!");
                            break;
                        default:
                            Console.WriteLine("Nie ma takiej opcji");
                            break;
                    }
                    Console.WriteLine("Naciśnij dowolny klawisz aby kontynuować...");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("Na który rejestr chcesz zamienić");
                    Console.WriteLine("1.AL");
                    Console.WriteLine("2.AH");
                    Console.WriteLine("3.BL");
                    Console.WriteLine("4.BH");
                    Console.WriteLine("5.CL");
                    Console.WriteLine("6.CH");
                    Console.WriteLine("7.DL");
                    Console.WriteLine("8.DH");
                    rejestr2 = Console.ReadLine();
                    switch (rejestr2)
                    {
                        case "1":
                            Zmienne.CL = Zmienne.AL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "2":
                            Zmienne.CL = Zmienne.AH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "3":
                            Zmienne.CL = Zmienne.BL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "4":
                            Zmienne.CL = Zmienne.BH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "5":
                            Zmienne.CL = Zmienne.CL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "6":
                            Zmienne.CL = Zmienne.CH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "7":
                            Zmienne.CL = Zmienne.DL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "8":
                            Zmienne.CL = Zmienne.DH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        default:
                            Console.WriteLine("Nie ma takiej opcji");
                            break;
                    }
                    Console.WriteLine("Naciśnij dowolny klawisz aby kontynuować...");
                    Console.ReadLine();
                    break;
                case "6":
                    Console.WriteLine("Na który rejestr chcesz zamienić");
                    Console.WriteLine("1.AL");
                    Console.WriteLine("2.AH");
                    Console.WriteLine("3.BL");
                    Console.WriteLine("4.BH");
                    Console.WriteLine("5.CL");
                    Console.WriteLine("6.CH");
                    Console.WriteLine("7.DL");
                    Console.WriteLine("8.DH");
                    rejestr2 = Console.ReadLine();
                    switch (rejestr2)
                    {
                        case "1":
                            Zmienne.CH = Zmienne.AL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "2":
                            Zmienne.CH = Zmienne.AH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "3":
                            Zmienne.CH = Zmienne.BL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "4":
                            Zmienne.CH = Zmienne.BH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "5":
                            Zmienne.CH = Zmienne.BL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "6":
                            Zmienne.CH = Zmienne.CH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "7":
                            Zmienne.CH = Zmienne.DL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "8":
                            Zmienne.CH = Zmienne.DH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        default:
                            Console.WriteLine("Nie ma takiej opcji");
                            break;
                    }
                    Console.WriteLine("Naciśnij dowolny klawisz aby kontynuować...");
                    Console.ReadLine();
                    break;
                case "7":
                    Console.WriteLine("Na który rejestr chcesz zamienić");
                    Console.WriteLine("1.AL");
                    Console.WriteLine("2.AH");
                    Console.WriteLine("3.BL");
                    Console.WriteLine("4.BH");
                    Console.WriteLine("5.CL");
                    Console.WriteLine("6.CH");
                    Console.WriteLine("7.DL");
                    Console.WriteLine("8.DH");
                    rejestr2 = Console.ReadLine();
                    switch (rejestr2)
                    {
                        case "1":
                            Zmienne.DL = Zmienne.AL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "2":
                            Zmienne.DL = Zmienne.AH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "3":
                            Zmienne.DL = Zmienne.BL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "4":
                            Zmienne.DL = Zmienne.BH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "5":
                            Zmienne.DL = Zmienne.CL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "6":
                            Zmienne.DL = Zmienne.CH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "7":
                            Zmienne.DL = Zmienne.DL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "8":
                            Zmienne.DL = Zmienne.DH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        default:
                            Console.WriteLine("Nie ma takiej opcji");
                            break;
                    }
                    Console.WriteLine("Naciśnij dowolny klawisz aby kontynuować...");
                    Console.ReadLine();
                    break;
                case "8":
                    Console.WriteLine("Na który rejestr chcesz zamienić");
                    Console.WriteLine("1.AL");
                    Console.WriteLine("2.AH");
                    Console.WriteLine("3.BL");
                    Console.WriteLine("4.BH");
                    Console.WriteLine("5.CL");
                    Console.WriteLine("6.CH");
                    Console.WriteLine("7.DL");
                    Console.WriteLine("8.DH");
                    rejestr2 = Console.ReadLine();
                    switch (rejestr2)
                    {
                        case "1":
                            Zmienne.DH = Zmienne.AL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "2":
                            Zmienne.DH = Zmienne.AH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "3":
                            Zmienne.DH = Zmienne.BL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "4":
                            Zmienne.DH = Zmienne.BH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "5":
                            Zmienne.DH = Zmienne.CL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "6":
                            Zmienne.DH = Zmienne.CH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "7":
                            Zmienne.DH = Zmienne.DL;
                            Console.WriteLine("Zamieniłem");
                            break;
                        case "8":
                            Zmienne.DH = Zmienne.DH;
                            Console.WriteLine("Zamieniłem");
                            break;
                        default:
                            Console.WriteLine("Nie ma takiej opcji");
                            break;
                    }
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Błędna wartość!");
                    break;
            }
        } 
        static void odejmowanie()//odejmowanie DEC
        {
            Console.Clear();
            Console.WriteLine("Na którym rejestrze dokonać zmian?");
            Console.WriteLine("1.AL");
            Console.WriteLine("2.AH");
            Console.WriteLine("3.BL");
            Console.WriteLine("4.BH");
            Console.WriteLine("5.CL");
            Console.WriteLine("6.CH");
            Console.WriteLine("7.DL");
            Console.WriteLine("8.DH");
            Console.WriteLine("Wybrana opcja: ");
            string zam = Console.ReadLine();
            int k;
            switch (zam)
            {
                case "1":
                    k = Convert.ToInt32(Zmienne.AL, 16) - 1;
                    Zmienne.AL = Convert.ToString(k, 16);
                    break;
                case "2":
                    k = Convert.ToInt32(Zmienne.AH, 16) - 1;
                    Zmienne.AH = Convert.ToString(k,16);
                    break;
                case "3":
                    k = Convert.ToInt32(Zmienne.BL, 16) - 1;
                    Zmienne.BL = Convert.ToString(k, 16);
                    break;
                case "4":
                    k = Convert.ToInt32(Zmienne.BH, 16) - 1;
                    Zmienne.BH = Convert.ToString(k,16);
                    break;
                case "5":
                    k = Convert.ToInt32(Zmienne.CL, 16) - 1;
                    Zmienne.CL = Convert.ToString(k, 16);
                    break;
                case "6":
                    k = Convert.ToInt32(Zmienne.CH, 16) - 1;
                    Zmienne.CH = Convert.ToString(k, 16);
                    break;
                case "7":
                    k = Convert.ToInt32(Zmienne.DL, 16) - 1;
                    Zmienne.DL = Convert.ToString(k, 16);
                    break;
                case "8":
                    k = Convert.ToInt32(Zmienne.DH, 16) - 1;
                    Zmienne.CH = Convert.ToString(k, 16);
                    break;
            }
        }
        static void inwersja()//inwersja NOT
            {
            Console.Clear();
            Console.WriteLine("Na którym rejestrze dokonać zmian?");
            Console.WriteLine("1.AL");
            Console.WriteLine("2.AH");
            Console.WriteLine("3.BL");
            Console.WriteLine("4.BH");
            Console.WriteLine("5.CL");
            Console.WriteLine("6.CH");
            Console.WriteLine("7.DL");
            Console.WriteLine("8.DH");
            Console.WriteLine("Wybrana opcja: ");
            string zam = Console.ReadLine();
            int k;
            switch(zam)
            {
                case "1":
                    k = Convert.ToInt32(Zmienne.AL, 16);
                    string s = Convert.ToString(k, 2);
                    char[] c = s.ToCharArray();
                    string temp = "";
                    foreach (char x in c)
                    {
                        if (x == '1')
                        {
                            temp += "0";
                        }
                        else
                        {
                            temp += "1";
                        }
                    }
                    int licz = 8 - temp.Length;
                    while (licz > 0)
                    {
                        temp = "1" + temp;
                        licz--;
                    }
                    Zmienne.AL = Convert.ToString(Convert.ToInt32(temp, 2), 16);
                    break;
                case "2":
                    k = Convert.ToInt32(Zmienne.AH, 16);
                    s = Convert.ToString(k, 2);
                    c = s.ToCharArray();
                    temp = "";
                    foreach (char x in c)
                    {
                        if (x == '1')
                        {
                            temp += "0";
                        }
                        else
                        {
                            temp += "1";
                        }
                    }
                    licz = 8 - temp.Length;
                    while (licz > 0)
                    {
                        temp = "1" + temp;
                        licz--;
                    }
                    Zmienne.AH = Convert.ToString(Convert.ToInt32(temp, 2), 16);
                    break;
                case "3":
                    k = Convert.ToInt32(Zmienne.BL, 16);
                    s = Convert.ToString(k, 2);
                    c = s.ToCharArray();
                    temp = "";
                    foreach (char x in c)
                    {
                        if (x == '1')
                        {
                            temp += "0";
                        }
                        else
                        {
                            temp += "1";
                        }
                    }
                    licz = 8 - temp.Length;
                    while (licz > 0)
                    {
                        temp = "1" + temp;
                        licz--;
                    }
                    Zmienne.BL = Convert.ToString(Convert.ToInt32(temp, 2), 16);
                    break;
                case "4":
                    k = Convert.ToInt32(Zmienne.BH, 16);
                    s = Convert.ToString(k, 2);
                    c = s.ToCharArray();
                    temp = "";
                    foreach (char x in c)
                    {
                        if (x == '1')
                        {
                            temp += "0";
                        }
                        else
                        {
                            temp += "1";
                        }
                    }
                    licz = 8 - temp.Length;
                    while (licz > 0)
                    {
                        temp = "1" + temp;
                        licz--;
                    }
                    Zmienne.BH = Convert.ToString(Convert.ToInt32(temp, 2), 16);
                    break;
                case "5":
                    k = Convert.ToInt32(Zmienne.CL, 16);
                    s = Convert.ToString(k, 2);
                    c = s.ToCharArray();
                    temp = "";
                    foreach (char x in c)
                    {
                        if (x == '1')
                        {
                            temp += "0";
                        }
                        else
                        {
                            temp += "1";
                        }
                    }
                    licz = 8 - temp.Length;
                    while (licz > 0)
                    {
                        temp = "1" + temp;
                        licz--;
                    }
                    Zmienne.CL = Convert.ToString(Convert.ToInt32(temp, 2), 16);
                    break;

                case "6":
                    k = Convert.ToInt32(Zmienne.CH, 16);
                    s = Convert.ToString(k, 2);
                    c = s.ToCharArray();
                    temp = "";
                    foreach (char x in c)
                    {
                        if (x == '1')
                        {
                            temp += "0";
                        }
                        else
                        {
                            temp += "1";
                        }
                    }
                    licz = 8 - temp.Length;
                    while (licz > 0)
                    {
                        temp = "1" + temp;
                        licz--;
                    }
                    Zmienne.CH = Convert.ToString(Convert.ToInt32(temp, 2), 16);
                    break;
                case "7":
                    k = Convert.ToInt32(Zmienne.DL, 16);
                    s = Convert.ToString(k, 2);
                    c = s.ToCharArray();
                    temp = "";
                    foreach (char x in c)
                    {
                        if (x == '1')
                        {
                            temp += "0";
                        }
                        else
                        {
                            temp += "1";
                        }
                    }
                    licz = 8 - temp.Length;
                    while (licz > 0)
                    {
                        temp = "1" + temp;
                        licz--;
                    }
                    Zmienne.DL = Convert.ToString(Convert.ToInt32(temp, 2), 16);
                    break;
                case "8":
                    k = Convert.ToInt32(Zmienne.DH, 16);
                    s = Convert.ToString(k, 2);
                    c = s.ToCharArray();
                    temp = "";
                    foreach (char x in c)
                    {
                        if (x == '1')
                        {
                            temp += "0";
                        }
                        else
                        {
                            temp += "1";
                        }
                    }
                    licz = 8 - temp.Length;
                    while (licz > 0)
                    {
                        temp = "1" + temp;
                        licz--;
                    }
                    Zmienne.DH = Convert.ToString(Convert.ToInt32(temp, 2), 16);
                    break;
            }
        }
        static void dodawanie()//dodawanie INC
        {
            Console.Clear();
            Console.WriteLine("Na którym rejestrze dokonać zmian?");
            Console.WriteLine("1.AL");
            Console.WriteLine("2.AH");
            Console.WriteLine("3.BL");
            Console.WriteLine("4.BH");
            Console.WriteLine("5.CL");
            Console.WriteLine("6.CH");
            Console.WriteLine("7.DL");
            Console.WriteLine("8.DH");
            Console.WriteLine("Wybrana opcja: ");
            string zam = Console.ReadLine();
            int k;
            switch (zam)
            {
                case "1":
                    k = Convert.ToInt32(Zmienne.AL, 16) + 1;
                    Zmienne.AL = Convert.ToString(k, 16);
                    break;
                case "2":
                    k = Convert.ToInt32(Zmienne.AH, 16) + 1;
                    Zmienne.AH = Convert.ToString(k, 16);
                    break;
                case "3":
                    k = Convert.ToInt32(Zmienne.BL, 16) + 1;
                    Zmienne.BL = Convert.ToString(k, 16);
                    break;
                case "4":
                    k = Convert.ToInt32(Zmienne.BH, 16) + 1;
                    Zmienne.BH = Convert.ToString(k, 16);
                    break;
                case "5":
                    k = Convert.ToInt32(Zmienne.CL, 16) + 1;
                    Zmienne.CL = Convert.ToString(k, 16);
                    break;
                case "6":
                    k = Convert.ToInt32(Zmienne.CH, 16) + 1;
                    Zmienne.CH = Convert.ToString(k, 16);
                    break;
                case "7":
                    k = Convert.ToInt32(Zmienne.DL, 16) + 1;
                    Zmienne.DL = Convert.ToString(k, 16);
                    break;
                case "8":
                    k = Convert.ToInt32(Zmienne.DH, 16) + 1;
                    Zmienne.DH = Convert.ToString(k, 16);
                    break;
            }
        }
    }
}