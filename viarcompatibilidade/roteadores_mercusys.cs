using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace viarcompatibilidade
{
    public partial class roteadores_mercusys : Form
    {
        public roteadores_mercusys()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 3xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m²\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador AC12G", MessageBoxButtons.OK);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 100 mbps.\nWAN: 10/100.\nLAN: 2xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador AC10", MessageBoxButtons.OK);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 3xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura (Por piso): Aproximadamente 50m².", "Roteador MW330HP", MessageBoxButtons.OK);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 2xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura (Por piso): Aproximadamente 50m².", "Roteador MW301R", MessageBoxButtons.OK);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 3xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura (Por piso): Aproximadamente 30m².", "Roteador MR325R", MessageBoxButtons.OK);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 3xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador MR70X", MessageBoxButtons.OK);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 2xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador MR50G", MessageBoxButtons.OK);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 2xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador MR30G", MessageBoxButtons.OK);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 3xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura (Por piso): Aproximadamente 50m².", "Roteador MR305R", MessageBoxButtons.OK);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 2xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura (Por piso): Aproximadamente 30m².", "Roteador MR301", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
