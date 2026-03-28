using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azil_zivotinje
{
    public static class Admin
    {
        //Unos podataka za zivotinje
        public static void Unos(string zapis)
        {
            StreamWriter sw = new StreamWriter("azilzivotinje.txt", true);
            sw.WriteLine(zapis);
            sw.Close();
        }
        //Unos podataka za udomitelje
        public static void UnosUdomitelja(string zapis)
        {
            StreamWriter sw = new StreamWriter("udomitelji.txt", true);
            sw.WriteLine(zapis);
            sw.Close();
        }
        //Učitavanje svih podataka o zivotinjama iz datoteke azilzivotinje.txt i spremanje u listu stringova, a zatim vraćanje te liste
        public static List<string> Load()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("azilzivotinje.txt");
            string linija = sr.ReadLine();

            while (linija != null)
            {
                lista.Add(linija);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }
        
        public static List<string> UcitajSveUdomitelje()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("udomitelji.txt");
            string linija = sr.ReadLine();

            while (linija != null)
            {
                lista.Add(linija);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }
        //Učitavanje svih podataka o vrstama zivotinja iz datoteke azilzivotinje.txt i spremanje u listu stringova, a zatim vraćanje te liste
        public static List<string> Vrste()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("azilzivotinje.txt");
            string linija = sr.ReadLine();

            while (linija != null)
            {
                string[] dijelovi = linija.Split('|');
                string vrsta = dijelovi[1];
                lista.Add(vrsta);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }

        public static List<string> SearchByVrsta(string kriterij)
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("azilzivotinje.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                string[] dijelovi = linija.Split('|');
                if (dijelovi[1] == kriterij)
                {
                    lista.Add(linija);
                }
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }
        //Ovdje se izračunava prosječna dob zivotinja u azilu, tako da se učitavaju sve dobne vrijednosti iz datoteke azilzivotinje.txt,
        //zbrajaju se i dijele s brojem zivotinja, a zatim se vraća ta prosječna vrijednost
        public static double ProsjecnaDob()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("azilzivotinje.txt");
            string linija = sr.ReadLine();
            int brojac = 0;
            int suma = 0;
            while (linija != null)
            {
                string[] dijelovi = linija.Split('|');
                int dob = int.Parse(dijelovi[4]);
                suma += dob;
                brojac++;
                linija = sr.ReadLine();
            }
            sr.Close();
            double prosjek = (double)suma / brojac;
            return prosjek;
        }
        //Ovdje se izračunava broj zivotinja po vrstama, tako da se učitavaju sve vrste zivotinja iz datoteke azilzivotinje.txt,
        //a zatim se broji koliko puta se svaka vrsta pojavljuje i sprema u listu, a zatim se ta lista vraća
        public static List<string> BrojVrsta()
        {
            List<string> lista = new List<string>();
            List<string> vrste = new List<string>();
            List<int> brojevi = new List<int>();
            StreamReader sr = new StreamReader("azilzivotinje.txt");
            string linija = sr.ReadLine();

            while (linija != null)
            {
                string[] dijelovi = linija.Split('|');
                if (dijelovi.Length > 1)
                {
                    string vrsta = dijelovi[1];
                    if (vrste.Contains(vrsta))
                    {
                        int index = vrste.IndexOf(vrsta);
                        brojevi[index]++;
                    }
                    else
                    {
                        vrste.Add(vrsta);
                        brojevi.Add(1);
                    }
                }
                linija = sr.ReadLine();
            }
            sr.Close();

            for (int i = 0; i < vrste.Count; i++)
            {
                lista.Add(vrste[i] + ": " + brojevi[i]);
            }
            return lista;
        }
    }
}

