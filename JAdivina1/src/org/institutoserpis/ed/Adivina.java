package org.institutoserpis.ed;

import java.util.Random;
import java.util.Scanner;

public class Adivina {

	public static void main(String[] args) {
		Scanner tcl = new Scanner(System.in);
		Random random = new Random();
		int numeroAleatorio = random.nextInt(1000)+1;
		int contadorIntentos = 1;
		String numero;
		System.out.println("Introduzca el número del 1 al 1000 ");
		numero=tcl.nextLine();
		int numeroUsuario = Integer.parseInt(numero);
		while (numeroUsuario!=numeroAleatorio) {
			if (numeroAleatorio < numeroUsuario) 
				System.out.printf("El número aleatorio es menor que el introducido, pruebe de nuevo [intento %s]: ",contadorIntentos);
			else
					System.out.printf("El número aleatorio es mayor que el introducido, pruebe de nuevo [intento %s]:  ",contadorIntentos);
			contadorIntentos++;
			numero = tcl.nextLine();
			numeroUsuario = Integer.parseInt(numero);
		}
		
		System.out.println("");
		System.out.println("El número "+numeroAleatorio+" es correcto");
		System.out.printf("Usted ha necesitado "+contadorIntentos+" intentos");
		
	}

}
