using Kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kolokwium.Services
{
    public class MusicDbService : IMusicDbService
    {
        private readonly MusicDbContext _context;

        public MusicDbService(MusicDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Musician> GetMusician(string id)
        {
            var _musician = _context.Musicians.Where(p => p.IdMusician.ToString() == id).Select(p => new Musician()
            {
                IdMusician = p.IdMusician,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Nickname = p.Nickname
            }).ToList();

            return _musician;
        }
        public Musician AddMusician(Musician musician)
        {
            try
            {
                _context.Musicians.Add(musician);
                _context.SaveChanges();
                return musician;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
