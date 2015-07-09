using System;

namespace Xevle.Math
{
	/// <summary>
	/// Represents a vector
	/// </summary>
    public class Tuple3dc: ITuple
    {
        #region Variables
        public double x;
        public double y;
        public double z;
        #endregion

        #region Constructors
        public Tuple3dc(ITuple tuple)
        {
            x=tuple.X;
            y=tuple.Y;
            z=tuple.Z;
        }

        public Tuple3dc(double x=0, double y=0, double z=0)
        {
            this.x=x;
            this.y=y;
            this.z=z;
        }
        #endregion

		#region Operators
		/// <param name="a">The first Tuple</param>
		/// <param name="b">The second Tuple</param>
		public static Tuple3dc operator+ (Tuple3dc a, Tuple3dc b)
		{
			return new Tuple3dc (a.x + b.x, a.y + b.y, a.z + b.z);
		}

		public static Tuple3dc operator- (Tuple3dc a, Tuple3dc b)
		{
			return new Tuple3dc (a.x - b.x, a.y - b.y, a.z - b.z);
		}
		#endregion

        #region ITuple implementation
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
    }
}