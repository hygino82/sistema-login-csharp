﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;
            string nome = txtUsuario.Text;
            if (CadastroUsuario.Login(nome, senha))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado");
                txtSenha.Text = "";
                txtUsuario.Text = "";
                txtUsuario.Focus();
                Close();
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
