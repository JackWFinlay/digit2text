using System;
using Xunit;
using Digit2Text;
using System.Collections.Generic;
using System.Text;

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
            string result = _digit2Text.Convert(1);
            Console.WriteLine(result);
            Assert.Equal("One", result);
        }

        [Fact]
        public void ReturnTenGiven10()
        {
            string result = _digit2Text.Convert(10);
            Console.WriteLine(result);
            Assert.Equal("Ten", result);
        }

        [Fact]
        public void ReturnElevenGiven11()
        {
            string result = _digit2Text.Convert(11);
            Console.WriteLine(result);
            Assert.Equal("Eleven", result);
        }

        [Fact]
        public void ReturnOneHundredGiven100()
        {
            string result = _digit2Text.Convert(100);
            Console.WriteLine(result);
            Assert.Equal("One Hundred", result);
        }

        [Fact]
        public void ReturnOneHundredOneGiven101()
        {
            string result = _digit2Text.Convert(101);
            Console.WriteLine(result);
            Assert.Equal("One Hundred One", result);
        }

        [Fact]
        public void ReturnOneHundredElevenGiven111()
        {
            string result = _digit2Text.Convert(111);
            Console.WriteLine(result);
            Assert.Equal("One Hundred Eleven", result);
        }

        [Fact]
        public void ReturnOneHundredTwentyOne()
        {
            string result = _digit2Text.Convert(121);
            Console.WriteLine(result);
            Assert.Equal("One Hundred Twenty-One", result);
        }

        [Fact]
        public void ReturnOneThousandOneHundredOneGiven1101()
        {
            string result = _digit2Text.Convert(1101);
            Console.WriteLine(result);
            Assert.Equal("One Thousand One Hundred One", result);
        }
    }
}
