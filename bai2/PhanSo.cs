using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Phanso
    {
         public int tuso;
         public int mauso;
        
        public Phanso()
        {
            tuso = 0;
            mauso = 1;
        }
        public Phanso(int soNguyen)
        {
            tuso = soNguyen;
            mauso = 1;
        }

        public Phanso(int tusoArg, int mausoArg)
        {
            tuso = tusoArg;
            mauso = mausoArg;
        }

        public static Phanso operator +(Phanso a, Phanso b)
        {
            int tusoMoi = a.tuso * b.mauso + a.mauso * b.tuso;
            int mausoMoi = a.mauso * b.mauso;
            return new Phanso(tusoMoi, mausoMoi);
        }

        public static Phanso operator -(Phanso a, Phanso b)
        {
            int tusoMoi = a.tuso * b.mauso - a.mauso * b.tuso;
            int mausoMoi = a.mauso * b.mauso;
            return new Phanso(tusoMoi, mausoMoi);
        }

        public static Phanso operator *(Phanso a, Phanso b)
        {
            int tusoMoi = a.tuso * b.tuso + a.mauso * b.mauso;
            int mausoMoi = a.mauso * b.mauso;
            return new Phanso(tusoMoi, mausoMoi);
        }

        public static Phanso operator /(Phanso a, Phanso b)
        {
            int tusoMoi = a.tuso * b.mauso;
            int mausoMoi = a.mauso * b.tuso;
            return new Phanso(tusoMoi, mausoMoi);
        }

        public static bool operator >(Phanso a, Phanso b)
        {
            Phanso kq = a - b;
            return kq.tuso > 0;
        }

        public static bool operator <(Phanso a, Phanso b)
        {
            Phanso kq = a - b;
            return kq.tuso < 0;
        }

        public static bool operator >=(Phanso a, Phanso b)
        {
            return !(a < b);
        }

        public static bool operator <=(Phanso a, Phanso b)
        {
            return !(a > b);
        }

        public static bool operator ==(Phanso a, Phanso b)
        {
            Phanso kq = a - b;
            return kq.tuso == 0;
        }

        public static bool operator !=(Phanso a, Phanso b)
        {
            return !(a == b);
        }

        public override bool Equals(object o)
        {
            if (o == null)
                return false;
            var second = o as Phanso;
            return second != null && tuso == second.tuso && mauso == second.mauso;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(tuso, mauso).GetHashCode(); 
        }

        public static Phanso Parse(string phanso)
        {
            if (phanso == null) throw new FormatException();
            string[] split = phanso.Split('/');
            int len = split.Length;

            if (len == 2)
            {
                int s0 = int.Parse(split[0]);
                int s1 = int.Parse(split[1]);
                return new Phanso(s0, s1);
            }
            else if (len == 4)
            {
                int s0 = int.Parse(split[0]);
                int s1 = int.Parse(split[1]);
                Phanso f1 = new Phanso(s0, s1);

                int s2 = int.Parse(split[2]);
                int s3 = int.Parse(split[3]);
                Phanso f2 = new Phanso(s2, s3);

                return f1 / f2;
            }

            else throw new FormatException();

        }
        static int gcd(int a,int b)
        {
            while (a != b)
                if (a < b) b = b - a;
                else a = a - b;

            return (a);

        }
        static int division(int a, int b)
        {
            int remainder = a, quotient = 0;
            while (remainder >= b)
            {
                remainder = remainder - b;
                quotient++;
            }
            return (quotient);
        }

        public static Phanso Reduce(Phanso phanso)
        {
            int divisor, numerator, denomnator, reduceNumerator, reduceDenomnator;
            numerator = phanso.tuso;
            denomnator = phanso.mauso;

            divisor = gcd(numerator, denomnator);

            if (divisor != 1)
            {
                reduceNumerator = division(numerator, denomnator);
                reduceDenomnator = division(numerator, denomnator);
                return new Phanso(reduceNumerator, reduceDenomnator);
            }
            else return phanso;
        }




    }

}

