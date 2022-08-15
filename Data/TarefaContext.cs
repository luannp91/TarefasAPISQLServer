using System.Data;

namespace TarefasAPISQL.Data
{
    public class TarefaContext
    {
        public delegate Task<IDbConnection> GetConnection();
    }
}
