using System;
using Gtk;
using Gdk;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{
	private static Color colorGREEN = new Color (0, 255, 0);
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		List<Button> buttons = new List<Button> ();
		Table table = new Table (9, 10, true);
			for (int i = 0; i < 90; i++) {
				Button button = new Button ();
				button.Label = (i + 1).ToString();
				button.Visible = true;
				uint row = (uint)(i / 10);
				uint column = (uint)(i % 10);
				table.Attach (button, column, column+1, row, row+1);
				buttons.Add (button);
		}
//
//		for (uint row = 0; row < 10; row++)
//			for (uint column = 0; column < 10; column++) {
//				int index = (int)(row * 10 + column);
//				Button button = new Button ();
//				button.Label = (index + 1).ToString();
//				button.Visible = true;
//				table.Attach (button, (uint)column, (uint)(column + 1), row, row+1);
//			
//			}



		table.Visible = true;	
		vBoxMain.Add (table);

		List<int> bolas = new List<int> ();
		for (int bola = 1; bola <= 90; bola++)
			bolas.Add (bola);

		//buttonAdelante.ModifyBg (StateType.Normal, colorGREEN);
		Random random = new Random();
		buttonAdelante.Clicked += delegate {
			int indexAleatorio = random.Next(bolas.Count);
			int bola = bolas[indexAleatorio]; //Bola Aleatoria
			bolas.Remove(bola);
			int index = bola - 1;
			buttons [index].ModifyBg(StateType.Normal, colorGREEN);

		};





	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
