using NUnit.Framework;
using System;

namespace CVector
{
	[TestFixture ()]
	public class Vector
	{
//		public static void Sort(int[] v){
			int n = v.Length;
			for (int positionIndex = 0; positionIndex < n - 1; positionIndex++) {
				int indexMin = positionIndex;
				for (int index = IndexMin + 1; index < n; index++)
					if (v [index] < v [IndexMin])
						indexMin = index;
				int aux = v [positionIndex];
				v [positionIndex] = v [IndexMin];
				v [IndexMin] = aux;
			}
//		int n = v.Length;
//		for (int positionIndex = 0; positionIndex < n -1; positionIndex++ ){
//			int indexMin = indexMin(v, positionIndex);
//			Swap(v, positionIndex, indexMin);
//		
//		}
		}

		/// <summary>
		/// Sort the specified v.
		/// </summary>
		/// <param name="v">V.</param>
		///public static void Sort(int[] v) {
			//Array.Sort<int> (v); Solucion simplificada
		}

		/// <summary>
		/// Indexs the minimum.
		/// </summary>
		/// <returns>The minimum.</returns>
		/// <param name="v">V.</param>
		/// <param name="initialIndex">Initial index.</param>
		public static int IndexMin(int[] v, int initialIndex){
			if (initialIndex >= v.Length)
				throw new IndexOutOfRangeException ();
			for (int index = initialIndex + 1; index < v.Length; index++)
				if (v[index] < v[IndexMin])
					IndexMin = index;
			return IndexMin;
		}

		/// <summary>
		/// Swap the specified v, index and otherIndex.
		/// </summary>
		/// <param name="v">V.</param>
		/// <param name="index">Index.</param>
		/// <param name="otherIndex">Other index.</param>
		public static void Swap(int[] v,int index, int otherIndex){
			int aux = v [index];
			v [index] = v [otherIndex];
			v [otherIndex] = aux;
		}
			
	}
}

