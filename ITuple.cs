using System;

namespace Xevle.Math
{
	/// <summary>
	/// Interface for all Tuple classes and structs
	/// </summary>
    public interface ITuple
    {
        double U { get; set; }
        double V { get; set; }

        double X { get; set; }
        double Y { get; set; }
        double Z { get; set; }
    }
}

