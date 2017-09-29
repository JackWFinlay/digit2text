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

            List<int> parts = BuildDigitNameParts(digits);

            string output = BuildOutput(parts);
            return output;
        }

        private List<int> BuildDigitNameParts(long digits)
        {
            List<int> parts = new List<int>();

            for (int n = 0; n < digits.ToString().Length; n++ )
            {
                string digitsString = digits.ToString();
                Int64.TryParse(digitsString.Substring(digitsString.Length - (n + 1), n + 1), out long subStringDigits);
                int number = (int)Math.Floor(subStringDigits/(Math.Pow(10, n)));
                parts.Add(number);
            }

            return parts;
        }

        private string BuildOutput(List<int> parts)
        {
            StringBuilder output = new StringBuilder();
            int partsCount = parts.Count;
            for (int i = (partsCount - 1); i >= 0; i--)
            {
                int digitAtPosition = parts[i];
                bool numberWasTeen = false;
                bool numberWasTens = false;

                // If the number is a teen, remove current value and insert
                // the value as a teen from the Numbers Enum
                if (i == 1 && digitAtPosition == 1)
                {
                    Int32.TryParse((parts[1].ToString() + parts[0].ToString()), out int number);
                    digitAtPosition = number;//Enum.GetName(typeof(Numbers), number);
                    parts.RemoveAt(0);
                    numberWasTeen = true;
                } else if (i == 1) {
                    digitAtPosition = digitAtPosition * 10;
                    numberWasTens = true;
                }

                //output.Append(Enum.GetName(typeof(Numbers), numberAtPosition));

                string spaceString = "";
                string andString = "";
                if (i > 0)
                {
                    spaceString = " ";
                    andString = ", ";
                }

                long power = (long)(Math.Pow(10, i));
                string powerString = Enum.GetName(typeof(Numbers), power);
                if (power <= 10)
                {
                    powerString = "";
                }

                long valueAtPosition;
                if (numberWasTeen || numberWasTens)
                {
                    valueAtPosition = digitAtPosition;
                } else {
                    valueAtPosition = digitAtPosition * (int)Math.Pow(10,i);
                }

                if ( valueAtPosition <= 19)
                {
                    output.Append(Enum.GetName(typeof(Numbers), digitAtPosition));
                }
                else if (valueAtPosition > 19 && valueAtPosition < 100)
                {
                    output.Append((Enum.GetName(typeof(Numbers), digitAtPosition)) + "-");
                } else {
                    output.Append(Enum.GetName(typeof(Numbers), digitAtPosition) + spaceString + powerString + spaceString);
                }

                if (numberWasTeen)
                {
                    i = 0;
                }
            }

            return output.ToString().Trim();
        }
    }
}
