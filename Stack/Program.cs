using Stack_Array;

Stack myStack = new Stack(100);
Console.Write("Enter a sentence to reverse: ");

string input = Console.ReadLine();
Console.WriteLine("Reversed sentence: " + myStack.Reverse(input));