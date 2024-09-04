using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prueba_tecnica_desarrollador_practicante
{
    public class GestorTareas
    {
        //creamos una lista privada donde se van a almacenar las diferentes tareas
        private List<Tarea> tareas = new List<Tarea>();

        //Agregar Tarea
       public void AgregarTarea( string actividad,string descripcion, string fechaLimite)
        {
            //crea una nueva tarea con los siguientes detalles
            var tarea = new Tarea (actividad ,descripcion, fechaLimite);
            //agrega la tarea en la lista de tareas
            tareas.Add(tarea);
            //y por ultimo imprime la confirmacion
            Console.WriteLine("Su tarea fue agregada.");
        }

        //Listar Tareas
        public void ListarTareas()
        {
            //si el total de tareas es 0
            if (tareas.Count == 0)
            {
                //que le muestre al uuario el siguiente mensaje
                Console.WriteLine("No hay tareas en la lista.");
            }
            //si  no es 0 entonces
            else
            {
                //que imprima el total de tareas ingresadas
                Console.WriteLine("Lista de tareas:");

                //por cada tarea agregada en la lista tareas
                foreach (var tarea in tareas)
                {
                    //le imprima  todas las tareas agregadas
                    Console.WriteLine(tarea);
                }
            }
            
        }
        //Eliminar Tareas
        public void ElimiarTareas()
        {

            //le pedimos al usuario que ingrese el nombre de la tarea
            Console.WriteLine("Ingrese el nombre de la tareas que desea eliminar ");
            //creamos una variable tipo string que nos va a servir para que compare y nos diga si la tarea coincide con una que ya estaba
            string nombreTarea = Console.ReadLine();

            //Busca las diferentes tareas comparandolas con el nombre de la tarea que el usuarion me ingrese e ignorando las mayusculas y minusculas
            Tarea TareaEliminar = tareas.FirstOrDefault(t => t.Actividad.Equals(nombreTarea, StringComparison.OrdinalIgnoreCase));

            //Si encuentra la tareas y la tarea es distinta a un valor nulo  que la tarea se elimine
            if (TareaEliminar != null)
            {
                tareas.Remove(TareaEliminar);
                Console.WriteLine("La siguiente tarea fue eliminada con exito:" + TareaEliminar);
            }

            //si no es nulo entonces que le mande el siguiente mensaje
            else
            {
                Console.WriteLine("No se encontro ninguna tarea");
                return;
            }

        }

        //Actualizar Tareas
        public void ActualizarTareas()
        {


            // Le pedimos al usuario que ingrese la descripción actual de la tarea
            Console.WriteLine("Ingrese la tarea actual de la tarea que desea actualizar:");

            // creamos una variable tipo string osea tipo texto  que va hacer el nombre de alguna tarea antes ingresada
            string TareaActual = Console.ReadLine();

            // lo que hace esto es buscar las tareas que coincidan con el nombre que el usuario me ingreso como tambien ignora mayusculas
            Tarea tareaPorActualizar = tareas.FirstOrDefault(t => t.Actividad.Equals(TareaActual, StringComparison.OrdinalIgnoreCase));

            // En caso de que la tarea no exista
            if (tareaPorActualizar == null)
            {
                //que le mande al usuario el siguiente mensaje
                Console.WriteLine("La tarea que quiere actualizar no existe.");
                //y que lo retorne
                return;
            }

            // Le pedimos al usuario que ingrese la nueva descripción para la tarea
            Console.WriteLine("Ingrese la nueva descripcion:");
            string nuevaDescripcion = Console.ReadLine();

            // Le pedimos al usuario que ingrese el nuevo nombre (actividad) de la tarea
            Console.WriteLine("Ingrese el nuevo nombre de la tarea:");
            string nuevaActividad = Console.ReadLine();

            // Le pedimos al usuario que ingrese la nueva fecha límite para la tarea
            Console.WriteLine("Ingrese la nueva fecha limite (dia/mes/año):");
            string nuevaFechaLimite = Console.ReadLine();

            // Actualiza los campos de la tarea encontrada
            tareaPorActualizar.Descripcion = nuevaDescripcion;
            tareaPorActualizar.Actividad = nuevaActividad;
            tareaPorActualizar.FechaLimite = nuevaFechaLimite;

            //y que por ultimo le mande un mensaje el cual haga la confirmacion
            Console.WriteLine("Tarea actualizada con exito.");
        }

        //Marcar Tareas como completadas
        public void MarcarTareaComoCompletada()
        {
            //si la cantidad de tareas es igual a 0 entonces
            if (tareas.Count == 0)
            {
                //que le mande el siguiente mensaje
                Console.WriteLine("No hay tareas para marcar como completadas.");
                //y que lo retorne
                return;



            }
            //si no 
            else
            {

                //que le mande el siguiente mensaje
                Console.WriteLine("Tarea Agregada con Exito");
            }


        }
       

        
       
        

    }
}

