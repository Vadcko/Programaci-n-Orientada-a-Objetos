using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas
{
    class Pelicula
    {
        //ATRIBUTOS
        public string nombre;
        public string calificacion;
        public string año;

        //Metodos

        //todos los metodos deben estar dentro de una clase

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.nombre = "Sueño de fuga";
            p1.calificacion = "9,2";
            p1.año = "1994";


            Pelicula p2 = new Pelicula();
            p2.nombre = "El Padrino";
            p2.calificacion = "9,1";
            p2.año = "1972";

            Console.WriteLine("Top Rated Movies");
            Console.WriteLine(p1.nombre + " " + p1.calificacion);
            Console.WriteLine(p2.nombre + " " + p2.calificacion);
            Console.ReadKey();
        }
    }
}
