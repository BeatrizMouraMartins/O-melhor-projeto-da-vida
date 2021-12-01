using _3C1Beatriz.Code.BLL;
using _3C1Beatriz.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1Beatriz.Ui
{

    public partial class FrmUsuarios : Form
    {
        CadastroBLL cadastroBLL = new CadastroBLL();
        CadastroDTO cadastroDTO = new CadastroDTO();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dgvUser.DataSource = cadastroBLL.Listar();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            cadastroDTO.Nome = txtNome.Text;
            cadastroDTO.Tell = txtTell.Text;
            cadastroDTO.Rua = txtRua.Text;
            cadastroDTO.Numero = txtNumero.Text;
            cadastroDTO.Bairro = txtBairro.Text;
            cadastroDTO.Cidade = txtCidade.Text;
            cadastroDTO.Estado = txtEstado.Text;
            cadastroDTO.Pais = txtNomedosPais.Text;
            cadastroDTO.Cpf = txtcpf.Text;
            cadastroDTO.Rg = txtRG.Text;
            cadastroDTO.Datanas = txtData.Text;
            cadastroDTO.País = txtPais.Text;
            cadastroDTO.Email = txtEmail.Text;
            cadastroDTO.Senha = txtSenha.Text;
            cadastroBLL.Editar(cadastroDTO);
            MessageBox.Show("Editado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvUser.DataSource = cadastroBLL.Listar();
            txtNome.Clear();
            txtTell.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtNomedosPais.Clear();
            txtcpf.Clear();
            txtRG.Clear();
            txtData.Clear();
            txtPais.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cadastroDTO.Nome = txtNome.Text;
            cadastroDTO.Tell = txtTell.Text;
            cadastroDTO.Rua = txtRua.Text;
            cadastroDTO.Numero = txtNumero.Text;
            cadastroDTO.Bairro = txtBairro.Text;
            cadastroDTO.Cidade = txtCidade.Text;
            cadastroDTO.Estado = txtEstado.Text;
            cadastroDTO.Pais = txtNomedosPais.Text;
            cadastroDTO.Cpf = txtcpf.Text;
            cadastroDTO.Rg = txtRG.Text;
            cadastroDTO.Datanas = txtData.Text;
            cadastroDTO.País = txtPais.Text;
            cadastroDTO.Email = txtEmail.Text;
            cadastroDTO.Senha = txtSenha.Text;
            cadastroBLL.Excluir(cadastroDTO);
            MessageBox.Show("Excluido com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvUser.DataSource = cadastroBLL.Listar();
            txtNome.Clear();
            txtTell.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtNomedosPais.Clear();
            txtcpf.Clear();
            txtRG.Clear();
            txtData.Clear();
            txtPais.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cadastroDTO.Id =int.Parse(dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTell.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRua.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNumero.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBairro.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCidade.Text = dgvUser.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEstado.Text = dgvUser.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtNomedosPais.Text = dgvUser.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtcpf.Text = dgvUser.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtRG.Text = dgvUser.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtData.Text = dgvUser.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtPais.Text = dgvUser.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtEmail.Text = dgvUser.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtSenha.Text = dgvUser.Rows[e.RowIndex].Cells[14].Value.ToString();
        }
    }
}
