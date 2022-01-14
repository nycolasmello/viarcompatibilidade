using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace viarcompatibilidade
{
    public partial class roteadores_intelbras : Form
    {
        public roteadores_intelbras()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 megas.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura: Aproximadamente 30m²\n\nOBS: Modelo descontinuado, recomenda-se a troca.", "Roteador IWR 3000N", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 megas.\nWAN: 10/100.\nLAN: 3xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura: Aproximadamente 30m²\n\nOBS: Modelo descontinuado, recomenda-se a troca.", "Roteador RF 301k", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 100 megas.\nWAN: 10/100.\nLAN: 3xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G: Aproximadamente 50m²\nÁrea de cobertura 5G: 30m²", "Roteador ACtion RF1200", MessageBoxButtons.OK);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 3xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G: Aproximadamente 50m²\nÁrea de cobertura 5G: 30m²", "Roteador ACtion RG1200", MessageBoxButtons.OK);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 100 megas.\nWAN: Gigabit.\nLAN: 3xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G: Aproximadamente 50m²\nÁrea de cobertura 5G: 30m²", "Roteador ACtion GF1200", MessageBoxButtons.OK);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 100 megas.\nWAN: 10/100.\nLAN: 3xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G: Aproximadamente 50m²\nÁrea de cobertura 5G: 30m²", "Roteador Wi-Force W5-1200F", MessageBoxButtons.OK);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 1xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G: Aproximadamente 180m² cada.\nÁrea de cobertura 5G: 60m² cada.", "Roteador Twibi Giga+", MessageBoxButtons.OK);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 megas.\nWAN: Gigabit.\nLAN: 3xLAN Gigabit.\nRedes Wi-Fi: 2G.\nÁrea de cobertura: Aproximadamente 30m²", "Roteador Wi-Force W4-300F", MessageBoxButtons.OK);
        }
    }
}
