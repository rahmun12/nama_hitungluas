using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nama_hitungluas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bHitung_Click(object sender, EventArgs e)
        {
            int sisii = int.Parse(tSisi.Text);
            int luasPersegi = sisii * sisii;

            label4.Text = luasPersegi.ToString();
        }
    }
}
