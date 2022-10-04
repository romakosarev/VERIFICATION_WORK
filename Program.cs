using System;
using static System.Console;
Clear();

string[] arr1 = {"hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};

string[][] res2 = new string[][] {arr1, arr2, arr3};


for (int i = 0; i < res2.Length; i++)
{
    Write("[");
    PrintArray(res2
[i]);
    Write("]");

    Write(" -> ");

    Write("[");
    int length_array = GetLengthArray(GetArrayLimitLength(res2
[i]));
    PrintArray(GetResArray(GetArrayLimitLength(res2
[i]), length_array));
    WriteLine("]");
}


string[] GetArrayLimitLength(string[] arr)
{
    string[] res = new string[arr.Length];
    int a = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            {
                res[a] = arr[i];
                a++;
            }
    }
    return res;
}


int GetLengthArray(string[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null) cnt++;
    }
    return cnt;
}


string[] GetResArray(string[] arr, int length)
{
    string[] res = new string[length];
    for (int i = 0; i < length; i++) 
    {
        res[i] = arr[i];
    }
    return res;
}


void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]}");
        if (i != arr.Length - 1) Write(", ");
    }
}