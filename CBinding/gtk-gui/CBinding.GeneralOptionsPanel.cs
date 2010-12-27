
// This file has been generated by the GUI designer. Do not modify.
namespace CBinding
{
	public partial class GeneralOptionsPanel
	{
		private global::Gtk.Table table1;
		private global::Gtk.ComboBox cCombo;
		private global::Gtk.ComboBox cppCombo;
		private global::Gtk.Button ctagsBrowse;
		private global::Gtk.Entry ctagsEntry;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.CheckButton parseLocalVariablesCheck;
		private global::Gtk.CheckButton parseSystemTagsCheck;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget CBinding.GeneralOptionsPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "CBinding.GeneralOptionsPanel";
			// Container child CBinding.GeneralOptionsPanel.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(5)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.cCombo = global::Gtk.ComboBox.NewText ();
			this.cCombo.TooltipMarkup = "Default compiler to use for new C projects.";
			this.cCombo.Name = "cCombo";
			this.table1.Add (this.cCombo);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.cCombo]));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.cppCombo = global::Gtk.ComboBox.NewText ();
			this.cppCombo.TooltipMarkup = "Default compiler to use for new C++ projects.";
			this.cppCombo.Name = "cppCombo";
			this.table1.Add (this.cppCombo);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.cppCombo]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ctagsBrowse = new global::Gtk.Button ();
			this.ctagsBrowse.CanFocus = true;
			this.ctagsBrowse.Name = "ctagsBrowse";
			this.ctagsBrowse.UseUnderline = true;
			// Container child ctagsBrowse.Gtk.Container+ContainerChild
			global::Gtk.Alignment w3 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w4 = new global::Gtk.HBox ();
			w4.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w5 = new global::Gtk.Image ();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-open", global::Gtk.IconSize.Menu);
			w4.Add (w5);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w7 = new global::Gtk.Label ();
			w7.LabelProp = global::Mono.Unix.Catalog.GetString ("Browse");
			w7.UseUnderline = true;
			w4.Add (w7);
			w3.Add (w4);
			this.ctagsBrowse.Add (w3);
			this.table1.Add (this.ctagsBrowse);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.ctagsBrowse]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(2));
			w11.RightAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ctagsEntry = new global::Gtk.Entry ();
			this.ctagsEntry.CanFocus = true;
			this.ctagsEntry.Name = "ctagsEntry";
			this.ctagsEntry.IsEditable = true;
			this.ctagsEntry.InvisibleChar = '●';
			this.table1.Add (this.ctagsEntry);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.ctagsEntry]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xpad = 10;
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Default C Compiler:");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xpad = 10;
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Default C++ Compiler:");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xpad = 10;
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("CTags: ");
			this.label3.Justify = ((global::Gtk.Justification)(1));
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.parseLocalVariablesCheck = new global::Gtk.CheckButton ();
			this.parseLocalVariablesCheck.CanFocus = true;
			this.parseLocalVariablesCheck.Name = "parseLocalVariablesCheck";
			this.parseLocalVariablesCheck.Label = global::Mono.Unix.Catalog.GetString ("Parse Local Variables");
			this.parseLocalVariablesCheck.DrawIndicator = true;
			this.parseLocalVariablesCheck.UseUnderline = true;
			this.table1.Add (this.parseLocalVariablesCheck);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.parseLocalVariablesCheck]));
			w16.TopAttach = ((uint)(4));
			w16.BottomAttach = ((uint)(5));
			w16.XPadding = ((uint)(10));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.parseSystemTagsCheck = new global::Gtk.CheckButton ();
			this.parseSystemTagsCheck.TooltipMarkup = "Choose whether you want to parse system tags or not, if you do you will get completion for things like printf, but the tag parsing process will take considerably longer.";
			this.parseSystemTagsCheck.CanFocus = true;
			this.parseSystemTagsCheck.Name = "parseSystemTagsCheck";
			this.parseSystemTagsCheck.Label = global::Mono.Unix.Catalog.GetString ("Parse System Tags");
			this.parseSystemTagsCheck.DrawIndicator = true;
			this.parseSystemTagsCheck.UseUnderline = true;
			this.table1.Add (this.parseSystemTagsCheck);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.parseSystemTagsCheck]));
			w17.TopAttach = ((uint)(3));
			w17.BottomAttach = ((uint)(4));
			w17.XPadding = ((uint)(10));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.ctagsBrowse.Clicked += new global::System.EventHandler (this.OnCtagsBrowseClicked);
			this.cppCombo.Changed += new global::System.EventHandler (this.OnCppComboChanged);
			this.cCombo.Changed += new global::System.EventHandler (this.OnCComboChanged);
		}
	}
}
