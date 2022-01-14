using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace viarcompatibilidade
{
    public partial class roteadores_linksys : Form
    {
        public roteadores_linksys()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 30m²", "E900", MessageBoxButtons.OK);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m²\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m²", "WRT1900", MessageBoxButtons.OK);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m²\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m²", "EA7450", MessageBoxButtons.OK);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m²\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m²", "RE6500", MessageBoxButtons.OK);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 30m²", "WRV200", MessageBoxButtons.OK);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 100 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m²\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m²", "E5350", MessageBoxButtons.OK);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m²\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m²", "MR9000", MessageBoxButtons.OK);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m²\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m²", "E2500", MessageBoxButtons.OK);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m²\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m²", "E7350", MessageBoxButtons.OK);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 30m²", "WRT54G", MessageBoxButtons.OK);
        }
    }
}
