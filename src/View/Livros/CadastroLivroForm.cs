using System;
using System.Windows.Forms;
using POO_II_NP2_WinForms.Controller;
using POO_II_NP2_WinForms.Validator;
using POO_II_NP2_WinForms.Model;

namespace POO_II_NP2_WinForms.View.Livros;

public partial class CadastroLivroForm : Form
{
    private readonly LivroController _livroController;

    public CadastroLivroForm(LivroController livroController)
    {
        InitializeComponent();
        _livroController = livroController;
    }

    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            var livro = new Livro
            {
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                Genero = txtGenero.Text,
                Editora = txtEditora.Text
            };

            if (await _livroController.Create(livro))
            {
                MessageBox.Show("Livro cadastrado com sucesso!");
                Close();
            }

            else
            {
                var livroValidator = new LivroValidator();
                var livroValidationResult = await livroValidator.ValidateAsync(livro);

                MessageBox.Show("Cadastro de Livro inválido!");

                foreach (var erro in livroValidationResult.Errors) MessageBox.Show(erro.ErrorMessage);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente mais tarde.");
            MessageBox.Show(ex.Message);
        }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
}