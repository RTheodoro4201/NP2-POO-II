using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using POO_II_NP2_WinForms.Controller;
using POO_II_NP2_WinForms.Model;
using POO_II_NP2_WinForms.Validator;

namespace POO_II_NP2_WinForms.View.Livros;

public partial class AlteraLivroForm : Form
{
    private readonly LivroController _livroController;
    private readonly int _idLivro;
    private Livro _livro;

    public AlteraLivroForm(LivroController livroController, int idLivro)
    {
        InitializeComponent();
        _livroController = livroController;
        _idLivro = idLivro;
    }

    private async void AlteraLivroForm_Load(object sender, EventArgs e)
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

    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            var livro = new Livro
            {
                IdLivro = _idLivro,
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                Genero = txtGenero.Text,
                Editora = txtEditora.Text
            };

            if (await _livroController.Edit(livro))
            {
                MessageBox.Show("Livro alterado com sucesso!");
                Close();
            }

            else
            {
                var livroValidator = new LivroValidator();
                var livroValidationResult = await livroValidator.ValidateAsync(livro);

                MessageBox.Show("Alteração de Livro inválida!");

                foreach (var erro in livroValidationResult.Errors) MessageBox.Show(erro.ErrorMessage);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente mais tarde.");
            MessageBox.Show(ex.Message);
            Close();
        }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
}