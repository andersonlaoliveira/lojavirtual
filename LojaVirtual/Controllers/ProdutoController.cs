﻿using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        private ICategoriaRepository _categoriaRepository;
        private IProdutoRepository _produtoRepository;

        public ProdutoController(ICategoriaRepository categoriaRepository, IProdutoRepository produtoRepository)
        {
            _categoriaRepository = categoriaRepository;
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        [Route("/Produto/Categoria/{slug}")]
        public IActionResult ListagemCategoria(string slug)
        {
            return View(_categoriaRepository.ObterCategoria(slug));
        }

        
        [HttpGet]
        public ActionResult Visualizar(int id)
        {
            //TODO - Obter o produto
            return View(_produtoRepository.ObterProduto(id));
        }
        
    }
}
