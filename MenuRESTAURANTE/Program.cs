using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuRESTAURANTE
{
    
   
    class Program
    {
        static int Menu()
        {
            int op;
            StringBuilder cad = new StringBuilder();
            cad.AppendLine("Menu de opciones");
            cad.AppendLine("1. Menu");
            cad.AppendLine("2. Preguntanos");
            cad.AppendLine("3. Salir");
            cad.AppendLine("Digite la opcion: ");
            Console.Write(cad);
            op = Int32.Parse(Console.ReadLine());
            return op;
        }
        static void Main(string[] args)
        {
            double ham = 1.50;
            double tac = 0.75;
            double piz = 3.50;

            Queue menuPrin = new Queue();
            menuPrin.Enqueue("Hamburguesas $"+ham);
            menuPrin.Enqueue("Tacos $"+tac);
            menuPrin.Enqueue("Pizza $"+piz);

            int opc;
            do
            {
                Console.Clear();
                opc = Menu();
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        foreach (var item in menuPrin)
                        {
                            Console.WriteLine(item); 
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("Quiere hacer un pedido?");
                        string P = Console.ReadLine();

                        if (P != "no")
                        {
                            Console.Clear();
                            Console.WriteLine("Numero de Hamburguesas");
                            int Phamb = Int16.Parse(Console.ReadLine());
                            double precioHamb = Phamb * ham;
                            Console.WriteLine("Numero de Tacos");
                            int Ptac = Int16.Parse(Console.ReadLine());
                            double precioTac = Ptac * tac;
                            Console.WriteLine("Numero de Pizzas");
                            int Ppiz = Int16.Parse(Console.ReadLine());
                            double precioPiz = Ppiz * piz;
                            double totalComida = precioHamb + precioPiz + precioTac;
                            Console.WriteLine("El total de su compra es: $" + totalComida);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingresa tu correo: ");
                        string Correo = Console.ReadLine();
                        Console.WriteLine("Realiza tu pregunta: ");
                        string Pregunta = Console.ReadLine();
                        Console.WriteLine("La respuesta sera enviada en unos minutos a: "+Correo);
                        Console.WriteLine("Gracias por preferirnos");
                        break;
                    case 3:
                        Console.WriteLine("Gracias por preferirnos");
                        break;
                    default:
                        Console.WriteLine("Este numero no esta en la lista");
                        break;
                }
                Console.ReadKey();
            } while (opc != 3);
        }
    }
}
