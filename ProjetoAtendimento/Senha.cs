using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        #region Propriedades
        public DateTime DataGerac
        {
            get{ return dataGerac; }
            set{ dataGerac = value; }
        }

        public DateTime HoraGerac
        {
            get{ return horaGerac; }
            set{ horaGerac = value; }
        }

        public DateTime DataAtend
        {
            get{ return dataAtend; }
            set{ dataAtend = value; }
        }

        public DateTime HoraAtend
        {
            get{ return horaAtend; }
            set{ horaAtend = value; }
        }
        public int Id
        {
            get { return id; }
        }
        #endregion
        public Senha(int id)
        {
            this.DataGerac = DateTime.Now;
            this.HoraGerac = DateTime.Now;
            this.DataAtend = new DateTime(0);
            this.HoraAtend = new DateTime(0);
            this.id = id;
        }

        public string dadosParciais()
        {
            return this.id + " - " + this.DataGerac.ToShortDateString() + " - " + this.HoraGerac.ToLongTimeString();
        }

        public string dadosCompletos()
        {
            return this.dadosParciais() + " - " + this.DataAtend.ToShortDateString() + " - " + this.HoraAtend.ToLongTimeString();
        }
    }
}
