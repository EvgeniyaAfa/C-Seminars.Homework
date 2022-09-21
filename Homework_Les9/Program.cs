int[,,] CreateRandom3dArray(int rows, int columns, int sheet)
{
    int[,,] array = new int[rows, columns, sheet];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            int k = 0;
            while (k < sheet)
            {
                int number = new Random().Next(10, 100);
                if (FindNum(array, number)) continue;
                array[i, j, k] = number;
                k++;
            }
        }
    return array;

}

bool FindNum(int[,,] array, int number)
{
    bool find = false;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) find = true;

            }
    return find;


}

void ShowIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{ array[i, j, k]} ({ i},{ j},{ k})");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Input rows number: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns number: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input quantity of sheet: ");
int sheet = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,,] myarray = CreateRandom3dArray(rows, columns, sheet);
ShowIndex(myarray);




