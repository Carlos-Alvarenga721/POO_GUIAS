using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO10L
{
    class Program
    {
        static void Main(string[] args)
        {
            Raiz();
        }
        //PARTE 1
        //EJER1
        static void Convertidor_KFC()
        {
            double cont=0;
            string opc;           
                Console.WriteLine("\t\t PROGRAMA PARA CONVERTIR TEMPERATURAS");
                Console.WriteLine("\n Elige el tipo de conversion");
                Console.WriteLine("\nPresiona FC si quieres convertir Celsius a Fahrenheit");
                Console.WriteLine("Presiona FK si quieres convertir Kelvin a Fahrenheit");
                Console.WriteLine("Presiona CF si quieres convertir Fahrenheit a Celsius");
                Console.WriteLine("Presiona CK si quieres convertir Kelvin a Celsius");
                Console.WriteLine("Presiona KF si quieres convertir Fahrenheit a Kelvin");
                Console.WriteLine("Presiona KC si quieres convertir Celsius a Kelvin");
            do
            {
                Console.WriteLine("\n\t\tElige una de las opciones:\n");
                opc = Console.ReadLine();
                cont = cont + 1;
                switch (opc)
                {
                    case "FC":
                    case "fc":
                        Faren_Celsius();
                        break;
                    case "FK":
                    case "fk":
                        Faren_Kelvin();
                        break;
                    case "CF":
                    case "cf":
                        Celsius_faren();
                        break;
                    case "CK":
                    case "ck":
                        Celsius_Kelvin();
                        break;
                    case "KF":
                    case "kf":
                        Kelvin_Faren();
                        break;
                    case "KC":
                    case "kc":
                        Kelvin_Celsius();
                        break;
                    default:
                        Console.WriteLine("Ha seleccionado una opcion incorrecta");
                        break;
                }
            } while (cont < 7);
            Console.ReadKey();
        }
        //Convertidores
        static void Faren_Celsius() 
        {
            double cel, far;
            Console.WriteLine("Escribir los Celsius que desea convertir:");
            cel = double.Parse(Console.ReadLine());
            far = (cel * 9 / 5) + 32;
            Console.WriteLine($"\n{cel} Celsius equivale en Fahrenheit a: {far}");
        }
        static void Faren_Kelvin()
        {
            double kel, far;
            Console.WriteLine("Escribir los Kelvin que desea convertir:");
            kel = double.Parse(Console.ReadLine());
            far = (kel-273.15)*9/5 + 32;
            Console.WriteLine($"\n{kel} Kelvin equivale en Fahrenheit a: {far}");
        }
        static void Celsius_faren()
        {
            double cel, far;
            Console.WriteLine("Escribir los Fahrenheit que desea convertir:");
            far = double.Parse(Console.ReadLine());
            cel = (far - 32) * 5 / 9;
            Console.WriteLine($"\n{far} Fahrenheit equivale en Celsius a: {cel}");

        }
        static void Celsius_Kelvin()
        {
            double cel,kel;
            Console.WriteLine("Escribir los Kelvin que desea convertir:");
            kel = double.Parse(Console.ReadLine());
            cel = kel - 273.15;
            Console.WriteLine($"\n{kel} Kelvin equivale en Celsius a: {cel}");

        }
        static void Kelvin_Celsius()
        {
            double cel, kel;
            Console.WriteLine("Escribir los Celsius que desea convertir:");
            cel = double.Parse(Console.ReadLine());
            kel = cel + 273.15;
            Console.WriteLine($"\n{cel} Celsius equivale en Kelvin a: {kel}");          
        }
        static void Kelvin_Faren()
        {
            double kel, far;
            Console.WriteLine("Escribir los Fahrenheit que desea convertir:");
            far = double.Parse(Console.ReadLine());
            kel = (far-32)*5/9+273.15;
            Console.WriteLine($"\n{far} Fahrenheit equivale en Kelvin a: {kel}");
        }

        //EJER2
        static void edad()
        {
            int añoNac, edad;
            Console.WriteLine("Introduzca el año en el que nacio:");
            añoNac = int.Parse(Console.ReadLine());
            edad = Calculador(añoNac);
            Console.WriteLine($"\nSu edad actual es: {edad} años");
            Console.ReadKey();
        }
        static int Calculador(int x)
        {
            int edad = 0;
            edad = 2021 - x;
            return edad;
        }

        //EJER3
        static void menu()
        {
            string opc;
            do
            {
                Console.WriteLine("\t\t MENU DE FORMULAS");
                Console.WriteLine("\na)Dividir");
                Console.WriteLine("b)Obtener Cubo");
                Console.WriteLine("c)Calcular IMC");
                Console.WriteLine("d)Salir");
                Console.WriteLine("\n\t Eliga una opcion entre <a..d>\n");
                opc = Console.ReadLine();
                switch (opc)
                {
                    case "A":
                    case "a":
                        Dividir();
                        break;
                    case "B":
                    case "b":
                        double num, potencia;
                        Console.WriteLine("Escribe el numero que se elevara al cubo:");
                        num = double.Parse(Console.ReadLine());
                        potencia = Elevacion(num);
                        Console.WriteLine($"El numero {num} elevado al cubo es: {potencia}");
                        break;
                    case "C":
                    case "c":
                        IMC();
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine($"Usted salio del programa");
                        break;
                    default:
                        Console.WriteLine("Usted digito una opcion incorrecta");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opc != "d");
        }
        static void Dividir()
        {
            double x1, x2, division = 0;
            Console.WriteLine("Digite los dos numeros que desea dividir");
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            if (x2 == 0)
            {
                Console.WriteLine("No es posible dividir un numero entre 0");
            }
            else
            {
                division = x1 / x2;
                Console.WriteLine($"La division da como resultado {division}");
            }
        }
        static double Elevacion(double x)
        {
            double cubo;
            cubo = Math.Pow(x, 3);
            return cubo;
        }
        static void IMC()
        {
            Double peso, resultado, altura;
            Console.WriteLine("Digite su peso en kilogramos");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite su altura en metros");
            altura = double.Parse(Console.ReadLine());
            resultado = peso / (altura * altura);
            Console.WriteLine($"Su indice de masa corporal es {resultado}");
        }


        //G1_Ejemplo_01:
        static void EJER1()
        {
            Console.Title = "Ejercicio Potencia con Funciones";
            Double x;
            //Se invocca la Funcion
            for (x = 1; x <= 10; x++)
            {
                Console.WriteLine($"El cuadrado de {x} es {Potencia(x)}");
            }
            Console.ReadKey();
        }
        //Protipo De Funcion
        static Double Potencia(Double x)
        {
            return x * x;
        }

        //G1_Ejemplo_02:
        static void Raiz()
        {
            Console.WriteLine("Calculo Raices:");
            for (int i = 1; i<= 10; i++)
            {
                Console.WriteLine($"La Raiz cuadrada de el numero {i} es igual a {Math.Sqrt(i)}");
            }
            Console.ReadKey();
        }

        //G1_Ejemplo_03: Es el que esta arriba el EJER1

    }
}
