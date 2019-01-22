using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Groups
{
    class Program
    {

        static void Main(string[] args)
        {

            List<string> group1 = new List<string>();
            List<string> group2 = new List<string>();
            List<string> group3 = new List<string>();
            List<string> group4 = new List<string>();

            Console.WriteLine("Kisi Sayisini Giriniz");
            int n = Convert.ToInt32(Console.ReadLine());

            List<string> persons = new List<string>();

            Console.WriteLine("Kisileri Giriniz:");

            for (int i = 0; i < n; i++)
            {
                Console.Write((i+1).ToString() + ". Kisi: ");
                persons.Add(Console.ReadLine().ToString());
            }

            persons.ForEach(i => Console.Write("{0}\t", i));

            n = persons.Capacity;

            Random rnd = new Random();

            while (n > 0)
            {
                if (persons.Count == 0)
                {
                    break;
                }
                else
                {
                    int i1 = rnd.Next(0, persons.Count - 1);
                    group1.Add(persons[i1]);
                    persons.RemoveAt(i1);
                }
                

                if (persons.Count == 0)
                {
                    break;
                }
                else
                {
                    int i2 = rnd.Next(0, persons.Count - 1);
                    group2.Add(persons[i2]);
                    persons.RemoveAt(i2);
                }

                if(persons.Count == 0)
                {
                    break;
                }
                else
                {
                    int i3 = rnd.Next(0, persons.Count - 1);
                    group3.Add(persons[i3]);
                    persons.RemoveAt(i3);
                }

                if (persons.Count == 0)
                {
                    break;
                }
                else
                {
                    int i4 = rnd.Next(0, persons.Count - 1);
                    group4.Add(persons[i4]);
                    persons.RemoveAt(i4);
                }
                
                n -= 4;
            }

            Console.WriteLine();
            Console.Write("Group1: ");
            group1.ForEach(i => Console.Write("{0}\t", i));

            Console.WriteLine();
            Console.Write("Group2: ");
            group2.ForEach(i => Console.Write("{0}\t", i));

            Console.WriteLine();
            Console.Write("Group3: ");
            group3.ForEach(i => Console.Write("{0}\t", i));

            Console.WriteLine();
            Console.Write("Group4: ");
            group4.ForEach(i => Console.Write("{0}\t", i));

            Console.ReadLine();
        }
    }
}
