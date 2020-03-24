using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using VinaC2C.Data.Models;
using VinaC2C.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace VinaC2C.Data.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : BaseModel
    {

        private readonly VinaC2CContext _context;

        public ServiceBase(VinaC2CContext context)
        {
            _context = context;
        }

        public int Create(TEntity model)
        {
            _context.Set<TEntity>().Add(model);
            return  _context.SaveChanges();
        }

        public async Task<int> CreateAsync(TEntity model)
        {
            _context.Set<TEntity>().Add(model);
            return await _context.SaveChangesAsync();
        }

        public int Delete(Int64 modelId)
        {
            var existModel = GetById(modelId);
            if (existModel != null)
            {
                _context.Set<TEntity>().Remove(existModel);
            }
            return  _context.SaveChanges();
        }

        public async Task<int> DeleteAsync(Int64 modelId)
        {
            var existModel = await GetByIdAsync(modelId);
            if (existModel != null)
            {
                _context.Set<TEntity>().Remove(existModel);
            }
            return await _context.SaveChangesAsync();
        }

        public List<TEntity> GetAllToList()
        {
            var result = _context.Set<TEntity>().ToList();
            return result != null ? result : new List<TEntity>();
        }

        public async Task<List<TEntity>> GetAllToListAsync()
        {
            var result = await _context.Set<TEntity>().ToListAsync();
            return result != null ? result : new List<TEntity>();
        }

        public TEntity GetById(Int64 modelId)
        {
            return  _context.Set<TEntity>().AsNoTracking().FirstOrDefault(model => model.Id == modelId);
        }

        public async Task<TEntity> GetByIdAsync(Int64 modelId)
        {
            return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(model => model.Id == modelId);
        }

        public int Update(Int64 modelId, TEntity model)
        {
            var existModel = GetById(modelId);
            if (existModel != null)
            {
                existModel = model;
                _context.Set<TEntity>().Update(existModel);
            }
            return _context.SaveChanges();
        }

        public async Task<int> UpdateAsync(Int64 modelId, TEntity model)
        {
            var existModel = await GetByIdAsync(modelId);
            if(existModel != null)
            {
                existModel = model;
                _context.Set<TEntity>().Update(existModel);
            }
            return await _context.SaveChangesAsync();
        }
    }
}
