using System.Data;
using System.Data.SQLite;
using System.Reflection;

namespace PlannerShop.Data
{
    /// <summary>
    /// Utility per l'accesso al database dell'agenda (PSDB_Agenda.db).
    /// Struttura identica a DBUtility, file separato per indipendenza del modulo.
    /// </summary>
    internal struct DBUtilityAgenda
    {
        public static void DiagnosticaDB()
        {
            string connString = GetConnectionString();
           
            using var conn = new SQLiteConnection(connString);
            conn.Open();
        }
        private static string GetConnectionString()
        {
            var location = Assembly.GetEntryAssembly()
                ?? throw new InvalidOperationException("Impossibile determinare il percorso dell'applicazione.");

            string path = Path.Combine(
                Path.GetDirectoryName(location.Location)!,
                "Forms/Agenda/Data",
                "PSDB_Agenda.db");

            var builder = new SQLiteConnectionStringBuilder
            {
                DataSource = path,
                Version = 3
            };

            System.Diagnostics.Debug.WriteLine($"[Agenda] DataSource: {builder.DataSource}");
            return builder.ConnectionString;
        }

        public static DataTable GetDBData(string queryString, IDictionary<string, object?>? parameters)
        {
            DataTable dt = new();
            string connString = GetConnectionString();

            using var conn = new SQLiteConnection(connString);
            using var cmd  = new SQLiteCommand(queryString, conn);

            if (parameters != null)
                foreach (var p in parameters)
                    cmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);

            conn.Open();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public static void SetDBData(string queryString, IDictionary<string, object?> parameters)
        {
            string connString = GetConnectionString();

            using var conn = new SQLiteConnection(connString);
            using var cmd  = new SQLiteCommand(queryString, conn);

            foreach (var p in parameters)
                cmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
