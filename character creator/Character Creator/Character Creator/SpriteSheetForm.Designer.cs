namespace Character_Creator {
    partial class SpriteSheetForm {
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textboxTileHeight = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textboxSpacing = new System.Windows.Forms.TextBox();
			this.textboxTileWidth = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(646, 287);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// textboxTileHeight
			// 
			this.textboxTileHeight.Location = new System.Drawing.Point(73, 331);
			this.textboxTileHeight.Name = "textboxTileHeight";
			this.textboxTileHeight.Size = new System.Drawing.Size(100, 20);
			this.textboxTileHeight.TabIndex = 1;
			this.textboxTileHeight.Text = "16";
			this.textboxTileHeight.TextChanged += new System.EventHandler(this.textboxTileHeight_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 312);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tile Width";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(583, 305);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Load";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 364);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Spacing";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 338);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tile Height";
			// 
			// textboxSpacing
			// 
			this.textboxSpacing.Location = new System.Drawing.Point(73, 357);
			this.textboxSpacing.Name = "textboxSpacing";
			this.textboxSpacing.Size = new System.Drawing.Size(100, 20);
			this.textboxSpacing.TabIndex = 6;
			this.textboxSpacing.Text = "1";
			this.textboxSpacing.TextChanged += new System.EventHandler(this.textboxSpacing_TextChanged);
			// 
			// textboxTileWidth
			// 
			this.textboxTileWidth.Location = new System.Drawing.Point(73, 305);
			this.textboxTileWidth.Name = "textboxTileWidth";
			this.textboxTileWidth.Size = new System.Drawing.Size(100, 20);
			this.textboxTileWidth.TabIndex = 7;
			this.textboxTileWidth.Text = "16";
			this.textboxTileWidth.TextChanged += new System.EventHandler(this.textboxTileWidth_TextChanged);
			// 
			// SpriteSheetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(670, 416);
			this.Controls.Add(this.textboxTileWidth);
			this.Controls.Add(this.textboxSpacing);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textboxTileHeight);
			this.Controls.Add(this.pictureBox1);
			this.Name = "SpriteSheetForm";
			this.Text = "Sprite Sheet";
			this.Shown += new System.EventHandler(this.SpriteSheetForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textboxTileHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxSpacing;
        private System.Windows.Forms.TextBox textboxTileWidth;
    }
}

