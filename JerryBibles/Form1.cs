using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JerryBibles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rLibros l = new UI.Registros.rLibros();
            l.Show();
        }
    }
}
