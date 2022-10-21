using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace viarcompatibilidade
{
    public partial class roteadores_fiberhome : Form
    {
        public roteadores_fiberhome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nTelefonia: 2 entradas.\nLAN: 4xLAN Gigabit\nRedes Wi-Fi: 2G e 5G\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "ONU Wi-FI AC", MessageBoxButtons.OK);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nTelefonia: 1 entrada.\nLAN: 1xLAN Gigabit, 1xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 30m².", "ONU AN5506-02-F1G", MessageBoxButtons.OK);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 100 megas.\nTelefonia: 2 entradas.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: Não possui Wi-Fi.", "ONU AN5506-04", MessageBoxButtons.OK);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nTelefonia: 2 entradas.\nLAN: 4xLAN Gigabit\nRedes Wi-Fi: 2G e 5G\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "ONU HG6245D Wi-Fi AC", MessageBoxButtons.OK);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nTelefonia: 2 entradas.\nLAN: 4xLAN Gigabit\nRedes Wi-Fi: 2G e 5G\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "AN5506-04-F", MessageBoxButtons.OK);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nTelefonia: 1 entrada.\n LAN 1:Gigabit.\nLAN 2: 10/100 \nRedes Wi-Fi: Não possui.",  "ONU AN5506-02-B",  MessageBoxButtons.OK);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nTelefonia: Não possui.\n LAN: 1xLAN Gigabit.\nRedes Wi-Fi: Não possui.",  "ONU AN5506-01", MessageBoxButtons.OK);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nTelefonia: Não possui.\n LAN: 1xLAN Gigabit.\nRedes Wi-Fi: Não possui.",  "ONU AN5506-01-A", MessageBoxButtons.OK);
        }
    }
}
