using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_circular_rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array ");
            int size = int.Parse(Console.ReadLine());

            int[] arr=new int[size];
            Console.WriteLine("Enter elements in array ");
            for(int i=0;i<size;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter no of rotations ");
            int rotations=int.Parse(Console.ReadLine());

            rotations = rotations % size;
            for(int i=0;i<rotations;i++)
            {
                int temp = arr[0];
                for (int j = 0; j < size - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[size - 1] = temp;
            }
            foreach(int x in arr)
            {
                Console.Write(x+" ");
            }
            /*int[] arr = { 1, 2, 3, 4, 5 };
            int size=arr.Length;
            int temp;
            for(int i=arr.Length-1; i>0; i--)
            {
                temp = arr[arr.Length-1];
                arr[arr.Length - 1] = arr[i-1];
                arr[i-1] = temp;
            }
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }*/
        }
    }
}
