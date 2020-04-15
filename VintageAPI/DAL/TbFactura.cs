using DAL.REPOSITORY;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using modelo = DO.Objetos;

namespace DAL
{
    public class TbFactura
    {
        private Repository<modelo.TbFactura> _repository = new Repository<modelo.TbFactura>("TbFactura");

        public async Task Create(modelo.TbFactura entity)
        {
            await _repository.Create(entity);
        }

        public async Task<IEnumerable<modelo.TbFactura>> Get()
        {
            return await _repository.Get();
        }

        public async Task<modelo.TbFactura> Get(string id)
        {
            return await _repository.Get(id);
        }
        public async Task<DeleteResult> Remove(string id)
        {
            return await _repository.Remove(id);
        }

         public async Task<IEnumerable<modelo.TbFactura>> customQuery(string query){return await _repository.customQuery(query); }
        public async Task<string> Update(string id, modelo.TbFactura entity)
        {
            await _repository.Update(id, entity);
            return "";
        }
    }
}
