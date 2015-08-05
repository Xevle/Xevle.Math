using System;
using System.Collections.Generic;
using Xevle.Maths.Tuples;

namespace Xevle.Maths.Tuples
{
	public static class ListOfITupleExtensions
	{
		public static List<Tuple2dc> ToListOfTuple2dc<T>(this List<T> list) where T : ITuple
		{
			if (list == null) throw new ArgumentNullException("this");

			List<Tuple2dc> ret = new List<Tuple2dc>();
			foreach (ITuple tuple in list) ret.Add(new Tuple2dc(tuple));
			return ret;
		}

		public static List<Tuple2ds> ToListOfTuple2ds<T>(this List<T> list) where T : ITuple
		{
			if (list == null) throw new ArgumentNullException("this");

			List<Tuple2ds> ret = new List<Tuple2ds>();
			foreach (ITuple tuple in list) ret.Add(new Tuple2ds(tuple));
			return ret;
		}

		public static List<Tuple2ic> ToListOfTuple2ic<T>(this List<T> list) where T : ITuple
		{
			if (list == null) throw new ArgumentNullException("this");

			List<Tuple2ic> ret = new List<Tuple2ic>();
			foreach (ITuple tuple in list) ret.Add(new Tuple2ic(tuple));
			return ret;
		}

		public static List<Tuple2is> ToListOfTuple2is<T>(this List<T> list) where T : ITuple
		{
			if (list == null) throw new ArgumentNullException("this");

			List<Tuple2is> ret = new List<Tuple2is>();
			foreach (ITuple tuple in list) ret.Add(new Tuple2is(tuple));
			return ret;
		}

		public static List<Tuple3dc> ToListOfTuple3dc<T>(this List<T> list) where T : ITuple
		{
			if (list == null) throw new ArgumentNullException("this");

			List<Tuple3dc> ret = new List<Tuple3dc>();
			foreach (ITuple tuple in list) ret.Add(new Tuple3dc(tuple));
			return ret;
		}

		public static List<Tuple3ds> ToListOfTuple3ds<T>(this List<T> list) where T : ITuple
		{
			if (list == null) throw new ArgumentNullException("this");

			List<Tuple3ds> ret = new List<Tuple3ds>();
			foreach (ITuple tuple in list) ret.Add(new Tuple3ds(tuple));
			return ret;
		}

		public static List<Tuple3ic> ToListOfTuple3ic<T>(this List<T> list) where T : ITuple
		{
			if (list == null) throw new ArgumentNullException("this");

			List<Tuple3ic> ret = new List<Tuple3ic>();
			foreach (ITuple tuple in list) ret.Add(new Tuple3ic(tuple));
			return ret;
		}

		public static List<Tuple3is> ToListOfTuple3is<T>(this List<T> list) where T : ITuple
		{
			if (list == null) throw new ArgumentNullException("this");

			List<Tuple3is> ret = new List<Tuple3is>();
			foreach (ITuple tuple in list) ret.Add(new Tuple3is(tuple));
			return ret;
		}
	}
}

