using System;
using System.Windows.Forms;
using POO_II_NP2_WinForms.Controller;
using POO_II_NP2_WinForms.Model;

namespace POO_II_NP2_WinForms.View.Livros;

public partial class ConsultaLivroForm : Form
{
    private readonly int _idLivro;
    private readonly LivroController _livroController;
    private Livro _livro;

    public ConsultaLivroForm(LivroController livroController, int idLivro)
    {
        InitializeComponent();
        _livroController = livroController;
        _idLivro = idLivro;
    }

    private async void ConsultaLivroForm_Load(object sender, EventArgs e)
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

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }
}