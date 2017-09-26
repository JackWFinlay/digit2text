using System;
using Xunit;
using Digit2Text;

namespace Digit2Text.Tests
{
    public class Digit2TextTests
    {
        private readonly Digit2Text _digit2Text;

        public Digit2TextTests()
        {
            _digit2Text = new Digit2Text();
        }

        [Fact]
        public void ReturnOneGiven1()
        {
            var result = _digit2Text.Convert(758975);
            Assert.Equal("One", result);
        }
    }
}
