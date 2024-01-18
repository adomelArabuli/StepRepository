using System.Collections;

namespace GenericVSNonGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region GenericColletions

            List<int> list = new List<int>();

            var keyValuePairs = new SortedList<string, int>(); // Key dublicate not allowed(Sorted by key)
            keyValuePairs.Add("nika", 22);
            keyValuePairs.Add("elene", 23);
            keyValuePairs.Add("giorgi", 22);
            //keyValuePairs.Add("nika", 22);
            Console.WriteLine();

            var dictionary = new Dictionary<int, string>(); // Key dublicate not allowed
            dictionary.Add(1234, "Giorgi");
            dictionary.Add(1111, "Bela");
            dictionary.Add(2222, "Giorgi");
            //dictionary.Add(1234, "Giorgi");

            var sortedDictionary = new SortedDictionary<string, int>(); // Key dublicate not allowed(sorted by key)
            sortedDictionary.Add("Giorgi", 1234);
            sortedDictionary.Add("Bela", 1111);
            sortedDictionary.Add("Avtandili", 2222);

            Stack<string> browserHistory = new Stack<string>(); // FILO
            browserHistory.Push("Page1");
            browserHistory.Push("Page2");
            browserHistory.Push("Page3");
            browserHistory.Push("Page4");
            browserHistory.Push("Page5");
            browserHistory.Push("Page6");

            Queue<string> strings = new Queue<string>();  // FIFO

            strings.Enqueue("Giorgi");
            strings.Enqueue("Elene");
            strings.Enqueue("Daviti");
            strings.Enqueue("Revazi");
            strings.Enqueue("Giorgi");

            strings.Dequeue();
            strings.Dequeue();

            HashSet<string> keys = new HashSet<string>();  // ელემენტების დუბლირება არ შეიძლება, დუბლიკატებს არ შეინახავს
            keys.Add("giorgi");
            keys.Add("giorgi");
            keys.Add("c");
            keys.Add("c");
            keys.Add("c");
            keys.Add("a");
            keys.Add("a");
            keys.Add("a");

            var sortedSet = new SortedSet<string>();// ელემენტების დუბლირება არ შეიძლება, დუბლიკატებს არ შეინახავს, თან ასორტირებს
            sortedSet.Add("giorgi");
            sortedSet.Add("giorgi");
            sortedSet.Add("c");
            sortedSet.Add("c");
            sortedSet.Add("c");
            sortedSet.Add("a");
            sortedSet.Add("a");
            sortedSet.Add("a");

            var linkedList = new LinkedList<string>();
            linkedList.AddFirst("a");
            linkedList.AddFirst("b");
            linkedList.AddFirst("c");
            linkedList.AddLast("d");

            #endregion

            #region NonGenericCollections

            ArrayList arrayList = new ArrayList();
            arrayList.Add("a");
            arrayList.Add("b");
            arrayList.Add("c");
            arrayList.Add("a");
            arrayList.Add("b");
            arrayList.Add(100);
            arrayList.Add(true);
            arrayList.Add(false);
            arrayList.Add(5.5);
            arrayList.Add('c');

            SortedList sortedList = new SortedList();
            sortedList.Add(4, "java");
            sortedList.Add(1, "java");
            sortedList.Add(2, "c#");
            sortedList.Add(3, "python");
            sortedList.Add(10, 3);
            sortedList.Add(11, true);

            Queue queue = new Queue();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue(100);
            queue.Enqueue(true);

            Hashtable hashtable = new Hashtable();
            hashtable.Add("giorgi", 10);
            hashtable.Add("gela", 11);
            hashtable.Add("nana", 19);
            hashtable.Add("qeti", 'c');

            BitArray bitArray = new BitArray(8);
            bitArray[0] = true;
            bitArray[1] = false;
            bitArray[2] = true;
            bitArray[3] = false;

            #endregion
        }
    }
}