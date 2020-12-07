using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;
using System.Configuration;

namespace Decadence_DAL.Repositories
{
    public class LabelRepository : GenericRepository<Label>, ILabelRepository
    {
        public LabelRepository(IConnectionFactory connectionFactory) : base(connectionFactory, "Labels", false)
        {
            connectionFactory.SetConnection("Data Source=34.65.147.0;Initial Catalog=FortBoyar;Persist Security Info=True;User ID=SA;Password=bravoSIX_RED");
        }
    }
}