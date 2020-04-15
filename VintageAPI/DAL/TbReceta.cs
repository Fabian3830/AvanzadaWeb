using DAL.REPOSITORY;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using modelo = DO.Objetos;

namespace DAL
{
    public class TbReceta
    {
        private Repository<modelo.TbReceta> _repository = new Repository<modelo.TbReceta>("TbReceta");

        public async Task Create(modelo.TbReceta entity)
        {
            await _repository.Create(entity);
        }

        public async Task<IEnumerable<modelo.TbReceta>> Get()
        {
            return await _repository.Get();
        }

        public async Task<modelo.TbReceta> Get(string id)
        {
            return await _repository.Get(id);
        }
        public async Task<DeleteResult> Remove(string id)
        {
            return await _repository.Remove(id);
        }

         public async Task<IEnumerable<modelo.TbReceta>> customQuery(string query){return await _repository.customQuery(query); }
        public async Task<string> Update(string id, modelo.TbReceta entity)
        {
            await _repository.Update(id, entity);
            return "";
        }
    }
}
