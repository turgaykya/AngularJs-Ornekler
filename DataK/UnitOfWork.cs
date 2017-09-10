using Entities2;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataK
{
    public class UnitOfWork
    {
        AngularContext angularContext;
        public UnitOfWork()
        {
            angularContext = new AngularContext();
        }
        Repository<Şehir> _adminUserRepository;
        public Repository<Şehir> ŞehirRepository
        {
            get
            {
                if (_adminUserRepository == null)
                {
                    _adminUserRepository = new Repository<Şehir>(angularContext);
                }
                return _adminUserRepository;
            }
        }

        Repository<Ürünler> _commentReposiroty;
        public Repository<Ürünler> ÜrünlerRepository
        {
            get
            {
                if (_commentReposiroty == null)
                {
                    _commentReposiroty = new Repository<Ürünler>(angularContext);
                }
                return _commentReposiroty;
            }
        }

        Repository<Kategori> _islandRepository;
        public Repository<Kategori> KategoriRepository
        {
            get
            {
                if (_islandRepository == null)
                {
                    _islandRepository = new Repository<Kategori>(angularContext);
                }
                return _islandRepository;
            }
        }

        DbContextTransaction _tran;
        public bool ApplyChanges()
        {
            bool isSuccess = false;
            _tran = angularContext.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            try
            {
                angularContext.SaveChanges();
                _tran.Commit();
                isSuccess = true;
            }
            catch (Exception e)
            {
                _tran.Rollback();
                isSuccess = false;

                throw new Exception(e.Message);
            }
            finally
            {
                _tran.Dispose();
            }
            return isSuccess;
        }
    }
}
