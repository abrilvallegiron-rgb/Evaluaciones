using System;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1. 
            /*
            tipo_de_dato_devuelto identificador_funcion(parametros)
            {
               Bloque de instrucciones
            }
            identificador_funcion(argumentos);
            */

            //2.
            int secuencia=2;
            while(secuencia<=6)
            {
                if(secuencia==6)
                {
                    Console.WriteLine(secuencia);
                    secuencia+=3;
                
                    while(secuencia==12)
                     {
                        Console.WriteLine(secuencia);
                        secuencia+=4;
                        if(secuencia==27)
                        {
                            break;
                        }
                     }
                }
                Console.WriteLine(secuencia);
                secuencia+=2;
            }

            //3.
            int inicio=4;
            int limite=3;
            int suma=inicio+limite;
            while(suma>8)
            {
                if(suma>8)
                {
                    suma-=1;
                    Console.WriteLine(suma);
                }
                else
                {
                    suma+=1;
                    Console.WriteLine(suma);
                } 
                Console.WriteLine(suma);
                suma+=1;
            }

            //4. 




            
        }
    }
}
