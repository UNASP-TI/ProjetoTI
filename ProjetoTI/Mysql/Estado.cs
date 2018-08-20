using System;
using System.Collections.Generic;

namespace ProjetoTI.Mysql
{
    public partial class Estado
    {
        public Estado()
        {
            Aluno = new HashSet<Aluno>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Aluno> Aluno { get; set; }
    }
}
