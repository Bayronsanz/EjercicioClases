using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    public  class SuperHeroe :SuperPoder {
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad {  get; set; }
        public bool PuedeVolar {  get; set; }
        public string SuperPoder { get; set; }
        
        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede Volar:{PuedeVolar}");
            Console.WriteLine($"Super poder: {SuperPoder}");
            Console.WriteLine($"Descripción: {descripcion}");
            Console.WriteLine($"Nivel de poder: {nivel}");
            Console.WriteLine();
        }
    }
}
