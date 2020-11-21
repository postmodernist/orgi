using System.Data;

namespace Decadence_DAL.Interfaces
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
        void SetConnection(string connectionString);   
    }
}
