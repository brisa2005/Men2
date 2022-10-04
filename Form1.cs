using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un programa creado por Brisa Figueroa", "Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            label1.ForeColor = Color.Red;
            rojoToolStripMenuItem.Checked = true;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            label1.ForeColor = Color.Blue;
            azulToolStripMenuItem.Checked = true;
        }
        private void borrarColor()
        {
            rojoToolStripMenuItem.Checked = false;
            azulToolStripMenuItem.Checked = false;
        }

        private void timeNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicSansToolStripMenuItem.Checked = false;
            label1.Font = new Font("Times New Roman",14, label1.Font.Style);
            timeNewRomanToolStripMenuItem.Checked = true;
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timeNewRomanToolStripMenuItem.Checked = false;
            label1.Font = new Font("Comic Sans MS", 14, label1.Font.Style);
            comicSansToolStripMenuItem.Checked = true;
        }
    }

}
