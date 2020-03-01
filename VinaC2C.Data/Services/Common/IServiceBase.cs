using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VinaC2C.Data.Models;

namespace VinaC2C.Data.Services.Common
{
    public interface IServiceBase<TEntity> where TEntity : BaseModel
    {
        public Task<int> CreateAsync(TEntity model);

        public Task<int> UpdateAsync(int modelId, TEntity model);

        public Task<int> DeleteAsync(int modelId);

        public Task<List<TEntity>> GetAllToListAsync();

        public Task<TEntity> GetByIdAsync(int modelId);

        public int Create(TEntity model);

        public int Update(int modelId, TEntity model);

        public int Delete(int modelId);

        public List<TEntity> GetAllToList();

        public TEntity GetById(int modelId);
    }
}
