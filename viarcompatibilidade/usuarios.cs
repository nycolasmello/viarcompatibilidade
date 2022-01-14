using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace viarcompatibilidade
{
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
            Senhatxt.Text = "";
            Senhatxt.PasswordChar = '*';
            Senhatxt.MaxLength = 8;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Usuariotxt.Text == "Viarnet" && Senhatxt.Text == "Viar@gpp")
            {
                this.Hide();
                var form2 = new adicionar_roteadores();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else 
            {
                MessageBox.Show("Login ou senha incorreta!", "Login Inválido", MessageBoxButtons.OK);
            }
        }
    }
}
