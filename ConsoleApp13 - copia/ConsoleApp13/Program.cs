using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        

        static void Main(string[] args)
        {
           //Pantalla Inicial
            Console.WriteLine("IMPORTANTE: Tenga en cuenta que para validar su seleccion");
            Console.WriteLine("debe ingresar una letra y luego apretar la tecla ENTER");
            Console.WriteLine("");
            Console.WriteLine("Por favor, ingrese su nombre y oprima enter para continuar");
            Console.Write("Nombre: ");

            //La variante userName esta alojada en un string y define el nombre del usuario
            string userName = Console.ReadLine();
            Console.Clear();

            //La variante "tecla" define la condicion al final del do while para seguir ejecutando el bucle o salir de el
            string tecla = ("a");
            //La variante "select" define la seleccion del usuario, luego esta sera convertida a un "int"
            string select = ("1");
            //La siguiente variante define la seleccion automatica de Deva, la computadora
                string selectDeva = ("1");

            // Aqui incia el Do While
            do
            {
                //Este es el menu principal del juego
                Console.WriteLine("Hola {0} por favor ingresa la letra de la opcion que deseas y luego presiona enter", userName);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Para jugar contra Deva ingresa (h)");
                Console.WriteLine("Para jugar de a dos ingresa (u)");
                Console.WriteLine("Para leer las reglas del juego ingresa (r)");
                Console.WriteLine("Pulsa (x) para salir");

                //Esta variante cambia de tal forma que se puedan cumplir las condiciones del siguiente if
                tecla = Console.ReadLine();


                //Menu de enfrentamiento contra Deva
                if (tecla == "h")
                {
                    Console.Clear();
                    Console.WriteLine("¿Crees tener lo necesario para enfrentarte a Deva?");
                    Console.WriteLine("Ingresa (y) para continuar o (n) para volver al menu principal");
                    tecla = Console.ReadLine();
                    Console.Clear();
                    
                    if (tecla == ("y"))
                    {
                        Console.Clear();
                        Console.WriteLine("Elige Tu Jugada");
                        Console.WriteLine("(1) PIEDRA - (2) PAPEL - (3) TIJERA");

                        select = Console.ReadLine();
                        int eleccionJugador = Convert.ToInt32(select);

                        //Aqui se definen las elecciones del usuario
                       switch (eleccionJugador)
                        {
                            case 1:
                                Console.WriteLine("{0} eligió PIEDRA", userName);
                                Console.ReadKey();
                                break;

                            case 2:
                                Console.WriteLine("{0} eligió PAPEL", userName);
                                Console.ReadKey();
                                    break;

                            case 3:
                                Console.WriteLine("{0} eligió TIJERAS", userName);
                                Console.ReadKey();
                                break;
                        }
                        //Esta parte del codigo no cumple ninguna funcion
                        Random deva = new Random();
                        int selDeva = deva.Next(1, 4);

                        

                        }

                        Console.ReadKey();
                       
                 

                    }
                    
                //Menu para jugar de a dos
                else if (tecla == "u")
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese 'o' para volver al menu principal");
                    tecla = Console.ReadLine();


                }
                //Menu de reglas
                else if (tecla == "r")
                {
                    Console.Clear();
                    Console.WriteLine("Daaale ¿De verdad no sabes jugar a piedra papel o tijeras?");

                    Console.WriteLine("Ingresa (x) para desaparecer de mi vista");
                    string letra = Console.ReadLine();

                }


            }
            while (tecla == ("x") && tecla == ("o"));
            //Aqui termina el  Do While




            Console.ReadKey();

            
            //Fin del programa
        }
    }
}
