using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace viarcompatibilidade
{
    public partial class adicionar_roteadores : Form
    {
        string strcon = @"Data Source=191.5.48.26;Initial Catalog=roteadores;Persist Security Info=True;User ID=viarnet;Password=Viarnet@@2022";
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
                //Abrir Imagem;
                SqlConnection cn = new SqlConnection(strcon);   
                string FileName = openFileDialog1.FileName;
                FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                Byte[] ImageData;
                ImageData = br.ReadBytes((int)fs.Length);
                fs.Close();
                br.Close();
                //Abrir banco de dados e inserir a imagem, o nome, e a descrição na tabela;
                string CmdString = "INSERT INTO roteadores (NOME, DESCRICAO, FOTO) values (@NOME, @DESCRICAO, @FOTO)";
                SqlCommand cmd = new SqlCommand(CmdString, cn);
                cmd.Parameters.Add("@NOME", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.VarChar, 750);
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
                //carrega a imagem do db e muda seu tipo;
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
