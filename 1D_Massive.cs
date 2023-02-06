using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Lab3
{
    public class _1D_Massive
    {
        //field
        private int[] array;
        public int n { get; set; }
        public int[] GetElementFromArray()//for using array
        {
            return array;
        }
        public void SetElementFromArray(int[] array)
        {
            this.array = array;
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
       
        public _1D_Massive(int n)//constructor
        {
            array = new int[n];
            this.n = n;
        }

       
        public _1D_Massive(int[] array)
        {
            this.array = array;
            this.n = array.Length;
        }

        public void WriteArr(string name) //methode to fill array 
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Array {name}[{i + 1}]=");
                array[i] = int.Parse(Console.ReadLine());
            }

        }
        public void ShowArr() //methode to fill array
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"{array[i]}\t");
        }
        public static double Sum(params int[][] array) 
        {
            int Sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] < 0)
                    {
                        Sum = Sum + array[i][j];
                    }
                }

            }
            return Sum;
        }
        public static _1D_Massive operator !(_1D_Massive Tab)
        {
            _1D_Massive arrayNew = new _1D_Massive(Tab.GetElementFromArray().Length);
            int c = 0;
            for (int i = 0; i < Tab.GetElementFromArray().Length; i++)
            {
                if (Tab[i] > 0)
                {
                    arrayNew[c] = Tab[i] * (-1);
                }
                else
                {
                    arrayNew[c] = Math.Abs(Tab[i]);
                }
                c++;
            }
            return arrayNew;
        }

        public static _1D_Massive operator *(_1D_Massive tab1, int n)
        {
            for (int i = 0; i < tab1.array.Length; i++)
            {
                tab1[i] *= n;
            }
            return tab1;
        }
      
        public static _1D_Massive operator *(int n, _1D_Massive tab1)
        {
            for (int i = 0; i < tab1.array.Length; i++)
            {
                tab1[i] *= n;
            }
            return tab1;
        }
        public static float SumNeg2(int[] array)//Sum neg of Array A or B or C
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sum = sum + array[i];
                }
            }

            return sum;
        }
        
      

    }
}