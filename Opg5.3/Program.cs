// See https://aka.ms/new-console-template for more information

using System.Runtime.Serialization;
using Opg5._3;

class App
{
    static void Main(String[] args)
    {
        Exercise5x3();
    }

    public static void Exercise5x3()
    {
        List<Person> persons1 = new List<Person>();
        try
        {
            persons1 = Person.ReadCSVFile(@"/Users/rasmusjerlov/Downloads/csvFiler/data1.csv");
            Console.WriteLine("IEnumerable, score less than 2");
            IEnumerable<Person> resultPersoner = persons1.Where(p => p.Score < 2);
            foreach (Person p in resultPersoner)
            {
                Console.WriteLine(p.Name + ", Score: " + p.Score);
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("IEnumerable, score is an even number");
            IEnumerable<Person> resultPersoner2 = persons1.Where(p => p.Score % 2 == 0);
            foreach (Person p in resultPersoner2)
            {
                Console.WriteLine(p.Name + ", Score: " + p.Score);
            }
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("IEnumerable, score is an even number and weight is above 60");
            IEnumerable<Person> resultPersoner3 = persons1.Where(p => p.Score % 2 == 0 && p.Weight > 60);
            foreach (Person p in resultPersoner3)
            {
                Console.WriteLine(p.Name + ", Score: " + p.Score + ", Weight: " + p.Weight);
            }
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("IEnumerable, weight is divisible by 3");
            IEnumerable<Person> resultPersoner4 = persons1.Where(p => p.Weight % 3 == 0);
            foreach (Person p in resultPersoner4)
            {
                Console.WriteLine(p.Name + ", Weight: " + p.Weight);
            }
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("First Index with a person with a score of 3");
            int indexPersoner1 = persons1.FindIndex(p => p.Score == 3);
            Console.WriteLine("Index: " + indexPersoner1);
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("First Index with a person with an age less than 10 and a score of 3");
            int indexPersoner2 = persons1.FindIndex(p => p.Age < 10 && p.Score == 3);
            Console.WriteLine("Index: "+ indexPersoner2);
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Count of people with an age less than 10 and a score of 3");
            List<Person> resultPersoner5 = persons1.FindAll(p => p.Age < 10 && p.Score == 3);
            Console.WriteLine(resultPersoner5.Count());
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Index of the first person with an age less that 8 and a score of 3");
            int indexPersoner3 = persons1.FindIndex(p => p.Age < 8 && p.Score == 3);
            Console.WriteLine(indexPersoner3);
            //Returner -1, dvs. at der ikke findes en person med en alder under 8 og en score lig 3.

            persons1.Sort(new SortByAge(true));
            foreach (Person p in persons1)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("-----------------------------------------");
            persons1.Sort(new SortByAge(false));
            foreach (Person p in persons1)
            {
                Console.WriteLine(p.ToString());
            }
            
            persons1.SetAccepted(p => p.Score >= 6 && p.Age <= 40);
            foreach (Person p in persons1)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("Ascending----------------------------------------------");
            var s = from p in persons1
                orderby p.Score ascending 
                select p.Name + p.Score;

            foreach (var str in s)
            {
                Console.WriteLine(str);
            }
            
            Console.WriteLine("Descending----------------------------------------------");

            var s1 = from p in persons1
                orderby p.Score descending
                select p.Name;
            foreach (var str in s1)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("ØVELSE 5.8");
            int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 10 };

            var s3 = from n in numbers
                where n.ToString().Length == 2
                orderby n ascending 
                select n;
            
            foreach (int n in s3)
            {
                Console.WriteLine(n);
            }

            var s4 = from n in numbers
                where n.ToString().Length == 2
                orderby n descending
                select n;

            foreach (int n in s4)
            {
                Console.WriteLine(n);
            }

            var s5 = from n in numbers
                where n.ToString().Length == 2
                orderby n ascending
                select "\"" + n.ToString() + "\"" + " is " + (n % 2 == 0 ? "even" : "odd");

            foreach (String n in s5)
            {
                Console.WriteLine(n);
            }
            
            persons1.Reset();
            Console.WriteLine(persons1[0].ToString());

            Console.WriteLine("ØVELSE 5.10-------------------------------");
            Random rnd = new Random();
            List<int> integers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                integers.Add(rnd.Next(50));
            }

            foreach (int n in integers)
            {
                Console.WriteLine(n);
            }

            IEnumerable<int> resultInts = integers.FindAll(i => i % 2 == 1);
            int unevenCount = resultInts.Count();
            Console.WriteLine("Amount of uneven: " + unevenCount);
            
            IEnumerable<int> resultInts2 = integers.Distinct();
            foreach (int n in resultInts2)
            {
                Console.WriteLine("Distinct number: " + n);
            }

            List<int> intList = resultInts.ToList();
            List<int> intListRes = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                intListRes.Add(intList[i]);
            }
            


        }
        
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
            
        }
    }
}