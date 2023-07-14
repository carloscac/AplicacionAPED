
using Dapper;
using Dominio.ModelosDominio;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccesoDatos.Repositorio
{

    public class RepositorioDapper : IRepositorioDapper
    {
        string connectionString = "Data Source=PCCARLOS\\SQLEXPRESS; Initial Catalog=Aplicaciones; User=UsuarioRegistro; Password=12345678; Encrypt=False";

        public ProspectoDTO ConsultaProspecto(string numeroIdentificacion)
        {
            ProspectoDTO consulta = new ProspectoDTO();
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {

                    consulta = connection.Query<ProspectoDTO>(sql: "aped.PA_ConsutarProspectoPorIdentificacion",
                           param: new { @Identificacion = numeroIdentificacion },
                           commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                consulta = new ProspectoDTO();
            }

            return consulta;
        }


        public List<ProspectoDTO> ListaProspectos()
        {
            List<ProspectoDTO> consulta = new List<ProspectoDTO>();

            try
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {

                    consulta = connection.Query<ProspectoDTO>(sql: "aped.PA_ConsutarProspectoPorIdentificacion",
                           commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {

                consulta = new List<ProspectoDTO>();
            }

            return consulta;
        }

    }
}
