using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace viarcompatibilidade
{
    public partial class roteadores_multilaser : Form
    {
        public roteadores_multilaser()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 megas.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura: Aproximadamente 30m²", "Roteador RE300", MessageBoxButtons.OK);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 megas.\nWAN: 10/100.\nLAN: 3xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura: Aproximadamente 30m²", "Roteador RE160V", MessageBoxButtons.OK);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 megas.\nWAN: 10/100.\nLAN: 3xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura: Aproximadamente 40m²", "Roteador RE163V", MessageBoxButtons.OK);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G: Aproximadamente 50m²\nÁrea de cobertura 5G: Aproximadamente 30m²\n\nOBS: Modelo descontinuado, recomenda-se a troca do aparelho.", "Roteador RE708", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos de até 100 megas.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G: Aproximadamente 50m²\nÁrea de cobertura 5G: Aproximadamente 30m²", "Roteador RE018", MessageBoxButtons.OK);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G: Aproximadamente 50m²\nÁrea de cobertura 5G: Aproximadamente 30m²", "Roteador RE016", MessageBoxButtons.OK);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G: Aproximadamente 50m²\nÁrea de cobertura 5G: Aproximadamente 30m²", "Roteador RE017", MessageBoxButtons.OK);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos de até 100 megas.\nWAN: 10/100.\nLAN: 1xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G: Aproximadamente 50m²\nÁrea de cobertura 5G: Aproximadamente 30m²", "Roteador Mesh Cosmo", MessageBoxButtons.OK);
        }
    }
}
