using System;
using System.Collections.Generic;
using System.Text;

namespace Digit2Text
{
    public class Digit2Text
    {
        private long _digits;
        private List<string> _parts;
        public Digit2Text(){

        }

        public long Digits { get => _digits; set => _digits = value; }
        public List<string> Parts { get => _parts; set => _parts = value; }
        public string Convert(long digits)
        {
            this.Digits = digits;
            this.Parts = new List<string>();

            for (int n = 0; digits%(10^n) == 0; n++ )
            {
                long number = digits%(10^n);
                this.Parts.Add(Enum.GetName(typeof(Numbers), number));
            }

            StringBuilder output = new StringBuilder();
            for (int i = Parts.Count - 1; Parts.Count > 0; i--)
            {
                long power = (10^i);
                output.Append(Parts[i]);
                output.Append(" " + Enum.GetName(typeof(Numbers), power));
            }

            return output.ToString();
        }
    }
}
