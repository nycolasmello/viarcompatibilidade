using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace viarcompatibilidade
{
    public partial class roteadores_ubiquiti : Form
    {
        public roteadores_ubiquiti()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nRedes: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 80m².\nÁrea de cobertura 5G (Por piso): Aproximadamente: 50m².", "UniFi AP AC Lite", MessageBoxButtons.OK);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nRedes: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 100m².\nÁrea de cobertura 5G (Por piso): Aproximadamente: 50m².", "UniFi AP AC LR", MessageBoxButtons.OK);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 100 megas.\nWAN: 10/100.\nRedes: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².", "UniFi AP", MessageBoxButtons.OK);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nRedes: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 120m².\nÁrea de cobertura 5G (Por piso): Aproximadamente: 60m².", "UniFi AP AC OUTDOOR", MessageBoxButtons.OK);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 1xLAN Gigabit.\nGigabit Redes: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 120m².\nÁrea de cobertura 5G (Por piso): Aproximadamente: 60m².", "UniFi UAP AC PRO", MessageBoxButtons.OK);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 1xLAN Gigabit.\nGigabit Redes: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 130m².\nÁrea de cobertura 5G (Por piso): Aproximadamente: 65m².", "UniFi UAP AC PRO OUTDOOR", MessageBoxButtons.OK);
        }
    }
}
