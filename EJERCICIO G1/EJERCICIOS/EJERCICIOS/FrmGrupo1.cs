using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIOS
{
    public partial class FrmGrupo1 : Form
    {
        public FrmGrupo1()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtTexto.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnTexto_Click(object sender, EventArgs e)
        {
            dtgContenido.Rows.Add(txtTexto.Text);
            clear();
        }
        
    }
}
