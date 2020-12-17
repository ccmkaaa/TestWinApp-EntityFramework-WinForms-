using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace TestWinApp.Classes.DALnew
{
    interface IRepository<T> //: IDisposable 
        where T : class
    {
        IEnumerable<T> GetList();
        T Find(decimal id);
        void Create(T item);
        void Update(T item);
        void Delete(decimal id);
        void Save();

    }
    public class TGROUPRepository : IRepository<TGROUP>
    {
        private TestDBContext _dbContext;

        public TGROUPRepository()
        {
            _dbContext = SingletonConnection.GetConnection();
            _dbContext.TGROUP.Load();
        } 

        public IEnumerable<TGROUP> GetList()
        {
            return _dbContext.TGROUP;
        }

        public TGROUP Find(decimal id)
        {
            return _dbContext.TGROUP.Find(id);
        }

        public void Create(TGROUP group)
        {
            _dbContext.TGROUP.Add(group);

            this.Save();
        }

        public void Update(TGROUP group)
        {
            _dbContext.Entry(group).State = EntityState.Modified;
        }

        public void Delete(decimal id)
        {
            TGROUP group = _dbContext.TGROUP.Find(id);
            if (group != null)
                _dbContext.TGROUP.Remove(group);

            this.Save();
        }

        public void Save()   
        {
            _dbContext.SaveChanges();
        }

        //private bool disposed = false;
        //public virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            _dbContext.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }

    public class TRELATIONRepository : IRepository<TRELATION>
    {
        private TestDBContext _dbContext;

        public TRELATIONRepository()
        {
            _dbContext = SingletonConnection.GetConnection();
            _dbContext.TRELATION.Load();
        }

        public IEnumerable<TRELATION> GetList()
        {
            return _dbContext.TRELATION;
        }

        public TRELATION Find(decimal id)
        {
            return _dbContext.TRELATION.Find(id);
        }

        public void Create(TRELATION relation)
        {
            _dbContext.TRELATION.Add(relation);

            this.Save();
        }

        public void Update(TRELATION relation)
        {
            _dbContext.Entry(relation).State = EntityState.Modified;
        }

        public void Delete(decimal id)
        {
            TRELATION relation = _dbContext.TRELATION.Find(id);
            if (relation != null)
                _dbContext.TRELATION.Remove(relation);

            this.Save();
        }

        public void Save() 
        { 
            _dbContext.SaveChanges();
        }
    }

    public class TPROPERTYRepository : IRepository<TPROPERTY>
    {
        private TestDBContext _dbContext;

        public TPROPERTYRepository()
        {
            _dbContext = SingletonConnection.GetConnection();
            _dbContext.TPROPERTY.Load();
        }

        public IEnumerable<TPROPERTY> GetList()
        {
            return _dbContext.TPROPERTY;
        }

        public TPROPERTY Find(decimal id)
        {
            return _dbContext.TPROPERTY.Find(id);
        }

        public TPROPERTY FindByGroupID(decimal id)
        {
            return _dbContext.TPROPERTY.Where(pr => pr.ID_Group == id).FirstOrDefault();
        }

        public void Create(TPROPERTY property)
        {
            _dbContext.TPROPERTY.Add(property);

            this.Save();
        }

        public void Update(TPROPERTY property)
        {
            _dbContext.Entry(property).State = EntityState.Modified;
        }

        public void Delete(decimal id)
        {
            TPROPERTY property = _dbContext.TPROPERTY.Find(id);
            if (property != null)
                _dbContext.TPROPERTY.Remove(property);

            this.Save();
        }

        public void Save()   
        {
            _dbContext.SaveChanges();
        }
    }
}
