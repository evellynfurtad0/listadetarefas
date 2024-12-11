using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listadetarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //mudar para cadastrar
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Equals("evellyn") && txtSenha.Text.Equals("12345"))
                 {
                    //ir para o inicio
                 }
                 else{
                    MessageBox.Show("Usuário ou senha incorretos",
                                    "Desculpe",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    //revisar
                    txtUsuario.Focus();
                    txtSenha.Text = "";
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show("Desculpe", 
                    ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
