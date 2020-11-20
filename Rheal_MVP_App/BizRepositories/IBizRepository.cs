using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rheal_MVP_App.BizRepositories
{
    public interface IBizRepository<TEntity, in TPk> where TEntity : class
    {
        //get all data
        List<TEntity> getData();

        //get single entry
        TEntity getData(TPk id);

        //create new data
        TEntity Create(TEntity entity);

        //update data
        TEntity Update(TPk id, TEntity entity);

        //delete data
        bool Delete(TPk id);
    }
}
