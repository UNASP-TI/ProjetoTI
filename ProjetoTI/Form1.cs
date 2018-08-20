using ProjetoTI.Mysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }
    }
}
