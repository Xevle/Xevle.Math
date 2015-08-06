using System;
using Xevle.Core;

namespace Xevle.Maths.Tuples
{
	/// <summary>
	/// Represents a vector as a class
	/// </summary>
	public class Tuple3dc: ITuple
	{
		#region Variables
		/// <summary>
		/// Variable to store the x value.
		/// </summary>
		public double x;

		/// <summary>
		/// Variable to store the y value.
		/// </summary>
		public double y;

		/// <summary>
		/// Variable to store the z value.
		/// </summary>
		public double z;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="Xevle.Math.Tuple3dc"/> class.
		/// </summary>
		/// <param name="tuple">Instance of an ITuple implementor.</param>
		public Tuple3dc(ITuple tuple)
		{
			x = tuple.X;
			y = tuple.Y;
			z = tuple.Z;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Xevle.Math.Tuple3dc"/> class.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		public Tuple3dc(double x = 0, double y = 0, double z = 0)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
		#endregion

		#region Operators
		#region Unary operators
		/// <summary>
		/// Does nothing, only for completeness
		/// </summary>
		/// <param name="a">The tuple</param>
		public static Tuple3dc operator +(Tuple3dc a)
		{
			return new Tuple3dc(a);
		}

		/// <summary>
		/// Invert the sign of the x, y and z component
		/// </summary>
		/// <param name="a">The tuple</param>
		public static Tuple3dc operator -(Tuple3dc a)
		{
			return new Tuple3dc(-a.x, -a.y, -a.z);
		}

		/// <summary>
		/// Calculate the magnitude of a vectors
		/// </summary>
		/// <param name="a">The tuple</param>
		public static double operator !(Tuple3dc a)
		{
			return System.Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
		}

		/// <summary>
		/// Calculate the normalized vector
		/// </summary>
		/// <param name="a">The tuple</param>
		public static Tuple3dc operator ~(Tuple3dc a)
		{
			double magnitude = !a;
			if (magnitude == 0) return new Tuple3dc(1, 0, 0);
			return new Tuple3dc(a.x / magnitude, a.y / magnitude, a.z / magnitude);
		}
		#endregion

		#region Binary operators
		/// <summary>
		/// Add one vector to another vector.
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static Tuple3dc operator+(Tuple3dc a, Tuple3dc b)
		{
			return new Tuple3dc(a.x + b.x, a.y + b.y, a.z + b.z);
		}

		/// <summary>
		/// Add one vector to another vector.
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple as ITuple</param>
		public static Tuple3dc operator+(Tuple3dc a, ITuple b)
		{
			return new Tuple3dc(a.x + b.X, a.y + b.Y, a.z + b.Z);
		}

		/// <summary>
		/// Subtracts one vector from another vector.
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple</param>
		public static Tuple3dc operator-(Tuple3dc a, Tuple3dc b)
		{
			return new Tuple3dc(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		/// <summary>
		/// Subtracts one vector from another vector.
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple as ITuple</param>
		public static Tuple3dc operator-(Tuple3dc a, ITuple b)
		{
			return new Tuple3dc(a.x - b.X, a.y - b.Y, a.z - b.Z);
		}

		/// <summary>
		/// Scale the vector
		/// </summary>
		/// <param name="a">The tuple</param>
		/// <param name="b">The scale value</param>
		public static Tuple3dc operator *(Tuple3dc a, double b)
		{
			return new Tuple3dc(a.x * b, a.y * b, a.z * b);
		}

		/// <summary>
		/// Returns the dot product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static double operator *(Tuple3dc a, Tuple3dc b)
		{
			return a.x * b.x + a.y * b.y + a.z * b.z;
		}

		/// <summary>
		/// Returns the dot product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple as ITuple</param>
		public static double operator *(Tuple3dc a, ITuple b)
		{
			return a.x * b.X + a.y * b.Y + a.z * b.Z;
		}

		/// <summary>
		/// Returns the cross product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static Tuple3dc operator ^(Tuple3dc a, Tuple3dc b)
		{
			return new Tuple3dc(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
		}

		/// <summary>
		/// Returns the cross product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple as ITuple</param>
		public static Tuple3dc operator ^(Tuple3dc a, ITuple b)
		{
			return new Tuple3dc(a.y * b.Z - a.z * b.Y, a.z * b.X - a.x * b.Z, a.x * b.Y - a.y * b.X);
		}

		/// <summary>
		/// Calculate the distance of two vectors
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple</param>
		public static double operator %(Tuple3dc a, Tuple3dc b)
		{
			return !(a - b);
		}

		/// <summary>
		/// Calculate the distance of two vectors
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple as ITuple</param>
		public static double operator %(Tuple3dc a, ITuple b)
		{
			return !(a - b);
		}
		#endregion

		#region Typecast operators
		public static implicit operator Tuple3dc(Tuple<double, double> source)
		{
			return new Tuple3dc(source.Item1, source.Item2);
		}

		public static implicit operator Tuple3dc(Tuple<float, float> source)
		{
			return new Tuple3dc(source.Item1, source.Item2);
		}

		public static implicit operator Tuple3dc(Tuple<int, int> source)
		{
			return new Tuple3dc(source.Item1, source.Item2);
		}

		public static implicit operator Tuple3dc(Tuple<double, double, double> source)
		{
			return new Tuple3dc(source.Item1, source.Item2, source.Item3);
		}

		public static implicit operator Tuple3dc(Tuple<float, float, float> source)
		{
			return new Tuple3dc(source.Item1, source.Item2, source.Item3);
		}

		public static implicit operator Tuple3dc(Tuple<int, int, int> source)
		{
			return new Tuple3dc(source.Item1, source.Item2, source.Item3);
		}
		#endregion
		#endregion

		#region Methods
		/// <summary>
		/// Calculate the angle between this and the b vector
		/// </summary>
		/// <returns>The angle from this tuple to tuple b</returns>
		/// <param name="b">The tuple</param>
		public double AngleTo(Tuple3dc b)
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
		/// Returns a <see cref="System.String"/> that represents the current <see cref="Xevle.Math.Tuples.Tuple3dc"/>.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents the current <see cref="Xevle.Math.Tuples.Tuple3dc"/>.</returns>
		public override string ToString()
		{
			return String.Format("({0}; {1}; {2})", x, y, z);
		}
		#endregion

		#region ITuple implementation
		public double W
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
				x = value;
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
				y = value;
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
				z = value;
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
		/// Copy this instance as Tuple3dc
		/// </summary>
		public Tuple3dc Copy()
		{
			return (Tuple3dc)MemberwiseClone();
		}
		#endregion
	}
}