package org.institutoserpis.ed;

import static org.junit.Assert.*;

import org.junit.Test;

public class VectorTest {

	@Test
	public void Indexof() {
		int[] v = new int[] {9,15,7,12,6};
		assertEquals(0, Vector.indexof(v, 9));
		assertEquals(2, Vector.indexof(v, 7));
		assertEquals(4, Vector.indexof(v, 6));
		assertEquals(-1, Vector.indexof(v, 33));
	}
	@Test
	public void selectionSort() {
		int [] v = new int[] {9,15,7,12,6};
		Vector.selectionSort(v);
		assertArrayEquals(new int[] {6,7,8,9,12,15}, v);
	}
	@Test
	public void indexOfMin( ) {
		assertEquals(4, Vector.indexOfMin(new int[] {9,15,7,12,6}));
	}
	@Test
	public void suma() {
		assertEquals(49,Vector.suma(new int[] {9,15,7,12,6}));
		assertEquals(0, Vector.suma(new int[] {}));
		assertEquals(43, Vector.suma(new int[] {9,15,7,12}));
	}
	
	@Test
	public void binarySearchNotFound() {
		int [] v = new int [] {7, 14, 21, 27, 31};
		assertEquals(-1, Vector.binarySearch(v, 6));
		assertEquals(-1, Vector.binarySearch(v, 10));
		assertEquals(-1, Vector.binarySearch(v, 16));
		assertEquals(-1, Vector.binarySearch(v, 29));
		assertEquals(-1, Vector.binarySearch(v, 33));
	}
	
	@Test
	public void binarySearchFound() {
		int [] v = new int [] {7, 14, 21, 27, 31};
		assertEquals(0, Vector.binarySearch(v, 7));
		assertEquals(1, Vector.binarySearch(v, 14));
		assertEquals(4, Vector.binarySearch(v, 31));
	}
	
	@Test
	public void binarySearchVector() {
		int [] v = new int [] {7, 14, 21, 27, 31};
		assertEquals(0, Vector.binarySearch(v, 7));
		assertEquals(1, Vector.binarySearch(v, 14));
		assertEquals(4, Vector.binarySearch(v, 31));
	}
	
	public void binarySearchOverflow() {
//		int [] v = new int[Integer.MAX_VALUE];
//		for (int i = 0; i < Integer.MAX_VALUE; i++)
//			v[i] = i+1;
//		assertEquals(-1, Vector.binarySearch(v, Integer.MAX_VALUE));

	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}