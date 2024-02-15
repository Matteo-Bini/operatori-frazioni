using System;

namespace Frazioni
{
    public class Fraction
    {
        public int N { get; }
        public int D { get; }

        public Fraction(int n, int d)
        {
            Semplifica(ref n, ref d);

            N = n;
            D = d;
        }

        private void Semplifica(ref int n, ref int d)
        {
            int mcd = CalcolaMcd(n, d);
            n = n / mcd;
            d = d / mcd;
        }

        private int CalcolaMcd(int a, int b)
        {
            while (b != 0)
            {
                int resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }

        public Fraction Somma(Fraction other)
        {
            return new Fraction(this.N * other.D + this.D * other.N, this.D * other.D);
        }

        public Fraction Sottrai(Fraction other)
        {
            return new Fraction(this.N * other.D - this.D * other.N, this.D * other.D);
        }

        public Fraction Moltiplica(Fraction other)
        {
            return new Fraction(this.N * other.N, this.D * other.D);
        }

        public Fraction Dividi(Fraction other)
        {
            return new Fraction(this.N * other.D, this.D * other.N);
        }


        public override string ToString()
        {
            return $"{N}/{D}";
        }


        public static Fraction Parse(string s)
        {
            string[] parts = s.Split('/');
            return new Fraction(int.Parse(parts[0]), int.Parse(parts[1]));
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            if (object.ReferenceEquals(f1, null))
                return object.ReferenceEquals(f2, null);
            else if (object.ReferenceEquals(f2, null))
                return false;
            else
                return f1.N == f2.N && f1.D == f2.D;
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            if (object.ReferenceEquals(f1, null))
                return object.ReferenceEquals(f2, null);
            else if (object.ReferenceEquals(f2, null))
                return f1.N != f2.N && f1.D != f2.D;
            else
                return false;
        }
        public static bool operator >=(Fraction f1, Fraction f2)
        {
            if (object.ReferenceEquals(f1, null))
                return object.ReferenceEquals(f2, null);
            else if (object.ReferenceEquals(f2, null))
                return true;
            else
                return f1.N < f2.N && f1.D < f2.D;
                
        }
        public static bool operator >(Fraction f1, Fraction f2)
        {
            if (object.ReferenceEquals(f1, null))
                return object.ReferenceEquals(f2, null);
            else if (object.ReferenceEquals(f2, null))
                return true;
            else
                return f1.N <= f2.N && f1.D <= f2.D;
        }
        public static bool operator <=(Fraction f1, Fraction f2)
        {
            if (object.ReferenceEquals(f1, null))
                return object.ReferenceEquals(f2, null);
            else if (object.ReferenceEquals(f2, null))
                return false;
            else
                return f1.N <= f2.N && f1.D <=f2.D;
        }
        public static bool operator <(Fraction f1, Fraction f2)
        {
            if (object.ReferenceEquals(f1, null))
                return object.ReferenceEquals(f2, null);
            else if (object.ReferenceEquals(f2, null))
                return false;                     
            else
                return f1.N < f2.N && f1.D < f2.D;

        }

    }
}
