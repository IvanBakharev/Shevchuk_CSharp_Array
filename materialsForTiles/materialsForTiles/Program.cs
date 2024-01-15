using System;

namespace RawMaterialPlanning
{

    class Program
    {  
        static void Main(string[] args)
        {
            int numberOfTipesOfTile, numberOfTypesOfMaterials;
            {
                Console.WriteLine("Введите кличество разновидностей плитки:");
                numberOfTipesOfTile = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите количество видов сырья для изготовления плитки:");
                numberOfTypesOfMaterials = int.Parse(Console.ReadLine());
            }
            decimal[,] A = new decimal[numberOfTipesOfTile, numberOfTypesOfMaterials];
           
            decimal[,] B = new decimal[numberOfTypesOfMaterials, 1];
            
            decimal[] C = new decimal[numberOfTipesOfTile];

            decimal[,] Z = new decimal[numberOfTipesOfTile, 1];

            for (int i  = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"Введите количество сырья № {j + 1} для плитки № {i + 1} (кг.):");
                    A[i, j] = Convert.ToDecimal(Console.ReadLine());
                }
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                Console.Write($"Введите цену сырья № {i + 1} (руб.): ");
                B[i, 0] = Convert.ToDecimal(Console.ReadLine());
            }
            
            for (int i = 0; i < C.Length; i++)
            {
                Console.Write($"Введите планируемый объем выпуска плитки № {i + 1} (в штукаках.):");
                C[i] = Convert.ToDecimal(Console.ReadLine());
            }

            // Z CalculateTotalCostOfMaterials (A, B, C, Z)
            {
                for (int i = 0; i < A.GetLongLength(0); i++)
                {
                    for (int j = 0; j < A.GetLongLength(1); j++)
                    {
                        Z[i, 0] += A[i, j] * B[j, 0];
                    }
                }

                decimal P = 0;

                for (int i = 0; i < Z.GetLength(0); i++)
                {
                    P += C[i] * Z[i, 0];
                }

                Console.WriteLine($"Общая стоимость сырья = {P}");

            }





        }
    }
}
