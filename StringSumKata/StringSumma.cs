using System;

namespace StringSumKata
{
    public class StringSumma
    {
        public string Sum(string num1, string num2)
        {
            var realNum1 = GetZeroWhenNullOrEmpty(num1);
            var realNum2 = GetZeroWhenNullOrEmpty(num2);

            return Convert.ToString(Add(realNum1, realNum2));
        }

        private string GetZeroWhenNullOrEmpty(string num1) => string.IsNullOrEmpty(num1) ? "0" : num1;

        private int Add(string realNum1, string realNum2) => int.Parse(realNum1) + int.Parse(realNum2);
    }
}
