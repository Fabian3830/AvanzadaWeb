using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.MODEL;
using MongoDB.Driver;

namespace DAL.REPOSITORY
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DBContext<T> _context ;
        string _collection;

        public Repository(string collection)
        {
            _context = new DBContext<T>(new DBSettings());
            _collection = collection;
        }

        public async Task Create(T entity)
        {
            await _context.Collection(_collection).InsertOneAsync(entity);
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _context.Collection(_collection).Find(x => true).ToListAsync();
        }

        public async Task<T> Get(string id)
        {
            var student = Builders<T>.Filter.Eq("_id", id);
            return await _context.Collection(_collection).Find(student).FirstOrDefaultAsync();
        }

        public async Task<DeleteResult> Remove(string id)
        {
            return await _context.Collection(_collection).DeleteOneAsync(Builders<T>.Filter.Eq("_id", id));
        }

        public async Task<string> Update(string id, T entity)
        {
            await _context.Collection(_collection).ReplaceOneAsync(Builders<T>.Filter.Eq("_id", id), entity);
            return "";
        }
    }
}
