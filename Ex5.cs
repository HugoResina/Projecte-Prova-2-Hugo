using System;
public class Program
{
    public static void Main()
    {
        const string InsertToLook = "Insereix un numero per veure si esta dins de la llista:"
        int[] nums = new int[20];

        for (int i = 0; i < nums.Length; i++)
        {
            string InsertNum = $"inserta el numero per la posició {i}";
            Console.WriteLine(InsertNum);
            nums[i] = int.Parse(Console.ReadLine());
        }
        BubbleSort(ref nums);
        Console.WriteLine();
        foreach (int i in nums)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine(InsertToLook);
        FindNum(nums, int.Parse(Console.ReadLine()));


    }
    public static void BubbleSort(ref int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[j])
                {
                    int aux = arr[i];
                    arr[i] = arr[j];
                    arr[j] = aux;

                }

            }
        }
    }
    public static void SwitchNums(int[] arr, int num1, int num2)
    {
        int aux = arr[num1];
        arr[num1] = arr[num2];
        arr[num2] = aux;
    }
    public static void FindNum(int[] arr, int find)
    {
        console.WriteLine(arr.Contains(find) ? "el numero es troba a dins" : "el numero no es troba a dins");
    }
}