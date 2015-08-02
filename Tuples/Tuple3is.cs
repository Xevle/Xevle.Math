using System;
using Xevle.Core;

namespace Xevle.Maths.Tuples
{
	public struct Tuple3is: ITuple
	{
		#region Variables
		/// <summary>
		/// Variable to store the x value.
		/// </summary>
		public int x;

		/// <summary>
		/// Variable to store the y value.
		/// </summary>
		public int y;

		/// <summary>
		/// Variable to store the z value.
		/// </summary>
		public int z;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="Xevle.Math.Tuple3is"/> class.
		/// </summary>
		/// <param name="tuple">Instance of an ITuple implementor.</param>
		public Tuple3is(ITuple tuple)
		{
			x = (int)tuple.X;
			y = (int)tuple.Y;
			z = (int)tuple.Z;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Xevle.Math.Tuple3is"/> class.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		public Tuple3is(int x = 0, int y = 0, int z = 0)
		{
			this.x = (int)x;
			this.y = (int)y;
			this.z = (int)z;
		}
		#endregion

		#region Operators
		#region Unary operators
		/// <summary>
		/// Does nothing, only for completeness
		/// </summary>
		/// <param name="a">The tuple</param>
		public static Tuple3is operator +(Tuple3is a)
		{
			return new Tuple3is(a);
		}

		/// <summary>
		/// Invert the sign of the x, y and z component
		/// </summary>
		/// <param name="a">The tuple</param>
		public static Tuple3is operator -(Tuple3is a)
		{
			return new Tuple3is(-a.x, -a.y, -a.z);
		}

		/// <summary>
		/// Calculate the magnitude of a vectors
		/// </summary>
		/// <param name="a">The tuple</param>
		public static double operator !(Tuple3is a)
		{
			return System.Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
		}
		#endregion

		#region Binary operators
		/// <summary>
		/// Add one vector to another vector.
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static Tuple3is operator+(Tuple3is a, Tuple3is b)
		{
			return new Tuple3is(a.x + b.x, a.y + b.y, a.z + b.z);
		}

		/// <summary>
		/// Add one vector to another vector.
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple as ITuple</param>
		public static Tuple3is operator+(Tuple3is a, ITuple b)
		{
			return new Tuple3is(a.x + (int)b.X, a.y + (int)b.Y, a.z + (int)b.Z);
		}

		/// <summary>
		/// Subtracts one vector from another vector.
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple</param>
		public static Tuple3is operator-(Tuple3is a, Tuple3is b)
		{
			return new Tuple3is(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		/// <summary>
		/// Subtracts one vector from another vector.
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple as ITuple</param>
		public static Tuple3is operator-(Tuple3is a, ITuple b)
		{
			return new Tuple3is(a.x - (int)b.X, a.y - (int)b.Y, a.z - (int)b.Z);
		}

		/// <summary>
		/// Scale the vector
		/// </summary>
		/// <param name="a">The tuple</param>
		/// <param name="b">The scale value</param>
		public static Tuple3is operator *(Tuple3is a, int b)
		{
			return new Tuple3is(a.x * b, a.y * b, a.z * b);
		}

		/// <summary>
		/// Returns the dot product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static double operator *(Tuple3is a, Tuple3is b)
		{
			return a.x * b.x + a.y * b.y + a.z * b.z;
		}

		/// <summary>
		/// Returns the dot product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple as ITuple</param>
		public static double operator *(Tuple3is a, ITuple b)
		{
			return a.x * b.X + a.y * b.Y + a.z * b.Z;
		}

		/// <summary>
		/// Returns the cross product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static Tuple3is operator ^(Tuple3is a, Tuple3is b)
		{
			return new Tuple3is(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
		}

		/// <summary>
		/// Returns the cross product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple as ITuple</param>
		public static Tuple3is operator ^(Tuple3is a, ITuple b)
		{
			return new Tuple3is(a.y * (int)b.Z - a.z * (int)b.Y, a.z * (int)b.X - a.x * (int)b.Z, a.x * (int)b.Y - a.y * (int)b.X);
		}

		/// <summary>
		/// Calculate the distance of two vectors
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple</param>
		public static double operator %(Tuple3is a, Tuple3is b)
		{
			return !(a - b);
		}

		/// <summary>
		/// Calculate the distance of two vectors
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple as ITuple</param>
		public static double operator %(Tuple3is a, ITuple b)
		{
			return !(a - b);
		}
		#endregion
		#endregion

		#region Methods
		/// <summary>
		/// Calculate the angle between this and the b vector
		/// </summary>
		/// <returns>The angle from this tuple to tuple b</returns>
		/// <param name="b">The tuple</param>
		public double AngleTo(Tuple3is b)
		{
			double c = (this * b) / (!this * !b);
			if (c > 1) c = 1;
			if (c < -1) c = -1;
			return System.Math.Acos(c);
		}

		/// <summary>
		/// Calculate if a tuple is inner a defined epsilon
		/// </summary>
		/// <returns><c>true</c>, if the tuple was is identical in the range of epsilon, <c>false</c> otherwise.</returns>
		/// <param name="a">The alpha component.</param>
		/// <param name="epsilon">maximum difference value</param>
		public bool EpsilonEquals(ITuple a, double epsilon)
		{
			double diff = x - a.X;
			if ((diff >= 0.0 ? diff : -diff) > epsilon) return false;

			diff = y - a.Y;
			if ((diff >= 0.0 ? diff : -diff) > epsilon) return false;

			diff = z - a.Z;
			return (diff >= 0.0 ? diff : -diff) <= epsilon;
		}

		/// <summary>
		/// Calculate if a tuple is inner a defined epsilon on 2 dimensions
		/// </summary>
		/// <returns><c>true</c>, if the tuple was is identical in the range of epsilon, <c>false</c> otherwise.</returns>
		/// <param name="a">The alpha component.</param>
		/// <param name="epsilon">maximum difference value</param>
		public bool EpsilonEquals2D(ITuple a, double epsilon)
		{
			double diff = x - a.X;
			if ((diff >= 0.0 ? diff : -diff) > epsilon) return false;

			diff = y - a.Y;
			return (diff >= 0.0 ? diff : -diff) <= epsilon;
		}

		/// <summary>
		/// Returns a <see cref="System.String"/> that represents the current <see cref="Xevle.Math.Tuples.Tuple3is"/>.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents the current <see cref="Xevle.Math.Tuples.Tuple3is"/>.</returns>
		public override string ToString()
		{
			return String.Format("({0}; {1}; {2})", x, y, z);
		}
		#endregion

		#region ITuple implementation
		/// <summary>
		/// Gets or sets the value U.
		/// </summary>
		/// <value>U</value>
		public double U
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>
		/// Gets or sets the value V.
		/// </summary>
		/// <value>The v.</value>
		public double V
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>
		/// Gets or sets the value X.
		/// </summary>
		/// <value>The x.</value>
		public double X
		{
			get
			{
				return x;
			}
			set
			{
				x = (int)value;
			}
		}

		/// <summary>
		/// Gets or sets the value Y.
		/// </summary>
		/// <value>The y.</value>
		public double Y
		{
			get
			{
				return y;
			}
			set
			{
				y = (int)value;
			}
		}

		/// <summary>
		/// Gets or sets the value Z.
		/// </summary>
		/// <value>The z.</value>
		public double Z
		{
			get
			{
				return z;
			}
			set
			{
				z = (int)value;
			}
		}
		#endregion

		#region ICopy Members
		/// <summary>
		/// Copy this instance as ITuple
		/// </summary>
		ITuple ICopy<ITuple>.Copy()
		{
			return Copy();
		}

		/// <summary>
		/// Copy this instance as Tuple3is
		/// </summary>
		public Tuple3is Copy()
		{
			return (Tuple3is)MemberwiseClone();
		}
		#endregion
	}
}

