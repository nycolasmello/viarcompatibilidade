using System;
using System.Windows.Forms;

namespace viarcompatibilidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarios add_rot = new usuarios();
            add_rot.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisar_roteador pesq_rot = new pesquisar_roteador();
            pesq_rot.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roteadores_tplink rot_tplink = new roteadores_tplink();
            rot_tplink.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            roteadores_dlink rot_dlink = new roteadores_dlink();
            rot_dlink.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            roteadores_xiaomi rot_xiaomi = new roteadores_xiaomi();
            rot_xiaomi.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            roteadores_linksys rot_linksys = new roteadores_linksys();
            rot_linksys.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            roteadores_mikrotik rot_mikrotik = new roteadores_mikrotik();
            rot_mikrotik.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            roteadores_ubiquiti rot_ubiquiti = new roteadores_ubiquiti();
            rot_ubiquiti.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            roteadores_multilaser rot_multilaser = new roteadores_multilaser();
            rot_multilaser.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            roteadores_intelbras rot_intelbras = new roteadores_intelbras();
            rot_intelbras.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            roteadores_mercusys rot_mercusys = new roteadores_mercusys();
            rot_mercusys.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            roteadores_fiberhome rot_fiber = new roteadores_fiberhome();
            rot_fiber.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("-Adicionado Roteador MESH E4 na aba TP - LINK\n\n-Adicionado Roteador MESH M4 na aba TP - LINK\n\n-Atualizado informação ONU AN5506-02-B", "ATUALIZAÇÃO NOVA",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            roteadores_huawei rot_huawei = new roteadores_huawei();
            rot_huawei.Show();
        }
    }
}
