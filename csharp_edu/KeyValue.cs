using System;

namespace csharp_edu
{
    //generic
    public class KeyValue<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public KeyValue(TKey key, TValue val)
        {
            Key = key;
            Value = val;
        }

        public void showData()
        {
            Console.WriteLine($"{Key} is {Value}");
        }
    }
}