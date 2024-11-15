﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using MySqlConnector;
using POO_II_NP2_WinForms.Model;

namespace POO_II_NP2_WinForms.Repository;

public class LivroRepository(IDbConnection dbConnection) : IRepository<Livro>
{
    public async Task<IEnumerable<Livro>> GetAll()
    {
        await using (var connection = new MySqlConnection(dbConnection.ConnectionString))
        {
            return await connection.QueryAsync<Livro>("SELECT * FROM Livros");
        }
    }

    public async Task<Livro> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<Livro>("SELECT * FROM Livros WHERE IdLivro = @IdLivro", new { IdLivro = id });
    }

    public async Task Add(Livro entity)
    {
        var query = "INSERT INTO Livros (Titulo, Autor, Genero, Editora) VALUES (@Titulo, @Autor, @Genero, @Editora)";
        await dbConnection.ExecuteAsync(query, entity);

        dbConnection.Close();
    }

    public async Task Update(Livro entity)
    {
        var query = "UPDATE Livros SET Titulo = @Titulo, Autor = @Autor, Genero = @Genero, Editora = @Editora WHERE IdLivro = @IdLivro";
        await dbConnection.ExecuteAsync(query, entity);

        dbConnection.Close();
    }

    public async Task Delete(int id)
    {
        if (dbConnection.State != ConnectionState.Open && dbConnection.State != ConnectionState.Connecting)
        {
            dbConnection.Open();
        }

        await dbConnection.ExecuteAsync("DELETE FROM Livros WHERE IdLivro = @IdLivro", new { IdLivro = id });
    }
}