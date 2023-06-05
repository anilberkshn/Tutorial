using System;

namespace Tutorial.CodeExample
{
    public class GenericType<T>
    {
        private T _item { get; }
        private string _name { get; set; }

        public GenericType(T item, string name)
        {
            _item = item;
            _name = name;
            Console.WriteLine(item + "-" + name);
        }
    }
}