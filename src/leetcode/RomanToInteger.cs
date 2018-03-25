using System;

namespace  leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/description/
    ///
    /// Given a roman numeral, convert it to an integer.
    /// Input is guaranteed to be within the range from 1 to 3999.
    /// </summary>
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int a = MyWay(s);
            int b = SmartWay(s);
            if (a != b) {
                throw new Exception("Расхождение в вариантах подсчета");
            }
            return a;
        }
        private int MyWay(string s)
        {
            var str = s.ToUpper();
            if (str.Length == 1) {
                return CharToInt(str[0]);
            }

            int sum = 0;
            int i = 0;

            while(i < str.Length)
            {
                int curr = CharToInt(str[i]);

                int next = i + 1 == str.Length ? -1 : CharToInt(str[i + 1]);

                if (next > curr) {
                    sum += next - curr;
                    i++;
                } else {
                    sum += curr;
                }

                i++;
            }

            return sum;
        }

        // Есть более умный вариант - просто вычитать curr, если next больше.
        // Тогда не надо подкручивать счетчик и не надо нервничать на конце,
        // ибо концевое значение просто безусловно добавляется после цикла
        private int SmartWay(string s)
        {
            var str = s.ToUpper();
            if (str.Length == 1) {
                return CharToInt(str[0]);
            }

            int sum = 0;
            for(int i = 0; i < str.Length - 1; i++)
            {
                int curr = CharToInt(str[i]);

                int next = i + 1 == str.Length ? -1 : CharToInt(str[i + 1]);

                if (curr < next) {
                    sum -= curr;
                } else {
                    sum += curr;
                }
            }

            return sum + CharToInt(str[str.Length - 1]);
        }
        private int CharToInt(char letter)
        {
            switch(letter)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    throw new Exception(letter.ToString());
            }
        }
    }
}
