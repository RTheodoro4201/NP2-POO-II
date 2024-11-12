using System.Collections.Generic;
using System.Threading.Tasks;
using POO_II_NP2_WinForms.Model;
using POO_II_NP2_WinForms.Repository;
using POO_II_NP2_WinForms.Validator;

namespace POO_II_NP2_WinForms.Controller;

public class LivroController(IRepository<Livro> livroRepository)
{
    public async Task<bool> Create(Livro livro)
    {
        var livroValidator = new LivroValidator();
        var livroValidationResult = await livroValidator.ValidateAsync(livro);

        if (livroValidationResult.IsValid)
        {
            await livroRepository.Add(livro);
            return true;
        }

        return false;
    }

    public async Task<IEnumerable<Livro>> Index()
    {
        var livros = await livroRepository.GetAll();
        return livros;
    }

    public async Task<Livro> SearchLivro(int livroId)
    {
        var livro = await livroRepository.GetById(livroId);
        return livro;
    }

    public async Task<bool> Edit(Livro livro)
    {
        var livroValidator = new LivroValidator();
        var livroValidationResult = await livroValidator.ValidateAsync(livro);

        if (livroValidationResult.IsValid)
        {
            await livroRepository.Update(livro);
            return true;
        }

        return false;
    }

    public async Task Delete(int id)
    {
        var livro = await livroRepository.GetById(id);

        if (livro != null)
        {
            await livroRepository.Delete(id);
        }
    }
}