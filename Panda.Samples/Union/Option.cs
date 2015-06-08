using System;
using System.CodeDom;
using System.Text.RegularExpressions;
using Panda.Union;

namespace Panda.Samples.Union
{
    public abstract class Option<T> : IUnion<Some<T>, None<T>>
    {
        public T ForceGetValue()
        {
            return this.Match(
                some => some.Value,
                none => { throw new InvalidOperationException("Could not retrive value from none"); });
        }
    }

    public sealed class Some<T> : Option<T>
    {
        private readonly T _value;

        public Some(T value)
        {
            _value = value;
        }

        public T Value
        {
            get { return _value; }
        }
    }

    public sealed class None<T> : Option<T>
    {
    }
}