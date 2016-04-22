using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NUnit.Tests
{
    public class Class1<T> : IInterface<T>
    {
        private readonly IEnumerable<T> _enumerable;

        public Class1(IEnumerable<T> enumerable)
        {
            var array = enumerable as T[] ?? enumerable.ToArray();
            _enumerable = array;
            Count = array.Length;
        }

        public IEnumerator<T> GetEnumerator() => _enumerable.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public int Count { get; }
    }
}