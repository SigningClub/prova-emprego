﻿using WebApplication1.Models;

namespace WebApplication1.Interface
{
    public interface IProdutoInterface
    {
        IQueryable<ProdutoBase> GetAll();
        Task Add(ProdutoBase produto);
    }
}
