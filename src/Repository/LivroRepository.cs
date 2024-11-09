﻿using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using POO_II_NP2_WinForms.Model;

namespace POO_II_NP2_WinForms.Repository;

public class LivroRepository : IRepository<Livro>
{
    private readonly IDbConnection _dbConnection;

    public LivroRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IEnumerable<Livro>> GetAll()
    {
        return await _dbConnection.QueryAsync<Livro>("SELECT * FROM Livros");
    }

    public async Task<Livro> GetById(int id)
    {
        return await _dbConnection.QueryFirstOrDefaultAsync<Livro>("SELECT * FROM Livros WHERE IdLivro = @IdLivro", new { IdLivro = id });
    }

    public async Task Add(Livro entity)
    {
        var query = "INSERT INTO Livros (Titulo, Autor, Genero, Editora) VALUES (@Titulo, @Autor, @Genero, @Editora)";
        await _dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Update(Livro entity)
    {
        var query = "UPDATE Livros SET Titulo = @Titulo, Autor = @Autor, Genero = @Genero, Editora = @Editora WHERE IdLivro = @IdLivro";
        await _dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await _dbConnection.ExecuteAsync("DELETE FROM Livros WHERE IdLivro = @IdLivro", new { IdLivro = id });
    }
}