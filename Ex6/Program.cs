using System;
using System.Net.Http.Headers;
namespace ex6 {
    public class Program
    {
        public static void Main()
        {
            const string InputString = "Insereix una contrasenya per veure si es valida";
            string s = Console.ReadLine();
            Console.WriteLine(ValidateContrasenya(s) ? "contrasenya valida" : "contrasenya invalida");

        }
        public static bool ValidateContrasenya(string s)
        {
            return ValidLength(s) && ValidateFormat(s) && ValidateFirstLast(s);
        }
        public static bool ValidLength(string s)
        {
            int len = s.Length;
            return len > 5 && len < 10;
        }
        public static bool ValidateFormat(string s)
        {
            const string abecedari = "abcdefghijklmnopqrstuwyxz";
            int num = 0;
            foreach (char c in s)
            {

                if (!(int.TryParse(s, out num) || abecedari.Contains(c.ToString().ToLower())))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValidateFirstLast(string s)
        {
            int num = 0;
            return !(int.TryParse(s[0].ToString(), out num) || int.TryParse(s[s.Length].ToString(), out num));
        }
    }
}
    
