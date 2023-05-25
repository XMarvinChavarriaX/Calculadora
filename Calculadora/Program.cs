using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            char operador;

            //Enviamos un mensaje de bienvenida y una descripcion del programa
            Console.WriteLine("Bienvenido a nuestro programa");
            Console.WriteLine("Este programa permite operaciones basicas sobre dos numeros");
            Console.WriteLine("--------------");

            Console.WriteLine("De el valor del primer nuemro");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Indique la operacion ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Indique la operacion(*, +, -, /, )");
            operador = char.Parse(Console.ReadLine());

            /*Identificamos el tipo de operacion a realizar haciendo uso del condicional IF*/

            if (operador == '*')
            {
                Console.WriteLine("La multiplicacion es de: " + (num1 * num2));
            }
          
            if(operador== '/')
            {
                Console.WriteLine("La division es de: "+ (num1 / num2));
     
            }
            if(operador== '+')
            {
                Console.WriteLine("La suma es de:" + (num1 + num2));
            }
            if (operador== '-')
            {
                Console.WriteLine("La resta es de :" + (num1 - num2));
            }

                Console.ReadLine();

            switch (operador)
            {
                case '*':
                    Console.WriteLine("la multiplicacion es de : " + (num1 * num2));
                    break;

                case '/':
                    Console.WriteLine("La division es de : " + (num1 / num2));
                    break;

                case '+':
                   Console.WriteLine("La suma es de : " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("La resta es de : " + (num1 - num2));
                        break;

                default: Console.WriteLine("No es una opcion valida");
                    break;

            }
            Console.ReadLine();
          
           
            

        }
    }
}
