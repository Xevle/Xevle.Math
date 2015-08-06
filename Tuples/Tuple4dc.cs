using System;
using Xevle.Core;

namespace Xevle.Maths.Tuples
{
	public class Tuple4dc: ITuple
	{
		#region Variables
		public double w;

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
		public Tuple4dc(ITuple tuple)
		{
			x = tuple.X;
			y = tuple.Y;
			z = tuple.Z;
			w = tuple.W;
		}

		public Tuple4dc(double x = 0, double y = 0, double z = 0, double w = 0)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}
		#endregion

		#region Operators
		#region Unary operators
		/// <summary>
		/// Does nothing, only for completeness
		/// </summary>
		/// <param name="a">The tuple</param>
		public static Tuple4dc operator +(Tuple4dc a)
		{
			return new Tuple4dc(a);
		}

		/// <summary>
		/// Invert the sign of the x, y and z component
		/// </summary>
		/// <param name="a">The tuple</param>
		public static Tuple4dc operator -(Tuple4dc a)
		{
			return new Tuple4dc(-a.x, -a.y, -a.z, -a.w);
		}

		/// <summary>
		/// Calculate the magnitude of a vectors
		/// </summary>
		/// <param name="a">The tuple</param>
		public static double operator !(Tuple4dc a)
		{
			return Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z + a.w * a.w);
		}

		/// <summary>
		/// Calculate the normalized vector
		/// </summary>
		/// <param name="a">The tuple</param>
		public static Tuple4dc operator ~(Tuple4dc a)
		{
			double magnitude = !a;
			if (Double.IsNaN(magnitude) || magnitude <= 0) return new Tuple4dc(1, 0, 0, 0);
			double length = Math.Sqrt(magnitude);
			return new Tuple4dc(a.x / length, a.y / length, a.z / length, a.w / length);
		}
		#endregion

		#region Binary operators
		/// <summary>
		/// Add one vector to another vector.
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static Tuple4dc operator+(Tuple4dc a, Tuple4dc b)
		{
			return new Tuple4dc(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		}

		/// <summary>
		/// Add one vector to another vector.
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple as ITuple</param>
		public static Tuple4dc operator+(Tuple4dc a, ITuple b)
		{
			return new Tuple4dc(a.x + b.X, a.y + b.Y, a.z + b.Z, a.w + b.W);
		}

		/// <summary>
		/// Subtracts one vector from another vector.
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple</param>
		public static Tuple4dc operator-(Tuple4dc a, Tuple4dc b)
		{
			return new Tuple4dc(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		}

		/// <summary>
		/// Subtracts one vector from another vector.
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple as ITuple</param>
		public static Tuple4dc operator-(Tuple4dc a, ITuple b)
		{
			return new Tuple4dc(a.x - b.X, a.y - b.Y, a.z - b.Z, a.w - b.W);
		}

		/// <summary>
		/// Scale the vector
		/// </summary>
		/// <param name="a">The tuple</param>
		/// <param name="b">The scale value</param>
		public static Tuple4dc operator *(Tuple4dc a, double b)
		{
			return new Tuple4dc(a.x * b, a.y * b, a.z * b, a.w * b);
		}

		/// <summary>
		/// Returns the dot product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static double operator *(Tuple4dc a, Tuple4dc b)
		{
			return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
		}

		/// <summary>
		/// Returns the dot product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple as ITuple</param>
		public static double operator *(Tuple4dc a, ITuple b)
		{
			return a.x * b.X + a.y * b.Y + a.z * b.Z + a.w * b.W;
		}

		/// <summary>
		/// Calculate the distance of two vectors
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple</param>
		public static double operator %(Tuple4dc a, Tuple4dc b)
		{
			return !(a - b);
		}

		/// <summary>
		/// Calculate the distance of two vectors
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple as ITuple</param>
		public static double operator %(Tuple4dc a, ITuple b)
		{
			return !(a - b);
		}
		#endregion

		#region Typecast operators
		public static implicit operator Tuple4dc(Tuple<double, double> source)
		{
			return new Tuple4dc(source.Item1, source.Item2);
		}

		public static implicit operator Tuple4dc(Tuple<float, float> source)
		{
			return new Tuple4dc(source.Item1, source.Item2);
		}

		public static implicit operator Tuple4dc(Tuple<int, int> source)
		{
			return new Tuple4dc(source.Item1, source.Item2);
		}

		public static implicit operator Tuple4dc(Tuple<double, double, double> source)
		{
			return new Tuple4dc(source.Item1, source.Item2, source.Item3);
		}

		public static implicit operator Tuple4dc(Tuple<float, float, float> source)
		{
			return new Tuple4dc(source.Item1, source.Item2, source.Item3);
		}

		public static implicit operator Tuple4dc(Tuple<int, int, int> source)
		{
			return new Tuple4dc(source.Item1, source.Item2, source.Item3);
		}
		#endregion
		#endregion

		#region Methods
		/// <summary>
		/// Calculate the angle between this and the b vector
		/// </summary>
		/// <returns>The angle from this tuple to tuple b</returns>
		/// <param name="b">The tuple</param>
		public double AngleTo(Tuple4dc b)
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
			if ((diff >= 0.0 ? diff : -diff) > epsilon) return false;

			diff = w - a.W;
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
		/// Returns a <see cref="System.String"/> that represents the current <see cref="Xevle.Math.Tuples.Tuple4dc"/>.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents the current <see cref="Xevle.Math.Tuples.Tuple4dc"/>.</returns>
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
				return w;
			}
			set
			{
				w = value;
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
		/// Copy this instance as Tuple4dc
		/// </summary>
		public Tuple4dc Copy()
		{
			return (Tuple4dc)MemberwiseClone();
		}
		#endregion
	}
}

