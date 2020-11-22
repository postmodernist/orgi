using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;
using System.Configuration;

namespace Decadence_DAL.Repositories
{
    public class LabelRepository : GenericRepository<Label>, ILabelRepository
    {
        public LabelRepository(IConnectionFactory connectionFactory) : base(connectionFactory, "Labels", false)
        {
            connectionFactory.SetConnection("Server=192.168.56.101;Database=Decadence;User ID=sa;Password=bravoSIX_RED");
        }
    }
}