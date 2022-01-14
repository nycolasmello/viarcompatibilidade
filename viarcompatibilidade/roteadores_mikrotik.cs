using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace viarcompatibilidade
{
    public partial class roteadores_mikrotik : Form
    {
        public roteadores_mikrotik()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: Não possui redes Wi-Fi.", "GR3", MessageBoxButtons.OK);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 100 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: Não possui redes Wi-Fi.", "GR2", MessageBoxButtons.OK);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 100 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 30m²", "HAP LITE", MessageBoxButtons.OK);
        }
    }
}
