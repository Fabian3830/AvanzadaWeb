using data = DAL.MODEL;
using DAL.REPOSITORY;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using modelo = DAL.MODEL;

namespace DAL
{
    public class TbArticulo
    {
        private Repository<data.TbArticulo> _repository = new Repository<data.TbArticulo>("TbArticulo");

        public async Task Create(modelo.TbArticulo entity)
        {
            await _repository.Create(entity);
        }

        public async Task<IEnumerable<modelo.TbArticulo>> Get()
        {
            return await _repository.Get();
        }

        public async Task<modelo.TbArticulo> Get(string id)
        {
            return await _repository.Get(id);
        }
        public async Task<DeleteResult> Remove(string id)
        {
            return await _repository.Remove(id);
        }

        public async Task<string> Update(string id, modelo.TbArticulo entity)
        {
            await _repository.Update(id, entity);
            return "";
        }
    }
}
