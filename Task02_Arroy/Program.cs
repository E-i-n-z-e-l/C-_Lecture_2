int Max(int argument1, int argument2, int argument3)
{
    int max_result = argument1;
    if (argument2 > max_result) max_result = argument2;
    if (argument3 > max_result) max_result = argument3;
    return max_result;
}

int[] array = { 19, 28, 37, 46, 50, 64, 73, 28, 9 };

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);


