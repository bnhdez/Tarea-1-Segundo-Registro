using System;

namespace Tarea_1__Boris_Hernandez_
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario tendra un saldo de $100 en su cuenta
            float saldo;
            saldo = 100;

            //usuario: user00 contra: contra123
            int r;
            string pass, user;

            do
            {
                Console.Write("DIGITE USUARIO: "); user = Console.ReadLine();
                Console.Write("DIGITE CLAVE: "); pass = Console.ReadLine();
                r = contraseña(pass, user);
            //aumentara el numero de intentos si no es correcta la contraseña
            } while (r == 0);

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
                // Pedimos los valores
                Console.WriteLine("Ingrese la cantidad de dinero que depositara: ");
                a = float.Parse(Console.ReadLine());
                // Invocamos el resultado
                Deposito(a, saldo);
            }
            // Checamos por el retiro
            if (opcion == 2)
            {
                // Variables necesarias
                float a = 0;
                // Pedimos los valores
                Console.WriteLine("Ingrese la cantidad de dinero que Retirara: ");
                a = float.Parse(Console.ReadLine());
                // Invocamos el resultado
                Retiro(saldo,a);
            }
            // Checamos por la consulta de saldo
            if (opcion == 3)
            {
                Consulta(saldo);
            }
            // Checamos por el cambio de contraseña
            if (opcion == 4)
            {
                // Variables necesarias
                string nueva_pass;
                // Pedimos los valores
                Console.WriteLine("Ingrese su nueva contraseña: ");
                nueva_pass = Console.ReadLine();
                // Invocamos el resultado
                Cambio(pass,nueva_pass);
            }

            //*********************************METODOS*****************************************************

            static int contraseña(string V_pass, string V_user)
            {
                int verif;
                    if ((V_pass == "contra123") && (V_user == "user00"))
                    {
                        Console.WriteLine("BIENVENIDO ");
                        Console.WriteLine();
                        verif = 1;
                    }
                    else
                    {
                        Console.WriteLine("USUARIO O CONTRASEÑA INCORRECTOS");
                        Console.WriteLine();
                        verif = 0;
                    }
                return verif;
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

            static void Consulta(float dinero)
            {
                float resultado;
                resultado = dinero + 0;
                Console.WriteLine("Su saldo es de: " + resultado);
            }

            static void Cambio(string contra, string nueva)
            {
                contra = nueva;
                Console.WriteLine("su nueva contraseña es: " + contra);
            }
        }
    }
}
