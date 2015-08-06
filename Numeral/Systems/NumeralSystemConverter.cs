using System;
using System.Collections.Generic;
using System.Text;

namespace Xevle.Maths.Numeral.Systems
{
	public static class NumeralSystemConverter
	{
		const uint MIN_RADIX = 1;
		const uint MAX_RADIX = 36;

		public static char FromDecimalDigit(uint digit, uint radix)
		{
			if (digit >= radix) return '\0';
			if (radix < MIN_RADIX || radix > MAX_RADIX) return '\0';

			if (digit < 10) return (char)('0' + digit);

			return (char)('a' - 10 + digit);
		}
			
		public static int ToDecimalDigit(char ch, uint radix)
		{
			int value = -1;

			if (radix >= MIN_RADIX && radix <= MAX_RADIX)
			{
				if (ch >= '0' && ch <= '9') value = ch - '0';
				if (ch >= 'a' && ch <= 'z') value = 10 + ch - 'a';
				if (ch >= 'A' && ch <= 'Z') value = 10 + ch - 'A';
			}

			return (value < (int)radix) ? value : -1;
		}
			
		public static string FromDecimal(uint number, uint radix)
		{
			string numberS = number.ToString();
			string ret = "";

			foreach (char sign in numberS)
			{
				ret += FromDecimalDigit(Convert.ToUInt32(sign), radix);
			}

			return ret;
		}
			
		public static uint ToDecimal(string number, uint radix)
		{
			string ret = "";

			foreach (char sign in number)
			{
				ret += ToDecimalDigit(sign, radix);
			}

			return Convert.ToUInt32(ret);
		}
			
		public static string ConvertNumber(string number, uint sourceRadix, uint targetRadix)
		{
			uint v1 = ToDecimal(number, sourceRadix);
			return FromDecimal(v1, targetRadix);
		}
			
		public static int HexadecimalToDecimal(string hexValue)
		{
			return Convert.ToInt32(ConvertNumber(hexValue, 16, 10));
		}
			
		public static string DecimalToHexadecimal(int decValue)
		{
			return ConvertNumber(decValue.ToString(), 10, 16);
		}
	}
}
