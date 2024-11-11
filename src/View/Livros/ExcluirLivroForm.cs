using System;
using System.Windows.Forms;
using POO_II_NP2_WinForms.Controller;
using POO_II_NP2_WinForms.Model;

namespace POO_II_NP2_WinForms.View.Livros;

public partial class ExcluirLivroForm : Form
{
    private readonly int _idLivro;
    private readonly LivroController _livroController;
    private Livro _livro;

    public ExcluirLivroForm(LivroController livroController, int idLivro)
    {
        InitializeComponent();
        _livroController = livroController;
        _idLivro = idLivro;
    }

    private async void ExcluirLivroForm_Load(object sender, EventArgs e)
    {
        ResizeForm(this, null);
        var livro = await _livroController.SearchLivro(_idLivro);
        if (livro != null)
        {
            _livro = livro;
            PopulaCampos(_livro);
        }

        else
        {
            MessageBox.Show("Não foi possível carregar os dados deste livro! Tente novamente mais tarde.");
            Close();
        }
    }

    private void PopulaCampos(Livro livro)
    {
        txtId.Text = livro.IdLivro.ToString();
        txtTitulo.Text = livro.Titulo;
        txtAutor.Text = livro.Autor;
        txtGenero.Text = livro.Genero;
        txtEditora.Text = livro.Editora;
    }

    private void ResizeForm(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            var resultado =
                MessageBox.Show(
                    $"Deseja excluir o livro {_livro.Titulo}? Esta ação não pode ser desfeita.",
                    "Excluir Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                await _livroController.Delete(_idLivro);
                MessageBox.Show("Livro excluído com sucesso!");
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Houve um erro ao tentar excluir o livro!");
            MessageBox.Show(exception.Message);
            throw;
        }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
}