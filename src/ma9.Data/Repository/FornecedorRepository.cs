using ma9.Business.Interfaces;
using ma9.Business.Models;
using ma9.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ma9.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContext context) : base(context) { }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(fornecedor => fornecedor.Endereco)
                .FirstOrDefaultAsync(fornecedor=> fornecedor.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(fornecedor => fornecedor.Endereco)
                .Include(fornecedor => fornecedor.Produtos)
                .FirstOrDefaultAsync(fornecedor => fornecedor.Id == id);
        }
    }
}
