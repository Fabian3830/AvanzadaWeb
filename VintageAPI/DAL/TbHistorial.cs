using DAL.REPOSITORY;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using modelo = DO.Objetos;

namespace DAL
{
    public class TbHistorial
    {
        private Repository<modelo.TbHistorial> _repository = new Repository<modelo.TbHistorial>("TbHistorial");

        public async Task Create(modelo.TbHistorial entity)
        {
            await _repository.Create(entity);
        }

        public async Task<IEnumerable<modelo.TbHistorial>> Get()
        {
            return await _repository.Get();
        }

        public async Task<modelo.TbHistorial> Get(string id)
        {
            return await _repository.Get(id);
        }
        public async Task<DeleteResult> Remove(string id)
        {
            return await _repository.Remove(id);
        }

         public async Task<IEnumerable<modelo.TbHistorial>> customQuery(string query){return await _repository.customQuery(query); }

        public async Task<string> Update(string id, modelo.TbHistorial entity)
        {
            await _repository.Update(id, entity);
            return "";
        }
    }
}
