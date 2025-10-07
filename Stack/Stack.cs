using System;

namespace Stack_Array
{
    public class Stack
    {
        private char[] array;
        int top;

        public Stack(int size)
        {
            array = new char[size];
            top = -1;
        }

        public void Push(char element)
        {
            if (this.isFull())
            {
                Console.WriteLine("Error: Stack Overflow.\n");
            }
            else
            {
                this.array[++top] = element;
            }
        }

        public char Pop()
        {
            if (this.isEmpty())
            {
                Console.WriteLine("Error: There is no element! The stack is empty.\n");
                return 'x';
            }
            else
            {
                return array[top--];
            }
        }

        private bool isEmpty()
        {
            return top == -1;
        }

        private bool isFull()
        {
            return top == array.Length;
        }

        public string Reverse(string input)
        {
            Stack stack = new Stack(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            string reversed = "";

            while (!stack.isEmpty())
            {
                reversed = reversed + stack.Pop();
            }

            return reversed;
        }
    }
}
