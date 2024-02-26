using LabNetBank.Business.Interfaces.Repositories;
using LabNetBank.Business.Models;
using LabNetBank.Infrastructure.Context;

namespace LabNetBank.Infrastructure.Repositories
{
    public class HolderRepository : BaseRepository<Holder>, IHolderRepository
    {
        public HolderRepository(LabNetBankContext dbContext) : base(dbContext)
        {
        }
    }
}
