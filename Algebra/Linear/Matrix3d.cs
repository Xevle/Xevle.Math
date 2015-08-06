using System;
using Xevle.Maths.Tuples;

namespace Xevle.Maths.Algebra.Linear
{
	/// <summary>
	/// | m00 m01 m02 |
	/// | m10 m11 m12 |
	/// |_m20 m21 m22_|
	/// </summary>
	public class Matrix3d
	{
		public double M00 { get; internal set; }

		public double M01 { get; internal set; }

		public double M02 { get; internal set; }

		public double M10 { get; internal set; }

		public double M11 { get; internal set; }

		public double M12 { get; internal set; }

		public double M20 { get; internal set; }

		public double M21 { get; internal set; }

		public double M22 { get; internal set; }

		#region Constructor
		public Matrix3d() : this(1, 0, 0, 0, 1, 0, 0, 0, 1)
		{
		}

		public Matrix3d(double _m00, double _m01, double _m02,
		                double _m10, double _m11, double _m12,
		                double _m20, double _m21, double _m22)
		{
			M00 = _m00;
			M01 = _m01;
			M02 = _m02;
			M10 = _m10;
			M11 = _m11;
			M12 = _m12;
			M20 = _m20;
			M21 = _m21;
			M22 = _m22;
		}

		public Matrix3d(double[] m)
		{
			M00 = m[0];
			M01 = m[1];
			M02 = m[2];
			M10 = m[3];
			M11 = m[4];
			M12 = m[5];
			M20 = m[6];
			M21 = m[7];
			M22 = m[8];
		}

		public Matrix3d(Matrix3d m)
		{
			M00 = m.M00;
			M01 = m.M01;
			M02 = m.M02;
			M10 = m.M10;
			M11 = m.M11;
			M12 = m.M12;
			M20 = m.M20;
			M21 = m.M21;
			M22 = m.M22;
		}

		public override int GetHashCode()
		{
			long bits = BitConverter.DoubleToInt64Bits(M00);
			int hash = (int)(bits ^ (bits >> 32));

			bits = BitConverter.DoubleToInt64Bits(M01);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M02);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M10);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M11);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M12);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M20);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M21);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M22);
			hash ^= (int)(bits ^ (bits >> 32));

			return hash;
		}
		#endregion

		#region Set Functions
		public Matrix3d Set(double _m00, double _m01, double _m02,
		                    double _m10, double _m11, double _m12,
		                    double _m20, double _m21, double _m22)
		{
			M00 = _m00;
			M01 = _m01;
			M02 = _m02;
			M10 = _m10;
			M11 = _m11;
			M12 = _m12;
			M20 = _m20;
			M21 = _m21;
			M22 = _m22;

			return this;
		}

		public Matrix3d Set(Matrix3d m)
		{
			M00 = m.M00;
			M01 = m.M01;
			M02 = m.M02;
			M10 = m.M10;
			M11 = m.M11;
			M12 = m.M12;
			M20 = m.M20;
			M21 = m.M21;
			M22 = m.M22;

			return this;
		}

		public Matrix3d Set(int r, int c, double val)
		{
			if (r == 0)
			{
				if (c == 0) M00 = val;
				else if (c == 1) M01 = val;
				else if (c == 2) M02 = val;
			}
			else if (r == 1)
			{
				if (c == 0) M10 = val;
				else if (c == 1) M11 = val;
				else if (c == 2) M12 = val;
			}
			else if (r == 2)
			{
				if (c == 0) M20 = val;
				else if (c == 1) M21 = val;
				else if (c == 2) M22 = val;
			}

			return this;
		}

		public Matrix3d SetColumn(Tuple3dc t, int c)
		{
			if (c == 0)
			{
				M00 = t.x;
				M10 = t.y;
				M20 = t.z;
			}
			if (c == 1)
			{
				M01 = t.x;
				M11 = t.y;
				M21 = t.z;
			}
			if (c == 2)
			{
				M02 = t.x;
				M12 = t.y;
				M22 = t.z;
			}
			return this;
		}

		public Matrix3d SetColumn(double x, double y, double z, int c)
		{
			if (c == 0)
			{
				M00 = x;
				M10 = y;
				M20 = z;
			}
			if (c == 1)
			{
				M01 = x;
				M11 = y;
				M21 = z;
			}
			if (c == 2)
			{
				M02 = x;
				M12 = y;
				M22 = z;
			}
			return this;
		}

		public Matrix3d SetColumn(double[] d, int c)
		{
			if (c == 0)
			{
				M00 = d[0];
				M10 = d[1];
				M20 = d[2];
			}
			if (c == 1)
			{
				M01 = d[0];
				M11 = d[1];
				M21 = d[2];
			}
			if (c == 2)
			{
				M02 = d[0];
				M12 = d[1];
				M22 = d[2];
			}
			return this;
		}

		public Matrix3d SetColumns(Tuple3dc c0, Tuple3dc c1, Tuple3dc c2)
		{
			M00 = c0.x;
			M01 = c1.x;
			M02 = c2.x;
			M10 = c0.y;
			M11 = c1.y;
			M12 = c2.y;
			M20 = c0.z;
			M21 = c1.z;
			M22 = c2.z;

			return this;
		}

		public Matrix3d SetRow(Tuple3dc t, int r)
		{
			if (r == 0)
			{
				M00 = t.x;
				M01 = t.y;
				M02 = t.z;
			}
			if (r == 1)
			{
				M10 = t.x;
				M11 = t.y;
				M12 = t.z;
			}
			if (r == 2)
			{
				M20 = t.x;
				M21 = t.y;
				M22 = t.z;
			}

			return this;
		}

		public Matrix3d SetRow(double x, double y, double z, int r)
		{
			if (r == 0)
			{
				M00 = x;
				M01 = y;
				M02 = z;
			}
			if (r == 1)
			{
				M10 = x;
				M11 = y;
				M12 = z;
			}
			if (r == 2)
			{
				M20 = x;
				M21 = y;
				M22 = z;
			}

			return this;
		}

		public Matrix3d SetRow(double[] d, int r)
		{
			if (r == 0)
			{
				M00 = d[0];
				M01 = d[1];
				M02 = d[2];
			}

			if (r == 1)
			{
				M10 = d[0];
				M11 = d[1];
				M12 = d[2];
			}

			if (r == 2)
			{
				M20 = d[0];
				M21 = d[1];
				M22 = d[2];
			}

			return this;
		}

		public Matrix3d SetRows(Tuple3dc r0, Tuple3dc r1, Tuple3dc r2)
		{
			M00 = r0.x;
			M01 = r0.y;
			M02 = r0.z;
			M10 = r1.x;
			M11 = r1.y;
			M12 = r1.z;
			M20 = r2.x;
			M21 = r2.y;
			M22 = r2.z;

			return this;
		}

		public Matrix3d SetIdentity()
		{
			M00 = 1;
			M01 = 0;
			M02 = 0;
			M10 = 0;
			M11 = 1;
			M12 = 0;
			M20 = 0;
			M21 = 0;
			M22 = 1;

			return this;
		}

		public Matrix3d SetZero()
		{
			M00 = 0;
			M01 = 0;
			M02 = 0;
			M10 = 0;
			M11 = 0;
			M12 = 0;
			M20 = 0;
			M21 = 0;
			M22 = 0;

			return this;
		}

		public Matrix3d SetRotationX(double a)
		{
			double s = Math.Sin(a);
			double c = Math.Cos(a);

			M00 = 1;
			M01 = 0;
			M02 = 0;
			M10 = 0;
			M11 = c;
			M12 = -s;
			M20 = 0;
			M21 = s;
			M22 = c;

			return this;
		}

		public Matrix3d SetRotationY(double a)
		{
			double s = Math.Sin(a);
			double c = Math.Cos(a);

			M00 = c;
			M01 = 0;
			M02 = s;
			M10 = 0;
			M11 = 1;
			M12 = 0;
			M20 = -s;
			M21 = 0;
			M22 = c;

			return this;
		}

		public Matrix3d SetRotationZ(double a)
		{
			double s = Math.Sin(a);
			double c = Math.Cos(a);

			M00 = c;
			M01 = -s;
			M02 = 0;
			M10 = s;
			M11 = c;
			M12 = 0;
			M20 = 0;
			M21 = 0;
			M22 = 1;

			return this;
		}

		public static Matrix3d RotateXMatrix(double a)
		{
			Matrix3d ret = new Matrix3d();
			ret.SetRotationX(a);
			return ret;
		}

		public static Matrix3d RotateYMatrix(double a)
		{
			Matrix3d ret = new Matrix3d();
			ret.SetRotationY(a);
			return ret;
		}

		public static Matrix3d RotateZMatrix(double a)
		{
			Matrix3d ret = new Matrix3d();
			ret.SetRotationZ(a);
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
				else if (c == 2) return M02;
			}
			else if (r == 1)
			{
				if (c == 0) return M10;
				else if (c == 1) return M11;
				else if (c == 2) return M12;
			}
			else if (r == 2)
			{
				if (c == 0) return M20;
				else if (c == 1) return M21;
				else if (c == 2) return M22;
			}

			return 0;
		}

		public Tuple3dc GetColumn(int c)
		{
			if (c == 0) return new Tuple3dc(M00, M10, M20);
			if (c == 1) return new Tuple3dc(M01, M11, M21);
			if (c == 2) return new Tuple3dc(M02, M12, M22);
			return new Tuple3dc(0, 0, 0);
		}

		public void GetColumns(out Tuple3dc c0, out Tuple3dc c1, out Tuple3dc c2)
		{
			c0 = new Tuple3dc(M00, M10, M20);
			c1 = new Tuple3dc(M01, M11, M21);
			c2 = new Tuple3dc(M02, M12, M22);
		}

		public Tuple3dc GetRow(int r)
		{
			if (r == 0) return new Tuple3dc(M00, M01, M02);
			if (r == 1) return new Tuple3dc(M10, M11, M12);
			if (r == 2) return new Tuple3dc(M20, M21, M22);
			return new Tuple3dc(0, 0, 0);
		}

		public void GetRows(out Tuple3dc r0, out Tuple3dc r1, out Tuple3dc r2)
		{
			r0 = new Tuple3dc(M00, M01, M02);
			r1 = new Tuple3dc(M10, M11, M12);
			r2 = new Tuple3dc(M20, M21, M22);
		}

		public void GetElements(
			out double _m00, out double _m01, out double _m02,
			out double _m10, out double _m11, out double _m12,
			out double _m20, out double _m21, out double _m22)
		{
			_m00 = M00;
			_m01 = M01;
			_m02 = M02;
			_m10 = M10;
			_m11 = M11;
			_m12 = M12;
			_m20 = M20;
			_m21 = M21;
			_m22 = M22;
		}
		#endregion

		#region Operators
		public static Matrix3d operator *(Matrix3d a, Matrix3d b)
		{
			Matrix3d ret = new Matrix3d();

			ret.M00 = a.M00 * b.M00 + a.M01 * b.M10 + a.M02 * b.M20;
			ret.M01 = a.M00 * b.M01 + a.M01 * b.M11 + a.M02 * b.M21;
			ret.M02 = a.M00 * b.M02 + a.M01 * b.M12 + a.M02 * b.M22;
			ret.M10 = a.M10 * b.M00 + a.M11 * b.M10 + a.M12 * b.M20;
			ret.M11 = a.M10 * b.M01 + a.M11 * b.M11 + a.M12 * b.M21;
			ret.M12 = a.M10 * b.M02 + a.M11 * b.M12 + a.M12 * b.M22;
			ret.M20 = a.M20 * b.M00 + a.M21 * b.M10 + a.M22 * b.M20;
			ret.M21 = a.M20 * b.M01 + a.M21 * b.M11 + a.M22 * b.M21;
			ret.M22 = a.M20 * b.M02 + a.M21 * b.M12 + a.M22 * b.M22;

			return ret;
		}

		public static Tuple3dc operator *(Matrix3d a, Tuple3dc t)
		{
			return new Tuple3dc(
				a.M00 * t.x + a.M01 * t.y + a.M02 * t.z,
				a.M10 * t.x + a.M11 * t.y + a.M12 * t.z,
				a.M20 * t.x + a.M21 * t.y + a.M22 * t.z);
		}

		public static Matrix3d operator *(Matrix3d a, double d)
		{
			return new Matrix3d(
				a.M00 * d, a.M01 * d, a.M02 * d,
				a.M10 * d, a.M11 * d, a.M12 * d,
				a.M20 * d, a.M21 * d, a.M22 * d);
		}

		public static Matrix3d operator +(Matrix3d a, Matrix3d m)
		{
			return new Matrix3d(
				a.M00 + m.M00, a.M01 + m.M01, a.M02 + m.M02,
				a.M10 + m.M10, a.M11 + m.M11, a.M12 + m.M12,
				a.M20 + m.M20, a.M21 + m.M21, a.M22 + m.M22);
		}

		public static Matrix3d operator -(Matrix3d a, Matrix3d m)
		{
			return new Matrix3d(
				a.M00 - m.M00, a.M01 - m.M01, a.M02 - m.M02,
				a.M10 - m.M10, a.M11 - m.M11, a.M12 - m.M12,
				a.M20 - m.M20, a.M21 - m.M21, a.M22 - m.M22);
		}

		public static Matrix3d operator +(Matrix3d m)
		{
			return new Matrix3d(
				m.M00, m.M01, m.M02,
				m.M10, m.M11, m.M12,
				m.M20, m.M21, m.M22);
		}

		public static Matrix3d operator -(Matrix3d m)
		{
			return new Matrix3d(
				-m.M00, -m.M01, -m.M02,
				-m.M10, -m.M11, -m.M12,
				-m.M20, -m.M21, -m.M22);
		}

		public static Matrix3d operator ~(Matrix3d m)
		{
			return new Matrix3d(
				m.M00, m.M10, m.M20,
				m.M01, m.M11, m.M21,
				m.M02, m.M12, m.M22);
		}

		public static Matrix3d operator !(Matrix3d m)
		{
			double d = m.Determinate;
			if (Math.Abs(d) < 1e-10) throw new ArithmeticException("Determinate of the matrix is 0, this matrix can't be inverted");

			return new Matrix3d(
				(m.M11 * m.M22 - m.M12 * m.M21) / d, (-m.M01 * m.M22 + m.M02 * m.M21) / d, (m.M01 * m.M12 - m.M02 * m.M11) / d,
				(-m.M10 * m.M22 + m.M12 * m.M20) / d, (m.M00 * m.M22 - m.M02 * m.M20) / d, (-m.M00 * m.M12 + m.M02 * m.M10) / d,
				(m.M10 * m.M21 - m.M11 * m.M20) / d, (-m.M00 * m.M21 + m.M01 * m.M20) / d, (m.M00 * m.M11 - m.M01 * m.M10) / d);
		}
		#endregion

		#region Arithmetic Functions
		public Matrix3d Transpose()
		{
			return ~this;
		}

		public Matrix3d Invert()
		{
			return !this;
		}

		public double Determinate
		{
			get
			{
				return M00 * (M11 * M22 - M12 * M21) + M01 * (M12 * M20 - M10 * M22) + M02 * (M10 * M21 - M11 * M20);
			}
		}
		#endregion
	}
}