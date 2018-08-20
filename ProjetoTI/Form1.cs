using ProjetoTI.Mysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            carregarComboBox();

            //configaração incial para adequar foto na exibição
            pbFotoAluno.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void carregarComboBox()
        {
            using (unaspContext db = new unaspContext())
            {
                //Adicionando programaticamente um item na comboBox para poder iniciar corretamente o programa
                var list = new List<Object>();

                list.Add(new { Id = -1, Nome = "Selecione o Estado" });
                list.AddRange(db.Estado.Select(x => new { x.Id, x.Nome }).ToList());

                //carregando a cmbox1
                cbEstado.DataSource = list;
                cbEstado.DisplayMember = "Nome";
                cbEstado.ValueMember = "Id";
            };
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            using (var db = new unaspContext())
            {
                Aluno aluno = new Aluno();                

                //adiciona no objeto aluno informações que estão no Forms
                aluno.Nome = txtNome.Text;
                aluno.Idade = Convert.ToInt16(txtIdade.Text);
                aluno.IdEstado = Convert.ToInt32(cbEstado.SelectedValue);
                aluno.DataMatricula = dtpMatricula.Value;

                //convertendo imagem para banco de dados
                if (pbFotoAluno.ImageLocation != null)
                {
                    Image img = resizeImage(pbFotoAluno.Image, new Size(500, 500));
                    byte[] bytes = imageToByteArray(img);
                    aluno.Foto = bytes;
                }
                
                db.Aluno.Add(aluno);

                db.SaveChanges();
                
                MessageBox.Show("Aluno Adicionado!");

            }
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Selecione a foto do Aluno";
                dlg.Filter = "All Files|*.*|JPG|*.jpg|PNG|*.png|GIF|*.gif";
                dlg.Multiselect = false;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property

                    pbFotoAluno.ImageLocation = dlg.FileName;
                }
            }
        }



        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                returnImage = Image.FromStream(ms);

            }
            catch
            {
                MessageBox.Show("Erro ao Exibir Imagem!");
            }
            return returnImage;
        }

        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
    }
}
