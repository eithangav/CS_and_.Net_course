using System;


namespace B21_Ex02
{
    class Program
    {

        static void Main()
        {
            byte n = 5;
            //  Tournament turnament = new Tournament();
            byte drowingBoardSize = (byte)(n*4  + 2);
            string[,] drowingBoard = new string[drowingBoardSize, drowingBoardSize];

            byte countColNum = 3;
            byte countColSpace = 1;
            byte colNum = 1;

            byte countRowNum = 3;
            byte countRowSpace = 1;
            byte RowNum = 1;

            for (int i = 0; i < drowingBoardSize; i++)
            {
                for(int j = 0; j < drowingBoardSize; j++)
                {
                    if (i == 0 && j != 0)
                    {
                        if (j % 2 == 0)
                        {
                            drowingBoard[i, j] = "//";
                        }
                        else
                        {
                            if (j == countColSpace)
                            {
                                drowingBoard[i, j] = "|";
                                countColSpace += 4;
                            }
                            else if (j == countColNum)
                            {
                                drowingBoard[i, j] = colNum.ToString();
                                colNum += 2;
                                countColNum += 4;
                            }
                        }
                    } 
                    else if (i != 0 && j == 0)
                    {
                        if(i % 2 == 0)
                        {
                            drowingBoard[i, j] = "row";
                        }
                        else if(i % 2 == 1)
                        {
                            if(j == countRowSpace)
                            {
                                drowingBoard[i, j] = "=";
                                countRowSpace += 4;
                            }
                            else if (j == countRowNum)
                            {
                                drowingBoard[i, j] = RowNum.ToString();
                                RowNum += 2;
                                countRowSpace += 4;
                            } 
                        }
                    }
                    else
                    {
                        drowingBoard[i, j] = "_";
                    }
                }
            }

            for(int i = 0; i < drowingBoardSize; i++)
            {
                for(int j = 0; j < drowingBoardSize; j++)
                {
                    Console.Write(drowingBoard[i, j] + " ");
                }

                Console.WriteLine("\n");
            }
        }
    }
    
}
