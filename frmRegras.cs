using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class frmRegras : Form
    {
        public frmRegras()
        {
            InitializeComponent();
        }

        public void btnVoltar_Click(object sender, EventArgs e)
        {
            //Fecha a janela de regras e volta para o jogo
            frmRegras frmRegras = new frmRegras();
            this.Close();
        }
    }
}
