using System.Collections.Generic;

namespace NUnit.Tests
{
    public interface IInterface<T> : IEnumerable<T>
    {
        int Count { get; }
    }
}