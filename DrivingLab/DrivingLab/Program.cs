namespace DrivingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500); Console.WriteLine(a.Move(3));
            Console.WriteLine(a);
            a.Descend(200);
            Console.WriteLine(a.Move());
            a.Move();
            Console.WriteLine(a);*/
            LaserGun laserGun = new LaserGun("BFG9000");
            WaterPistol waterPistol = new WaterPistol("SuperSoaker");

            Camera nikon = new Camera("Nikon");
            Camera pentax = new Camera("Pentax");
            Camera disposable = new Camera("Disposable");


            Hunter ellis = new Hunter("Ellis", "Witten", laserGun);
            Hunter jon = new Hunter("Jon", "Crofts", waterPistol);
            Hunter nish = new Hunter("Nish", "Mandal", disposable);

/*            nish.Shooter = jon;




            List<IShootable> weapons = new List<IShootable>()
            {
                ellis, jon, nish
            };

            foreach (IShootable shooter in weapons)
            {
                Console.WriteLine(shooter.Shoot());
            }*/

            /*       List<int> listOfInt = new List<int>()
                   {
                       5,4,3,9,0

                   };

                   listOfInt.Add(8);
                   listOfInt.OrderBy(i => i);
                   listOfInt.RemoveRange(1, 2);
                   listOfInt.Insert(2, 1);
                   listOfInt.Reverse();
                   listOfInt.Remove(9);
                   foreach (int item in listOfInt)
                   {
                       Console.WriteLine(item);
                   }*/


            var myQueue = new Queue<Person>();

            myQueue.Enqueue(ellis);
            myQueue.Enqueue(jon);
            myQueue.Enqueue(nish);

            foreach (var person in myQueue)
            {
                Console.WriteLine(person);
            }

            var first = myQueue.Peek;
            Console.WriteLine(first);

            var serve = myQueue.Dequeue();
            Console.WriteLine(serve);


            var myStack = new Stack<int>();

            int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] numsReverse = new int[nums.Length];

            foreach(var num in nums)
            {
                myStack.Push(num);
            }
            for (int i = 0; i <numsReverse.Length; i++)
            {
                numsReverse[i] = myStack.Pop();
            }

            var morePeople = new HashSet<Person> { new Person("Cathy", "Jones"), new Person("Jasmine", "Hope"), new Person("Thomas", "Larkin") };

            var personDict = new Dictionary<string, Person>
            {
                { "helen", jon},
                {"tom", new Person("Thomas") }
            };

            var p = personDict["tom"];
            var successAddPerson = personDict.TryAdd("helen", new Person("Tester"));

            personDict.Add("bill", ellis);

            string input = "The cat in the hat comes back";
            input = input.Trim().ToLower();
            var countDict = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (countDict.ContainsKey(c))
                {
                    countDict[c]++;
                }
                else
                {
                    countDict.Add(c, 1);
                }
            }

            Console.WriteLine("\nDictionary Problem");
            foreach (var entry in countDict)
            {
                Console.WriteLine(entry);
            }

            foreach (var key in countDict.Keys)
            {
                Console.Write($"Key {key}, ");
            }
            Console.WriteLine();
            foreach (var value in countDict.Values)
            {
                Console.Write($"Value {value}, ");
            }
    }
}