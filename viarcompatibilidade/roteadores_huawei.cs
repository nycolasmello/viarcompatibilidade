using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace viarcompatibilidade
{
    public partial class roteadores_huawei : Form
    {
        public roteadores_huawei()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN/LAN: 3 Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador HUAWEI AX2", MessageBoxButtons.OK);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: 1 Gigabit\nLAN: 3 Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador HUAWEI AX3/AX3-PRO", MessageBoxButtons.OK);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: 1 Gigabit\nLAN: 3 Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador HUAWEI WS5200", MessageBoxButtons.OK);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: 1 Gigabit\nLAN: 3 Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador HUAWEI WS5200", MessageBoxButtons.OK);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos de 50 MBPS.\nWAN: 1 Fast Ethernet /100\nLAN: 2 Fast Ethernet /100\nRedes Wi-Fi: 2G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².", "Roteador HUAWEI WS318n", MessageBoxButtons.OK);
        }
    }
}
