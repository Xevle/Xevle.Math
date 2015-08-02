using System;
using Xevle.Core;

namespace Xevle.Maths.Tuples
{
	public class Tuple2dc: ITuple
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
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="Xevle.Math.Tuple2dc"/> class.
		/// </summary>
		/// <param name="tuple">Instance of an ITuple implementor.</param>
		public Tuple2dc(ITuple tuple)
		{
			x = tuple.X;
			y = tuple.Y;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Xevle.Math.Tuple2dc"/> class.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		public Tuple2dc(double x = 0, double y = 0)
		{
			this.x = x;
			this.y = y;
		}
		#endregion

		#region Operators
		#region Unary operators
		/// <summary>
		/// Does nothing, only for completeness
		/// </summary>
		/// <param name="a">The tuple</param>
		public static Tuple2dc operator +(Tuple2dc a)
		{
			return new Tuple2dc(a);
		}

		/// <summary>
		/// Invert the sign of the x, y and z component
		/// </summary>
		/// <param name="a">The tuple</param>
		public static Tuple2dc operator -(Tuple2dc a)
		{
			return new Tuple2dc(-a.x, -a.y);
		}

		/// <summary>
		/// Calculate the magnitude of a vectors
		/// </summary>
		/// <param name="a">The tuple</param>
		public static double operator !(Tuple2dc a)
		{
			return System.Math.Sqrt(a.x * a.x + a.y * a.y);
		}

		/// <summary>
		/// Calculate the normalized vector
		/// </summary>
		/// <param name="a">The tuple</param>
		public static Tuple2dc operator ~(Tuple2dc a)
		{
			double magnitude = !a;
			if (magnitude == 0) return new Tuple2dc(1, 0);
			return new Tuple2dc(a.x / magnitude, a.y / magnitude);
		}
		#endregion

		#region Binary operators
		/// <summary>
		/// Add one vector to another vector.
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static Tuple2dc operator+(Tuple2dc a, Tuple2dc b)
		{
			return new Tuple2dc(a.x + b.x, a.y + b.y);
		}

		/// <summary>
		/// Add one vector to another vector.
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple as ITuple</param>
		public static Tuple2dc operator+(Tuple2dc a, ITuple b)
		{
			return new Tuple2dc(a.x + b.X, a.y + b.Y);
		}

		/// <summary>
		/// Subtracts one vector from another vector.
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple</param>
		public static Tuple2dc operator-(Tuple2dc a, Tuple2dc b)
		{
			return new Tuple2dc(a.x - b.x, a.y - b.y);
		}

		/// <summary>
		/// Subtracts one vector from another vector.
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple as ITuple</param>
		public static Tuple2dc operator-(Tuple2dc a, ITuple b)
		{
			return new Tuple2dc(a.x - b.X, a.y - b.Y);
		}

		/// <summary>
		/// Scale the vector
		/// </summary>
		/// <param name="a">The tuple</param>
		/// <param name="b">The scale value</param>
		public static Tuple2dc operator *(Tuple2dc a, double b)
		{
			return new Tuple2dc(a.x * b, a.y * b);
		}

		/// <summary>
		/// Returns the dot product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static double operator *(Tuple2dc a, Tuple2dc b)
		{
			return a.x * b.x + a.y * b.y;
		}

		/// <summary>
		/// Returns the dot product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple as ITuple</param>
		public static double operator *(Tuple2dc a, ITuple b)
		{
			return a.x * b.X + a.y * b.Y;
		}

		/// <summary>
		/// Returns the cross product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static Tuple3dc operator ^(Tuple2dc a, Tuple2dc b)
		{
			return new Tuple3dc(0, 0, a.x * b.y - a.y * b.x);
		}

		/// <summary>
		/// Returns the cross product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple as ITuple</param>
		public static Tuple3dc operator ^(Tuple2dc a, ITuple b)
		{
			return new Tuple3dc(0, 0, a.x * b.Y - a.y * b.X);
		}

		/// <summary>
		/// Calculate the distance of two vectors
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple</param>
		public static double operator %(Tuple2dc a, Tuple2dc b)
		{
			return !(a - b);
		}

		/// <summary>
		/// Calculate the distance of two vectors
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple as ITuple</param>
		public static double operator %(Tuple2dc a, ITuple b)
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
		public double AngleTo(Tuple2dc b)
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
			return (diff >= 0.0 ? diff : -diff) <= epsilon;
		}

		/// <summary>
		/// Returns a <see cref="System.String"/> that represents the current <see cref="Xevle.Math.Tuples.Tuple2dc"/>.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents the current <see cref="Xevle.Math.Tuples.Tuple2dc"/>.</returns>
		public override string ToString()
		{
			return String.Format("({0}; {1})", x, y);
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
				return 0;
			}
			set
			{
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
		/// Copy this instance as Tuple2dc
		/// </summary>
		public Tuple2dc Copy()
		{
			return (Tuple2dc)MemberwiseClone();
		}
		#endregion
	}
}

