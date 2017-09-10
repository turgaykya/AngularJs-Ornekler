using DataK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities2;

namespace Business
{
    public class UrunBLL : IRepository<Ürünler>
    {
        UnitOfWork _uow;
        public UrunBLL()
        {
            _uow = new UnitOfWork();
        }
        public void Add(Ürünler item)
        {
            throw new NotImplementedException();
        }

       

        public void Remove(Ürünler item)
        {
            throw new NotImplementedException();
        }

        public void Update(Ürünler item)
        {
            throw new NotImplementedException();
        }

        public Ürünler Get(int id)
        {
            throw new NotImplementedException();
        }

       
        public List<Ürünler> GetAll()
        {
            return _uow.ÜrünlerRepository.GetAll();
        }

        public List<Kategori> KategoriGetAll()
        {
            return _uow.KategoriRepository.GetAll();
        }

        public List<Şehir> ŞehirGetAll()
        {
            return _uow.ŞehirRepository.GetAll();
        }
    }
}
