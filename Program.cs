using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_17_01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string sizeStr;
                int sizeCnt;

                Console.WriteLine("\nВведите размер массива: ");
                sizeStr = Console.ReadLine();

                if (int.TryParse(sizeStr, out sizeCnt))
                {
                    OneDimensionArray oneDimensionArray = new OneDimensionArray(sizeCnt);
                    for(int i = 0; i < sizeCnt;)
                    {
                        int numberInt;
                        string numberStr;

                        Console.WriteLine($"Введите {i + 1} значение: ");
                        numberStr = Console.ReadLine();

                        if (int.TryParse(numberStr, out numberInt))
                        {
                            oneDimensionArray[i] = numberInt;
                            i++;
                        }
                        else { Console.WriteLine("Введены неправильные данные!"); }  
                    }
                    Console.WriteLine("Значения массива: ");
                    for(int i = 0; i < sizeCnt; i++)
                    {
                        Console.WriteLine($"{i + 1} : {oneDimensionArray[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("Введены неправильные данные!");
                }
            }
        }
    }
}
