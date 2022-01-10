using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;


namespace viarcompatibilidade
{
    public partial class pesquisar_roteador : Form
    {
        string strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\viarcompatibilidade\viarcompatibilidade\DB_Roteadores.mdf;Integrated Security=True";
        public pesquisar_roteador()
        {
            InitializeComponent();
        }

        private void pesquisar_roteador_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(strcon);
            SqlCommand comm = new SqlCommand();
            string query = "SELECT NOME from roteadores";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "roteadores");

            comboBox1.DisplayMember = "NOME";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = ds.Tables["roteadores"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(strcon);
                cn.Open();
                string query = "SELECT FOTO FROM roteadores WHERE FOTO = NOME";
                SqlDataAdapter adp = new SqlDataAdapter(query,cn);               
                DataSet ds = new DataSet();
                adp.Fill(ds, "roteadores");
                int c = ds.Tables["roteadores"].Rows.Count;

                if (c > 0)
                {
                    //BLOB is read into Byte array, then used to construct MemoryStream,
                    //then passed to PictureBox.
                    Byte[] byt = new Byte[0];
                    byt = (Byte[])(ds.Tables["roteadores"].Rows[c - 1]["FOTO"]);
                    MemoryStream stm = new MemoryStream(byt);
                    pictureBox1.Image = Image.FromStream(stm);
                }
                cn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(strcon);
            SqlCommand comm = new SqlCommand();
            string query = "SELECT DESCRICAO from roteadores";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "roteadores");

            listBox1.DisplayMember = "DESCRICAO";
            listBox1.ValueMember = "ID";
            listBox1.DataSource = ds.Tables["roteadores"];
        }
    }
}
