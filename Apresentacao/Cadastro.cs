﻿using Academia.controle;
using Academia.validacao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        
        private void AcademiaCad_Load(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

     

        private void button1_Click(object sender, EventArgs e)
        {

            //valida CEP

            if (!string.IsNullOrWhiteSpace(cepCadastro.Text))
            {
                validaCEP validaCEP = new validaCEP();
                validaCEP.validacaoCEP(cepCadastro);
    
            Controle controle = new Controle();
            String mensagem =  controle.cadastrar(emailCadastro.Text, usuarioCadastro.Text, senhaCadastro.Text, cepCadastro.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login academiaCadastro = new Login();
                academiaCadastro.Show();
            }
            else
            {
                MessageBox.Show(controle.mensagem);

            }
     } else
            {
                MessageBox.Show("Coloque um CEP válido!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void abrirLogin_click(object sender, EventArgs e)
        {
            Login abrirLogin = new Login();
            abrirLogin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }
    }
}
