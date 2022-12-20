int[,] CreateRandom2dArray()
{
   Console.WriteLine("Please, enter number of rows: ");
   int rows = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Please, enter number of columns: ");
   int columns = Convert.ToInt32(Console.ReadLine());

   Console.WriteLine("Please, enter min value of an array: ");
   int minValue = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Please, enter max value of an array: ");
   int maxValue = Convert.ToInt32(Console.ReadLine());

   int[,] array = new int[rows, columns];

   for(int i = 0; i < rows; i++)
      for(int j = 0; j < columns; j++)
         array[i,j] = new Random().Next(minValue, maxValue+1);

   return array;
}


void Show2dArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
      for(int j = 0; j < array.GetLength(1); j++)
         Console.Write(array[i,j] + " ");
      Console.WriteLine();
   }
   Console.WriteLine();
}


//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

/*
int[,] CreateRandomSumArray()
{
   Console.WriteLine("Please, enter number of rows: ");
   int rows = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Please, enter number of columns: ");
   int columns = Convert.ToInt32(Console.ReadLine());

   int[,] array = new int[rows, columns];

   for(int i = 0; i < rows; i++)
      for(int j = 0; j < columns; j++)
         array[i,j] = i+j;

   return array;
}


int[,] myArray = CreateRandomSumArray();
Show2dArray(myArray);

*/


//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

/* void EvenIndex(int[,] array)
{

   for(int i = 0; i < array.GetLength(0); i++)
      for(int j = 0; j < array.GetLength(1); j++)
         if(i%2==0 && j%2==0)
            array[i,j] = array[i,j] * array[i,j];

}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
EvenIndex(myArray);
Show2dArray(myArray); */


//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


int SumOfMainDiag(int[,] array)
{
   int sum = 0;
   for(int i = 0; i < array.GetLength(0); i++)
      for(int j = 0; j < array.GetLength(1); j++)
         if(i==j)
            sum += array[i,j];
   return sum;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

int result = SumOfMainDiag(myArray);

Console.Write("The sum of main diagonal is: " + result);