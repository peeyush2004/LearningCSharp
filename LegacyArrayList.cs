using System.Collections;

namespace LegacyArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList myArrayList1 = new ArrayList();
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList1.Add(345);
            myArrayList1.Add("Hello");
            myArrayList1.Add(67.89);
            myArrayList1.Add(54);
            myArrayList1.Add('A');
            myArrayList1.Add(78);
            myArrayList1.Add(5);
            myArrayList1.Add(74.89);

            myArrayList1.Remove(67.89);
            myArrayList1.RemoveAt(2);// index wise removal

            Console.WriteLine(myArrayList1.Count);

            double sum = 0;

            foreach (object obj in myArrayList1)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else
                {
                    if (obj is string)
                    {
                        Console.WriteLine(obj);
                    }
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
