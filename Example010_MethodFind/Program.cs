using System;
int[] array = {25, 36, 65, 87, 32, 98, 101, 74, 32};

int n = array.Length;
int find = 32;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}
