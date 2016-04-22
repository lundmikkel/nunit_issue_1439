using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NUnit.Tests
{
    public class Class2<T> : IInterface<T>, IEquatable<IInterface<T>>
    {

        private readonly T[] _enumerable;

        public Class2(IEnumerable<T> enumerable)
        {
            var array = enumerable as T[] ?? enumerable.ToArray();
            _enumerable = array;
            Count = array.Length;
        }

        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>) _enumerable).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public int Count { get; }
        public bool Equals(IInterface<T> other) => ReferenceEquals(this, other) || Count == other?.Count;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) {
                return true;
            }
            if (obj == null) {
                return false;
            }
            var that = obj as IInterface<T>;
            return that != null && Equals(that);
        }
    }
}