using System;

namespace Xevle.Maths.Tuples
{
	/// <summary>
	/// Static class that server ITuple extensions methods.
	/// </summary>
	public static class ITupleExtensions
	{
		#region Converter methods
		/// <summary>
		/// Convert a ITuple to a Tuple3dc
		/// </summary>
		/// <returns>The tuple3dc.</returns>
		/// <param name="tuple">Tuple.</param>
		public static Tuple3dc ToTuple3dc(this ITuple tuple)
		{
			return new Tuple3dc(tuple);
		}

		/// <summary>
		/// Convert a ITuple to a Tuple3ds
		/// </summary>
		/// <returns>The tuple3ds.</returns>
		/// <param name="tuple">Tuple.</param>
		public static Tuple3ds ToTuple3ds(this ITuple tuple)
		{
			return new Tuple3ds(tuple);
		}
		#endregion
	}
}

