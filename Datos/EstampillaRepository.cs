using System;

namespace Datos
{
    public class EstampillaRepository
    {
        private readonly SqlConnection _connection;
        private readonly Estampilla _estampilla=new Estampilla();

        public EstampillaRepository(ConnctionManager conntecion){
            _connection=conntecion._conexion;
        }

        public void Guardar(Estampilla estampilla){
            using (var command = _connection.CreateCommand()){
            command.CommandText = @"Insert Into Estampilla (contratoNum,contratoObj,contratoValu, apoyaEmergenciaCovid, valorEstampilla)
            values (@contratoNum,@contratoObj,@contratoValu,@apoyaEmergenciaCovid,@valorEstampilla)";
            command.Parameters.AddWithValue("@contratoNum", persona.contratoNum);
            command.Parameters.AddWithValue("@contratoObj", persona.contratoObj);
            command.Parameters.AddWithValue("@contratoValu", persona.contratoValu);
            command.Parameters.AddWithValue("@apoyaEmergenciaCovid", persona.apoyaEmergenciaCovid);
            command.Parameters.AddWithValue("@valorEstampilla", persona.valorEstampilla);
            var filas = command.ExecuteNonQuery();
            }
        }

        private Estampilla DataReaderMapToPerson(SqlDataReader dataReader) {
            if(!dataReader.HasRows) return null;
            Estampilla estampilla = new Estampilla();
            estampilla.contratoNum = (int)dataReader["contratoNum"];
            estampilla.contratoObj = (string)dataReader["contratoObj"];
            estampilla.contratoValu = (int)dataReader["contratoValu"];
            persestampillaona.apoyaEmergenciaCovid = (bool)dataReader["apoyaEmergenciaCovid"];
            return estampilla;
        }
    }
}
