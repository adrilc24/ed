
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.Entry entryNombre;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.HBox hbox3;
	
	private global::Gtk.Label label4;
	
	private global::Gtk.Entry entry2;
	
	private global::Gtk.Button buttonAceptar;
	
	private global::Gtk.Label labelSaludo;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero 1");
		this.hbox1.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.entryNombre = new global::Gtk.Entry ();
		this.entryNombre.CanFocus = true;
		this.entryNombre.Name = "entryNum1";
		this.entryNombre.IsEditable = true;
		this.entryNombre.InvisibleChar = '•';
		this.hbox1.Add (this.entryNombre);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryNombre]));
		w2.Position = 1;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("+");
		this.hbox2.Add (this.label2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label2]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero 2");
		this.hbox3.Add (this.label4);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label4]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entryNum2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.hbox3.Add (this.entry2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entry2]));
		w7.Position = 1;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
		w8.Position = 3;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.buttonAceptar = new global::Gtk.Button ();
		this.buttonAceptar.CanFocus = true;
		this.buttonAceptar.Name = "buttonAceptar";
		this.buttonAceptar.UseStock = true;
		this.buttonAceptar.UseUnderline = true;
		this.buttonAceptar.Label = "gtk-ok";
		this.vbox1.Add (this.buttonAceptar);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.buttonAceptar]));
		w9.Position = 4;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelSaludo = new global::Gtk.Label ();
		this.labelSaludo.Name = "labelResultado";
		this.labelSaludo.LabelProp = global::Mono.Unix.Catalog.GetString ("Hola");
		this.vbox1.Add (this.labelSaludo);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.labelSaludo]));
		w10.Position = 5;
		w10.Expand = false;
		w10.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 433;
		this.DefaultHeight = 163;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
