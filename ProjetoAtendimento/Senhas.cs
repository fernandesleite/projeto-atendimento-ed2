using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    class Senhas
    {
        private Queue<Senha> filaSenhas;
        private int proximoAtendimento;
        public Queue<Senha> FilaSenhas
        {
            get { return filaSenhas; }
        }

        public Senhas()
        {
            this.filaSenhas = new Queue<Senha>();
            this.proximoAtendimento = 1;
        }

        public void gerar()
        {
            this.filaSenhas.Enqueue(new Senha(this.proximoAtendimento++));
        }
    }
}
