using System;

namespace Biblioteca
{
    public class Sumador
    {
        public int cantidadSumas;
        public Sumador():this(0)
        {

        }
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return (int)s1 + (int)s2;
        }
        /// <summary>
        /// Devuelve la suma del atributo cantSumas
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator |(Sumador s1, Sumador s2)
        {
            return (int)s1 == (int)s2;
        }
    }
}
