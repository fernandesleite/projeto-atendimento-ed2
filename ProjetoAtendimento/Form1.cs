using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtendimento
{
    public partial class Form1 : Form
    {
        private Senhas senhas = new Senhas();
        private Guiches guiches = new Guiches();
        
        public Form1()
        {
            InitializeComponent();
        }

        #region eventosSenha
        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
            MessageBox.Show("Senha Gerada");
        }
        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            listSenhasGeradas.Items.Clear();
            foreach (Senha senha in senhas.FilaSenhas)
            {
                listSenhasGeradas.Items.Add(senha.dadosParciais());
            }
        }
        #endregion

        #region eventosGuiche
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche(guiches.ListaGuiches.Count + 1));
            labelGuichesAbertos.Text = guiches.ListaGuiches.Count.ToString();
        }        
        private void btnChamar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tbGuicheChamado.Text) <= guiches.ListaGuiches.Count)
                    guiches.ListaGuiches[int.Parse(tbGuicheChamado.Text) - 1].chamar(senhas.FilaSenhas);
                else
                    MessageBox.Show("Guiche não encontrado", "Erro");
            }
            catch (Exception FormatException)
            {
                MessageBox.Show("Digite o número do guiche", "Erro");
            }

        }
        private void btnListarAtendimentos_Click(object sender, EventArgs e)
        {
            listAtendimentosChamados.Items.Clear();
            if (int.Parse(tbGuicheChamado.Text) <= guiches.ListaGuiches.Count)
            {
                foreach (Senha senha in guiches.ListaGuiches[int.Parse(tbGuicheChamado.Text) - 1].Atendimentos)
                {
                    listAtendimentosChamados.Items.Add(senha.dadosCompletos());
                }
            }
        } 
        #endregion
    }
}
