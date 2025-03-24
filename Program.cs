using System;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ejercicio1
            /* int n;
            int contador;
            int contadorPrimos = 0;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                contador = 0;
                for (int y = 1;y <= n; y++)
                {
                    if(n % y == 0) {
                        contador++;
                    }
                }
                if(contador == 2) {
                    contadorPrimos++;
                }
            }
            Console.WriteLine("El total de números primos fue: " + contadorPrimos); */

            //ejercicio2
            /* int n, numerosImpares, contador, bandera = 0, porcentajeNumerosImpares = 0, grupoMayorImpar = 0, mayorPorcentaje = 0;
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                contador = 0;
                numerosImpares = 0;
                while (n != 0)
                {
                    contador++;
                    if(n % 2 != 0) {
                        numerosImpares++;
                    }

                    Console.WriteLine("Ingrese un número: ");
                    n = int.Parse(Console.ReadLine());
                }
                porcentajeNumerosImpares = (numerosImpares * 100) / contador;
                if(bandera == 0) {
                    grupoMayorImpar = (x + 1);
                    bandera = 1;
                } else if(porcentajeNumerosImpares > mayorPorcentaje) {
                    mayorPorcentaje = porcentajeNumerosImpares;
                    grupoMayorImpar = (x + 1);
                }
            }
            Console.WriteLine("El grupo con mayor porcentaje de números impares fue el: " + grupoMayorImpar); */


            //ejercicio2 revancha 
            /* int n; 
            int contadorImpares, contadorTotal;
            int porcentaje;
            int maximoImpar = 0;
            int grupoMaximo = 0;
            int bandera;
            int mayor;
            int grupoOrdenado = 0;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                mayor = n;

                contadorImpares = 0;
                contadorTotal = 0;
                bandera = 0;

                while (n != 0)
                {
                    contadorTotal++;
                    if (n % 2 != 0) {
                        contadorImpares++;
                    }

                    if(n < mayor) {
                        mayor = n;
                    } else {
                        bandera = 1;
                    }

                    Console.WriteLine("Ingrese un número: ");
                    n = int.Parse(Console.ReadLine());
                }

                porcentaje = contadorImpares * 100 / contadorTotal;
                if (porcentaje > maximoImpar) {
                    maximoImpar = porcentaje;
                    grupoMaximo = (x + 1);
                }

                if(bandera == 0) {
                    grupoOrdenado++;
                }
            }
            Console.WriteLine("El grupo con mayor porcentaje de números impares fue el: " + grupoMaximo);
            Console.WriteLine("La cantidad de grupos de forma ordenada decrecientemente es: " + grupoOrdenado); */


            //ejercicio2 con maxi
            /* int n;
            int contadorTotal;
            int conImpares;
            int grupoImparesMaximo = 0;
            int min;
            int gruposOrdenados = 0;
            double porcentajeImpares, maximoPorcentaje = 0;
            bool banderaOrdenados;

            for (int x = 0; x < 3; x++)
            {
                contadorTotal = 0;
                conImpares = 0;
                banderaOrdenados = true;
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                min = n;

                while (n != 0)
                {
                    contadorTotal++;

                    if(n % 2 != 0) {
                        conImpares++;
                    }

                    if(n <= min) {
                        min = n;
                    } else {
                        banderaOrdenados = false;
                    }

                    Console.WriteLine("Ingrese otro número: ");
                    n = int.Parse(Console.ReadLine());
                }//fin del while
                porcentajeImpares = conImpares * 100 / contadorTotal;
                if(porcentajeImpares >= maximoPorcentaje) {
                    maximoPorcentaje = porcentajeImpares;
                    grupoImparesMaximo = x+1;
                }

                if(banderaOrdenados == true) {
                    gruposOrdenados++;
                }

            }//fin del for

            Console.WriteLine("El grupo con mayor porcentaje de impares es el: " + grupoImparesMaximo);
            Console.WriteLine("La cantidad de grupos ordenados de forma decreciente es: " + gruposOrdenados); */


            //ejercicio3

            int n;
            int contador = 0;
            int numeroGrupo = 0;

            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());

            while (n >= 0)
            {
                numeroGrupo++;
                while (n > 0)
                {
                    contador++;

                    Console.WriteLine("Ingrese un número");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("El total de números del grupo " + numeroGrupo + " fue: " + contador);
                contador = 0;
            }

        }
    }
}
