using System;
using System.Xml;

namespace StackLibrary
{
    public class Stack <T>
    {

        private T[] _arrayStack;
        private int _countIndex;
        private int _sizeArray;

        public Stack()
        {
            _sizeArray = 5;
            _arrayStack = new T[_sizeArray];
            _countIndex = 0;
        }

        public void Push(T value)
        {
            if (_countIndex == _sizeArray) { RaisingArrayStack(); }

            _arrayStack[_countIndex] = value;
            _countIndex++;
        }

        public T Pop()
        {
            if (_sizeArray == 0) { throw new Exception("Stack is null"); }
            
            T _newArrayStack = _arrayStack[_countIndex - 1];
            _countIndex--;
 
            
            return _newArrayStack;
        }

        public void PushStack(Stack<T> valueStack)
        {
            int index = 0;
                
            while (index < valueStack._countIndex) 
            {
                _arrayStack[_countIndex] = valueStack._arrayStack[index];
                _countIndex++;
                index++;
            }
        }

        public Stack<T> PopStack(int size)
        {
            T[] _newStackArray = new T[size];
            Stack<T> newStack = new Stack<T>();

            for (int i = 0; i < size; i++)
                _newStackArray[i] = this.Pop();
            
            
            for (int i = _newStackArray.Length - 1; i >= 0; i--) 
                newStack.Push(_newStackArray[i]);

            return newStack;
        }

	private void RaisingArrayStack()
        {
            T[] _newStackArray = new T[_sizeArray *= 2];

            _arrayStack.CopyTo(_newStackArray, 0);
            _arrayStack = _newStackArray;
        }
        

        public int Count()
        {
            return _countIndex;
        }

        public void Print()
        {
            foreach (var i in _arrayStack)
            {
                Console.Write(i + " ");
            }
        }
        
    }
}