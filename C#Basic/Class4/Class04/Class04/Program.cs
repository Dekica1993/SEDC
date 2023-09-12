// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int[] numbers = new int[5];
//int sum = 0;    
//for (int i = 0; i < 5; i++)
//{

//    Console.WriteLine("Enter number");
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//    sum += numbers[i];
//}
//Console.WriteLine($"The result is:{sum}");

//void Afirmation()
//{
//    Console.WriteLine("No matter how hard it gets");
//}
//Afirmation();

//void PermitForDrink (int age)
//{

//    if(age <= 18)
//    {
//        Console.WriteLine("You are not old enought to drink, grow up");
//    }
//    else
//    {
//        Console.WriteLine("You are old Enought to buy drink");
//    }
//}
////Call the method
////PermitForDrink(25);
//Console.WriteLine("PLease enter your age");
//int UserAge = int.Parse(Console.ReadLine());
//PermitForDrink(UserAge);

//string WeekendMind ()
//{
//    string result = "the weekend is best spent with friends";
//    return result;

//}

//string res = WeekendMind();

//string DayOfTheWeek(int day)
//{
//    string result;
//    switch (day)
//    {
//        case 1:
//            result = "Today is Monday";
//            break;
//        case 2:
//            result = "Today is Tuesday";
//            break;
//        case 3:
//            result = " Today is Wednesday";
//            break;
//        case 4:
//            result = "Today is Thursday";
//            break;
//        case 5:
//            result = "Today is Friday";
//            break;
//        case 6:
//            result = "Today is Saturday";
//            break;
//        case 7:
//            result = "Today is Sunday ";
//            break;
//        default:
//            result = "You entered invalid day";
//            break;
//    }
//    return result;
//}
//string EnteredDay = DayOfTheWeek(10);
//Console.WriteLine(EnteredDay);

//string Introduction (string Name, int InputDay )
//{

//    string ResultDayOfTheWeek = DayOfTheWeek(InputDay);
//    string result = "Nice to meet you" + "  " + Name + ", " + ResultDayOfTheWeek;
//    return result;  
//}
//Console.WriteLine("What is your Name");
//string UserName = Console.ReadLine();
//Console.WriteLine("Insert number");
//int UserNumber = Convert.ToInt32(Console.ReadLine());
//string UserResult= Introduction(UserName, UserNumber);
//Console.WriteLine(UserResult);

// int SumOfTwoNumber ( int Number1, int Number2 )
//{
//   int ResultSum=Number1 + Number2;
//    return ResultSum;
//}

//int SubStractTwoNumber ( int Number1, int Number2 )
//{
//    int ResultSubStract=Number1 - Number2;
//    return ResultSubStract;
//}

//Console.WriteLine("Input operation");
//char operation = char.Parse(Console.ReadLine());

//int FinalOperator (int input1, int input2)
//{
//    int result=0;
//    switch (operation) 
//    {
//        case '+':
//            result = SumOfTwoNumber(input1, input2);
//            break;
//        case '-':
//            result = SubStractTwoNumber(input1, input2);
//            break;

//    }
//    return result;
//}
//Console.WriteLine("Enter number 1");
//int InputNumber1 =Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter number 2");
//int InputNumber2 =Convert.ToInt32(Console.ReadLine());
//int UserInput =FinalOperator (InputNumber1, InputNumber2);
//Console.WriteLine("The result is:"+UserInput);

//string name = "Dana";
//string company = "Seavus";

//string concatinationEx = "Hello , my name is " + " " + name + " " + "and a work in" + company;
//Console.WriteLine(concatinationEx);


//string interpolationEx = $"Hello, my name is {name} and i work in {company}";
//Console.WriteLine(interpolationEx);

//string formatExemple= String.Format("Hello, my name is {0} and u work in {1}",name,company);
//Console.WriteLine(formatExemple);

//string escapingEx = "This is a "string" in c#";
//string escapingEx = "This is a\"string\" in C#";
//Console.WriteLine(escapingEx);

//string escapingEx2 = "This is \\n means new line";
//Console.WriteLine(escapingEx2);

//string verbatimEx = @"This is""string""in C#";
//Console.WriteLine(verbatimEx);

//string verbatimEx2 = @"This \n means new line";
//Console.WriteLine(verbatimEx2);

//string verbatinEx3 = @$" i am going to ""check"" the c:\drive in {company}";
//Console.WriteLine(verbatinEx3);

//string percentEx = string.Format("This is {0:P}", 0.5);
//Console.WriteLine(percentEx);

//string numberEx = string.Format("This is {0:N}", 125000);
//Console.WriteLine(numberEx);

//string decimalspaceEx = string.Format("Two decimal {0:0.00}", 125.265);
//Console.WriteLine(decimalspaceEx);

//string cumstomEx = string.Format("{0:0##/###-###}", 070775944);
//Console.WriteLine(cumstomEx);

//string s1 = "Enjoy your day";
//bool startswith = s1.StartsWith("z");
//Console.WriteLine(startswith);

//int indexofEx = name.IndexOf("D",2);
//Console.WriteLine(indexofEx);

//string substring = name.Substring(2,2);
//Console.WriteLine(substring);

//string splitEx = "C# is fun programing lenguage";
//string[] splitstring = splitEx.Split("");
//foreach (string splitS in splitstring)
//{
//    Console.WriteLine(splitS);

//}

//string chararrEx = "Language";
//char [] charEx = chararrEx.ToCharArray();
//foreach (char c in chararrEx)
//{
//    Console.WriteLine (c);
//}


//void Substrings ()
//{
//    string result = "Hello from SEDC Codecademy 2023";
//    Console.WriteLine("input a number");
//    int input = Convert.ToInt32(Console.ReadLine());
//    int lengthString = result.Length;
//    string newSubString = result.Substring(input, lengthString - input);
//    Console.WriteLine($"The new string is {newSubString}, the length of the original {lengthString}");

//}
//Substrings();

//DateTime dt1 = new DateTime();
//Console.WriteLine(dt1);

//DateTime dt2 = new DateTime(2023, 03, 16);
//Console.WriteLine(dt2);

//DateTime dt3 =  new DateTime(2023, 03, 16, 05, 05, 05);
//Console.WriteLine(dt3);

//DateTime currentdatetime = DateTime.Now;
//Console.WriteLine(currentdatetime);

//DateTime dt5 = currentdatetime.AddDays(5);
//Console.WriteLine(dt5);

//DateTime dt6 = currentdatetime.AddMonths(3);
//Console.WriteLine(dt6);

//int month = currentdatetime.Month;
//Console.WriteLine(month);

//int day = currentdatetime.Day;
//Console.WriteLine(day);
//string datetime = "2023-01-01";
//DateTime convertdatetime = Convert.ToDateTime(datetime);
//Console.WriteLine(convertdatetime);

//string dateFormat1 = string.Format("This is: {0:dd/MM/yy},{0:dddd}",currentdatetime);
//Console.WriteLine(dateFormat1);

//string dateFormat2 = string.Format("Today is: {0:dd-MM-yyyy}, {0:t}", currentdatetime);
//Console.WriteLine(dateFormat2);