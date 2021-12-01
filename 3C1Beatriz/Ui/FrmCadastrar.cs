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
    public partial class FrmCadastrar : Form
    {
        bool mover = false;
        Point posicao_inicial;

        CadastroBLL cadastroBLL = new CadastroBLL();
        CadastroDTO cadastroDTO = new CadastroDTO();

        public FrmCadastrar()
        {
            InitializeComponent();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_inicial = new Point(e.X, e.Y);
        }

        private void panelCabecalho_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - posicao_inicial.X, novo.Y - posicao_inicial.Y);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastroDTO.Nome = txtNome.Text;
            cadastroDTO.Tell = txtTell.Text;
            cadastroDTO.Rua = txtRua.Text;
            cadastroDTO.Numero = txtNumero.Text;
            cadastroDTO.Bairro = txtBairro.Text;
            cadastroDTO.Cidade =txtCidade.Text;
            cadastroDTO.Estado =txtEstado.Text;
            cadastroDTO.Pais =txtNomedosPais.Text;
            cadastroDTO.Cpf =txtcpf.Text;
            cadastroDTO.Rg =txtRG.Text;
            cadastroDTO.Datanas =txtData.Text;
            cadastroDTO.País =txtPais.Text;
            cadastroDTO.Email =txtEmail.Text;
            cadastroDTO.Senha =txtSenha.Text;

            cadastroBLL.RealizarCadastro(cadastroDTO);
            MessageBox.Show("Cadastrado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
        }
    }
}
