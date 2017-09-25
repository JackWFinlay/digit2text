using System;

namespace Digit2Text
{
    public class Digit2Text
    {
        private long _digits;
        public Digit2Text(){

        }

        public long Digits { get => _digits; set => _digits = value; }
        public string Convert(Int64 digits)
        {
            this.Digits = digits;
            throw new NotImplementedException("Not yet implemented.");
        }
    }
}
