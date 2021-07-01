using ma9.Business.Models;
using System;
using System.Threading.Tasks;

namespace ma9.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
