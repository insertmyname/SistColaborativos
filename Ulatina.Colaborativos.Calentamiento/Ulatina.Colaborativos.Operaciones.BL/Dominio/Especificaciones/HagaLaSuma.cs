using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Especificaciones
{
    public class HagaLaSuma
    {
        public double[,] RealizarLaOperacionMatematica(double[,] matriz1, double[,] matriz2)
        {

            int filas, columnas, contador;
            double[,] matrizTotalSuma;

            Console.WriteLine("Digite la cantidad de filas que desea para las dos matrices");
            filas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de columnas que desea para las dos matrices");
            columnas = Convert.ToInt32(Console.ReadLine());

            matriz1 = new double[filas, columnas];
            matriz2 = new double[filas, columnas];
            matrizTotalSuma = new double[filas, columnas];

            contador = 1;

            //Agregar numeros a la matriz 1
            Console.WriteLine("Digite el(los) numero(s) que desea agregar en la(s) fila(s) y columna(s) de la matriz 1");
            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine("Fila: " + contador);
                for (int j = 0; j < columnas; j++)
                {

                    matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                contador++;
            }

            contador = 1;

            //Agregar numeros a la matriz 2
            Console.WriteLine("Digite el o los numero(s) que desea agregar en la(s) fila(s) y columna(s) de la matriz 2");
            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine("Fila: " + contador);
                for (int j = 0; j < columnas; j++)
                {
                    matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                contador++;
            }

            //Ejecucion de la suma entre matriz 1 y matriz1
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrizTotalSuma[i, j] = matriz1[i, j] + matriz2[i, j];
                }

                Console.WriteLine();
            }

            //Demostracion de matriz 1
            Console.WriteLine("Matriz 1: ");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz1[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Demostracion de matriz 2
            Console.WriteLine("Matriz 2: ");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz2[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Desmostracion de la matriz final, de la suma
            Console.WriteLine("Suma entre matriz 1 y matriz 2: ");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matrizTotalSuma[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}