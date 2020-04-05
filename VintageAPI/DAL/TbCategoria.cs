using DAL.REPOSITORY;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using modelo = DO.Objetos;

namespace DAL
{
    public class TbCategoria
    {
        private Repository<modelo.TbCategoria> _repository = new Repository<modelo.TbCategoria>("TbCategoria");

        public async Task Create(modelo.TbCategoria entity)
        {
            await _repository.Create(entity);
        }

        public async Task<IEnumerable<modelo.TbCategoria>> Get()
        {
            return await _repository.Get();
        }

        public async Task<modelo.TbCategoria> Get(string id)
        {
            return await _repository.Get(id);
        }
        public async Task<DeleteResult> Remove(string id)
        {
            return await _repository.Remove(id);
        }

        public async Task<string> Update(string id, modelo.TbCategoria entity)
        {
            await _repository.Update(id, entity);
            return "";
        }
    }
}
