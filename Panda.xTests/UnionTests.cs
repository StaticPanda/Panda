using System;
using System.Collections.Generic;
using Panda.Union;
using Xunit;

namespace Panda.xTests
{

    #region Union for tests

    public abstract class UnionBase : IUnion<OptionInt, OptionDbl>
    {
    }

    public sealed class OptionDbl : UnionBase
    {
        public OptionDbl(double dVal)
        {
            DVal = dVal;
        }

        public double DVal { get; private set; }
    }

    public sealed class OptionInt : UnionBase
    {
        public OptionInt(int iVal)
        {
            IVal = iVal;
        }

        public int IVal { get; private set; }
    }

    #endregion

    public class UnionTests
    {
        [Theory, MemberData("RetMatchCases")]
        public void RetMatchChoosesCorrectOption(
            UnionBase input,
            Func<OptionInt, int> onInt,
            Func<OptionDbl, double> onDouble,
            dynamic expected)
        {
            var actual = input.Match(i => onInt(i), d => onDouble(d));
            Assert.Equal(expected, actual);
        }

        [Theory, MemberData("VoidMatchCases")]
        public void VoidMatchChoosesCorrectOption(
            UnionBase input,
            Action<OptionInt> onInt,
            Action<OptionDbl> onDouble)
        {
            input.Match(onInt, onDouble);
        }

        #region MemberData

        public static IEnumerable<object[]> RetMatchCases
        {
            get
            {
                return new List<object[]>
                {
                    new object[]
                    {
                        new OptionDbl(123.0),
                        (Func<OptionInt, int>) (_ =>
                        {
                            Assert.True(false);
                            return 0;
                        }),
                        (Func<OptionDbl, double>) (p => p.DVal),
                        123.0
                    },
                    new object[]
                    {
                        new OptionInt(123),
                        (Func<OptionInt, int>) (p => p.IVal),
                        (Func<OptionDbl, double>) (p =>
                        {
                            Assert.True(false);
                            return 0;
                        }),
                        123
                    }
                };
            }
        }

        public static IEnumerable<object[]> VoidMatchCases
        {
            get
            {
                return new List<object[]>
                {
                    new object[]
                    {
                        new OptionDbl(123.0),
                        (Action<OptionInt>) (_ => Assert.True(false)),
                        (Action<OptionDbl>) (_ => { })
                    },
                    new object[]
                    {
                        new OptionInt(123),
                        (Action<OptionInt>) (_ => { }),
                        (Action<OptionDbl>) (_ => Assert.True(false))
                    }
                };
            }
        }

        #endregion
    }
}