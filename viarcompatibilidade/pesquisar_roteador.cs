﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.VisualBasic;


namespace viarcompatibilidade
{
    public partial class pesquisar_roteador : Form
    {
        string strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Viar\Source\Repos\viarcompatibilidade1\viarcompatibilidade\roteadores.mdf;Integrated Security=True";
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
            this.comboBox1.DisplayMember = "NOME";
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.DataSource = ds.Tables["roteadores"];
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Informe o nome do roteador no Banco de dados", "ROTEADORES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                SqlConnection cn = new SqlConnection(strcon);
                
                SqlCommand cmdSelect = new SqlCommand("select FOTO,DESCRICAO from roteadores where NOME=@NOME",cn);
                
                cmdSelect.Parameters.Add("@NOME", SqlDbType.VarChar, 50);
                cmdSelect.Parameters.Add("@DESCRICAO", SqlDbType.VarChar, 750);
                cmdSelect.Parameters["@DESCRICAO"].Value = this.textBox1.Text;
                cmdSelect.Parameters["@NOME"].Value = this.comboBox1.Text;
                cn.Open();      
                
                byte[] vetorImagem = (byte[])cmdSelect.ExecuteScalar();
                string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
                fs.Write(vetorImagem, 0, vetorImagem.Length);
                fs.Flush();
                fs.Close();
                SqlDataReader da = cmdSelect.ExecuteReader();
                while (da.Read())
                {
                    textBox1.Text = da.GetValue(1).ToString();
                }
                


                pictureBox1.Image = Image.FromFile(strNomeArquivo);

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


    }
}