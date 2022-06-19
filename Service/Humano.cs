using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Service
{
    public class serviceHumano
    {

        private static readonly string[] Names = new[]
        {
            "Damian", "Lucero", "Irving", "Laura", "Pablo"
        };

        private static readonly char[] Genero = new[]
       {
           'M', 'H',
        };
        public IEnumerable<Humano> generateList()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Humano
            {
                Id = index,
                Edad = rng.Next(20, 55),
                Nombre = Names[index - 1],
                Sexo = Genero[rng.Next(Genero.Length)],
                Altura = Convert.ToString(rng.Next(150, 210) + " cm"),
                Peso = Convert.ToString(rng.Next(50, 100) + " Kg")
            })
          .ToArray();
        }
    }
}
