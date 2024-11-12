using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO_II_NP2_WinForms.Controller;

namespace POO_II_NP2_WinForms.View.Livros;

#region TODO

#endregion

public partial class LivroForm : Form
{
    private readonly LivroController _livroController;

    public LivroForm(LivroController livroController)
    {
        InitializeComponent();
        _livroController = livroController;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void LivroForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        dataLivros.AutoGenerateColumns = true;
        await CarregarGrid();
    }

    private async Task CarregarGrid()
    {
        try
        {
            var livros = await _livroController.Index();

            if (livros.Any())
            {
                dataLivros.DataSource = livros;
                dataLivros.Columns[0].HeaderText = "Id";
                dataLivros.Columns[1].HeaderText = "Título";
                dataLivros.Columns[3].HeaderText = "Gênero";
                dataLivros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            else
            {
                MessageBox.Show("Não foi encontrado nenhum registro no servidor.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        catch (Exception e)
        {
            MessageBox.Show(
                "Ocorreu um erro ao carregar os dados dos livros. Por favor, tente novamente mais tarde.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            MessageBox.Show(
                "Erro: " + e.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool VerificarSelecao()
    {
        if (dataLivros.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecione um livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        return true;
    }

    #region Métodos de Click

    private async void btnCadastrar_Click(object sender, EventArgs e)
    {
        var cadastroLivroForm = new CadastroLivroForm(_livroController);
        cadastroLivroForm.ShowDialog();

        await CarregarGrid();
    }

    private async void btnAlterar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var idLivro =
                Convert.ToInt32(dataLivros.SelectedRows[0].Cells["IdLivro"].Value);

            var alteraLivroForm = new AlteraLivroForm(_livroController, idLivro);
            alteraLivroForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnConsultar_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var idLivro = Convert.ToInt32(dataLivros.SelectedRows[0].Cells["IdLivro"].Value);
            var consultaLivroForm = new ConsultaLivroForm(_livroController, idLivro);
            consultaLivroForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        if (VerificarSelecao())
        {
            var idLivro = Convert.ToInt32(dataLivros.SelectedRows[0].Cells["IdLivro"].Value);
            var excluirLivroForm = new ExcluirLivroForm(_livroController, idLivro);
            excluirLivroForm.ShowDialog();

            await CarregarGrid();
        }
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion

    private async void btnRecarregar_Click(object sender, EventArgs e)
    {
        await CarregarGrid();
    }

    private async Task AtualizarGrid(int idLivro)
    {
        try
        {
            var livros = await _livroController.Index();

            if (livros.Any())
            {

            }

            else
            {
                MessageBox.Show("Não foi encontrado nenhum registro no servidor.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        catch (Exception e)
        {
            MessageBox.Show(
                "Ocorreu um erro ao carregar os dados dos livros. Por favor, tente novamente mais tarde.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            MessageBox.Show(
                "Erro: " + e.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}