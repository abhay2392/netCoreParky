using ParkyAPI.Data;
using ParkyAPI.Models;
using ParkyAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Repository
{
    public class NationalParkRepository : INationalParkRepository
    {
        protected readonly ApplicationDBContext _context;
        public NationalParkRepository(ApplicationDBContext _dbContext)
        {
            _context = _dbContext;
        }
        public void Delete(NationalPark park)
        {
            _context.NationalParks.Remove(park);
            Save();
        }

        

        public IEnumerable<NationalPark> GetAll()
        {
            return _context.NationalParks;
        }

        public NationalPark GetById(int parkID)
        {
            return _context.NationalParks.FirstOrDefault(park => park.Id == parkID);
        }

        public void Insert(NationalPark park)
        {
            _context.Add(park);
            Save();
        }

        public void Save()
        {
             _context.SaveChanges();
        }

        public void Update(NationalPark park)
        {
            _context.NationalParks.Update(park);
            Save();
        }
    }
}
