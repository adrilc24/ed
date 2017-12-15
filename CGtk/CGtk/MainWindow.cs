using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();





	buttonAceptar.Clicked += delegate {

			Console.WriteLine("Has hecho click en el botón de aceptar")
			
			labelResultado.Text = "El resultado es:  ";
//			Button button = new Button();
//			button.Visible = true;
//			vbox1.Add (button);
		};



	//	for (int i = 0; i < 10; i++) {
	//		Button button = new Button ();
	//		button.Label = "Botonsico " + (i+1);
	//		button.Visible = true;
	//		vbox1.Add (button);
	//	}
	//	labelSaludo.Text = "Hola buenas";
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}