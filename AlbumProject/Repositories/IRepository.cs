using AlbumProject.Data;
using AlbumProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumProject.Repositories
{
    public interface IRepository<T> where T :class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T artist);
        void Delete(T artist);
        void Update(T artist);
        void Save();
    }
}
