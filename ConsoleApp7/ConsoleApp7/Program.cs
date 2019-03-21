using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cancion> Lista = new List<Cancion>();

            Cancion c1 = new Cancion();
            c1.ID = 1;
            c1.Name = "Cheap Thrils";
            c1.Artista = "Sia";
            c1.Genero = "Pop";

            Cancion c2 = new Cancion();
            c2.ID = 2;
            c2.Name = "Perdoname";
            c2.Artista = "Gerardo Ortiz";
            c2.Genero = "Banda";

            Cancion c3  = new Cancion();
            c3.ID = 3;
            c3.Name = "Vete Ya";
            c3.Artista = "Valentin Elizalde";
            c3.Genero = "Banda";

            Lista.Add(c1);
            Lista.Add(c2);
            Lista.Add(c3);
            Lista.Add(new Cancion { ID = 4, Name = "Si Yo Fuera Ladron", Artista = "El Chapo de Sinaloa", Genero = "Banda"});
            Lista.Add(new Cancion { ID = 5, Name = "Somewhere I Belong", Artista = "Linkin Park", Genero = "Nu Metal"});
            Lista.Add(new Cancion { ID = 6, Name = "Molinos de Viento", Artista = "Mago De Oz", Genero = "Rock"});
            Lista.Add(new Cancion { ID = 7, Name = "Hasta Que ElCuerpo Aguante", Artista = "Mago De Oz", Genero = "Rock" });

            foreach (Cancion item in Lista)
            {
                if(item.Genero == "Banda")
                Console.WriteLine(item.ID + " --- " + item.Name + " --- " + item.Artista + " --- "+ item.Genero);
            }

            var lista = (from item in Lista
                         where item.Genero == "Rock"
                         select item.Name).ToList();

            foreach(var i in lista)
            {
                Console.WriteLine(i);
            }

            bool allStartWithB = Lista.All(cancion => cancion.Genero.StartsWith("B"));

            Console.WriteLine(
                "{0} los generos empiezan con 'B'.",
                allStartWithB ? "Algunos de" : "No todos");
            Console.WriteLine(allStartWithB);
            Console.ReadKey();
        }
    }
}
