// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[,] array = {
{1, 2, 3, 2},
{4, 3, 3, 5},
{7, 4, 2, 3},
{5, 4, 7, 5}
};
Console.WriteLine(DifferenceOfTwoDiagonal(array));
static int DifferenceOfTwoDiagonal(int[ , ] arr)
{
    int rightToLeftDiagonal = 0;
    int leftToRightDiagonal = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                leftToRightDiagonal += arr[i, j];
            }
            if ((i + j) == arr.GetLength(0) - 1)
            {
                rightToLeftDiagonal += arr[i, j];
            }
        }
    }
    int diff = Math.Abs(rightToLeftDiagonal - leftToRightDiagonal);
    return diff;
}