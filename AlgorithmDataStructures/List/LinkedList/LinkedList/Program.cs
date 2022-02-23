using System.Collections.Generic;
using System.Collections;
using System;
using Node;


namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Nodes<T> head;
        private Nodes<T> end;
        private int count = 0;
        
        public void Add(T data)
        {
            Nodes<T> node = new Nodes<T>(data);

            if (head == null)
                head = node;
            else
                end.Next = node;

            end = node;
            count++;
        }

        public void Delete(T data)
        {
            Nodes<T> current = head;
            Nodes<T> prev = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (prev != null)
                    {
                        prev.Next = current.Next;

                        if (current.Next == null)
                            end = prev;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            end = null;

                    }

                    count--;
                }
                prev = current;
                current = current.Next;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
 
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Nodes<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
    
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            
            list.Add(20);
            list.Add(3420);
            list.Add(999);
            
            list.Delete(3420);
            
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}