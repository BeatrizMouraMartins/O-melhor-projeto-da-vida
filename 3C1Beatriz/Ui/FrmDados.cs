using _3C1Beatriz.Code.BLL;
using _3C1Beatriz.Code.DTO;
using System;
using System.Windows.Forms;

namespace _3C1Beatriz.Ui
{
    public partial class FrmDados : Form
    {
        DadosBLL Dadosbll = new DadosBLL();
        DadosDTO Dadosdto = new DadosDTO();

        public FrmDados()
        {
            InitializeComponent();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            Dadosdto.Bmm = txtNome.Text;
            Dadosdto.B08 = txtSobrenome.Text;
            Dadosdto.M11 = txtTurma.Text;

            //Envio do dto preenchido para o método inserir
            Dadosbll.Inserir(Dadosdto);

            //mensagem de cadastrado 
            MessageBox.Show("Cadastrado com sucesso!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSorvetes.DataSource = Dadosbll.Listar();

            txtNome.Clear();
            txtSobrenome.Clear();
            txtTurma.Clear();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            Dadosdto.Bmm = txtNome.Text;
            Dadosdto.B08 = txtSobrenome.Text;
            Dadosdto.M11 = txtTurma.Text;

            //Envio do dto preenchido para o método inserir
            Dadosbll.Editar(Dadosdto);

            //mensagem de cadastrado 
            MessageBox.Show("Editado com sucesso!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSorvetes.DataSource = Dadosbll.Listar();

            txtNome.Clear();
            txtSobrenome.Clear();
            txtTurma.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            Dadosdto.Bmm = txtNome.Text;
            Dadosdto.B08 = txtSobrenome.Text;
            Dadosdto.M11 = txtTurma.Text;

            //Envio do dto preenchido para o método inserir
            Dadosbll.Excluir(Dadosdto);

            //mensagem de cadastrado 
            MessageBox.Show("Excluido com sucesso!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSorvetes.DataSource = Dadosbll.Listar();

            txtNome.Clear();
            txtSobrenome.Clear();
            txtTurma.Clear();
        }

        private void dgvSorvetes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dadosdto.Id = int.Parse(dgvSorvetes.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = dgvSorvetes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSobrenome.Text = dgvSorvetes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTurma.Text = dgvSorvetes.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
