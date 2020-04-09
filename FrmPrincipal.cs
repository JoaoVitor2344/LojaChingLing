﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LojaCL
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void carrega_dgvPri_pedido()
        {
            SqlConnection con = Conexao.obterConexao();
            String query = "SELECT * FROM cartaovenda";
            SqlCommand cmd = new SqlCommand(query, con);
            Conexao.obterConexao();
            cmd.CommandType = CommandType.Text;
            //SQlDataAdapter, usado para preencher o DataTable
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Adicionar DataTable carregado em memória
            DataTable cartao = new DataTable();
            da.Fill(cartao);
            //Fonte de dados
            dgvPri_pedido.DataSource = cartao;
            //Quando for criar um controle em tempo de execução, é importante atribuir nome, e definir as principais propriedades
            DataGridViewButtonColumn fechar = new DataGridViewButtonColumn();
            fechar.Name = "fecharConta";
            fechar.HeaderText = "Fechar Conta";
            fechar.Text = "Fechar Conta";
            fechar.UseColumnTextForButtonValue = true;
            int columIndex = 4;
            dgvPri_pedido.Columns.Insert(columIndex, fechar);
            Conexao.fecharConexao();
            //Chama o evento
            dgvPri_pedido.CellClick += dgvPri_pedido_CellClick;
            int colunas = dgvPri_pedido.Columns.Count;
            if(colunas > 5)
            {
                dgvPri_pedido.Columns.Remove("fecharConta");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudCliente cli = new FrmCrudCliente();
            cli.Show();
        }

        private void testarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conexao.obterConexao();
                String query = "select * from cliente";
                SqlCommand cmd = new SqlCommand(query, con);
                Conexao.obterConexao();
                DataSet ds = new DataSet();
                MessageBox.Show("Conectado ao Banco de Dados com Sucesso!", "Teste de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                Conexao.fecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudProduto pro = new FrmCrudProduto();
            pro.Show();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVenda ven = new FrmVenda();
            ven.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudUsuario usu = new FrmCrudUsuario();
            usu.Show();
        }

        private void dgvPri_pedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == dgvPri_pedido.Columns["fecharConta"].Index)
                {
                    if(Application.OpenForms["FrmVenda"] == null)
                    {
                        FrmVenda ven = new FrmVenda();
                        ven.Show();
                    }
                }
            }
            catch { }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            carrega_dgvPri_pedido();
        }

        private void cartãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudCartaoVenda car = new FrmCrudCartaoVenda();
            car.Show();
        }
    }
}
