using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace overloading
{
    public class Produkt
    {
        public double Cena;
        public string Nazwa;
        public int Ilosc;

        public Produkt(int cena, string nazwa, int ilosc)
        {
            Cena = cena;
            Nazwa = nazwa;
            Ilosc = ilosc;
        }

        public string Info()
        {
            return $"{Nazwa}, {Cena}zl\n{Ilosc} sztuk";
        }

        public static bool operator ==(Produkt a, Produkt b)
        {
            if (a.Cena == b.Cena) return true; return false;
        }

        public static bool operator !=(Produkt a, Produkt b)
        {
            return !(a == b);
        }

        public static bool operator >(Produkt a, Produkt b)
        {
            if (a.Cena > b.Cena) return true; return false;
        }

        public static bool operator <(Produkt a, Produkt b)
        {
            if (a.Cena < b.Cena) return true; return false;
        }

        public static bool operator <=(Produkt a, Produkt b)
        {
            if (a.Cena <= b.Cena) return true; return false; 
        }

        public static bool operator >=(Produkt a, Produkt b)
        {
            if (a.Cena >= b.Cena) return true; return false;
        }

        public static Produkt operator ++(Produkt a)
        {
            a.Cena++; return a;
        }

        public static Produkt operator --(Produkt a)
        {
            a.Cena--; return a;
        }
    }

    public class Magazyn
    {
        public string Nazwa;
        public List<Produkt> stan = new();

        public Magazyn(string nazwa)
        {
            this.Nazwa = nazwa;
        }

        public void Produkty()
        {
            for(int i = 0; i < stan.Count; i++)
            {
                Console.WriteLine(stan[i].Info());
            }
            Console.WriteLine();
        }

        public void Sort()
        {
            for(int i = 0; i < stan.Count; i++)
            {
                for(int j = 1; j < stan.Count; j++)
                {
                    if (stan[j] < stan[j - 1])
                    {
                        Produkt temp = stan[j];
                        stan[j] = stan[j - 1];
                        stan[j - 1] = temp;
                    }
                }
            }
        }
    }

    public class Macierz
    {
        public List<List<int>> matrix;

        public Macierz(Macierz m)
        {
            this.matrix = m.matrix;
        }
        public Macierz(List<List<int>> matrix)
        {
            this.matrix = matrix;
        }

        public void Show()
        {
            for(int i = 0; i < matrix.Count; i++)
            {
                for(int j = 0; j< matrix[i].Count; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static List<List<int>> operator +(Macierz a, Macierz b)
        {
            for(int i = 0;i < a.matrix.Count; i++)
            {
                for(int j = 0; j < a.matrix[i].Count; j++)
                {
                    a.matrix[i][j] += b.matrix[i][j];
                }
            }
            return a.matrix;
        }

        public static List<List<int>> operator -(Macierz a, Macierz b)
        {
            for (int i = 0; i < a.matrix.Count; i++)
            {
                for (int j = 0; j < a.matrix[i].Count; j++)
                {
                    a.matrix[i][j] -= b.matrix[i][j];
                }
            }
            return a.matrix;
        }

        public static Macierz operator ++(Macierz a)
        {
            for (int i = 0; i < a.matrix.Count; i++)
            {
                for (int j = 0; j < a.matrix[i].Count; j++)
                {
                    a.matrix[i][j] += 2;
                }
            }
            return a;
        }

        public static Macierz operator --(Macierz a)
        {
            for (int i = 0; i < a.matrix.Count; i++)
            {
                for (int j = 0; j < a.matrix[i].Count; j++)
                {
                    a.matrix[i][j] -= 2;
                }
            }
            return a;
        }

        public static List<List<int>> operator *(Macierz a, Macierz b)
        {
            Macierz c = new(a.matrix);
            for (int i = 0; i < a.matrix.Count; i++)
            {
                for (int j = 0; j < a.matrix[i].Count; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < a.matrix.Count; k++)
                    {
                        sum += a.matrix[i][k] * b.matrix[k][j];
                    }
                    c.matrix[i][j] = sum;
                }
            }
            return c.matrix;
        }
    }
}
