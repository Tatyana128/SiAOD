using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__2.Folder
{
     class Chess
     {
        private static  int Size = 8;
        private static int[,] ChessField = new int[Size,Size];
        private static int QuantityFerz = 7;

        private void CreateChessField()
        {
            for(int i = 0; i < Size; i++)
            {
                for (int j= 0; j < Size; j++)
                {
                    ChessField[i, j] = 0;
                }
            }
        }

        private bool Prov(int indexX,int indexY)
        {
            if (indexX > 7 || indexX < 0 || indexY > 7 || indexY < 0)
                return false;
            else return true;

        }

        private void AddFerz(int indexX,int indexY)
        {
            for (int i = 0; i < Size; i++)
            {
                if (i != indexX)
                {
                    ChessField[i, indexY] = 2;
                }
            }

            for (int j = 0; j < Size; j++)
            {
                if (j != indexY)
                {
                    ChessField[indexX, j] = 2;
                }
            }

            int indexX1 = indexX;
            int indexY1 = indexY;


            for (int i = indexX1 + 1; i < Size; i++)
            {
                if (Prov(i, indexY1 + 1))
                    ChessField[i, indexY1 = indexY1 + 1] = 2;
                else break;
            }

            indexX1 = indexX;
            indexY1 = indexY;

            for (int i = indexX1-1 ; i >=0; i--)
            {
                indexY1 = indexY1 - 1;
                if (Prov(i, indexY1)){
                    
                    ChessField[i, indexY1 ] = 2;
                    
                }
                else break;
            }

            indexX1 = indexX;
            indexY1 = indexY;

            for (int i = indexY1 - 1; i >= 0; i--)
            {
                indexX1 = indexX1 + 1;
                if (Prov(indexX1, i))
                {

                    ChessField[indexX1, i] = 2;

                }
                else break;
            }

            indexX1 = indexX;
            indexY1 = indexY;


            for (int i = indexY1 + 1; i < Size; i++)
            {
                indexX1 = indexX1 - 1;
                if (Prov(indexX1, i))
                {
                    ChessField[indexX1, i] = 2;
                } 
                else break;
            }

        }

        private void PrintMatrix()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write(ChessField[i, j] + " ");
                }
                Console.Write("\r\n");
            }
        }


        private bool FindPlace()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                   if (ChessField[i, j] == 0)
                   {
                        ChessField[i, j] = 1;
                        AddFerz(i, j);
                        return true;
                   }
                }
            }
            return false;
        }

        private void DelateTwo()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (ChessField[i, j] == 2)
                    {
                        ChessField[i, j] = 0;
                    }
                }
            }
        }

        public void Arrange()
        {
            
            while (true)
            {
                CreateChessField();
                Random rand = new Random();
                int indexX = rand.Next(0, 8);
                int indexY = rand.Next(0, 8);

                ChessField[indexX, indexY] = 1;
                AddFerz(indexX, indexY);

                int count = 0;

                for(int i = 0; i < QuantityFerz; i++)
                {
                    count++;
                    if (!FindPlace()) break;
                }

                if (count == QuantityFerz) break;
            }
            DelateTwo();
            PrintMatrix();
        }
     }
}
