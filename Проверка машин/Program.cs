using System;
using System.Collections.Generic;
using System.IO;

namespace Проверка_машин
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listMachin = new List<string>();
            listMachin.AddRange(File.ReadAllLines("Машины.txt"));

            while (true)
            {
                string newMachin = Console.ReadLine();

                for (int i = 0; i < listMachin.Count; i++)
                {
                    if (newMachin == listMachin[i])
                    {
                        Console.WriteLine("Такая машину уже есть");
                        break;
                    }
                    else if (i == listMachin.Count - 1)
                    {
                        listMachin.Add(newMachin);
                        File.WriteAllLines("Машины.txt", listMachin);
                        break;
                    }
                }
            }
        }
    }
}
