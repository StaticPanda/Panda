using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Panda.Extensions;

namespace Panda.Testing
{
    public class Expect : IDisposable
    {
        private readonly List<Action> _asserts;

        public Expect()
        {
            _asserts = new List<Action>();
        }

        void IDisposable.Dispose()
        {
            That(_asserts);
        }

        public void That(Action assert)
        {
            _asserts.Add(assert);
        }

        public static void That(params Action[] asserts)
        {
            if (!asserts.Any())
            {
                throw new ArgumentException("Called Expect.That without providing any asserts.");
            }
            var exceptions = new List<Exception>();
            foreach (var assert in asserts.Indexed())
            {
                try
                {
                    assert.Value();
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }
            if (exceptions.Any())
            {
                var message = string.Format(" {0} assertions failed:{1}",
                    exceptions.Count,
                    Environment.NewLine +
                    string.Join(Environment.NewLine,
                        exceptions.Select((e, i) => string.Format("{0}) {1}", i + 1, e.Message))));
                var ex = new ExpectFailedException(message, exceptions);
                replaceStackTrace(ex, exceptions.First().StackTrace);
                throw ex;
            }
        }

        public static void That(IEnumerable<Action> asserts)
        {
            That(asserts.ToArray());
        }

        /// <summary>
        /// Taken from <see href="http://stackoverflow.com/a/14207679" />
        /// </summary>
        private static void replaceStackTrace(Exception exception, string stackTrace)
        {
            var remoteStackTraceString = typeof(Exception)
                .GetField("_remoteStackTraceString",
                    BindingFlags.Instance | BindingFlags.NonPublic);

            remoteStackTraceString.SetValue(exception, stackTrace);
        }
    }

    [Serializable]
    public class ExpectFailedException : AggregateException
    {
        public ExpectFailedException(string message, IEnumerable<Exception> innerExceptions)
            : base(message, innerExceptions)
        {
        }

        protected ExpectFailedException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}