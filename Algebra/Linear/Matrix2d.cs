using System;
using Xevle.Maths.Tuples;

namespace Xevle.Maths.Algebra.Linear
{
	/// <summary>
	/// Matrix2d.
	/// | m00 m01 |
	//  |_m10 m11_|
	/// </summary>
	public class Matrix2d
	{
		public double M00 { get; internal set; }

		public double M01 { get; internal set; }

		public double M10 { get; internal set; }

		public double M11 { get; internal set; }

		#region Constructor
		public Matrix2d() : this(1, 0, 0, 1)
		{
		}

		public Matrix2d(double _m00, double _m01, double _m10, double _m11)
		{
			M00 = _m00;
			M01 = _m01;
			M10 = _m10;
			M11 = _m11;
		}

		public Matrix2d(double[] m)
		{
			M00 = m[0];
			M01 = m[1];
			M10 = m[2];
			M11 = m[3];
		}

		public Matrix2d(Matrix2d m)
		{
			M00 = m.M00;
			M01 = m.M01;
			M10 = m.M10;
			M11 = m.M11;
		}

		public override int GetHashCode()
		{
			double bitssum = M00 + M10 + M01 + M11;
			long bits = BitConverter.DoubleToInt64Bits(bitssum);
			return (int)(bits ^ (bits >> 32));
		}
		#endregion

		#region Set Functions
		public Matrix2d Set(double _m00, double _m01, double _m10, double _m11)
		{
			M00 = _m00;
			M01 = _m01;
			M10 = _m10;
			M11 = _m11;
			return this;
		}

		public Matrix2d Set(Matrix2d m)
		{
			M00 = m.M00;
			M01 = m.M01;
			M10 = m.M10;
			M11 = m.M11;
			return this;
		}

		public Matrix2d Set(int r, int c, double val)
		{
			if (r == 0)
			{
				if (c == 0) M00 = val;
				else if (c == 1) M01 = val;
			}
			else if (r == 1)
			{
				if (c == 0) M10 = val;
				else if (c == 1) M11 = val;
			}

			return this;
		}

		public Matrix2d SetColumn(Tuple2dc t, int c)
		{
			if (c == 0)
			{
				M00 = t.x;
				M10 = t.y;
			}
			if (c == 1)
			{
				M01 = t.x;
				M11 = t.y;
			}
			return this;
		}

		public Matrix2d SetColumn(double x, double y, double z, int c)
		{
			if (c == 0)
			{
				M00 = x;
				M10 = y;
			}
			if (c == 1)
			{
				M01 = x;
				M11 = y;
			}
			return this;
		}

		public Matrix2d SetColumn(double[] d, int c)
		{
			if (c == 0)
			{
				M00 = d[0];
				M10 = d[1];
			}
			if (c == 1)
			{
				M01 = d[0];
				M11 = d[1];
			}
			return this;
		}

		public Matrix2d SetColumns(Tuple2dc c0, Tuple2dc c1)
		{
			M00 = c0.x;
			M01 = c1.x;
			M10 = c0.y;
			M11 = c1.y;
			return this;
		}

		public Matrix2d SetRow(Tuple2dc t, int r)
		{
			if (r == 0)
			{
				M00 = t.x;
				M01 = t.y;
			}
			if (r == 1)
			{
				M10 = t.x;
				M11 = t.y;
			}
			return this;
		}

		public Matrix2d SetRow(double x, double y, int r)
		{
			if (r == 0)
			{
				M00 = x;
				M01 = y;
			}
			if (r == 1)
			{
				M10 = x;
				M11 = y;
			}
			return this;
		}

		public Matrix2d SetRow(double[] d, int r)
		{
			if (r == 0)
			{
				M00 = d[0];
				M01 = d[1];
			}
			if (r == 1)
			{
				M10 = d[0];
				M11 = d[1];
			}
			return this;
		}

		public Matrix2d SetRows(Tuple2dc r0, Tuple2dc r1)
		{
			M00 = r0.x;
			M01 = r0.y;
			M10 = r1.x;
			M11 = r1.y;
			return this;
		}

		public Matrix2d SetIdentity()
		{
			M00 = 1;
			M01 = 0;
			M10 = 0;
			M11 = 1;
			return this;
		}

		public Matrix2d SetZero()
		{
			M00 = 0;
			M01 = 0;
			M10 = 0;
			M11 = 0;
			return this;
		}

		public Matrix2d SetRotation(double d)
		{
			double s = Math.Sin(d);
			double c = Math.Cos(d);
			M00 = c;
			M01 = -s;
			M10 = s;
			M11 = c;
			return this;
		}

		public static Matrix2d RotationMatrix(double a)
		{
			Matrix2d ret = new Matrix2d();
			ret.SetRotation(a);
			return ret;
		}
		#endregion

		#region Get Functions
		public double Get(int r, int c)
		{
			if (r == 0)
			{
				if (c == 0) return M00;
				else if (c == 1) return M01;
			}
			else if (r == 1)
			{
				if (c == 0) return M10;
				else if (c == 1) return M11;
			}

			return 0;
		}

		public Tuple2dc GetColumn(int c)
		{
			if (c == 0) return new Tuple2dc(M00, M10);
			if (c == 1) return new Tuple2dc(M01, M11);
			return new Tuple2dc(0, 0);
		}

		public void GetColumns(Tuple2dc c0, Tuple2dc c1)
		{
			c0 = new Tuple2dc(M00, M10);
			c1 = new Tuple2dc(M01, M11);
		}

		public Tuple2dc GetRow(int r)
		{
			if (r == 0) return new Tuple2dc(M00, M01);
			if (r == 1) return new Tuple2dc(M10, M11);
			return new Tuple2dc(0, 0);
		}

		public void GetRows(Tuple2dc r0, Tuple2dc r1)
		{
			r0 = new Tuple2dc(M00, M01);
			r1 = new Tuple2dc(M10, M11);
		}

		public void GetElements(
			out double _m00, out double _m01,
			out double _m10, out double _m11)
		{
			_m00 = M00;
			_m01 = M01;
			_m10 = M10;
			_m11 = M11;
		}
		#endregion

		#region Operators
		public static Matrix2d operator *(Matrix2d a, Matrix2d b)
		{
			Matrix2d ret = new Matrix2d();
			ret.M00 = a.M00 * b.M00 + a.M01 * b.M10;
			ret.M01 = a.M00 * b.M01 + a.M01 * b.M11;
			ret.M10 = a.M10 * b.M00 + a.M11 * b.M10;
			ret.M11 = a.M10 * b.M01 + a.M11 * b.M11;
			return ret;
		}

		public static Tuple2dc operator *(Matrix2d a, Tuple2dc t)
		{
			return new Tuple2dc(
				a.M00 * t.x + a.M01 * t.y,
				a.M10 * t.x + a.M11 * t.y);
		}

		public static Matrix2d operator *(Matrix2d a, double d)
		{
			return new Matrix2d(
				a.M00 * d, a.M01 * d,
				a.M10 * d, a.M11 * d);
		}

		public static Matrix2d operator +(Matrix2d a, Matrix2d m)
		{
			return new Matrix2d(
				a.M00 + m.M00, a.M01 + m.M01,
				a.M10 + m.M10, a.M11 + m.M11);
		}

		public static Matrix2d operator -(Matrix2d a, Matrix2d m)
		{
			return new Matrix2d(
				a.M00 - m.M00, a.M01 - m.M01,
				a.M10 - m.M10, a.M11 - m.M11);
		}

		public static Matrix2d operator +(Matrix2d m)
		{
			return new Matrix2d(
				m.M00, m.M01,
				m.M10, m.M11);
		}

		public static Matrix2d operator -(Matrix2d m)
		{
			return new Matrix2d(
				-m.M00, -m.M01,
				-m.M10, -m.M11);
		}

		/// <summary>
		/// Transpose the matrix.
		/// </summary>
		/// <param name="m">M.</param>
		public static Matrix2d operator ~(Matrix2d m)
		{
			return new Matrix2d(
				m.M00, m.M10,
				m.M01, m.M11);
		}

		/// <summary>
		/// Invert the matrix.
		/// </summary>
		/// <param name="m">M.</param>
		public static Matrix2d operator !(Matrix2d m) // Invert
		{
			double d = m.Determinate;
			if (Math.Abs(d) < 1e-10) throw new ArithmeticException("Determinate of the matrix is 0, this matrix can't be inverted");
			return new Matrix2d(m.M11 / d, -m.M01 / d, -m.M10 / d, m.M00 / d);
		}
		#endregion

		#region Arithmetic Functions
		public Matrix2d Transpose()
		{
			return ~this;
		}

		public Matrix2d Invert()
		{
			return !this;
		}

		public double Determinate
		{
			get
			{
				return M00 * M11 - M01 * M10;
			}
		}
		#endregion

		public void DecompositeRotationScaleSkew(out double rot, out double scaleX, out double scaleY, out double skew)
		{
			double konst1 = M00 * M00 + M10 * M10;
			double konst2 = Math.Sqrt(1 / konst1);
			double tanskx = (M00 * M01 + M10 * M11) / konst1;

			skew = Math.Atan(tanskx);

			scaleX = konst1 * konst2;
			scaleY = Determinate * konst2;

			if (M00 < 0 || M10 < 0) rot = 2 * Math.PI - Math.Acos(M00 * konst2);
			else rot = Math.Acos(M00 * konst2);
		}
	}
}
