using System;
using System.Drawing;
using System.Windows.Forms;

using _3C1Beatriz.Code.BLL;
using _3C1Beatriz.Code.DTO;

namespace _3C1Beatriz.Ui
{
    public partial class FrmLogin : Form
    {

        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        bool mover = false;
        Point posicao_inicial;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;
            loginDTO.Cpf = txtCPF.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                FrmMenu menu = new FrmMenu();
                this.Hide();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique se o e-mail, senha ou cpf estao corretos.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrar cad = new FrmCadastrar();
            this.Hide();
            cad.ShowDialog();
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
    }
}
