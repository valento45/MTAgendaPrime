using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaBE;
namespace AgendaUI
{
    public partial class frmHistoricoA : Form
    {
        public frmHistoricoA()
        {
            InitializeComponent();
        }
        public frmHistoricoA(int idcliente_)
        {
            InitializeComponent();
            if (idcliente_ > 0)
            {               
                string linha = "".PadLeft(80, '_');
                string pulaLinha = "\r\n";
                foreach (var x in LogCliente.HistoricoById(idcliente_))
                {
                    txtHistorico.Text += linha + pulaLinha + pulaLinha + x.ToString() + pulaLinha + linha + pulaLinha;
                }
            }

        }
    }
}
