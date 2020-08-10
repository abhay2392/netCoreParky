using ParkyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Repository.IRepository
{
    public interface INationalParkRepository
    {
        IEnumerable<NationalPark> GetAll();
        NationalPark GetById(int parkID);
        void Insert(NationalPark park);
        void Update(NationalPark park);
        void Delete(NationalPark park);
        void Save();
    }
}
