using System;
using Xevle.Core;

namespace Xevle.Maths.Tuples
{
	/// <summary>
	/// Interface for all Tuple classes and structs
	/// </summary>
	public interface ITuple: ICopy<ITuple>
	{
		/// <summary>
		/// Gets or sets the value U.
		/// </summary>
		/// <value>U</value>
		double U { get; set; }

		/// <summary>
		/// Gets or sets the value V.
		/// </summary>
		/// <value>The v.</value>
		double V { get; set; }

		/// <summary>
		/// Gets or sets the value X.
		/// </summary>
		/// <value>The x.</value>
		double X { get; set; }

		/// <summary>
		/// Gets or sets the value Y.
		/// </summary>
		/// <value>The y.</value>
		double Y { get; set; }

		/// <summary>
		/// Gets or sets the value Z.
		/// </summary>
		/// <value>The z.</value>
		double Z { get; set; }
	}
}

