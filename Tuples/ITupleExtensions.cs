using System;

namespace Xevle.Maths.Tuples
{
	/// <summary>
	/// Static class that server ITuple extensions methods.
	/// </summary>
	public static class ITupleExtensions
	{
		#region Converter methods
		public static Tuple2dc ToTuple2dc(this ITuple tuple)
		{
			return new Tuple2dc(tuple);
		}

		public static Tuple2ds ToTuple2ds(this ITuple tuple)
		{
			return new Tuple2ds(tuple);
		}

		public static Tuple2ic ToTuple2ic(this ITuple tuple)
		{
			return new Tuple2ic(tuple);
		}

		public static Tuple2is ToTuple2is(this ITuple tuple)
		{
			return new Tuple2is(tuple);
		}

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

		public static Tuple3ic ToTuple3ic(this ITuple tuple)
		{
			return new Tuple3ic(tuple);
		}

		public static Tuple3is ToTuple3is(this ITuple tuple)
		{
			return new Tuple3is(tuple);
		}
		#endregion
	}
}

