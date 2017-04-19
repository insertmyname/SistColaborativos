using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Especificaciones
{
    public class HagaLaMultiplicacion
    {
        public double[,] RealizarLaOperacionMatematica(double[,] matriz1, double[,] matriz2)
        {
            int filasMatriz1, columnasMatriz1, columnasMatriz2, contador;
            double totalMultiplicacion, totalSuma;
            double[,] matrizTotalMultiplicacion;

            Console.WriteLine("Digite la cantidad de filas que desea para la matriz 1");
            filasMatriz1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite la cantidad de columnas que desea para la matriz 1");
            columnasMatriz1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La cantidad de filas que tendrá la matriz 2 es: " + columnasMatriz1);

            Console.WriteLine("Digite la cantidad de columnas que desea para la matriz 2");
            columnasMatriz2 = Convert.ToInt32(Console.ReadLine());

            contador = 1;
            totalSuma = 0;
            totalMultiplicacion = 0;

            matriz1 = new double[filasMatriz1, columnasMatriz1];
            matriz2 = new double[columnasMatriz1, columnasMatriz2];
            matrizTotalMultiplicacion = new double[filasMatriz1, columnasMatriz2];

            //Llenar la matriz 1 con numeros 
            Console.WriteLine("Digite el(los) numero(s) que desea agregar en la(s) fila(s) y columna(s) de la matriz 1");
            for (int i = 0; i < filasMatriz1; i++)
            {
                Console.WriteLine("Fila: " + contador);
                for (int j = 0; j < columnasMatriz1; j++)
                {
                    matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                contador++;
            }

            contador = 1;

            //Llenar la matriz 2 con numeros 
            Console.WriteLine("Digite el(los) numero(s) que desea agregar en la(s) fila(s) y columna(s) de la matriz 2");
            for (int i = 0; i < columnasMatriz1; i++)
            {
                Console.WriteLine("Fila: " + contador);
                for (int j = 0; j < columnasMatriz2; j++)
                {
                    matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                contador++;
            }

            //Ejecucion de la multiplicacion entre matriz 1 y matriz 2
            for (int i = 0; i < columnasMatriz2; i++)
            {
                for (int j = 0; j < filasMatriz1; j++)
                {
                    for (int c = 0; c < columnasMatriz1; c++)
                    {
                        totalMultiplicacion = matriz1[j, c] * matriz2[c, i];
                        totalSuma += totalMultiplicacion;
                    }
                    matrizTotalMultiplicacion[j, i] = totalSuma;
                    totalMultiplicacion = 0;
                    totalSuma = 0;
                }
            }

            //Demostracion de matriz 1
            Console.WriteLine("Matriz 1: ");
            for (int i = 0; i < filasMatriz1; i++)
            {
                for (int j = 0; j < columnasMatriz1; j++)
                {
                    Console.Write(matriz1[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Demostracion de matriz 2
            Console.WriteLine("Matriz 2: ");
            for (int i = 0; i < columnasMatriz1; i++)
            {
                for (int j = 0; j < columnasMatriz2; j++)
                {
                    Console.Write(matriz2[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Desmostracion de la matriz final de la multiplicacion
            Console.WriteLine("Multiplicacion entre matriz 1 y matriz 2: ");
            for (int i = 0; i < filasMatriz1; i++)
            {
                for (int j = 0; j < columnasMatriz2; j++)
                {
                    Console.Write(matrizTotalMultiplicacion[i, j] + " ");
                }
                Console.WriteLine();
            }

            return matrizTotalMultiplicacion;
        }
    }
}