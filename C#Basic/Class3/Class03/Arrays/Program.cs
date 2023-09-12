// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] stringArray = { "Dejan", "Bojan", "Vali aga" };
int[] intArrays = { 2,6,789};
Console.WriteLine(stringArray[2]);
Console.WriteLine($" stringArrays lenght { stringArray.Length}");
double[] doubleArray = { 2, 33.3, 44.6, 78, 258 };
doubleArray[4] = 7658; 
Console.WriteLine(doubleArray[4]);

//RESIZE

Array.Resize(ref doubleArray, 7);
doubleArray[5] = 55.9;
Console.WriteLine(doubleArray[5]);

//INDEX OF
int indexFound = Array.IndexOf(doubleArray, 44.6);
Console.Write("Index of 44.6: ");
Console.WriteLine(indexFound);

//Reverse

Console.WriteLine(doubleArray[0]);
Array.Reverse(doubleArray);
Console.WriteLine(doubleArray[0]);

string[] stringArray2 = { "Dejan", "Elena", "Teo", "Dame", "Ana" };
double[] doubleArray2 = { 2.2, 33.5, 88.5, 55.8, 60.9 };
char[] charArray2 = { '-', '+', '+', '/', '%' };
bool[] boolArray2 = { false, false, false, false, false, false, false };
int[][] arrayOfInts = new int[][]
{
    new int[] {2,5},
    new int[] {5,5},
    new int[] {6,21},
    new int[] {9,1},
    new int[] {10,1}
};
foreach(string arrays in stringArray2)
{
    Console.WriteLine(arrays);

}
