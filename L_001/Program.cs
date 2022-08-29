/*string[,] table = new string[2,5];
// StringEmpty для инициалиации
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2]..
table[1,2] = "слово";

for(int rows = 0; rows < 2; rows++)
{
    for( int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}*/
int[,] matrix = new int[3,4];

void PrintArray (int[,] matr)
{ 
//                         количество строк
    for( int rows = 0; rows < matr.GetLength(0); rows++)
    {                            //    количество столбцов
        for( int colums = 0; colums < matr.GetLength(1); colums++)
        {
            Console.Write($"{matr[rows, colums]} ");
        }
    Console.WriteLine();
    }
}

void FillArray (int[,] matr)
{
    for( int i = 0; i < matr.GetLength(0); i++)
    {
        for( int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
