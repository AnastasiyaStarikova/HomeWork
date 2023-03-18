// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

var array = new int[] { 1, 2, 3, 5, 4 };
int max = 0;
int max1 = 0;
for (var i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array [i] > max1 )
    {
        max1 = array[i];
        max1 = i; 
    }
   

}
Console.WriteLine(max);
Console.WriteLine(max1);

