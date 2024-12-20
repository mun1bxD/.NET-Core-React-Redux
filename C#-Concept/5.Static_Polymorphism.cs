using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Polymorphism_001
{
    public class Calcualtor
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Add(double x, double y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        public double Subtract(double x, double y)
        {
            return x - y;
        }
        public int Subtract(int []arr)
        {
            int result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result -= arr[i];
            }
            return result;
        }
        public int Multiply(int x, int y) { 
            return x * y;
        }
        public double Multiply(double x, double y) 
        {
            return x * y;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Calcualtor calculator = new Calcualtor();
            Console.WriteLine("Add (int): " + calculator.Add(5, 10));
            Console.WriteLine("Add (double): " + calculator.Add(5.5, 10.3));
            Console.WriteLine("Subtract (int): " + calculator.Subtract(10, 5));
            Console.WriteLine("Subtract (double): " + calculator.Subtract(10.5, 5.2));
            Console.WriteLine("Multiply (int): " + calculator.Multiply(4, 3));
            Console.WriteLine("Multiply (double): " + calculator.Multiply(3.5, 2.5));

            int[] intArray = { 10, 2, 3 };
            Console.WriteLine("Subtract (int array): " + calculator.Subtract(intArray)); // Should output: 5

            Console.ReadLine();
        
    }
    }
}
