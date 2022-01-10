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
    public partial class adicionar_roteadores : Form
    {
        string strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\viarcompatibilidade\viarcompatibilidade\DB_Roteadores.mdf;Integrated Security=True";
        public adicionar_roteadores()
        {
            InitializeComponent();
        }
        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens;
   

        private void adicionar_roteadores_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection cn = new SqlConnection(strcon);   
                string FileName = openFileDialog1.FileName;
                FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                Byte[] ImageData;
                ImageData = br.ReadBytes((int)fs.Length);
               // Byte[] byt = new Byte[FileName.Length];
               // fs.Read(byt, 0, byt.Length);
                fs.Close();
                br.Close();
                string CmdString = "INSERT INTO roteadores (NOME, DESCRICAO, FOTO) values (@NOME, @DESCRICAO, @FOTO)";
                SqlCommand cmd = new SqlCommand(CmdString, cn);

                cmd.Parameters.Add("@NOME", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.VarChar, 500);
                cmd.Parameters.Add("@FOTO", SqlDbType.Image);
                
                cmd.Parameters["@NOME"].Value = textBox1.Text;
                cmd.Parameters["@DESCRICAO"].Value = textBox2.Text;
                cmd.Parameters["@FOTO"].Value = ImageData;              

                cn.Open();
                int RowsAffected = cmd.ExecuteNonQuery();       
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Dados salvos com sucesso!");
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CarregaImagem()
        {
            try
            {
                this.openFileDialog1.ShowDialog(this);
                string strFn = this.openFileDialog1.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                this.pictureBox1.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CarregaImagem();
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
