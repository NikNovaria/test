using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.Json;
using WSTxDoc.Models;


namespace WSTxDoc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WSTxDocControllers : ControllerBase
    {

        private readonly ILogger<WSTxDocControllers> _logger;

        //variabili usate nelle API
        ResponseClass response = new();
        public string sql = string.Empty;
        int rdr = 0;



        public WSTxDocControllers(ILogger<WSTxDocControllers> logger)
        {
            _logger = logger;
        }


#region API

    #region CAMBIA STATO  
        [HttpGet(Name = "GetDArc")]
        public ResponseClass GetDArc()
        {
            
            List<DArc_readIntermedia> lsDArc = new List<DArc_readIntermedia>();

            string connectionstring = "Data Source=cloud.rds.alapagplus.it;Initial Catalog=apwarch1_prova;User Id=sa;Password=Fenice$Alapag$04";
            using var con = new SqlConnection(connectionstring);

            //APERTURA CONNESSIONE
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                //connessione non riuscita
                response.StatusCode = (int)HttpStatusCode.NotFound;
                response.Body = "Connessione al DB fallita.";

                return response;
            }


            //QUERY stato da 0 a 1
            sql = "UPDATE D_Archiviazione SET stato = 1 WHERE stato = 0";

            try
            {
                using var cmd = new SqlCommand(sql, con);
                rdr = cmd.ExecuteNonQuery();

                if (rdr < 0)
                {
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    response.Body = $"Transizione non eseguita.";

                    return response;
                }
            }
            catch (Exception ex)
            {
                //operazione non riuscita
                response.StatusCode = (int)HttpStatusCode.NotFound;
                response.Body = $"Transizione non eseguita. {ex.Message}";

                return response;
            }


            //QUERY leggo tutti i record con stato = 1
            sql = "SELECT id, visualizzato, dataVisualizzazione FROM D_Archiviazione WHERE stato = 1";

            try
            {
                using var cmd = new SqlCommand(sql, con);

                using SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        var dArc = new DArc_readIntermedia
                        {
                            Id = (int)rdr["id"],
                            Visualizzato = rdr.IsDBNull(rdr.GetOrdinal("visualizzato")) ? null : (int)rdr["visualizzato"],
                            DataVisualizzazione = rdr.IsDBNull(rdr.GetOrdinal("dataVisualizzazione")) ? null :(DateTime)rdr["dataVisualizzazione"]
                        };

                        lsDArc.Add(dArc);
                    }

                    response.StatusCode = (int)HttpStatusCode.OK;
                    response.Body = JsonSerializer.Serialize(lsDArc);

                    return response;
                }
                else
                {
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    response.Body = $"Lettura non eseguita.";

                    return response;
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = (int)HttpStatusCode.NotFound;
                response.Body = $"Lettura non eseguita. {ex.Message}";

                return response;
            }

            return response;


        }

        [HttpPut(Name = "PostStatus")]
        public ResponseClass PostStatus()
        {

            string connectionstring = "Data Source=cloud.rds.alapagplus.it;Initial Catalog=apwarch1_prova;User Id=sa;Password=Fenice$Alapag$04";
            using var con = new SqlConnection(connectionstring);

            //APERTURA CONNESSIONE
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                //connessione non riuscita
                response.StatusCode = (int)HttpStatusCode.NotFound;
                response.Body = "Connessione al DB fallita.";

                return response;
            }


            //QUERY stato da 1 a 2
            sql = "UPDATE D_Archiviazione SET stato = 2 WHERE stato = 1";

            try
            {
                using var cmd = new SqlCommand(sql, con);
                rdr = cmd.ExecuteNonQuery();

                if (rdr > 0)
                {
                    response.StatusCode = (int)HttpStatusCode.OK;
                    response.Body = $"Transizione eseguita.";

                    return response;
                }
                else
                {
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    response.Body = $"Transizione non eseguita.";

                    return response;
                }
            }
            catch (Exception ex)
            {
                //operazione non riuscita
                response.StatusCode = (int)HttpStatusCode.NotFound;
                response.Body = $"Transizione non eseguita. {ex.Message}";

                return response;
            }
        }

    #endregion

    #region INSERISCI RECORD
        
        [HttpPost(Name = "PostX")]
        public ResponseClass InsertRecordDArc(DArchiviazione record)
        {

            string connectionstring = "Data Source=cloud.rds.alapagplus.it;Initial Catalog=apwarch1_prova;User Id=sa;Password=Fenice$Alapag$04";
            using var con = new SqlConnection(connectionstring);

            //APERTURA CONNESSIONE
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                //connessione non riuscita
                response.StatusCode = (int)HttpStatusCode.NotFound;
                response.Body = "Connessione al DB fallita.";

                return response;
            }

            string author = "Katy McClachlen";
            byte[] bytes = Encoding.ASCII.GetBytes(author);

            record.FileArch = bytes;

            //QUERY stato da 1 a 2
            sql = $"INSERT INTO D_Archiviazione " +
                $"VALUES ('{ record.Idstudio}', {record.CodErogante}, {record.CodDipendente}, '{record.AnnoMese}' " +
                $", '{record.TipoDoc}', {record.Ufficiale}, {record.Id}, '{record.PiCf}', '{record.Rags}', '{record.Cogd}', '{record.Nomd}'" +
                $", '{record.Cofi}', '{record.Utente}', '{record.NomeFile}', '{record.DataArchiviazione}', {record.InviataMail}, {record.Visualizzato}" +
                $", '{record.DataInvioMail}', '{record.DataVisualizzazione}', {record.ConfermaLettura}, '{record.DataConfermaLettura}', {record.Eliminato}" +
                $", {record.VisibilitaPortale}, {record.FileArch}, {record.Esterno}, {record.Stato}) ";

            try
            {
                using var cmd = new SqlCommand(sql, con);
                rdr = cmd.ExecuteNonQuery();

                if (rdr > 0)
                {
                    response.StatusCode = (int)HttpStatusCode.OK;
                    response.Body = $"Inserimento riuscito.";

                    return response;
                }
                else
                {
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    response.Body = $"Inserimento non eseguito.";

                    return response;
                }
            }
            catch (Exception ex)
            {
                //operazione non riuscita
                response.StatusCode = (int)HttpStatusCode.NotFound;
                response.Body = $"Inserimento non eseguito. {ex.Message} {sql}";

                return response;
            }
        }


    #endregion


#endregion

    }
}