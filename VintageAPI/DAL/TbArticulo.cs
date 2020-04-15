using DAL.REPOSITORY;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using modelo = DO.Objetos;

namespace DAL
{
    public class TbArticulo
    {
        private Repository<modelo.TbArticulo> _repository = new Repository<modelo.TbArticulo>("TbArticulo");

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


        public async Task<IEnumerable<modelo.TbArticulo>> customQuery(string query) { return await _repository.customQuery(query); }
        public async Task<string> Update(string id, modelo.TbArticulo entity)
        {
            await _repository.Update(id, entity);
            return "";
        }
    }
}
