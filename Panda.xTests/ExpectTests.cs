using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using FluentAssertions.Execution;
using Panda.Testing;
using Xunit;
using System.Threading.Tasks;


namespace Panda.xTests
{
    public class ExpectTests
    {
        [Fact]
        public void WithUsingSyntax()
        {
            var ex = Record.Exception(() =>
            {
                using (var expect = new Expect())
                {
                    expect.That(() => 1.Should().Be(0));
                    expect.That(() => 2.Should().BeGreaterOrEqualTo(3).And.BeNegative());
                }
            });
            Assert.IsType<ExpectFailedException>(ex);
        }

        [Fact]
        public void WithStaticMethod()
        {
            var ex = Record.Exception(() =>
            {
                Expect.That(
                    () => Assert.True(false),
                    () => Assert.Equal(2, 3));
            });
            Assert.IsType<ExpectFailedException>(ex);
        }
    }
}