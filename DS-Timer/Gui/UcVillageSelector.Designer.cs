namespace DS_Timer.Gui
{
	partial class UcVillageSelector
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.cbVillageName = new System.Windows.Forms.ComboBox();
			this.locationSelectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.villagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.txtPlayerName = new System.Windows.Forms.TextBox();
			this.txtCoords = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.locationSelectorBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.villagesBindingSource)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbVillageName
			// 
			this.cbVillageName.AllowDrop = true;
			this.cbVillageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbVillageName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbVillageName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.locationSelectorBindingSource, "SelectedVillage", true));
			this.cbVillageName.DataSource = this.villagesBindingSource;
			this.cbVillageName.DisplayMember = "LongName";
			this.cbVillageName.FormattingEnabled = true;
			this.cbVillageName.Location = new System.Drawing.Point(50, 0);
			this.cbVillageName.Margin = new System.Windows.Forms.Padding(0);
			this.cbVillageName.Name = "cbVillageName";
			this.cbVillageName.Size = new System.Drawing.Size(390, 21);
			this.cbVillageName.TabIndex = 2;
			this.toolTip.SetToolTip(this.cbVillageName, "Dorfname");
			this.cbVillageName.ValueMember = "Position";
			this.cbVillageName.SelectedValueChanged += new System.EventHandler(this.cbStartVillageName_SelectedValueChanged);
			this.cbVillageName.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtCoords_DragDrop);
			this.cbVillageName.DragOver += new System.Windows.Forms.DragEventHandler(this.txtCoords_DragOver);
			// 
			// locationSelectorBindingSource
			// 
			this.locationSelectorBindingSource.DataSource = typeof(DS_Timer.AttackPlaner.LocationSelector);
			// 
			// villagesBindingSource
			// 
			this.villagesBindingSource.DataMember = "Villages";
			this.villagesBindingSource.DataSource = this.locationSelectorBindingSource;
			// 
			// txtPlayerName
			// 
			this.txtPlayerName.AllowDrop = true;
			this.txtPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPlayerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtPlayerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtPlayerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationSelectorBindingSource, "PlayerName", true));
			this.txtPlayerName.Location = new System.Drawing.Point(440, 0);
			this.txtPlayerName.Margin = new System.Windows.Forms.Padding(0);
			this.txtPlayerName.Name = "txtPlayerName";
			this.txtPlayerName.Size = new System.Drawing.Size(195, 20);
			this.txtPlayerName.TabIndex = 3;
			this.toolTip.SetToolTip(this.txtPlayerName, "Spielername");
			this.txtPlayerName.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtCoords_DragDrop);
			this.txtPlayerName.DragOver += new System.Windows.Forms.DragEventHandler(this.txtCoords_DragOver);
			this.txtPlayerName.Validated += new System.EventHandler(this.txtPlayerName_Validated);
			// 
			// txtCoords
			// 
			this.txtCoords.AllowDrop = true;
			this.txtCoords.Location = new System.Drawing.Point(0, 0);
			this.txtCoords.Margin = new System.Windows.Forms.Padding(0);
			this.txtCoords.Name = "txtCoords";
			this.txtCoords.Size = new System.Drawing.Size(50, 20);
			this.txtCoords.TabIndex = 1;
			this.txtCoords.Text = "123|123";
			this.toolTip.SetToolTip(this.txtCoords, "Koordinaten");
			this.txtCoords.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtCoords_DragDrop);
			this.txtCoords.DragOver += new System.Windows.Forms.DragEventHandler(this.txtCoords_DragOver);
			this.txtCoords.Validated += new System.EventHandler(this.txtCoords_Validated);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.txtCoords, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtPlayerName, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.cbVillageName, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 130);
			this.tableLayoutPanel1.TabIndex = 26;
			// 
			// UcVillageSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "UcVillageSelector";
			this.Size = new System.Drawing.Size(635, 130);
			((System.ComponentModel.ISupportInitialize)(this.locationSelectorBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.villagesBindingSource)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbVillageName;
		private System.Windows.Forms.TextBox txtPlayerName;
		private System.Windows.Forms.TextBox txtCoords;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.BindingSource villagesBindingSource;
		private System.Windows.Forms.BindingSource locationSelectorBindingSource;
		private System.Windows.Forms.ToolTip toolTip;
	}
}
