using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace viarcompatibilidade
{
    public partial class roteadores_xiaomi : Form
    {
        public roteadores_xiaomi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador Mi AX1800", MessageBoxButtons.OK);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador Mi 4A GIGA", MessageBoxButtons.OK);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 2xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura (Por piso): Aproximadamente 50m².", "Roteador Mi 4C", MessageBoxButtons.OK);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 3xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador Mi AX6", MessageBoxButtons.OK);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 100 mbps.\nWAN: 10/100.\nLAN: 2xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador Mi 4A", MessageBoxButtons.OK);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 3xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador Mi AX6000", MessageBoxButtons.OK);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 3xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador Mi AX3000", MessageBoxButtons.OK);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 3xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador Mi AX2100", MessageBoxButtons.OK);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 3xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador Mi AC3600", MessageBoxButtons.OK);
        }
    }
}
