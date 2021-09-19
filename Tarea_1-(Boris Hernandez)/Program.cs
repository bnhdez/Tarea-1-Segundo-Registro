using System;

namespace Tarea_1__Boris_Hernandez_
{
    class Program
    {
        static void Main(string[] args)
        {
            //El usuario tendra 3 intentos
            //usuario: user00 contra: contra123
            contraseña();


            int opcion = 0;
            string valor = "";
            // Mostramos el menu
            Console.WriteLine("1-Deposito");
            Console.WriteLine("2-Retiro");
            Console.WriteLine("3-Consulta de saldo");
            Console.WriteLine("4-Cambio de contraseña");
            // Pedimos la opcion
            Console.WriteLine("Cual es tu opcion:");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            // Checamos por el deposito
            if (opcion == 1)
            {
                Deposito();
            }
            // Checamos por el retiro
            if (opcion == 2)
            {
                // Variable para nuestro resultado
                float resultado = 0;
                // Invocamos y obtenemos el resultado
                resultado = Retiro();
                // Mostramos el resultado
                Console.WriteLine("El resultado de la resta es {0}", resultado);
            }
            // Checamos por la consulta de saldo
            if (opcion == 3)
            {
                //variable para nuestro saldo
                float saldo = 0;
                //Invocamos y obtenemos el resultado
                saldo = Consulta();
                // Mostramos el saldo
                Console.WriteLine("Su saldo es de: " + saldo);
            }
            // Checamos por el cambio de contraseña
            if (opcion == 4)
            {
                Cambio();
            }

            static void contraseña()
            {
                int intentos = 0, verif = 0;
                string pass, user;
                do
                {
                    Console.Write("DIGITE USUARIO: "); user = Console.ReadLine();
                    Console.Write("DIGITE CLAVE: "); pass = Console.ReadLine();
                    if ((pass == "contra123") && (user == "user00"))
                    {
                        verif = 1;
                    }
                    else
                    {
                        intentos++;
                    }
                    //aumentara el numero de intentos si no es correcta la contraseña
                } while (((intentos < 3) & (verif == 0)));
                if (verif == 1)
                {
                    Console.WriteLine("BIENVENIDO ");
                }
                else
                {
                    Console.WriteLine("OPORTUNIDADES TERMINADAS");
                }
            }

            static void Deposito()
            {
                // Variables necesarias
                float a = 0;
                float b = 0;
                float r = 0;
                // Pedimos los valores
                b = 100;
                Console.WriteLine("Ingrese la cantidad de dinero que depositara: ");
                a = float.Parse(Console.ReadLine());
                // Calculamos el resultado
                r = a + b;
                // Mostramos el resultado
                Console.WriteLine("Su saldo es ahora de "+ r);
            }

            static float Retiro()
            {
                // Variables necesarias
                float a = 0;
                float b = 0;
                float r = 0;
                // Pedimos los valores
                b = 100;
                Console.WriteLine("Ingrese la cantidad de dinero que Retirara: ");
                a = float.Parse(Console.ReadLine());
                // Calculamos el resultado
                r = a - b;
                // Retornamos el resultado
                return r;
            }

            static float Consulta()
            {
                float a = 300;
                float s = 0;
                s = a + 0;
                return s;
            }

            static void Cambio()
            {
                string n_pass;
                
                Console.WriteLine("Ingrese su nueva contraseña: ");
                n_pass = Console.ReadLine();
            }
        }
    }
}
