using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] inputLines = File.ReadAllLines("input.txt");

        int n = int.Parse(inputLines[0]);
        int[] array = Array.ConvertAll(inputLines[1].Split(), int.Parse);
        int m = int.Parse(inputLines[2]);
        string movements = inputLines[3];

        var results = ProcessMovements(n, array, m, movements);

        File.WriteAllLines("output.txt", results);
    }

    static string[] ProcessMovements(int n, int[] array, int m, string movements)
    {
        int l = 0; 
        int r = 0; 
        string[] results = new string[m];

        for (int i = 0; i < m; i++)
        {
            char move = movements[i];

            if (move == 'R')
            {
                r++;
                if (r >= n) r = n - 1; 
            }
            else if (move == 'L')
            {
                l++;
                if (l >= n) l = n - 1; 
            }

            int maxValue = Math.Max(array[l], array[r]);
            results[i] = maxValue.ToString();
        }

        return results;
    }
}
