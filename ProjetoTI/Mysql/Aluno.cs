using System;
using System.Collections.Generic;

namespace ProjetoTI.Mysql
{
    public partial class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public byte[] Foto { get; set; }
        public DateTime DataMatricula { get; set; }
        public int IdEstado { get; set; }

        public Estado IdEstadoNavigation { get; set; }
    }
}
