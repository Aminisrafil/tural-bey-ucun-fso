using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilmis sozun ilk herifinin A olub olmamaisini yoxlayan proqram yazin

            //var soz = Console.ReadLine();
            //int i = 0;
            //if (soz[i] == 'A')
            //{
            //    Console.WriteLine("soz A ile basliyir");
            //}
            //else
            //{
            //    Console.WriteLine("soz A ile baslamir");
            //}
            //var soz = Console.ReadLine();
            //var hasA = false;

            //for (int i = 0; i < soz.Length; i++)
            //{
            //    if (soz[i] == 'b' || soz[i] == 'B')
            //    {
            //        hasA = true;
            //        break;
            //    }
            //}
            //if (hasA)
            //{
            //    Console.WriteLine("sozde b herfi var");
            //}
            //else
            //{
            //    Console.WriteLine("sozde b herfi yoxdu");
            //}
            //Isdifadeci eded daxil edir. Daxil edilen ededin musbet olmalidir ve 7 ile 3ce bolunub bolunmemesini yoxla
            //var numbers = Console.ReadLine();
            //var num = Convert.ToInt32(numbers);

            //if (num > 0)
            //{
            //    if (num % 21 == 0)
            //    {
            //        Console.WriteLine("eded 3e ve 7e tam bolunur");
            //    }
            //    else
            //    {
            //        Console.WriteLine("eded 21e tam bolunmur");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("sehvdi, eded musbet olmalidir ay qardas");
            //}
            //Verilmis 4 eded icerisinde necesinin 3 - e tambolunduyunu tapan alqoritm
            //var num1 = Console.ReadLine();
            //var Num1 = Convert.ToInt32(num1);
            //var num2 = Console.ReadLine();
            //var Num2 = Convert.ToInt32(num2);
            //var num3 = Console.ReadLine();
            //var Num3 = Convert.ToInt32(num3);
            //var num4 = Console.ReadLine();
            //var Num4 = Convert.ToInt32(num4);
            //var counter = 0;

            //if (Num1 % 3 ==0)
            //{
            //    counter++;
            //}
            // if (Num2 % 3 == 0)
            //{
            //    counter++;
            //}
            // if (Num3 % 3 == 0)
            //{
            //    counter++;
            //}
            // if (Num4 % 3 == 0)
            //{
            //    counter++;

            //}

            //Console.WriteLine(counter);

            //Istenilen 4 ededin musbetlerinin hasilini ve menfilerin cemini tapan
            //var num1 = Console.ReadLine();
            //var Num1 = Convert.ToInt32(num1);
            //var num2 = Console.ReadLine();
            //var Num2 = Convert.ToInt32(num2);
            //var num3 = Console.ReadLine();
            //var Num3 = Convert.ToInt32(num3);
            //var num4 = Console.ReadLine();
            //var Num4 = Convert.ToInt32(num4);
            //var count = 1;
            //var sum = 0;

            //if (Num1 > 0)
            //{
            //    count *= Num1;
            //}
            //else
            //{
            //    sum += Num1;
            //}
            //if (Num2 > 0)
            //{
            //    count *= Num2;
            //}
            //else
            //{
            //    sum += Num2;
            //}
            //if (Num3 > 0)
            //{
            //    count *= Num3;
            //}
            //else 
            //{
            //    sum += Num3;
            //}
            //if (Num4 > 0)
            //{
            //    count *= Num4;
            //}
            //else 
            //{
            //    sum += Num4;
            //}
            //if (count == 1)
            //{
            //    Console.WriteLine(sum);
            //}
            //else
            //{
            //    Console.WriteLine(sum);
            //    Console.WriteLine(count);
            //}
            //Verilmis arraydaki ededlerin cutlerin cemini ve teklerinin hasili tapan proqram yazin
            int[] array = new int[] { 0, 1, 2, 98, 4, 5, 6, 7, 43, 9 };
            var sum = 0;
            var count = 1;


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
                else if (array[i] % 2 != 0)
                {
                    count *= array[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(count);










        }
    }
}
