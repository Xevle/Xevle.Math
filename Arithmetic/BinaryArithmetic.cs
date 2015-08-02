using System;

namespace Xevle.Maths.Arithmetic
{
	public static class BinaryArithmetic
	{
		public static uint GetPowerOf2(uint size)
		{
			uint potenceOf2Size=1;
			while(potenceOf2Size<size) potenceOf2Size*=2;
			if(potenceOf2Size>size) potenceOf2Size/=2;
			return potenceOf2Size;
		}
	}
}

