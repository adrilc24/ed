using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();

		buttonSuma.Clicked += delegate {
			int numero1 = int.Parse(entryNum1.Text);
			int numero2 = int.Parse(entryNum2.Text);
			int resulatado = numero1+numero2;
			labelResultado.Text = resulatado.ToString();
		};

		showAll (buttonSuma);
	}

	private void showAll (Container container) {
		foreach (Widget child in container.Children) {
			child.Visible = true;
			if (child is Container)
				showAll ((Container)child);
		}

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
