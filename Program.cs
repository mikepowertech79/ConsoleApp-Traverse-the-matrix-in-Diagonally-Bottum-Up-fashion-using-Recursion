using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Traverse_the_matrix_in_Diagonally_Bottum_Up_fashion_using_Recursion
{

        class GFG
        {
            //SOURCE https://www.geeksforgeeks.org/traverse-the-matrix-in-diagonally-bottum-up-fashion-using-recursion/

            // Static variable for changing
            // row and coloumn
            static int k1 = 0, k2 = 0;

            // Flag variable for handling
            // bottum up diagonal traversing
            static bool flag = true;

            // Recursive function to traverse the
            // matrix diagonally bottom-up
            static bool traverseMatrixDiagonally(int[,] m, int i, int j, int row, int col)  //  traverseMatrixDiagonally(mtrx, 0, 0, 5, 5);
            {
                


                // Base Condition
                if (i >= row || j >= col)
                {

                    // Condition when to traverse
                    // Bottom Diagonal of the matrix
                    if (flag)
                    {
                        int a = k1;
                        k1 = k2;
                        k2 = a;
                        flag = !flag;
                        k1++;
                    }
                    else
                    {
                        int a = k1;
                        k1 = k2;
                        k2 = a;
                        flag = !flag;
                    }

                    
                    
                    Console.WriteLine();
                    Console.ReadKey();
                    return false;
                }

                // Print matrix cell value
                Console.Write(m[i, j] + " ");

            


                // Recursive function to traverse
                // The matrix diagonally
                if (traverseMatrixDiagonally(m, i + 1, j + 1, row, col))
                {
                    return true;
                }

                // Recursive function 
                // to change diagonal
                if (traverseMatrixDiagonally(m, k1, k2, row, col))
                {
                    return true;
                }




                int[,] matrix = new int[10, 10];

                for (i = 0; i < m.GetUpperBound(0); i++)
                {

                    for (j = 0; j < m.GetUpperBound(1); j++)
                    {

                        matrix[i, j] = m[i, j];
                    }
                }
                //ok
                return true;
        }



        // Driver Code
        public static void Main(String[] args)
            {

                // Intialize the 5 x 5 matrix
                int[,] mtrx = {

                    //{ 01, 02, 03, 04, 05 },
                    //{ 06, 07, 08, 09, 10 },
                    //{ 11, 12, 13, 14, 15 },
                    //{ 16, 17, 18, 19, 20 },
                    //{ 21, 22, 23, 24, 25 }


                    { 01, 10, 17, 22, 25 },
                    { 06, 02, 11, 18, 23 },
                    { 14, 07, 03, 12, 19 },
                    { 20, 15, 08, 04, 13 },
                    { 24, 21, 16, 09, 05 }





                };


                // Function call for  
                // traversing matrix
                traverseMatrixDiagonally(mtrx, 0, 0, 5, 5);


                
            }
        }

}
