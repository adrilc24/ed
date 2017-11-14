package org.institutoserpis.ed;

public class Vector {

	public static void main(String[] args) {
		int [] v = new int[] {9,15,7,12,6};
		
		for (int index=0; index < 5; index++) 
			System.out.printf("v[%s]=%s ", index, v[index]);
		System.out.println();
		
		int valor = 4;
		int position = indexof(v, valor);
		int min = min(v); 
		System.out.println("minimo = "+min);
		
	}
	
	public static int indexof(int[] v, int valor) {
//		int index = 0;
//		while (index < v.length && v[index] != valor)
//			index++;
//		if (index == v.length)
//			return -1;
//		return index;
		
		
		for (int index = 0; index < v.length; index++)
			if (v[index] == valor)
				return index;
		return -1;
	}
	
	public static int min(int[] v) {
		int comp = v [0];
		for (int index = 0; index < v.length; index++)
			if (v [index] < comp)
				comp = v [index];
		return comp;
	}
	public static void selectionSort(int[] v) {
		int selectedIndex = 0;
		int indexOfMin = selectedIndex;
		for (int index = selectedIndex + 1;index < v.length; index++)
			if (v[index] < v[selectedIndex]) {
				
			}			
	}
	
	public static int suma (int[] v) {
		int suma= 0;
//		for (int index = 0; index <v.length; index++)
//			suma = suma + v[index];
		for (int item : v)
			suma = suma + item;
		return suma;
	}

	public static int indexOfMin(int[] v) {
		int indexofmin = 0; 
		for (int index = 0; index <v.length; index++)
			if (v[index] < v[indexofmin])
				indexofmin = index;
		return indexofmin;
	}
}
