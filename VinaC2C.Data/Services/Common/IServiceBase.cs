using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VinaC2C.Data.Models;

namespace VinaC2C.Data.Services
{
    public interface IServiceBase<TEntity> where TEntity : BaseModel
    {
        public Task<int> CreateAsync(TEntity model);

        public Task<int> UpdateAsync(Int64 modelId, TEntity model);

        public Task<int> DeleteAsync(Int64 modelId);

        public Task<List<TEntity>> GetAllToListAsync();

        public Task<TEntity> GetByIdAsync(Int64 modelId);

        public int Create(TEntity model);

        public int Update(Int64 modelId, TEntity model);

        public int Delete(Int64 modelId);

        public List<TEntity> GetAllToList();

        public TEntity GetById(Int64 modelId);
    }
}
