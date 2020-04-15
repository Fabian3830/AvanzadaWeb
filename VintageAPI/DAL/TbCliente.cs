using DAL.REPOSITORY;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using modelo = DO.Objetos;

namespace DAL
{
    public class TbCliente
    {
        private Repository<modelo.TbCliente> _repository = new Repository<modelo.TbCliente>("TbCliente");

        public async Task Create(modelo.TbCliente entity)
        {
            await _repository.Create(entity);
        }

        public async Task<IEnumerable<modelo.TbCliente>> Get()
        {
            return await _repository.Get();
        }

        public async Task<modelo.TbCliente> Get(string id)
        {
            return await _repository.Get(id);
        }
        public async Task<DeleteResult> Remove(string id)
        {
            return await _repository.Remove(id);
        }

     public async Task<string> Update(string id, modelo.TbCliente entity)
        {
            await _repository.Update(id, entity);
            return "";
        }

        public async Task<IEnumerable<modelo.TbCliente>> customQuery(string query)
        {
            return await _repository.customQuery(query);
        }

        public async Task<modelo.TbCliente> Verify(modelo.credentials credential)
        {
            MODEL.DBContext<modelo.TbCliente> contexto = new MODEL.DBContext<modelo.TbCliente>(new MODEL.DBSettings());
            var filtro = Builders<modelo.TbCliente>.Filter.Eq("sCorreo", credential.email);
            return await contexto.Collection("TbCliente").Find(filtro).FirstOrDefaultAsync();
            
        }
    }
}
