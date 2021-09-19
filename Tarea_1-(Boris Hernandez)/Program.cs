using System;

namespace Tarea_1__Boris_Hernandez_
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario tendra un saldo de $100 en su cuenta
            float dinero;
            dinero = 100;
            
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
                // Variables necesarias
                float a = 0;
                float r = 0;
                // Pedimos los valores
                Console.WriteLine("Ingrese la cantidad de dinero que depositara: ");
                a = float.Parse(Console.ReadLine());
                // Invocamos el resultado
                Deposito(a, dinero);
            }
            // Checamos por el retiro
            if (opcion == 2)
            {
                // Variables necesarias
                float a = 0;
                float r = 0;
                // Pedimos los valores
                Console.WriteLine("Ingrese la cantidad de dinero que Retirara: ");
                a = float.Parse(Console.ReadLine());
                // Invocamos el resultado
                Retiro(dinero,a);
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

            static void Deposito(float ingreso, float existente)
            {
                // Variables necesarias
                float r = 0;
                // Calculamos el resultado
                r = ingreso + existente;
                // Mostramos el resultado
                Console.WriteLine("Su saldo es ahora de "+ r);
            }

            static void Retiro(float existente, float retiro)
            {
                // Variables necesarias
                float r = 0;
                // Calculamos el resultado
                r = existente - retiro;
                // Mostramos el resultado
                Console.WriteLine("Su saldo es ahora de " + r);
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
