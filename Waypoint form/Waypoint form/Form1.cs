using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waypoint_form {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void textOuptut_Load(object sender, EventArgs e) {

		}

		private void pictureBox1_Click(object sender, EventArgs e) {
			if(e.GetType() == typeof(MouseEventArgs)) {
				MouseEventArgs me = e as MouseEventArgs;
				textOutput.Text = me.Location.ToString();
			}
		}

		private void buttonExport_Click(object sender, EventArgs e) {
			System.IO.Stream myStream;
			SaveFileDialog saveFileDialogue1 = new SaveFileDialog();

			saveFileDialogue1.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
			saveFileDialogue1.FilterIndex = 2;
			saveFileDialogue1.RestoreDirectory = true;

			if(saveFileDialogue1.ShowDialog() == DialogResult.OK) {
				if((myStream = saveFileDialogue1.OpenFile()) != null) {
					myStream.Close();
				}
			}
		}
	}
}
