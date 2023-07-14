using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
    public partial class Form1 : Form
    {
        //Váriaveis globais//
        public List<string> extratos = new List<string>();



        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {




        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

            




        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Para salvar o valor do saldo digitado//
            double valor;
            double saldo;

            valor = double.Parse(txtValor.Text);
            string novo_saldo = lblSaldo.Text;
            // Replace serve para substituir algo//
            novo_saldo = novo_saldo.Replace("R$", "");

            saldo = double.Parse(novo_saldo);

            
            double soma;
            if( lblOperacao.Text == "DEPÓSITO")
            {
               

                soma = saldo + valor;
                extratos.Add($"SAQUE no valor de R$ {valor}");
            }
            else
            {


                soma = valor - saldo;
                extratos.Add($"DEPÓSITO no valor de R$ {valor}");
            }


            

            lblSaldo.Text = $"R$ {soma} ";



        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            //Tirar a cor do depositar//
            btnDepositar.BackColor = Color.Gray;
            btnDepositar.ForeColor = Color.White;

            // Pintar botão sacar//
            btnSacar.BackColor = Color.Black;
            btnSacar.ForeColor = Color.White;
            // Escrever na hora de sacar//
            lblOperacao.Text  = "SAQUE";








            //ForeColor mudar cor da fonte
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

            

            //Tirar a cor do sacar//
            btnSacar.BackColor = Color.Gray;
            btnSacar.ForeColor = Color.White;

            // Pintar botão depositar//
            btnDepositar.BackColor = Color.Black;
            btnDepositar.ForeColor = Color.White;
            lblOperacao.Text = "DEPÓSITO";
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            // Abrir nova tela quando clicar em extrato//
            Form2 telaextrato = new Form2();
            
            //Juntar as informações das duas telas//
            telaextrato.extratos = extratos;
            telaextrato.Show();
        }
    }
}
