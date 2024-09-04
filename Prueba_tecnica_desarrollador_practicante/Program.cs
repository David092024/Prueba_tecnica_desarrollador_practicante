using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_tecnica_desarrollador_practicante
{

    internal class Program
    {
        static List<string> tareas = new List<string>(); // Lista para almacenar tareas

        static void Main(string[] args)
        {
            var gestor = new GestorTareas(); //nos va crear una instancia del gestor de tareas para poder llamar los metodos
            bool continuar = true; // la variable que va a controlar el ciclo del programa

           //este es el ciclo principal del programa 
            while (continuar)
            {
                // Mostrar menú de opciones
                Console.WriteLine("Seleccione la opcion que desea"); 
                Console.WriteLine("1 - Para agregar tarea");          
                Console.WriteLine("2 - Listar Tareas ");              
                Console.WriteLine("3 - Eliminar una tarea");          
                Console.WriteLine("4 - Actualizar una tarea"); 
                Console.WriteLine("5 - Marcar tarea como completada");
                Console.WriteLine("6 - Salir");
                Console.WriteLine("*************************************");

                // Leer la opción del usuario
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Agregar tarea
                        Console.WriteLine("Ingrese el nombre de la tarea: ");
                        string actividad = Console.ReadLine();
                        Console.Write("Ingrese la descripción de la tarea: ");
                        string descripcion = Console.ReadLine();
                        Console.Write("Ingrese la fecha limite (dia/mes/año): ");
                        string fechaLimite = Console.ReadLine();
                        gestor.AgregarTarea(actividad, descripcion, fechaLimite);
                        break;

                    case "2":
                        // Marcar tarea como completada
                        gestor.ListarTareas();
                        break;

                    case "3":
                        // Eliminar tarea
                        gestor.ElimiarTareas();
                        break;

                    case "4":
                        // Listar tareas
                        gestor.ActualizarTareas();
                        break;

                    case "5":
                        // Actualizar tarea
                        gestor.MarcarTareaComoCompletada();
                        break;

                    case "6":
                        // Salir
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("¡Estas loco esa opcion no existe!");
                        break;
                }

                Console.WriteLine(); // Línea en blanco para mejor lectura
            }
        }
    }
}
    

