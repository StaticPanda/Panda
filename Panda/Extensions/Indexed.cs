using System;
using System.Collections.Generic;

namespace Panda.Extensions
{
    public sealed class Indexed<T>
    {
        private readonly T _value;
        private readonly uint _index;

        public Indexed(T value, uint index)
        {
            _value = value;
            _index = index;
        }

        public T Value
        {
            get { return _value; }
        }

        public uint Index
        {
            get { return _index; }
        }
    }

    public static class IndexedExtensions
    {
        public static IEnumerable<Indexed<T>> Indexed<T>(this IEnumerable<T> self)
        {
            if (self == null) throw new ArgumentNullException("self");
            return self.indexedImpl();
        }

        private static IEnumerable<Indexed<T>> indexedImpl<T>(this IEnumerable<T> self)
        {
            uint index = 0;
            foreach (var element in self)
            {
                yield return new Indexed<T>(element, index);
                unchecked
                {
                    index++;
                }
            }
        }
    }
}