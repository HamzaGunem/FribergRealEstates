using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Repositories
{
    //Auth: Hamza
    public class ResidenceRepository : GenericRepository<Residence, ApiDbContext>, IResidenceRepository
    {
        public ResidenceRepository(ApiDbContext context) : base(context)
        {
        }
    }
}
