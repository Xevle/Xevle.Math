﻿using System;
using Xevle.Core;

namespace Xevle.Math.Tuples
{
	/// <summary>
	/// Represents a vector
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
            x=tuple.X;
            y=tuple.Y;
            z=tuple.Z;
        }

		/// <summary>
		/// Initializes a new instance of the <see cref="Xevle.Math.Tuple3dc"/> class.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
        public Tuple3dc(double x=0, double y=0, double z=0)
        {
            this.x=x;
            this.y=y;
            this.z=z;
        }
        #endregion

		#region Operators

		#region Binary operators
		/// <summary>
		/// Add one vector to another vector.
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static Tuple3dc operator+ (Tuple3dc a, Tuple3dc b)
		{
			return new Tuple3dc (a.x + b.x, a.y + b.y, a.z + b.z);
		}

		/// <summary>
		/// Subtracts one vector from another vector.
		/// </summary>
		/// <param name="a">The first tuple</param>
		/// <param name="b">The second tuple</param>
		public static Tuple3dc operator- (Tuple3dc a, Tuple3dc b)
		{
			return new Tuple3dc (a.x - b.x, a.y - b.y, a.z - b.z);
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
		/// Returns the cross product of two vectors
		/// </summary>
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static Tuple3dc operator ^(Tuple3dc a, Tuple3dc b) // cross product
		{
			return new Tuple3dc(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
		}
		#endregion
		#endregion

		#region Methods
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
                x=value;
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
                y=value;
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
                z=value;
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