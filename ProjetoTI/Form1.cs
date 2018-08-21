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
            carregarDadosGrid();

            //configaração incial para adequar foto na exibição
            pbFotoAluno.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void carregarDadosGrid()
        {

            using (var db = new unaspContext())
            {
                //Database query direto na DataSource


                dgAluno.DataSource = db.Aluno.Select(x =>
                    new
                    {
                        Id = x.Id,
                        Nome = x.Nome,
                        Idade = x.Idade,
                        Estado = x.IdEstadoNavigation.Nome,
                        DataMatricula = x.DataMatricula
                    }).OrderBy(x=> x.Id).ToList();

                //Configuracoes de DataGridView
                dgAluno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgAluno.AutoGenerateColumns = false;
                dgAluno.ReadOnly = true;


                //Customizando as colunas
                dgAluno.Columns["Id"].Visible = false;
                //dgvAluno.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dgvAluno.Columns["Idade"].HeaderText = "Idade do aluno";
                dgAluno.Columns["Idade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgAluno.Columns["Estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgAluno.Columns["DataMatricula"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

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

        private byte[] retornaImagemDoAluno(int idAluno)
        {
            using (var db = new unaspContext())
            {
                var fotoAluno = db.Aluno.First(x => x.Id == idAluno).Foto;

                return fotoAluno;
            }
        }

        private void dgAluno_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btCadastrar.Text = "Atualizar";
            btDeletar.Enabled = true;

            var _grid = dgAluno.CurrentRow;

            txtNome.Text = _grid.Cells["Nome"].Value.ToString();
            txtIdade.Text = _grid.Cells["Idade"].Value.ToString();

            //pega o nome do estado que está na gridView
            string _estado = _grid.Cells["Estado"].Value.ToString();
            cbEstado.SelectedIndex = cbEstado.FindStringExact(_estado);

            //Imagem do aluno
            int idAluno = Convert.ToInt16(_grid.Cells["Id"].Value.ToString());
            byte[] fotoAlunoEmByte = retornaImagemDoAluno(idAluno);
            pbFotoAluno.Image = byteArrayToImage(fotoAlunoEmByte);

            //Data da Matricula
            string dataMatricula = _grid.Cells["DataMatricula"].Value.ToString();
            dtpMatricula.Value = DateTime.Parse(dataMatricula);
        }
    }
}
