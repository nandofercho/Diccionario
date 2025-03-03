using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_11
{
    class Program
    {
        static void Main()
        {
            // Se inicializa el diccionario con algunas palabras en español y sus traducciones al inglés.
            Dictionary<string, string> diccionario = new Dictionary<string, string>()
        {
            {"tiempo", "time"},
            {"persona", "person"},
            {"año", "year"},
            {"camino", "way"},
            {"forma", "way"},
            {"día", "day"},
            {"cosa", "thing"},
            {"hombre", "man"},
            {"mundo", "world"},
            {"vida", "life"},
            {"mano", "hand"},
            {"parte", "part"},
            {"niño", "child"},
            {"niña", "child"},
            {"ojo", "eye"},
            {"mujer", "woman"},
            {"lugar", "place"},
            {"trabajo", "work"},
            {"semana", "week"},
            {"caso", "case"},
            {"punto", "point"},
            {"tema", "point"},
            {"gobierno", "government"},
            {"empresa", "company"},
            {"compañía", "company"}
        };

            // Bucle principal que mantiene el programa en funcionamiento hasta que el usuario decida salir.
            while (true)
            {
                // Se muestra el menú al usuario.
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("=======================================================");
                Console.WriteLine("             DICCIONARIO ESPAÑOL-INGLES                ");
                Console.WriteLine("=======================================================");
                Console.WriteLine("1. Traducir una frase");
                Console.WriteLine("2. Ingresar más palabras al diccionario");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                // Si el usuario selecciona "0", el bucle se interrumpe y el programa termina.
                if (opcion == "0") break;

                switch (opcion)
                {
                    case "1":
                        // Caso para traducir una frase.
                        Console.Write("Ingrese la frase: ");
                        string frase = Console.ReadLine();

                        // Se separa la frase en palabras individuales.
                        string[] palabras = frase.Split(' ');
                        string fraseTraducida = "";

                        // Se recorre cada palabra de la frase.
                        foreach (string palabra in palabras)
                        {
                            // Se convierte la palabra a minúsculas para hacer la búsqueda insensible a mayúsculas.
                            string palabraMinuscula = palabra.ToLower();

                            // Se verifica si la palabra existe en el diccionario.
                            if (diccionario.ContainsKey(palabraMinuscula))
                            {
                                // Si existe, se añade su traducción a la frase traducida.
                                fraseTraducida += diccionario[palabraMinuscula] + " ";
                            }
                            else
                            {
                                // Si no existe, se deja la palabra tal como está (en español).
                                fraseTraducida += palabra + " ";
                            }
                        }

                        // Se muestra la frase completa, con las palabras traducidas y las no traducidas tal cual.
                        Console.WriteLine("Su frase traducida es: " + fraseTraducida.Trim());
                        break;

                    case "2":
                        // Caso para agregar nuevas palabras al diccionario.
                        Console.Write("Ingrese la palabra en español: ");
                        string palabraEspanol = Console.ReadLine().ToLower();

                        Console.Write("Ingrese la traducción en inglés: ");
                        string palabraIngles = Console.ReadLine().ToLower();

                        // Se verifica si la palabra ya existe en el diccionario.
                        if (!diccionario.ContainsKey(palabraEspanol))
                        {
                            // Si no existe, se añade la nueva palabra al diccionario.
                            diccionario.Add(palabraEspanol, palabraIngles);
                            Console.WriteLine("Palabra añadida correctamente.");
                        }
                        else
                        {
                            // Si ya existe, se informa al usuario.
                            Console.WriteLine("La palabra ya existe en el diccionario.");
                        }
                        break;

                    default:
                        // Si el usuario ingresa una opción no válida, se le informa.
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                // Se añade una línea en blanco para mejorar la legibilidad entre las operaciones.
                Console.WriteLine();
            }
        }
    }
}
