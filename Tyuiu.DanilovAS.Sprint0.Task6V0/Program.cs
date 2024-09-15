using System.ComponentModel;
using Tyuiu.DanilovAS.Sprint0.Task6V0.Lib;

namespace Tyuiu.DanilovAS.Sprint0.Task6V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arraynums));
            Console.WriteLine("Разность элементов массива = " + DataService.SubtrationArray(arraynums));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(arraynums));
            Console.ReadKey();
        }
    }
}
