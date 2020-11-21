using System.Configuration;
using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;

namespace Decadence_DAL.Repositories.DBRepositories
{
    public class LabelRepository:GenericRepository<Label>, ILabelRepository
    {
        public LabelRepository(IConnectionFactory connectionFactory) : base(connectionFactory,  "LABELS", false)
        {
            connectionFactory.SetConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
    }
}