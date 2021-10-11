using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IMyList
    {
        void Add(string item);
    }

    class MyList : IMyList
    {
        Item head;
        class Item
        {
            public string Value;
            public Item Next;

            public Item(string value)
            {
                Value = value;
            }
        }
        public void Add(string item)
        {
            if (head == null) head = new Item(item);
            else
            {
                Item current = head;
                while (current.Next != null)
                    current = current.Next;
                current.Next = new Item(item);
            }
        }

        public string Get(int index)
        {
            Item current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("AAAA");
            list.Add("BBBB");
            list.RemoveAt(0);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            MyList my_list = new MyList();
            my_list.Add("AAAA");
            my_list.Add("BBBB");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(my_list.Get(i));
            }
            Console.ReadLine();
        }
    }
}
