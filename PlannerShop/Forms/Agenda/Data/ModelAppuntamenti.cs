using PlannerShop.Forms.Agenda;
using System.Data;
using System.Drawing;

namespace PlannerShop.Data
{
    /// <summary>
    /// Layer dati per gli appuntamenti dell'agenda.
    /// Struttura e convenzioni identiche a ModelClienti.
    ///
    /// NOMECLIENTE e OPERATORE sono campi testo libero:
    /// nessun legame obbligatorio con PSDB.db.
    /// </summary>
    internal struct ModelAppuntamenti
    {
        // ============================================================
        // READ
        // ============================================================

        public static DataTable GetAppuntamentoById(int id)
        {
            return DBUtilityAgenda.GetDBData(
                "SELECT * FROM TAppuntamenti WHERE IDAPPUNTAMENTO = @id AND ISDELETED = 'FALSE'",
                new Dictionary<string, object?> { { "@id", id } });
        }

        /// <summary>
        /// Restituisce tutti gli appuntamenti della settimana (lunedì → domenica).
        /// </summary>
        public static DataTable GetAppuntamentiBySettimana(DateTime lunedi)
        {
            DateTime domenica = lunedi.AddDays(6);
            string sql = @"
                SELECT * FROM TAppuntamenti
                WHERE  DATE(DATA_INIZIO) >= @dal
                  AND  DATE(DATA_INIZIO) <= @al
                  AND  ISDELETED = 'FALSE'
                ORDER BY DATA_INIZIO";

            return DBUtilityAgenda.GetDBData(sql, new Dictionary<string, object?>
            {
                { "@dal", lunedi.ToString("yyyy-MM-dd")    },
                { "@al",  domenica.ToString("yyyy-MM-dd")  }
            });
        }

        /// <summary>
        /// Restituisce tutti gli appuntamenti di un giorno specifico.
        /// </summary>
        public static DataTable GetAppuntamentiByGiorno(DateTime giorno)
        {
            string sql = @"
                SELECT * FROM TAppuntamenti
                WHERE  DATE(DATA_INIZIO) = @giorno
                  AND  ISDELETED = 'FALSE'
                ORDER BY DATA_INIZIO";

            return DBUtilityAgenda.GetDBData(sql, new Dictionary<string, object?>
            {
                { "@giorno", giorno.ToString("yyyy-MM-dd") }
            });
        }

        public static DataTable SearchAppuntamenti(string searchTerm)
        {
            string sql = @"
                SELECT * FROM TAppuntamenti
                WHERE (TITOLO       LIKE @term
                   OR  NOMECLIENTE  LIKE @term
                   OR  OPERATORE    LIKE @term
                   OR  NOMESERVIZIO LIKE @term)
                  AND  ISDELETED = 'FALSE'
                ORDER BY DATA_INIZIO DESC";

            return DBUtilityAgenda.GetDBData(sql, new Dictionary<string, object?>
            {
                { "@term", "%" + searchTerm + "%" }
            });
        }

        // ============================================================
        // WRITE
        // ============================================================

        public static void AddAppuntamento(Appointment app)
        {
            string sql = @"
                INSERT INTO TAppuntamenti (TITOLO, NOMECLIENTE, OPERATORE, IDSERVIZIO, NOMESERVIZIO, DATA_INIZIO, DATA_FINE, STATO, COLORE, NOTE, ISDELETED, TIMESTAMP) VALUES                   (@titolo, @nomeCliente, @operatore, @idServizio, @nomeServizio, @inizio, @fine, @stato, @colore, @note, 'FALSE', @ts)";
            DBUtilityAgenda.SetDBData(sql, BuildParameters(app));
        }

        public static void EditAppuntamento(int id, Appointment app)
        {
            string sql = @"
                UPDATE TAppuntamenti SET
                    TITOLO       = @titolo,
                    NOMECLIENTE  = @nomeCliente,
                    OPERATORE    = @operatore,
                    IDSERVIZIO   = @idServizio,
                    NOMESERVIZIO = @nomeServizio,
                    DATA_INIZIO  = @inizio,
                    DATA_FINE    = @fine,
                    STATO        = @stato,
                    COLORE       = @colore,
                    NOTE         = @note,
                    TIMESTAMP    = @ts
                WHERE IDAPPUNTAMENTO = @id";

            var p = BuildParameters(app);
            p["@id"] = id;
            DBUtilityAgenda.SetDBData(sql, p);
        }

        /// <summary>
        /// Soft-delete coerente con TAcquisti di PSDB.
        /// </summary>
        public static void DeleteAppuntamento(int id)
        {
            DBUtilityAgenda.SetDBData(
                "UPDATE TAppuntamenti SET ISDELETED = 'TRUE' WHERE IDAPPUNTAMENTO = @id",
                new Dictionary<string, object?> { { "@id", id } });
        }

        public static void UpdateStato(int id, AppointmentStatus stato)
        {
            DBUtilityAgenda.SetDBData(
                "UPDATE TAppuntamenti SET STATO = @stato WHERE IDAPPUNTAMENTO = @id",
                new Dictionary<string, object?>
                {
                    { "@id",    id },
                    { "@stato", stato.ToString() }
                });
        }

        // ============================================================
        // OPZIONI AGENDA
        // ============================================================

        public static string GetOpzione(string key)
        {
            var dt = DBUtilityAgenda.GetDBData(
                "SELECT VALUE FROM TOpzioniAgenda WHERE \"KEY\" = @key",
                new Dictionary<string, object?> { { "@key", key } });

            return dt.Rows.Count > 0
                ? dt.Rows[0]["VALUE"]?.ToString() ?? string.Empty
                : string.Empty;
        }

        // ============================================================
        // HELPER
        // ============================================================

        /// <summary>
        /// Converte un DataRow (dal DB) in un oggetto Appointment.
        /// </summary>
        public static Appointment RowToAppointment(DataRow row)
        {
            Color color;
            try   { color = ColorTranslator.FromHtml(row["COLORE"]?.ToString() ?? "#7B68EE"); }
            catch { color = Color.MediumSlateBlue; }

            return new Appointment
            {
                Id           = Convert.ToInt32(row["IDAPPUNTAMENTO"]),
                Title        = row["TITOLO"]?.ToString()       ?? string.Empty,
                ClientName   = row["NOMECLIENTE"]?.ToString()  ?? string.Empty,
                OperatorName = row["OPERATORE"]?.ToString()    ?? string.Empty,
                ServiceId    = row["IDSERVIZIO"] == DBNull.Value ? 0 : Convert.ToInt32(row["IDSERVIZIO"]),
                ServiceName  = row["NOMESERVIZIO"]?.ToString() ?? string.Empty,
                Start        = DateTime.Parse(row["DATA_INIZIO"].ToString()!),
                End          = DateTime.Parse(row["DATA_FINE"].ToString()!),
                Status       = Enum.TryParse<AppointmentStatus>(row["STATO"]?.ToString(), out var s)
                               ? s : AppointmentStatus.Prenotato,
                Color        = color,
                Notes        = row["NOTE"]?.ToString() ?? string.Empty
            };
        }

        // ── Parametri comuni Insert / Update ────────────────────────
        private static Dictionary<string, object?> BuildParameters(Appointment app) =>
            new()
            {
                { "@titolo",       app.Title },
                { "@nomeCliente",  app.ClientName },
                { "@operatore",    app.OperatorName },
                { "@idServizio",   app.ServiceId == 0 ? (object?)DBNull.Value : app.ServiceId },
                { "@nomeServizio", app.ServiceName },
                { "@inizio",       app.Start.ToString("yyyy-MM-dd HH:mm:ss") },
                { "@fine",         app.End.ToString("yyyy-MM-dd HH:mm:ss") },
                { "@stato",        app.Status.ToString() },
                { "@colore",       ColorTranslator.ToHtml(app.Color) },
                { "@note",         app.Notes },
                { "@ts",           app.Timestamp.ToString("yyyy-MM-dd HH:mm:ss") }
            };
    }
}
