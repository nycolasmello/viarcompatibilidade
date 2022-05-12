using System;
using System.Windows.Forms;

namespace viarcompatibilidade
{
    public partial class roteadores_tplink : Form
    {
        public roteadores_tplink()
        {
            InitializeComponent();


            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 3xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador EC220-G5", MessageBoxButtons.OK);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade C6: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.Redes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².\n\nCompatibilidade C80: Todos os planos\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m²\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².\n\nCompatibilidade A6: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G \nÁrea de cobertura 2G (Por piso): Aproximadamente 50m²\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteadores C6/C80/A6", MessageBoxButtons.OK);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade C60: Planos até 100 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G e 5G\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m²\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteadores C50/C60", MessageBoxButtons.OK);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade AX50: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².\n\nCompatibilidade AX10: Todos os planos\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi:2G e 5G\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m²\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador AX50/AX10", MessageBoxButtons.OK);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes: 2G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 30m².\n\nOBS: Modelo descontinuado, recomenda-se a troca", "Roteador MR3420", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura (Por piso): Aproximadamente 30m².", "Roteador TL WR820N ", MessageBoxButtons.OK);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os Planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 80m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 50m².", "Roteador ARCHER AX73", MessageBoxButtons.OK);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura (Por piso): Aproximadamente 50m².\n\nCompatibilidade TL WR940N: Planos até 50mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura (Por piso): Aproximadamente 50m².", "Roteadores TL WR949N/TL WR940N", MessageBoxButtons.OK);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura (Por piso): Aproximadamente 30m².", "Roteador TL WR840N", MessageBoxButtons.OK);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura (Por piso): Aproximadamente 30m².", "Roteador TL-WR829N", MessageBoxButtons.OK);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G.\nÁrea de cobertura (Por piso): Aproximadamente 30m².\n\nOBS: Modelo descontinuado, recomenda-se trocar. ", "Roteador TL WR841N", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador ARCHER C2 ", MessageBoxButtons.OK);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 100 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador ARCHER C20", MessageBoxButtons.OK);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 100 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador ARCHER C21", MessageBoxButtons.OK);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade C64: Planos até 150 mbps.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi:2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².\n\nCompatibilidade C54: Planos até 100 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador C64/C54", MessageBoxButtons.OK);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes: 2G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 60m².", "Roteador High Power TL-WR841HP", MessageBoxButtons.OK);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos até 50 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes: 2G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 60m².", "Roteador High Power TL-WR841HP", MessageBoxButtons.OK);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade C50: Planos até 100 mbps.\nWAN: 10/100.\nLAN: 4xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².\n\nCompatibilidade C5: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi:2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): Aproximadamente 30m².", "Roteador ARCHER C5/C50 ", MessageBoxButtons.OK);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 1xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 125m² cada AP.\nÁrea de cobertura 5G (Por piso): 50m² cada AP.", "Roteador Deco M5", MessageBoxButtons.OK);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Planos de até 100 megas.\nWAN: 10/100.\nLAN: 1xLAN 10/100.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 100m².\nÁrea de cobertura 5G (Por piso): 50m².", "Roteador Omada EAP245", MessageBoxButtons.OK);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 4xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): 30m².", "Roteador C7 AC1750", MessageBoxButtons.OK);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 1xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 90m².\nÁrea de cobertura 5G (Por piso): 60m².", "Roteador Omada EAP-225", MessageBoxButtons.OK);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 1xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 120m².\nÁrea de cobertura 5G (Por piso): 80m².", "Roteador Omada EAP225-OUTDOOR", MessageBoxButtons.OK);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compatibilidade: Todos os planos.\nWAN: Gigabit.\nLAN: 3xLAN Gigabit.\nRedes Wi-Fi: 2G e 5G.\nÁrea de cobertura 2G (Por piso): Aproximadamente 50m².\nÁrea de cobertura 5G (Por piso): 30m².", "Roteador EC230 G1", MessageBoxButtons.OK);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
