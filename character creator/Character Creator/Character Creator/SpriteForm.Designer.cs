namespace Character_Creator {
	partial class SpriteForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBoxSheets = new System.Windows.Forms.ComboBox();
			this.lableName = new System.Windows.Forms.Label();
			this.listBoxTiles = new System.Windows.Forms.ListBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.labelSheet = new System.Windows.Forms.Label();
			this.labelLayers = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox.Location = new System.Drawing.Point(12, 12);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(277, 319);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(354, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(227, 20);
			this.textBox1.TabIndex = 1;
			// 
			// comboBoxSheets
			// 
			this.comboBoxSheets.FormattingEnabled = true;
			this.comboBoxSheets.Location = new System.Drawing.Point(354, 38);
			this.comboBoxSheets.Name = "comboBoxSheets";
			this.comboBoxSheets.Size = new System.Drawing.Size(227, 21);
			this.comboBoxSheets.TabIndex = 2;
			// 
			// lableName
			// 
			this.lableName.AutoSize = true;
			this.lableName.Location = new System.Drawing.Point(315, 19);
			this.lableName.Name = "lableName";
			this.lableName.Size = new System.Drawing.Size(35, 13);
			this.lableName.TabIndex = 3;
			this.lableName.Text = "Name";
			// 
			// listBoxTiles
			// 
			this.listBoxTiles.FormattingEnabled = true;
			this.listBoxTiles.Location = new System.Drawing.Point(354, 65);
			this.listBoxTiles.Name = "listBoxTiles";
			this.listBoxTiles.Size = new System.Drawing.Size(227, 212);
			this.listBoxTiles.TabIndex = 4;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(506, 283);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete.TabIndex = 5;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			// 
			// labelSheet
			// 
			this.labelSheet.AutoSize = true;
			this.labelSheet.Location = new System.Drawing.Point(313, 46);
			this.labelSheet.Name = "labelSheet";
			this.labelSheet.Size = new System.Drawing.Size(35, 13);
			this.labelSheet.TabIndex = 6;
			this.labelSheet.Text = "Sheet";
			// 
			// labelLayers
			// 
			this.labelLayers.AutoSize = true;
			this.labelLayers.Location = new System.Drawing.Point(310, 65);
			this.labelLayers.Name = "labelLayers";
			this.labelLayers.Size = new System.Drawing.Size(38, 13);
			this.labelLayers.TabIndex = 7;
			this.labelLayers.Text = "Layers";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(425, 283);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 8;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// SpriteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 343);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.labelLayers);
			this.Controls.Add(this.labelSheet);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.listBoxTiles);
			this.Controls.Add(this.lableName);
			this.Controls.Add(this.comboBoxSheets);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox);
			this.Name = "SpriteForm";
			this.Text = "SpriteForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBoxSheets;
		private System.Windows.Forms.Label lableName;
		private System.Windows.Forms.ListBox listBoxTiles;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Label labelSheet;
		private System.Windows.Forms.Label labelLayers;
		private System.Windows.Forms.Button buttonAdd;
	}
}