//Console.WriteLine("Enter the first number");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the second number");
//int number2 = Convert.ToInt32(Console.ReadLine());
//int result = number1 / number2;


//try
//{
//    Console.WriteLine("Enter the first number");
//    int number1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Enter the second number");
//    int number2 = Convert.ToInt32(Console.ReadLine());
//    int result = number1 / number2;
//    Console.WriteLine($"The result is {result}");
//}


////catch {

////    Console.WriteLine("An error happend: Please contact the support team");

////}
////catch (Exception ex) 
////{
////    Console.WriteLine("An error happend: Please contact the support team");
////    Console.WriteLine("An error occured" + ex.Message);
////    Console.WriteLine(ex.StackTrace);

////}

//catch (DivideByZeroException ex)
//{

//    Console.WriteLine("An error happend: Please contact the support team");
//    Console.WriteLine("Divide error occured" + ex.Message);
//    Console.WriteLine(ex.StackTrace);


//}

//catch (FormatException ex) 
//{
//    Console.WriteLine("An error happend: Please contact the support team");
//        Console.WriteLine("format error occured" + ex.Message);
//        Console.WriteLine(ex.StackTrace);
//}

//catch (Exception ex)
//{
//    Console.WriteLine("An error happend: Please contact the support team");
//    Console.WriteLine("An error occured" + ex.Message);
//    Console.WriteLine(ex.StackTrace);

//}

//finally
//{

//    Console.WriteLine("Thank you for inserting the numbers, have a great day");


//}




//try
//{
//    string[] Colors = { "Red", "Blue", "Green" };
//    Console.WriteLine(Colors[4]);

//}
//catch (IndexOutOfRangeException ex){
//    Console.WriteLine("An error occured" + ex.Message);
//}

//finally
//{
//    Console.WriteLine("This is it");
//}


//try {

//    Console.WriteLine("Please insert number between 1 and 5");
//    int num = Convert.ToInt32(Console.ReadLine());

//    if (num > 0 && num < 6)
//    {
//        Console.WriteLine("You enter the number:" + num);
//    }
//    else
//    {
//        throw new Exception("Oops, you entered invalid number, please be carefull");
//    }

//}
//catch (Exception ex) {

//Console.WriteLine("Cumstom excaption happend "+ ex.Message);

//}


//finally {

//  Console.WriteLine("Press enter to exit");
//}

//void AccessWithAge (int age)
//{
//    try
//    {

//        if (age > 18)
//        {
//            Console.WriteLine("Access approved");

//        }
//        else
//        {
//            throw new Exception("You don't have access, you need to be above 18");
//        }


//    }

//    catch (Exception ex) { 
//    Console.WriteLine("Error happend:" + ex.Message);
//        Console.WriteLine(ex.StackTrace);


//    }

//    finally 
//    {
//        Console.WriteLine("Press enter to exit");
//        Console.ReadLine(); 


//    }



//}

//Console.WriteLine("Please enter your age");
//int UserAge = Convert.ToInt32(Console.ReadLine());
//AccessWithAge(UserAge);


//int SumNumber (int input1 , int input2 )
//{

//    return input1 + input2;

//}

//int SubstractNumber (int input1, int input2)
//{

//    return input1 - input2;
//}

//int MultiplyNumber (int input1, int input2)
//{
//    return input1 * input2;
//}

//int DivideNumber (int input1, int input2)
//{
//    return input1 / input2;
//}



//void Calculator (int input1, int input2, char InputOperation)
//{
//    try
//    {



//        switch (InputOperation)
//        {
//            case '+':
//                SumNumber(input1, input2);
//                break;
//            case '-':
//                SubstractNumber(input1, input2);
//                break;
//            case '*':
//                MultiplyNumber(input1, input2);
//                break;
//            case '/':
//                DivideNumber(input1, input2);
//                break;
//            default: 
//              throw new Exception("Invalid Operant");
//        }

//    }
//    catch (FormatException ex)
//    {

//        Console.WriteLine("Wrong input Please try again" + ex.Message);
//        Console.WriteLine(ex.StackTrace);
//    }
//    catch (DivideByZeroException ex)
//    {

//        Console.WriteLine("Divide error" + ex.Message);
//        Console.WriteLine(ex.StackTrace);
//    }
//    catch (Exception ex) {

//        Console.WriteLine("Error again" + ex.Message);
//        Console.WriteLine(ex.StackTrace);
    
//    }


//    finally
//    {

//        Console.WriteLine("Bravo you did it, but it is not enough");

//    }

//}

//Console.WriteLine("Enter operation");
//char InputOperation = Convert.ToChar(Console.ReadLine());
//Console.WriteLine("Enter number 1");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter number 2");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Calculator(number1, number2, InputOperation);



void UnhandeledException ()
{
    string[] color = { "Red", "Blue", "Yellow" };
    Console.WriteLine(color[4]);



}
//UnhandeledException (); 

try {

    UnhandeledException();


}

catch( Exception ex) {

    Console.WriteLine("Error" + ex.Message);
    Console.WriteLine(ex.StackTrace);   


}


finally {

    Console.WriteLine("You did it");


}