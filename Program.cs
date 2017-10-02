using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresBasics
{

    class Program
    {
        //create random class
        public static Random random = new Random();

        //generate randomName class using random
        public static string randomName()
        {
            string[] names = new string[8] { "Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher" };
            int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
            return names[randomIndex];
        }

        //generate randomNumber class using random - return an int between 0 and 20
        public static int randomNumberInRange()
        {
            return Convert.ToInt32(random.NextDouble() * 20);
        }
        static void Main(string[] args)
        {
            //declare queue and dictionary variables
            Queue<string> custQueue = new Queue<string>();
            Dictionary<string, int> custDictionary = new Dictionary<string, int>();

            //fill queue with 100 customers using randomName class
            for (int i = 0; i < 100; i++)
            {
                custQueue.Enqueue(randomName());
            }

            //declare IEnumerator to iterate over a collection - the customer queue
            IEnumerator<string> MyQueueEnumerator = custQueue.GetEnumerator();

            
            while (MyQueueEnumerator.MoveNext())
            {
                //declare variables for customer name and number of burgers ordered
                string myValue = MyQueueEnumerator.Current;
                int numBurgers = randomNumberInRange();

                if (custDictionary.ContainsKey(myValue))
                {
                    //add number of burgers to value of existing customer in dictionary
                    custDictionary[myValue] += numBurgers;
                }
                else
                {
                    //add first time customer to dictionary w/ number of burgers ordered
                    custDictionary.Add(myValue, numBurgers);
                }
            }
            

            //use foreach to loop through queue
            /*
            foreach (var customer in custQueue)
            {
                string myValue = customer;
                int numBurgers = randomNumberInRange();

                if (custDictionary.ContainsKey(myValue))
                {
                    //add number of burgers to value of existing customer in dictionary
                    custDictionary[myValue] += numBurgers;
                }
                else
                {
                    //add first time customer to dictionary w/ number of burgers ordered
                    custDictionary.Add(myValue, numBurgers);
                }
            }
            */

            //use dequeue to loop through custQueue
            /*
            while (custQueue.Count > 0)
            {
                string myValue = custQueue.Peek();
                int numBurgers = randomNumberInRange();

                if (custDictionary.ContainsKey(myValue))
                {
                    //add number of burgers to value of existing customer in dictionary
                    custDictionary[myValue] += numBurgers;
                }
                else
                {
                    //add first time customer to dictionary w/ number of burgers ordered
                    custDictionary.Add(myValue, numBurgers);
                }
                custQueue.Dequeue();
            }
            */

            //use foreach to output dictionary entries
            foreach (KeyValuePair<string, int> DictItem in custDictionary)
             {
                 Console.WriteLine(DictItem.Key + "\t\t" + DictItem.Value);
             }

            //end program with user input
            Console.ReadLine();
        }
    }
 }


