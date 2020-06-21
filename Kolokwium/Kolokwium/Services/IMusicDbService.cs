using Kolokwium.Models;
using System.Collections.Generic;

namespace Kolokwium.Services
{
    public interface IMusicDbService
    {
        public IEnumerable<Musician> GetMusician(string id);
        public Musician AddMusician(Musician musician);
    }
}
