using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_Produtos.Models
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private List<Produto> produtos = new List<Produto>();
        private int _nextId = 1;

        public ProdutoRepositorio()
        {
            Add(new Produto { Nome = "Guaraná Antartica", Categoria = "Refrigerantes", Preco = 4.59M });
            Add(new Produto { Nome = "Suco Aurora", Categoria = "Sucos", Preco = 7.50M });
            Add(new Produto { Nome = "Mostarda Etti", Categoria = "Condimentos", Preco = 2.59M });
            Add(new Produto { Nome = "Molho tomate Cepera", Categoria = "Condimentos", Preco = 6.59M });
            Add(new Produto { Nome = "Suco Del Valle", Categoria = "Sucos", Preco = 2.59M });
            Add(new Produto { Nome = "Coca Cola", Categoria = "Refrigerantes", Preco = 1.59M });
        }

        public Produto Add(Produto item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            produtos.Add(item);
            return item;
        }

        public Produto Get(int id)
        {
            return produtos.Find(p => p.Id == id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return produtos;
        }

        public void Remove(int id)
        {
            produtos.RemoveAll(p => p.Id == id);
        }

        public bool Update(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = produtos.FindIndex(p => p.Id == item.Id);

            if(index == -1)
            {
                return false;
            }
            produtos.RemoveAt(index);
            produtos.Add(item);
            return true;
        }
    }
}