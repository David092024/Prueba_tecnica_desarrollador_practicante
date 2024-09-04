using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_tecnica_desarrollador_practicante
{
    public class Tarea 
    {
        //creamos las propiedades
        public string Actividad { get; set; }
        public string Descripcion { get; set; }
        public string FechaLimite { get; set; }

        //creamos el constructor para que inicialice las propiedades
        public Tarea(string actividad, string descripcion, string fechaLimite)
        {
            Actividad = actividad;
            Descripcion = descripcion;
            FechaLimite = fechaLimite;
        }


        //creamos public override tipo string que lo que va hacer es que va hacer que los objetos se puedan describir asi mismo
        public override string ToString()
        {
            return $"Tarea: {Actividad} Descripcion: {Descripcion}, Fecha Limite: {FechaLimite}";
        }
    }

}
