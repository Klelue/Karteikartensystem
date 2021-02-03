
using System.Data;
using System.Data.SqlClient;

namespace DatenbankEngine
{
    public interface IDatenbankEngine
    {
        DataTable ExecuteSelectQuery(SqlCommand sqlCommand);
        int ExecuteQuery(SqlCommand sqlCommand);
    }
}
