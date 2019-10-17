using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    class Guiche
    {
        private int id;
        Queue<Senha> atendimentos;

        public int Id
        {
            get { return id; }
        }
        public Queue<Senha> Atendimentos
        {
            get { return atendimentos; }
        }

        public Guiche()
        {
            atendimentos = new Queue<Senha>();
            id = 0;
        }

        public Guiche(int id)
        {
            atendimentos = new Queue<Senha>();
            this.id = id;
        }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            if (filaSenhas.Count != 0)
            {
                Senha senhaRetirada = filaSenhas.Dequeue();
                senhaRetirada.DataAtend = DateTime.Now;
                senhaRetirada.HoraAtend = DateTime.Now;
                atendimentos.Enqueue(senhaRetirada);
                return true;
            }
                return false;            
        }
    }
}
