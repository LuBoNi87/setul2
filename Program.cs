using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setul1
{
    class Program
    {
        public static void Main()
        {
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(Console.LargestWindowWidth-40, Console.LargestWindowHeight-20);
            Console.WriteLine(@"1.  Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
2.  Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.
3.  Calculati suma si produsul numerelor de la 1 la n. 
4.  Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
5.  Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 
6.  Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
7.  Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
8.  Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
9.  Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
14. O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. 
15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 
16. O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.");

            Console.WriteLine("Numarul problemei pe care vrei sa o rezolvi: ");
            int nrProblema = int.Parse(Console.ReadLine());
            switch (nrProblema)
            {
                case 1: Console.Clear(); Problema1(); break;
                case 2: Console.Clear(); Problema2(); break;
                case 3: Console.Clear(); Problema3(); break;
                case 4: Console.Clear(); Problema4(); break;
                case 5: Console.Clear(); Problema5(); break;
                case 6: Console.Clear(); Problema6(); break;
                case 7: Console.Clear(); Problema7(); break;
                case 8: Console.Clear(); Problema8(); break;
                case 9: Console.Clear(); Problema9(); break;
                case 10: Console.Clear(); Problema10(); break;
                case 11: Console.Clear(); Problema11(); break;
                case 12: Console.Clear(); Problema12(); break;
                case 13: Console.Clear(); Problema13(); break;
                case 14: Console.Clear(); Problema14(); break;
                case 15: Console.Clear(); Problema15(); break;
                case 16: Console.Clear(); Problema16(); break;
                case 17: Console.Clear(); Problema17(); break;
                default:
                    break;
            }
        }

        public static void Problema1()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determine cate din ele sunt pare.");
            Console.Write("n:");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while(n > 0)
            {
                int numar = int.Parse(Console.ReadLine());
                if (numar % 2 == 0)
                    count++;
                n--;
            }
            Console.WriteLine($"In secventa sunt {count} numere pare");
        }

        public static void Problema2()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.");
            Console.Write("n:");
            int n = int.Parse(Console.ReadLine());
            int pozitive = 0;
            int negative = 0;
            int zero = 0;
            while (n > 0)
            {
                int numar = int.Parse(Console.ReadLine());
                if (numar > 0)
                    pozitive++;
                else if (numar < 0)
                    negative++;
                else zero++;
                n--;
            }
            Console.WriteLine($"In secventa sunt {negative} numere negative,{zero} numere egale cu 0 si {pozitive} numere pozitive");
        }

        public static void Problema3()
        {
            Console.WriteLine("Calculati suma si produsul numerelor de la 1 la n.");
            Console.Write("n:");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int prod = 1;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
                prod *= i;
            }
            Console.WriteLine($"Suma si produsul numerelor de la 1 la {n} sunt egale cu {suma}, respectiv {prod}.");
        }

        public static void Problema4()
        {
            Console.WriteLine("Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1.");
            Console.Write("n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("a:");
            int a = int.Parse(Console.ReadLine());
            int pos = -1;
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(Console.ReadLine()) == a)
                    pos = i;
            }
            if(pos == -1)
                Console.WriteLine($"Numarul {a} nu se afla in aceasta secventa");
            Console.WriteLine($"Numarul {a} se afla pe pozitia {pos}");
        }

        public static void Problema5()
        {
            Console.WriteLine("Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0.");
            Console.Write("n:");
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if(x==i)
                    nr++;
            }
            Console.WriteLine($"Numarul de elemente egale cu pozitia pe care se afla este {nr}");
        }

        public static void Problema6()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
            Console.Write("n:");
            int n = int.Parse(Console.ReadLine());
            bool ascending = true;
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < n-1; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if(b<a)
                    ascending = false;
                a = b;
            }
            if(ascending)
                Console.WriteLine("Numerele din secventa sunt in ordine crescatoare");
            else
                Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare");
        }

        public static void Problema7()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.");
            Console.Write("n:");
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < n - 1; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < min)
                    min = a;
                if (a > max)
                    max = a;
            }
            Console.WriteLine($"Numarul maxim este {max}, iar numarul minim este {min}");
        }

        public static void Problema8()
        {
            Console.WriteLine("Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");
            Console.Write("n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Al {n}-lea termen din sirul lui fibonacci este {Fibonacci(n)}");
        }

        public static int Fibonacci(int n)
        {
            switch (n)
            {
                case 1:
                    return 0;
                case 2:
                    return 1;
                default:
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        public static void Problema9()
        {
            Console.WriteLine("Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.");
            Console.Write("n:");
            int n = int.Parse(Console.ReadLine());

        }

        public static void Problema10()
        {
            
        }

        public static void Problema11()
        {
            
        }

        public static void Problema12()
        {
            
        }

        public static void Problema13()
        {
            
        }

        public static void Problema14()
        {
            
        }

        public static void Problema15()
        {
            
        }

        public static void Problema16()
        {
            
        }

        public static void Problema17()
        {
            
        }
    }
}
