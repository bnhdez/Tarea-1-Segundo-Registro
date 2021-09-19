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

        }
    }
}
