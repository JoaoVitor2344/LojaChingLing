using System;
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
    public partial class FrmCrudCartaoVenda : Form
    {
        SqlConnection con = Conexao.obterConexao();
        public FrmCrudCartaoVenda()
        {
            InitializeComponent();
        }

        public void carrega_dgv_cartaoVenda()
        {
            SqlConnection con = Conexao.obterConexao();
            String query = "select * from cartaovenda";
            SqlCommand cmd = new SqlCommand(query, con);
            Conexao.obterConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable cartao = new DataTable();
            da.Fill(cartao);
            dgv_cartaoVenda.DataSource = cartao;
            Conexao.fecharConexao();
        }

        public void CarregacbxUsuario()
        {
            string cli = "select id, nome from usuario";
            SqlCommand cmd = new SqlCommand(cli, con);
            Conexao.obterConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cli, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "nome");
            cbx_usuario.ValueMember = "id";
            cbx_usuario.DisplayMember = "nome";
            cbx_usuario.DataSource = ds.Tables["nome"];
            Conexao.fecharConexao();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conexao.obterConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Inserir_CartaoVenda";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero", txt_numero.Text);
                cmd.Parameters.AddWithValue("@usuario", cbx_usuario.Text);
                Conexao.obterConexao();
                cmd.ExecuteNonQuery();
                carrega_dgv_cartaoVenda();
                FrmPrincipal obj = (FrmPrincipal)Application.OpenForms["FrmPrincipal"];
                obj.carrega_dgvPri_pedido();
                MessageBox.Show("Registro inserido com sucesso!", "Cadastro", MessageBoxButtons.OK);
                Conexao.fecharConexao();
                txt_numero.Text = "";
                cbx_usuario.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conexao.obterConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Atualizar_CartaoVenda";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                cmd.Parameters.AddWithValue("@numero", this.txt_numero.Text);
                cmd.Parameters.AddWithValue("@usuario", this.cbx_usuario.Text);
                Conexao.obterConexao();
                cmd.ExecuteNonQuery();
                carrega_dgv_cartaoVenda();
                FrmPrincipal obj = (FrmPrincipal)Application.OpenForms["FrmPrincipal"];
                obj.carrega_dgvPri_pedido();
                MessageBox.Show("Registro atualizado com sucesso!", "Atualizar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexao.fecharConexao();
                txt_numero.Text = "";
                cbx_usuario.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conexao.obterConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Excluir_CartaoVenda";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                Conexao.obterConexao();
                cmd.ExecuteNonQuery();
                carrega_dgv_cartaoVenda();
                FrmPrincipal obj = (FrmPrincipal)Application.OpenForms["FrmPrincipal"];
                obj.carrega_dgvPri_pedido();
                MessageBox.Show("Registro apagado com sucesso!", "Excluir Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Conexao.fecharConexao();
                txt_numero.Text = "";
                cbx_usuario.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conexao.obterConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Localizar_CartaoVenda";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                Conexao.obterConexao();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtId.Text = rd["Id"].ToString();
                    txt_numero.Text = rd["numero"].ToString();
                    cbx_usuario.Text = rd["usuario"].ToString();
                    Conexao.fecharConexao();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!", "Sem registro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Conexao.fecharConexao();
                }
            }
            finally
            {
            }
        }

        private void cbx_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmCrudCartaoVenda_Load(object sender, EventArgs e)
        {
            CarregacbxUsuario();
        }
    }
}
