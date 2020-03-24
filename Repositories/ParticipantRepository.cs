using CoreRegSite.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CoreRegSite.Repositories
{
    public class ParticipantRepository : BaseRepository<Participant>
    {
        public ParticipantRepository() : base(new CityFestContext())
        {
        }
    }
}