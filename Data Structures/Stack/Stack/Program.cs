using System;
using StackLibrary;

namespace Stack
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> first_stack = new Stack<int>();
            Stack<int> second_stack = new Stack<int>();
            
            first_stack.Push(1);
            first_stack.Push(2);

            second_stack.Push(3);
            second_stack.Push(4);
            
            first_stack.PushStack(second_stack);

            first_stack.PopStack(2);
            
            first_stack.Print();
            
        }
    }
}