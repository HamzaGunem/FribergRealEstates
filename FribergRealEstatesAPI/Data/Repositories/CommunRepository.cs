using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Data.Repositories
{
    //Auth: Hamza
    public class CommunRepository : GenericRepository<Commun, ApiDbContext>, ICommunRepository
    {
        public CommunRepository(ApiDbContext context) : base(context)
        {
        }

    }
}
