using Class07;
using System.Collections;

//static void iterateCollection(IEnumerable collection)
//{
//    foreach (var item in collection)
//    {
//        Console.WriteLine(item);
//    }
//}





//Dictionary<string, string> firstDictionary = new Dictionary<string, string>();
//firstDictionary.Add("song1", "Have a nice day");
//firstDictionary.Add("song2", "Wind of change");

//bool firstKey = firstDictionary.ContainsKey("song2");
//Console.WriteLine(firstKey);
//bool thirdKey = firstDictionary.ContainsKey("song3");
//Console.WriteLine(thirdKey);

//Console.WriteLine("num of elements: "+ firstDictionary.Count);
//Console.WriteLine(firstDictionary["song1"]);
//Console.WriteLine(firstDictionary["song2"]);


//Dictionary<int, string> products = new Dictionary<int, string>()
//{
//    {123345,"Bread" },
//    {566789,"Milk" },
//    {345673,"Salt" }
//};


//bool success = products.TryGetValue(66666, out string product);
//Console.WriteLine(success);

//List<int> integerList = new List<int>();
//integerList.Add(3);
//integerList.Add(245334543);
//integerList.Add(6);
//integerList.Add(9);
//integerList.Remove(6);
//Console.WriteLine(integerList[1]);
//Console.WriteLine(integerList[2]);
//integerList.RemoveAt(0);
//Console.WriteLine(integerList[0]);
//Console.WriteLine(integerList.Count);
//iterateCollection(integerList);

//ArrayList arrayList = new ArrayList() { "Hello", 2 };
//arrayList.Add(true);
//arrayList.Add(new string[] { "Hi", "Bye" });
//Console.WriteLine(arrayList[2]);
//Console.WriteLine(arrayList.Count);
//arrayList.Remove(2);
//Console.WriteLine(arrayList.Count);
//Console.WriteLine(((string[])arrayList[2])[0]);
//iterateCollection(arrayList);

//Queue<int> intQueue = new Queue<int>();
//intQueue.Enqueue(5);
//intQueue.Enqueue(2);
//intQueue.Enqueue(7);
//iterateCollection(intQueue);
//int fistNumber = intQueue.Peek();
//Console.WriteLine(fistNumber);
//Console.WriteLine(intQueue.Count);
//int fistMember = intQueue.Dequeue();
//int fistMemberOut = intQueue.Dequeue();
//Console.WriteLine(fistMemberOut);

//fistNumber = intQueue.Peek();
//Console.WriteLine(fistNumber);
//Console.WriteLine(intQueue.Count);

//Stack<string> ourStack = new Stack<string>();
//ourStack.Push("Hello");
//ourStack.Push("Hi");
//ourStack.Push("Goodbye");
//iterateCollection(ourStack);
//string lastMember = ourStack.Peek();
//Console.WriteLine(lastMember);
//Console.WriteLine(ourStack.Count);

//string lastMemberOut = ourStack.Pop();
//Console.WriteLine(lastMemberOut);

//static void checkPhoneBook(Dictionary<string,int> PhoneBook,string input)
//{
//   if (!PhoneBook.TryGetValue(input,out int result))
//        {
//        Console.WriteLine("That apaerson was not found");
//        return;
//    }
//    Console.WriteLine(PhoneBook[input]);
//};


//Dictionary<string, int> PhoneBook = new Dictionary<string, int >();
//{
//    PhoneBook.Add("Dejan", 071390127);
//    PhoneBook.Add("Elena", 070356058);
//    PhoneBook.Add("Ana", 070355458);
//    PhoneBook.Add("Dame", 070325433);
//    PhoneBook.Add("Teo", 070258114);
//}
//Console.WriteLine("Enter a name");
//Console.WriteLine(PhoneBook);









