﻿using LojaVirtual.Migrations;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Repositories.Contracts
{
    public interface ICategoriaRepository
    {
        //CRUD
        void Cadastrar(Categoria categoria);
        void Atualizar(Categoria categoria);
        void Excluir(int Id);
        Categoria ObterCategoria(int Id);
        Categoria ObterCategoria(string Slug);
        IEnumerable<Categoria> ObterCategoriasRecursiva(Categoria categoriaPai);
        IPagedList<Categoria> ObterTodosOsCategorias(int? pagina);

        IEnumerable<Categoria> ObterTodosOsCategorias();
    }
}