using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3C1Beatriz
{
    public partial class FrmMenu : Form
    {
        bool mover = false;
        Point posicao_inicial;
        public Form _objForm;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Ui.FrmLogin login = new Ui.FrmLogin();
            this.Hide();
            login.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new Ui.FrmUsuarios
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelConteudo.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new Ui.FrmDados
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelConteudo.Controls.Add(_objForm);
            _objForm.Show();
        }
    }
}
