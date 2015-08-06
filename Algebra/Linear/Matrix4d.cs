using System;
using Xevle.Maths.Tuples;

namespace Xevle.Maths.Algebra.Linear
{
	/// <summary>
	/// | m00 m01 m02 m03 |
	/// | m10 m11 m12 m13 |
	/// | m20 m21 m22 m23 |
	/// |_m30 m31 m32 m33_|
	/// </summary>
	public class Matrix4d
	{
		public double M00 { get; internal set; }

		public double M01 { get; internal set; }

		public double M02 { get; internal set; }

		public double M03 { get; internal set; }

		public double M10 { get; internal set; }

		public double M11 { get; internal set; }

		public double M12 { get; internal set; }

		public double M13 { get; internal set; }

		public double M20 { get; internal set; }

		public double M21 { get; internal set; }

		public double M22 { get; internal set; }

		public double M23 { get; internal set; }

		public double M30 { get; internal set; }

		public double M31 { get; internal set; }

		public double M32 { get; internal set; }

		public double M33 { get; internal set; }

		#region Constructor
		public Matrix4d() : this(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1)
		{
		}

		public Matrix4d(double m00, double m01, double m02, double m03,
		                double m10, double m11, double m12, double m13,
		                double m20, double m21, double m22, double m23,
		                double m30, double m31, double m32, double m33)
		{
			this.M00 = m00;
			this.M01 = m01;
			this.M02 = m02;
			this.M03 = m03;
			this.M10 = m10;
			this.M11 = m11;
			this.M12 = m12;
			this.M13 = m13;
			this.M20 = m20;
			this.M21 = m21;
			this.M22 = m22;
			this.M23 = m23;
			this.M30 = m30;
			this.M31 = m31;
			this.M32 = m32;
			this.M33 = m33;
		}

		public Matrix4d(double[] matrix)
		{
			M00 = matrix[0];
			M01 = matrix[1];
			M02 = matrix[2];
			M03 = matrix[3];
			M10 = matrix[4];
			M11 = matrix[5];
			M12 = matrix[6];
			M13 = matrix[7];
			M20 = matrix[8];
			M21 = matrix[9];
			M22 = matrix[10];
			M23 = matrix[11];
			M30 = matrix[12];
			M31 = matrix[13];
			M32 = matrix[14];
			M33 = matrix[15];
		}

		public Matrix4d(float[] matrix)
		{
			M00 = matrix[0];
			M01 = matrix[1];
			M02 = matrix[2];
			M03 = matrix[3];
			M10 = matrix[4];
			M11 = matrix[5];
			M12 = matrix[6];
			M13 = matrix[7];
			M20 = matrix[8];
			M21 = matrix[9];
			M22 = matrix[10];
			M23 = matrix[11];
			M30 = matrix[12];
			M31 = matrix[13];
			M32 = matrix[14];
			M33 = matrix[15];
		}

		public Matrix4d(Matrix4d matrix)
		{
			M00 = matrix.M00;
			M01 = matrix.M01;
			M02 = matrix.M02;
			M03 = matrix.M03;
			M10 = matrix.M10;
			M11 = matrix.M11;
			M12 = matrix.M12;
			M13 = matrix.M13;
			M20 = matrix.M20;
			M21 = matrix.M21;
			M22 = matrix.M22;
			M23 = matrix.M23;
			M30 = matrix.M30;
			M31 = matrix.M31;
			M32 = matrix.M32;
			M33 = matrix.M33;
		}

		public override int GetHashCode()
		{
			long bits = BitConverter.DoubleToInt64Bits(M00);
			int hash = (int)(bits ^ (bits >> 32));

			bits = BitConverter.DoubleToInt64Bits(M01);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M02);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M03);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M10);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M11);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M12);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M13);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M20);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M21);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M22);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M23);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M30);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M31);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M32);
			hash ^= (int)(bits ^ (bits >> 32));
			bits = BitConverter.DoubleToInt64Bits(M33);
			hash ^= (int)(bits ^ (bits >> 32));

			return hash;
		}
		#endregion

		#region Set Functions
		public Matrix4d Set(double m00, double m01, double m02, double m03,
		                    double m10, double m11, double m12, double m13,
		                    double m20, double m21, double m22, double m23,
		                    double m30, double m31, double m32, double m33)
		{
			this.M00 = m00;
			this.M01 = m01;
			this.M02 = m02;
			this.M03 = m03;
			this.M10 = m10;
			this.M11 = m11;
			this.M12 = m12;
			this.M13 = m13;
			this.M20 = m20;
			this.M21 = m21;
			this.M22 = m22;
			this.M23 = m23;
			this.M30 = m30;
			this.M31 = m31;
			this.M32 = m32;
			this.M33 = m33;
			return this;
		}

		public Matrix4d Set(Matrix4d matrix)
		{
			M00 = matrix.M00;
			M01 = matrix.M01;
			M02 = matrix.M02;
			M03 = matrix.M03;
			M10 = matrix.M10;
			M11 = matrix.M11;
			M12 = matrix.M12;
			M13 = matrix.M13;
			M20 = matrix.M20;
			M21 = matrix.M21;
			M22 = matrix.M22;
			M23 = matrix.M23;
			M30 = matrix.M30;
			M31 = matrix.M31;
			M32 = matrix.M32;
			M33 = matrix.M33;
			return this;
		}

		public Matrix4d Set(double[] matrix)
		{
			M00 = matrix[0];
			M01 = matrix[1];
			M02 = matrix[2];
			M03 = matrix[3];
			M10 = matrix[4];
			M11 = matrix[5];
			M12 = matrix[6];
			M13 = matrix[7];
			M20 = matrix[8];
			M21 = matrix[9];
			M22 = matrix[10];
			M23 = matrix[11];
			M30 = matrix[12];
			M31 = matrix[13];
			M32 = matrix[14];
			M33 = matrix[15];

			return this;
		}

		public Matrix4d Set(float[] matrix)
		{
			M00 = matrix[0];
			M01 = matrix[1];
			M02 = matrix[2];
			M03 = matrix[3];
			M10 = matrix[4];
			M11 = matrix[5];
			M12 = matrix[6];
			M13 = matrix[7];
			M20 = matrix[8];
			M21 = matrix[9];
			M22 = matrix[10];
			M23 = matrix[11];
			M30 = matrix[12];
			M31 = matrix[13];
			M32 = matrix[14];
			M33 = matrix[15];

			return this;
		}

		public Matrix4d Set(int row, int column, double val)
		{
			if (row == 0)
			{
				if (column == 0) M00 = val;
				else if (column == 1) M01 = val;
				else if (column == 2) M02 = val;
				else if (column == 3) M03 = val;
			}
			else if (row == 1)
			{
				if (column == 0) M10 = val;
				else if (column == 1) M11 = val;
				else if (column == 2) M12 = val;
				else if (column == 3) M13 = val;
			}
			else if (row == 2)
			{
				if (column == 0) M20 = val;
				else if (column == 1) M21 = val;
				else if (column == 2) M22 = val;
				else if (column == 3) M23 = val;
			}
			else if (row == 3)
			{
				if (column == 0) M30 = val;
				else if (column == 1) M31 = val;
				else if (column == 2) M32 = val;
				else if (column == 3) M33 = val;
			}

			return this;
		}

		public Matrix4d SetColumn(Tuple4dc tuple, int column)
		{
			if (column == 0)
			{
				M00 = tuple.x;
				M10 = tuple.y;
				M20 = tuple.z;
				M30 = tuple.w;
			}
			else if (column == 1)
			{
				M01 = tuple.x;
				M11 = tuple.y;
				M21 = tuple.z;
				M31 = tuple.w;
			}
			else if (column == 2)
			{
				M02 = tuple.x;
				M12 = tuple.y;
				M22 = tuple.z;
				M32 = tuple.w;
			}
			else if (column == 3)
			{
				M03 = tuple.x;
				M13 = tuple.y;
				M23 = tuple.z;
				M33 = tuple.w;
			}

			return this;
		}

		public Matrix4d SetColumn(double x, double y, double z, double w, int column)
		{
			if (column == 0)
			{
				M00 = x;
				M10 = y;
				M20 = z;
				M30 = w;
			}
			else if (column == 1)
			{
				M01 = x;
				M11 = y;
				M21 = z;
				M31 = w;
			}
			else if (column == 2)
			{
				M02 = x;
				M12 = y;
				M22 = z;
				M32 = w;
			}
			else if (column == 3)
			{
				M03 = x;
				M13 = y;
				M23 = z;
				M33 = w;
			}

			return this;
		}

		public Matrix4d SetColumn(double[] doubles, int column)
		{
			if (column == 0)
			{
				M00 = doubles[0];
				M10 = doubles[1];
				M20 = doubles[2];
				M30 = doubles[3];
			}
			else if (column == 1)
			{
				M01 = doubles[0];
				M11 = doubles[1];
				M21 = doubles[2];
				M31 = doubles[3];
			}
			else if (column == 2)
			{
				M02 = doubles[0];
				M12 = doubles[1];
				M22 = doubles[2];
				M32 = doubles[3];
			}
			else if (column == 3)
			{
				M03 = doubles[0];
				M13 = doubles[1];
				M23 = doubles[2];
				M33 = doubles[3];
			}

			return this;
		}

		public Matrix4d SetColumns(Tuple4dc column0, Tuple4dc column1, Tuple4dc column2, Tuple4dc column3)
		{
			M00 = column0.x;
			M01 = column1.x;
			M02 = column2.x;
			M03 = column3.x;
			M10 = column0.y;
			M11 = column1.y;
			M12 = column2.y;
			M13 = column3.y;
			M20 = column0.z;
			M21 = column1.z;
			M22 = column2.z;
			M23 = column3.z;
			M30 = column0.w;
			M31 = column1.w;
			M32 = column2.w;
			M33 = column3.w;

			return this;
		}

		public Matrix4d SetRow(Tuple4dc tuple, int row)
		{
			if (row == 0)
			{
				M00 = tuple.x;
				M01 = tuple.y;
				M02 = tuple.z;
				M03 = tuple.w;
			}
			else if (row == 1)
			{
				M10 = tuple.x;
				M11 = tuple.y;
				M12 = tuple.z;
				M13 = tuple.w;
			}
			else if (row == 2)
			{
				M20 = tuple.x;
				M21 = tuple.y;
				M22 = tuple.z;
				M23 = tuple.w;
			}
			else if (row == 3)
			{
				M30 = tuple.x;
				M31 = tuple.y;
				M32 = tuple.z;
				M33 = tuple.w;
			}

			return this;
		}

		public Matrix4d SetRow(double x, double y, double z, double w, int row)
		{
			if (row == 0)
			{
				M00 = x;
				M01 = y;
				M02 = z;
				M03 = w;
			}
			else if (row == 1)
			{
				M10 = x;
				M11 = y;
				M12 = z;
				M13 = w;
			}
			else if (row == 2)
			{
				M20 = x;
				M21 = y;
				M22 = z;
				M23 = w;
			}
			else if (row == 3)
			{
				M30 = x;
				M31 = y;
				M32 = z;
				M33 = w;
			}

			return this;
		}

		public Matrix4d SetRow(double[] doubles, int row)
		{
			if (row == 0)
			{
				M00 = doubles[0];
				M01 = doubles[1];
				M02 = doubles[2];
				M03 = doubles[3];
			}

			if (row == 1)
			{
				M10 = doubles[0];
				M11 = doubles[1];
				M12 = doubles[2];
				M13 = doubles[3];
			}

			if (row == 2)
			{
				M20 = doubles[0];
				M21 = doubles[1];
				M22 = doubles[2];
				M23 = doubles[3];
			}

			if (row == 3)
			{
				M30 = doubles[0];
				M31 = doubles[1];
				M32 = doubles[2];
				M33 = doubles[3];
			}

			return this;
		}

		public Matrix4d SetRows(Tuple4dc row0, Tuple4dc row1, Tuple4dc row2, Tuple4dc row3)
		{
			M00 = row0.x;
			M01 = row0.y;
			M02 = row0.z;
			M03 = row0.w;
			M10 = row1.x;
			M11 = row1.y;
			M12 = row1.z;
			M13 = row1.w;
			M20 = row2.x;
			M21 = row2.y;
			M22 = row2.z;
			M23 = row2.w;
			M30 = row3.x;
			M31 = row3.y;
			M32 = row3.z;
			M33 = row3.w;

			return this;
		}

		public Matrix4d SetIdentity()
		{
			M00 = 1;
			M01 = 0;
			M02 = 0;
			M03 = 0;
			M10 = 0;
			M11 = 1;
			M12 = 0;
			M13 = 0;
			M20 = 0;
			M21 = 0;
			M22 = 1;
			M23 = 0;
			M30 = 0;
			M31 = 0;
			M32 = 0;
			M33 = 1;

			return this;
		}

		public Matrix4d SetZero()
		{
			M00 = 0;
			M01 = 0;
			M02 = 0;
			M03 = 0;
			M10 = 0;
			M11 = 0;
			M12 = 0;
			M13 = 0;
			M20 = 0;
			M21 = 0;
			M22 = 0;
			M23 = 0;
			M30 = 0;
			M31 = 0;
			M32 = 0;
			M33 = 0;

			return this;
		}

		public Matrix4d SetRotationX(double angle)
		{
			double s = Math.Sin(angle);
			double c = Math.Cos(angle);

			M00 = 1;
			M01 = 0;
			M02 = 0;
			M03 = 0;
			M10 = 0;
			M11 = c;
			M12 = -s;
			M13 = 0;
			M20 = 0;
			M21 = s;
			M22 = c;
			M23 = 0;
			M30 = 0;
			M31 = 0;
			M32 = 0;
			M33 = 1;

			return this;
		}

		public Matrix4d SetRotationY(double angle)
		{
			double s = Math.Sin(angle);
			double c = Math.Cos(angle);

			M00 = c;
			M01 = 0;
			M02 = s;
			M03 = 0;
			M10 = 0;
			M11 = 1;
			M12 = 0;
			M13 = 0;
			M20 = -s;
			M21 = 0;
			M22 = c;
			M23 = 0;
			M30 = 0;
			M31 = 0;
			M32 = 0;
			M33 = 1;

			return this;
		}

		public Matrix4d SetRotationZ(double angle)
		{
			double s = Math.Sin(angle);
			double c = Math.Cos(angle);

			M00 = c;
			M01 = -s;
			M02 = 0;
			M03 = 0;
			M10 = s;
			M11 = c;
			M12 = 0;
			M13 = 0;
			M20 = 0;
			M21 = 0;
			M22 = 1;
			M23 = 0;
			M30 = 0;
			M31 = 0;
			M32 = 0;
			M33 = 1;

			return this;
		}

		public Matrix4d SetRotationScale(Matrix3d matrix)
		{
			M00 = matrix.M00;
			M01 = matrix.M01;
			M02 = matrix.M02;
			M03 = 0;
			M10 = matrix.M10;
			M11 = matrix.M11;
			M12 = matrix.M12;
			M13 = 0;
			M20 = matrix.M20;
			M21 = matrix.M21;
			M22 = matrix.M22;
			M23 = 0;
			M30 = 0;
			M31 = 0;
			M32 = 0;
			M33 = 1;

			return this;
		}

		public Matrix4d SetRotation(double x, double y, double z, double angle)
		{
			double s = Math.Sin(angle);
			double c = Math.Cos(angle);
			double t = 1 - c;
			double mag = Math.Sqrt(x * x + y * y + z * z);

			x /= mag;
			y /= mag;
			z /= mag;

			M00 = t * x * x + c;
			M01 = t * x * y - s * z;
			M02 = t * x * z + s * y;
			M10 = t * x * y + s * z;
			M11 = t * y * y + c;
			M12 = t * y * z - s * x;
			M20 = t * x * z - s * y;
			M21 = t * y * z + s * x;
			M22 = t * z * z + c;
			M03 = M13 = M23 = 0;
			M30 = M31 = M32 = 0;
			M33 = 1;

			return this;
		}

		public Matrix4d SetRotation(Tuple3dc axis, double angle)
		{
			double s = Math.Sin(angle);
			double c = Math.Cos(angle);
			double t = 1 - c;

			Tuple3dc myp = ~axis;

			double x = myp.x;
			double y = myp.y;
			double z = myp.z;

			M00 = t * x * x + c;
			M01 = t * x * y - s * z;
			M02 = t * x * z + s * y;
			M10 = t * x * y + s * z;
			M11 = t * y * y + c;
			M12 = t * y * z - s * x;
			M20 = t * x * z - s * y;
			M21 = t * y * z + s * x;
			M22 = t * z * z + c;
			M03 = M13 = M23 = 0;
			M30 = M31 = M32 = 0;
			M33 = 1;

			return this;
		}

		public Matrix4d SetTranslation(double x, double y, double z)
		{
			M00 = 1;
			M01 = 0;
			M02 = 0;
			M03 = x;
			M10 = 0;
			M11 = 1;
			M12 = 0;
			M13 = y;
			M20 = 0;
			M21 = 0;
			M22 = 1;
			M23 = z;
			M30 = 0;
			M31 = 0;
			M32 = 0;
			M33 = 1;

			return this;
		}

		public Matrix4d SetTranslation(Tuple3dc tuple)
		{
			M00 = 1;
			M01 = 0;
			M02 = 0;
			M03 = tuple.x;
			M10 = 0;
			M11 = 1;
			M12 = 0;
			M13 = tuple.y;
			M20 = 0;
			M21 = 0;
			M22 = 1;
			M23 = tuple.z;
			M30 = 0;
			M31 = 0;
			M32 = 0;
			M33 = 1;

			return this;
		}

		public Matrix4d SetScale(double x, double y, double z)
		{
			M01 = M02 = M03 = 0;
			M10 = M12 = M13 = 0;
			M20 = M21 = M23 = 0;
			M30 = M31 = M32 = 0;
			M00 = x;
			M11 = y;
			M22 = z;
			M33 = 1;

			return this;
		}

		public Matrix4d SetScale(Tuple3dc tuple)
		{
			M01 = M02 = M03 = 0;
			M10 = M12 = M13 = 0;
			M20 = M21 = M23 = 0;
			M30 = M31 = M32 = 0;
			M00 = tuple.x;
			M11 = tuple.y;
			M22 = tuple.z;
			M33 = 1;

			return this;
		}

		public static Matrix4d RotationXMatrix(double angle)
		{
			return new Matrix4d().SetRotationX(angle);
		}

		public static Matrix4d RotationYMatrix(double angle)
		{
			return new Matrix4d().SetRotationY(angle);
		}

		public static Matrix4d RotationZMatrix(double angle)
		{
			return new Matrix4d().SetRotationZ(angle);
		}

		public static Matrix4d RotationMatrix(double x, double y, double z, double angle)
		{
			return new Matrix4d().SetRotation(x, y, z, angle);
		}

		public static Matrix4d RotationMatrix(Tuple3dc axis, double angle)
		{
			return new Matrix4d().SetRotation(axis, angle);
		}

		public static Matrix4d TranslationMatrix(double x, double y, double z)
		{
			return new Matrix4d().SetTranslation(x, y, z);
		}

		public static Matrix4d TranslationMatrix(Tuple3dc tuple)
		{
			return new Matrix4d().SetTranslation(tuple);
		}

		public static Matrix4d ScaleMatrix(double x, double y, double z)
		{
			return new Matrix4d().SetScale(x, y, z);
		}

		public static Matrix4d ScaleMatrix(Tuple3dc tuple)
		{
			return new Matrix4d().SetScale(tuple);
		}

		public static Matrix4d RotationScaleMatrix(Matrix3d matrix)
		{
			return new Matrix4d().SetRotationScale(matrix);
		}
		#endregion

		#region Get Functions
		public double Get(int row, int column)
		{
			if (row == 0)
			{
				if (column == 0) return M00;
				else if (column == 1) return M01;
				else if (column == 2) return M02;
				else if (column == 3) return M03;
			}
			else if (row == 1)
			{
				if (column == 0) return M10;
				else if (column == 1) return M11;
				else if (column == 2) return M12;
				else if (column == 3) return M13;
			}
			else if (row == 2)
			{
				if (column == 0) return M20;
				else if (column == 1) return M21;
				else if (column == 2) return M22;
				else if (column == 3) return M23;
			}
			else if (row == 3)
			{
				if (column == 0) return M30;
				else if (column == 1) return M31;
				else if (column == 2) return M32;
				else if (column == 3) return M33;
			}

			return 0;
		}

		public Tuple4dc GetColumn(int column)
		{
			if (column == 0) return new Tuple4dc(M00, M10, M20, M30);
			if (column == 1) return new Tuple4dc(M01, M11, M21, M31);
			if (column == 2) return new Tuple4dc(M02, M12, M22, M32);
			if (column == 3) return new Tuple4dc(M03, M13, M23, M33);

			return new Tuple4dc(0, 0, 0, 0);
		}

		public void GetColumns(out Tuple4dc column0, out Tuple4dc column1, out Tuple4dc column2, out Tuple4dc column3)
		{
			column0 = new Tuple4dc(M00, M10, M20, M30);
			column1 = new Tuple4dc(M01, M11, M21, M31);
			column2 = new Tuple4dc(M02, M12, M22, M32);
			column3 = new Tuple4dc(M03, M13, M23, M33);
		}

		public Tuple4dc GetRow(int row)
		{
			if (row == 0) return new Tuple4dc(M00, M01, M02, M03);
			if (row == 1) return new Tuple4dc(M10, M11, M12, M13);
			if (row == 2) return new Tuple4dc(M20, M21, M22, M23);
			if (row == 3) return new Tuple4dc(M30, M31, M32, M33);

			return new Tuple4dc(0, 0, 0, 0);
		}

		public void GetRows(out Tuple4dc row0, out Tuple4dc row1, out Tuple4dc row2, out Tuple4dc row3)
		{
			row0 = new Tuple4dc(M00, M01, M02, M03);
			row1 = new Tuple4dc(M10, M11, M12, M13);
			row2 = new Tuple4dc(M20, M21, M22, M23);
			row3 = new Tuple4dc(M30, M31, M32, M33);
		}

		public void GetElements(
			out double m00, out double m01, out double m02, out double m03,
			out double m10, out double m11, out double m12, out double m13,
			out double m20, out double m21, out double m22, out double m23,
			out double m30, out double m31, out double m32, out double m33)
		{
			m00 = this.M00;
			m01 = this.M01;
			m02 = this.M02;
			m03 = this.M03;
			m10 = this.M10;
			m11 = this.M11;
			m12 = this.M12;
			m13 = this.M13;
			m20 = this.M20;
			m21 = this.M21;
			m22 = this.M22;
			m23 = this.M23;
			m30 = this.M30;
			m31 = this.M31;
			m32 = this.M32;
			m33 = this.M33;
		}

		public void GetElements(float[] mat)
		{
			mat[0] = (float)M00;
			mat[1] = (float)M01;
			mat[2] = (float)M02;
			mat[3] = (float)M03;
			mat[4] = (float)M10;
			mat[5] = (float)M11;
			mat[6] = (float)M12;
			mat[7] = (float)M13;
			mat[8] = (float)M20;
			mat[9] = (float)M21;
			mat[10] = (float)M22;
			mat[11] = (float)M23;
			mat[12] = (float)M30;
			mat[13] = (float)M31;
			mat[14] = (float)M32;
			mat[15] = (float)M33;
		}

		public void GetElementsTransposed(float[] mat)
		{
			mat[0] = (float)M00;
			mat[4] = (float)M01;
			mat[8] = (float)M02;
			mat[12] = (float)M03;
			mat[1] = (float)M10;
			mat[5] = (float)M11;
			mat[9] = (float)M12;
			mat[13] = (float)M13;
			mat[2] = (float)M20;
			mat[6] = (float)M21;
			mat[10] = (float)M22;
			mat[14] = (float)M23;
			mat[3] = (float)M30;
			mat[7] = (float)M31;
			mat[11] = (float)M32;
			mat[15] = (float)M33;
		}

		public void GetElements(double[] mat)
		{
			mat[0] = M00;
			mat[1] = M01;
			mat[2] = M02;
			mat[3] = M03;
			mat[4] = M10;
			mat[5] = M11;
			mat[6] = M12;
			mat[7] = M13;
			mat[8] = M20;
			mat[9] = M21;
			mat[10] = M22;
			mat[11] = M23;
			mat[12] = M30;
			mat[13] = M31;
			mat[14] = M32;
			mat[15] = M33;
		}

		public void GetElementsTransposed(double[] mat)
		{
			mat[0] = M00;
			mat[1] = M10;
			mat[2] = M20;
			mat[3] = M30;
			mat[4] = M01;
			mat[5] = M11;
			mat[6] = M21;
			mat[7] = M31;
			mat[8] = M02;
			mat[9] = M12;
			mat[10] = M22;
			mat[11] = M32;
			mat[12] = M03;
			mat[13] = M13;
			mat[14] = M23;
			mat[15] = M33;
		}
		#endregion

		#region Operators
		public static Matrix4d operator *(Matrix4d a, Matrix4d b)
		{
			Matrix4d ret = new Matrix4d();
			ret.M00 = a.M00 * b.M00 + a.M01 * b.M10 + a.M02 * b.M20 + a.M03 * b.M30;
			ret.M01 = a.M00 * b.M01 + a.M01 * b.M11 + a.M02 * b.M21 + a.M03 * b.M31;
			ret.M02 = a.M00 * b.M02 + a.M01 * b.M12 + a.M02 * b.M22 + a.M03 * b.M32;
			ret.M03 = a.M00 * b.M03 + a.M01 * b.M13 + a.M02 * b.M23 + a.M03 * b.M33;

			ret.M10 = a.M10 * b.M00 + a.M11 * b.M10 + a.M12 * b.M20 + a.M13 * b.M30;
			ret.M11 = a.M10 * b.M01 + a.M11 * b.M11 + a.M12 * b.M21 + a.M13 * b.M31;
			ret.M12 = a.M10 * b.M02 + a.M11 * b.M12 + a.M12 * b.M22 + a.M13 * b.M32;
			ret.M13 = a.M10 * b.M03 + a.M11 * b.M13 + a.M12 * b.M23 + a.M13 * b.M33;

			ret.M20 = a.M20 * b.M00 + a.M21 * b.M10 + a.M22 * b.M20 + a.M23 * b.M30;
			ret.M21 = a.M20 * b.M01 + a.M21 * b.M11 + a.M22 * b.M21 + a.M23 * b.M31;
			ret.M22 = a.M20 * b.M02 + a.M21 * b.M12 + a.M22 * b.M22 + a.M23 * b.M32;
			ret.M23 = a.M20 * b.M03 + a.M21 * b.M13 + a.M22 * b.M23 + a.M23 * b.M33;

			ret.M30 = a.M30 * b.M00 + a.M31 * b.M10 + a.M32 * b.M20 + a.M33 * b.M30;
			ret.M31 = a.M30 * b.M01 + a.M31 * b.M11 + a.M32 * b.M21 + a.M33 * b.M31;
			ret.M32 = a.M30 * b.M02 + a.M31 * b.M12 + a.M32 * b.M22 + a.M33 * b.M32;
			ret.M33 = a.M30 * b.M03 + a.M31 * b.M13 + a.M32 * b.M23 + a.M33 * b.M33;
			return ret;
		}

		public static Tuple3dc operator *(Matrix4d a, Tuple3dc p)
		{
			double x = a.M00 * p.x + a.M01 * p.y + a.M02 * p.z + a.M03;
			double y = a.M10 * p.x + a.M11 * p.y + a.M12 * p.z + a.M13;
			double z = a.M20 * p.x + a.M21 * p.y + a.M22 * p.z + a.M23;
			double w = a.M30 * p.x + a.M31 * p.y + a.M32 * p.z + a.M33;
			return new Tuple3dc(x / w, y / w, z / w);
		}

		public static Matrix4d operator *(Matrix4d a, double d)
		{
			return new Matrix4d(
				a.M00 * d, a.M01 * d, a.M02 * d, a.M03 * d,
				a.M10 * d, a.M11 * d, a.M12 * d, a.M13 * d,
				a.M20 * d, a.M21 * d, a.M22 * d, a.M23 * d,
				a.M30 * d, a.M31 * d, a.M32 * d, a.M33 * d);
		}

		public static Matrix4d operator +(Matrix4d a, Matrix4d m)
		{
			return new Matrix4d(
				a.M00 + m.M00, a.M01 + m.M01, a.M02 + m.M02, a.M03 + m.M03,
				a.M10 + m.M10, a.M11 + m.M11, a.M12 + m.M12, a.M13 + m.M13,
				a.M20 + m.M20, a.M21 + m.M21, a.M22 + m.M22, a.M23 + m.M23,
				a.M30 + m.M30, a.M31 + m.M31, a.M32 + m.M32, a.M33 + m.M33);
		}

		public static Matrix4d operator -(Matrix4d a, Matrix4d m)
		{
			return new Matrix4d(
				a.M00 - m.M00, a.M01 - m.M01, a.M02 - m.M02, a.M03 - m.M03,
				a.M10 - m.M10, a.M11 - m.M11, a.M12 - m.M12, a.M13 - m.M13,
				a.M20 - m.M20, a.M21 - m.M21, a.M22 - m.M22, a.M23 - m.M23,
				a.M30 - m.M30, a.M31 - m.M31, a.M32 - m.M32, a.M33 - m.M33);
		}

		public static Matrix4d operator +(Matrix4d a)
		{
			return a;
		}

		public static Matrix4d operator -(Matrix4d a)
		{
			return new Matrix4d(
				-a.M00, -a.M01, -a.M02, -a.M03,
				-a.M10, -a.M11, -a.M12, -a.M13,
				-a.M20, -a.M21, -a.M22, -a.M23,
				-a.M30, -a.M31, -a.M32, -a.M33);
		}

		public static Matrix4d operator ~(Matrix4d a)
		{
			return new Matrix4d(
				a.M00, a.M10, a.M20, a.M30,
				a.M01, a.M11, a.M21, a.M31,
				a.M02, a.M12, a.M22, a.M32,
				a.M03, a.M13, a.M23, a.M33);
		}

		public static Matrix4d operator !(Matrix4d a)
		{
			double d = a.Det;
			if (Math.Abs(d) < 1e-10) throw new ArithmeticException("Determinate of the matrix is 0, this matrix can't be inverted");

			return new Matrix4d(
				(a.M11 * (a.M22 * a.M33 - a.M23 * a.M32) + a.M12 * (a.M23 * a.M31 - a.M21 * a.M33) + a.M13 * (a.M21 * a.M32 - a.M22 * a.M31)) / d,
				(a.M21 * (a.M02 * a.M33 - a.M03 * a.M32) + a.M22 * (a.M03 * a.M31 - a.M01 * a.M33) + a.M23 * (a.M01 * a.M32 - a.M02 * a.M31)) / d,
				(a.M31 * (a.M02 * a.M13 - a.M03 * a.M12) + a.M32 * (a.M03 * a.M11 - a.M01 * a.M13) + a.M33 * (a.M01 * a.M12 - a.M02 * a.M11)) / d,
				(a.M01 * (a.M13 * a.M22 - a.M12 * a.M23) + a.M02 * (a.M11 * a.M23 - a.M13 * a.M21) + a.M03 * (a.M12 * a.M21 - a.M11 * a.M22)) / d,
				(a.M12 * (a.M20 * a.M33 - a.M23 * a.M30) + a.M13 * (a.M22 * a.M30 - a.M20 * a.M32) + a.M10 * (a.M23 * a.M32 - a.M22 * a.M33)) / d,
				(a.M22 * (a.M00 * a.M33 - a.M03 * a.M30) + a.M23 * (a.M02 * a.M30 - a.M00 * a.M32) + a.M20 * (a.M03 * a.M32 - a.M02 * a.M33)) / d,
				(a.M32 * (a.M00 * a.M13 - a.M03 * a.M10) + a.M33 * (a.M02 * a.M10 - a.M00 * a.M12) + a.M30 * (a.M03 * a.M12 - a.M02 * a.M13)) / d,
				(a.M02 * (a.M13 * a.M20 - a.M10 * a.M23) + a.M03 * (a.M10 * a.M22 - a.M12 * a.M20) + a.M00 * (a.M12 * a.M23 - a.M13 * a.M22)) / d,
				(a.M13 * (a.M20 * a.M31 - a.M21 * a.M30) + a.M10 * (a.M21 * a.M33 - a.M23 * a.M31) + a.M11 * (a.M23 * a.M30 - a.M20 * a.M33)) / d,
				(a.M23 * (a.M00 * a.M31 - a.M01 * a.M30) + a.M20 * (a.M01 * a.M33 - a.M03 * a.M31) + a.M21 * (a.M03 * a.M30 - a.M00 * a.M33)) / d,
				(a.M33 * (a.M00 * a.M11 - a.M01 * a.M10) + a.M30 * (a.M01 * a.M13 - a.M03 * a.M11) + a.M31 * (a.M03 * a.M10 - a.M00 * a.M13)) / d,
				(a.M03 * (a.M11 * a.M20 - a.M10 * a.M21) + a.M00 * (a.M13 * a.M21 - a.M11 * a.M23) + a.M01 * (a.M10 * a.M23 - a.M13 * a.M20)) / d,
				(a.M10 * (a.M22 * a.M31 - a.M21 * a.M32) + a.M11 * (a.M20 * a.M32 - a.M22 * a.M30) + a.M12 * (a.M21 * a.M30 - a.M20 * a.M31)) / d,
				(a.M20 * (a.M02 * a.M31 - a.M01 * a.M32) + a.M21 * (a.M00 * a.M32 - a.M02 * a.M30) + a.M22 * (a.M01 * a.M30 - a.M00 * a.M31)) / d,
				(a.M30 * (a.M02 * a.M11 - a.M01 * a.M12) + a.M31 * (a.M00 * a.M12 - a.M02 * a.M10) + a.M32 * (a.M01 * a.M10 - a.M00 * a.M11)) / d,
				(a.M00 * (a.M11 * a.M22 - a.M12 * a.M21) + a.M01 * (a.M12 * a.M20 - a.M10 * a.M22) + a.M02 * (a.M10 * a.M21 - a.M11 * a.M20)) / d);
		}
		#endregion

		#region Arithmetic Functions
		public Matrix4d Transpose()
		{
			return ~this;
		}

		public Matrix4d Invert()
		{
			return !this;
		}

		public double Det
		{
			get
			{
				return (M00 * M11 - M01 * M10) * (M22 * M33 - M23 * M32)
				- (M00 * M12 - M02 * M10) * (M21 * M33 - M23 * M31)
				+ (M00 * M13 - M03 * M10) * (M21 * M32 - M22 * M31)
				+ (M01 * M12 - M02 * M11) * (M20 * M33 - M23 * M30)
				- (M01 * M13 - M03 * M11) * (M20 * M32 - M22 * M30)
				+ (M02 * M13 - M03 * M12) * (M20 * M31 - M21 * M30);
			}
		}

		public double Determinate
		{
			get { return Det; }
		}
		#endregion

		public Matrix4d SetColumns(Tuple3dc column0, Tuple3dc column1, Tuple3dc column2)
		{
			M00 = column0.x;
			M01 = column1.x;
			M02 = column2.x;
			M03 = 0;
			M10 = column0.y;
			M11 = column1.y;
			M12 = column2.y;
			M13 = 0;
			M20 = column0.z;
			M21 = column1.z;
			M22 = column2.z;
			M23 = 0;
			M30 = 0;
			M31 = 0;
			M32 = 0;
			M33 = 1;

			return this;
		}

		public Matrix4d SetColumns(Tuple3dc column0, Tuple3dc column1, Tuple3dc column2, Tuple3dc column3)
		{
			M00 = column0.x;
			M01 = column1.x;
			M02 = column2.x;
			M03 = column3.x;
			M10 = column0.y;
			M11 = column1.y;
			M12 = column2.y;
			M13 = column3.y;
			M20 = column0.z;
			M21 = column1.z;
			M22 = column2.z;
			M23 = column3.z;
			M30 = 0;
			M31 = 0;
			M32 = 0;
			M33 = 1;

			return this;
		}

		public Matrix4d SetRows(Tuple3dc row0, Tuple3dc row1, Tuple3dc row2)
		{
			M00 = row0.x;
			M01 = row0.y;
			M02 = row0.z;
			M03 = 0;
			M10 = row1.x;
			M11 = row1.y;
			M12 = row1.z;
			M13 = 0;
			M20 = row2.x;
			M21 = row2.y;
			M22 = row2.z;
			M23 = 0;
			M30 = 0;
			M31 = 0;
			M32 = 0;
			M33 = 1;

			return this;
		}

		public Matrix4d SetRows(Tuple3dc row0, Tuple3dc row1, Tuple3dc row2, Tuple3dc row3)
		{
			M00 = row0.x;
			M01 = row0.y;
			M02 = row0.z;
			M03 = 0;
			M10 = row1.x;
			M11 = row1.y;
			M12 = row1.z;
			M13 = 0;
			M20 = row2.x;
			M21 = row2.y;
			M22 = row2.z;
			M23 = 0;
			M30 = row3.x;
			M31 = row3.y;
			M32 = row3.z;
			M33 = 1;

			return this;
		}
	}
}
