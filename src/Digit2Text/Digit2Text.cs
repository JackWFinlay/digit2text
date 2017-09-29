using System;
using System.Collections.Generic;
using System.Text;

namespace Digit2Text
{
    public class Digit2Text
    {
        private long _digits;
        public Digit2Text(){

        }

        public long Digits { get => _digits; set => _digits = value; }
        public string Convert(long digits)
        {
            this.Digits = digits;

            List<string> parts = BuildDigitNameParts(digits);

            string output = BuildOutput(parts);
            return output;
        }

        private List<string> BuildDigitNameParts(long digits)
        {
            List<string> parts = new List<string>();

            for (int n = 0; n < digits.ToString().Length; n++ )
            {
                string digitsString = digits.ToString();
                Int64.TryParse(digitsString[n].ToString(), out long digit);
                long number = (long)Math.Floor(digit/(Math.Pow(10, n)));
                parts.Add(Enum.GetName(typeof(Numbers), number));
            }

            return parts;
        }

        private string BuildOutput(List<string> parts)
        {
            StringBuilder output = new StringBuilder();
            int partsCount = parts.Count;
            for (int i = (partsCount - 1); i >= 0; i--)
            {
                string numberString = parts[i];
                bool numberWasTeen = false;

                // If the number is a teen, remove current value and insert
                // the value as a teen from the Numbers Enum
                if (i == 1 && numberString.Equals("1"))
                {
                    Int32.TryParse(parts[1] + parts[0], out int number);
                    numberString = Enum.GetName(typeof(Numbers), number);
                    parts.RemoveAt(0);
                    numberWasTeen = true;
                }

                output.Append(numberString);

                string spaceString = "";
                if (i > 0)
                {
                    spaceString = " ";
                }

                long power = (long)(Math.Pow(10, i));
                string powerString = Enum.GetName(typeof(Numbers), power);
                if (power <= 10)
                {
                    powerString = "";
                }

                output.Append(spaceString + powerString);

                if (numberWasTeen)
                {
                    i = 0;
                }
            }

            return output.ToString();
        }
    }
}
