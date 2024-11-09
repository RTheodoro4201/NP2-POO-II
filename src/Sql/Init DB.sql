use poo_ii_np2;

create table Livros
(
    IdLivros int auto_increment
        primary key,
    Titulo   nvarchar(150) not null,
    Autor    nvarchar(100) not null,
    Genero   nvarchar(50)  not null,
    Editora  nvarchar(100) not null
);

