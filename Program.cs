using System;
using System.Text;

namespace Csharp_Lab3
{
    internal class Program 
    {
        static void Main(string[] args) 

        {
            
            Console.WriteLine("Enter the size of array A:");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the size of array B:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the size of array C:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            _1D_Massive massiveA = new _1D_Massive(n1);
            _1D_Massive massiveB = new _1D_Massive(n2);
            _1D_Massive massiveC = new _1D_Massive(n3);
            while (true) 
            {
                Console.WriteLine("Input the Array A:");
                massiveA.WriteArr("A");
                Console.WriteLine("Output the Array A:");
                massiveA.ShowArr();
                Console.WriteLine("Input the Array B:");
                massiveB.WriteArr("B");
                Console.WriteLine("Output the Array B:");
                massiveB.ShowArr();
                Console.WriteLine("Input the Array C:");
                massiveC.WriteArr("C");
                Console.WriteLine("Output the Array C:");
                massiveC.ShowArr();
                Console.WriteLine("The sum of negative array's A elements");
                Console.WriteLine(_1D_Massive.Sum(massiveA.GetElementFromArray()));
                Console.WriteLine("The sum of negative array's B elements");
                Console.WriteLine(_1D_Massive.Sum(massiveB.GetElementFromArray()));
                Console.WriteLine("The sum of negative array's C elements");
                Console.WriteLine(_1D_Massive.Sum(massiveC.GetElementFromArray()));
                Console.WriteLine("Transform element of Array A");
                _1D_Massive multA = !(massiveA);
                multA.ShowArr();
                Console.WriteLine("Transform element of Array B");
                _1D_Massive multB = !(massiveB);
                multB.ShowArr();
                Console.WriteLine("Transform element of Array C");
                _1D_Massive multC = !(massiveC);
                multC.ShowArr();
                Console.WriteLine("A*5:");
                Console.WriteLine("------------");
                _1D_Massive multA_with_5 = (massiveA * 5);
                multA_with_5.ShowArr();
                Console.WriteLine("C*5:");
                Console.WriteLine("------------");
                _1D_Massive multC_with_5 = (massiveC * 5);
                multC_with_5.ShowArr();
                Console.Write("2*B:");
                Console.WriteLine("------------");
                _1D_Massive multB_with_2 = (2 * massiveC);
                multB_with_2.ShowArr();
                Console.Write("2*(-A):");
                Console.WriteLine("------------");
                _1D_Massive mult2_with_minusA = (massiveA*(-1) * 2);
                mult2_with_minusA.ShowArr();
                Console.WriteLine("C*4:");
                Console.WriteLine("------------");
                _1D_Massive multC_with_4 = (massiveC * 4);
                multB_with_2.ShowArr();
                double Sum1 = _1D_Massive.Sum(massiveA.GetElementFromArray());
                double Sum2 = _1D_Massive.Sum(massiveB.GetElementFromArray());
                if (Sum1 > Sum2)//if Sum of negative element's A are > B
                {

                    for(int i = 0; i < massiveA.n; i++) 
                    {
                       for (int j = 1; j < massiveA.n; j++) 
                        {
                            if (massiveA[i]<0 && massiveA[i]== massiveA[j]) 
                            {
                                massiveA[i] = Convert.ToInt32(Sum1);
                               
                            }
                        }
                    }
                    Console.WriteLine("Last Array");
                    massiveA.ShowArr();
                }
                
                else
                {
                    Console.WriteLine("The Sum1 is less than the Sum2");
                }
                break;
            }
            Console.ReadKey();
            Console.Clear();

        }
    }
}