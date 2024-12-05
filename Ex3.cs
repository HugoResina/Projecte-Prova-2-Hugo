using System;
public class Program
{
    public static void Main()
    {
        const string InputDay = "insereix el dia a comprobar:";
        const string InputMonth = "insereix el mes a comprobar:";
        const string InputYear = "insereix l'any a comprobar:";
        int dia, mes, any;
        bool validat = false;
        Console.WriteLine(InputDay);
        dia = int.Parse(Console.ReadLine());
        Console.WriteLine(InputMonth);
        mes = int.Parse(Console.ReadLine());
        Console.WriteLine(InputYear);
        any = int.Parse(Console.ReadLine());

        Console.WriteLine(ValidateDate(dia, mes, any) ? "valid date" : "invalid date");

    }
    public static bool ValidateDate(int day, int month, int year)
    {
        if (month >= 1 && month <= 12)
        {
            if (month == 2)
            {
                if (year % 4 == 0)
                {
                    return day <= 29 && day >= 1;
                }
                else
                {
                    return day <= 28 && day >= 1;
                }
            }
            else
            {
                if (month % 2 == 1)
                {
                    return (day <= 31 && day >= 1);
                }
                else
                {
                    return (day <= 30 && day >= 1);

                }
            }
        }
        return false;

    }


}