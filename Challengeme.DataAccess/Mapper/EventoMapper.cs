using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using Challengeme.DataAccess.Crud;
using Challengeme.DataAccess.Dao;
using Challengeme.Entities;

namespace Challengeme.DataAccess.Mapper
{
    public class EventoMapper: EntityMapper
    {
        private const string DbColIdEvento = "ID_EVENTO";
        private const string DbColNombreEvento = "NOMBRE_EVENTO";
        private const string DbColUbicacionEvento = "UBICACION_EVENTO";
        private const string DbColDescripcionEvento = "DESCRIPCION_EVENTO";
        private const string DbColLogoEvento = "LOGO_EVENTO";
        private const string DbColIdCategoria = "ID_CATEGORIA";
        private const string DbColCupoEvento = "CUPO_EVENTO";
        private const string DbColIdEntidad = "ID_ENTIDAD";
        private const string DbColFechaInicioEvento = "FECHA_INICIO_EVENTO";
        private const string DbColFechaFinalEvento = "FECHA_FINAL_EVENTO";
        private const string DbColFechaInicioInscripcion = "FECHA_INICIO_INSCRIPCION_EVENTO";
        private const string DbColFechaFinalInscripcion = "FECHA_FINAL_INSCRIPCION_EVENTO";
        private const string DbColCostoInscripcion = "COSTO_INSCRIPCION_EVENTO";
        private const string DbColIdActividad = "ID_ACTIVIDAD";
        private const string DbColEstadoEvento = "ESTADO_EVENTO";
        private const string DbCrudAction = "ACTION";

        private ImageConverter imageConverter = new ImageConverter();

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_EVENTO"
        };

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var evento = BuildObject(row);
                lstResults.Add(evento);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            byte[] byteArrayImage = GetByteValue(row, DbColLogoEvento);
            Image image;

            if (byteArrayImage != null)
            {
                MemoryStream streamImage = new MemoryStream(byteArrayImage);
                image = Image.FromStream(streamImage);
            }
            else
            {
                image = null;
            }


            var evento = new Evento()
            {
                IdEvento = GetIntValue(row, DbColIdEvento),
                NombreEvento = GetStringValue(row, DbColNombreEvento),
                UbicacionEvento = GetStringValue(row, DbColUbicacionEvento),
                DescripcionEvento = GetStringValue(row, DbColDescripcionEvento),
                LogoEvento = image,
               
                IdCategoria = GetIntValue(row, DbColIdCategoria),
                CupoEvento = GetIntValue(row, DbColCupoEvento),
                IdEntidad = GetStringValue(row, DbColIdEntidad),
                FechaInicioEvento = GetDateValue(row, DbColFechaInicioEvento),
                FechaFinalEvento = GetDateValue(row, DbColFechaFinalEvento),
                FechaInicioInscripcion = GetDateValue(row, DbColFechaInicioInscripcion),
                FechaFinalInscripcion = GetDateValue(row, DbColFechaFinalInscripcion),
                CostoInscripcion = GetDecimalValue(row, DbColCostoInscripcion),
                Estado_Evento = GetStringValue(row,DbColEstadoEvento),
                
            };

            return evento;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO"
            };
            var evento = (Evento)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdEvento, evento.IdEvento);
            operation.AddVarcharParam(DbColNombreEvento, evento.NombreEvento);
            operation.AddVarcharParam(DbColUbicacionEvento, evento.UbicacionEvento);
            operation.AddVarcharParam(DbColDescripcionEvento, evento.DescripcionEvento);
            operation.AddByteParam(DbColLogoEvento, ConvertImageToByteArray(evento.LogoEvento));
       
            operation.AddIntParam(DbColIdCategoria, evento.IdCategoria);
            operation.AddIntParam(DbColCupoEvento, evento.CupoEvento);
            operation.AddVarcharParam(DbColIdEntidad, evento.IdEntidad);
            operation.AddDateParam(DbColFechaInicioEvento, evento.FechaInicioEvento);
            operation.AddDateParam(DbColFechaFinalEvento, evento.FechaFinalEvento);
            operation.AddDateParam(DbColFechaInicioInscripcion, evento.FechaInicioInscripcion);
            operation.AddDateParam(DbColFechaFinalInscripcion, evento.FechaFinalInscripcion);
            operation.AddDecimalParam(DbColCostoInscripcion, evento.CostoInscripcion);
           
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);

            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO"
            };
            var evento = (Evento)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdEvento, evento.IdEvento);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO"
            };
            var evento = (Evento)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdEvento, evento.IdEvento);
            operation.AddVarcharParam(DbColNombreEvento, evento.NombreEvento);
            operation.AddVarcharParam(DbColUbicacionEvento, evento.UbicacionEvento);
            operation.AddVarcharParam(DbColDescripcionEvento, evento.DescripcionEvento);
            operation.AddByteParam(DbColLogoEvento, ConvertImageToByteArray(evento.LogoEvento));
          
            operation.AddIntParam(DbColIdCategoria, evento.IdCategoria);
            operation.AddIntParam(DbColCupoEvento, evento.CupoEvento);
            operation.AddVarcharParam(DbColIdEntidad, evento.IdEntidad);
            operation.AddDateParam(DbColFechaInicioEvento, evento.FechaInicioEvento);
            operation.AddDateParam(DbColFechaFinalEvento, evento.FechaFinalEvento);
            operation.AddDateParam(DbColFechaInicioInscripcion, evento.FechaInicioInscripcion);
            operation.AddDateParam(DbColFechaFinalInscripcion, evento.FechaFinalInscripcion);
            operation.AddDecimalParam(DbColCostoInscripcion, evento.CostoInscripcion);
            
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO"
            };
            var evento = (Evento)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdEvento, evento.IdEvento);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);

            return operation;
        }

        public SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }



        private byte[] ConvertImageToByteArray(Image logoEvento)
        {
            return (byte[])imageConverter.ConvertTo(logoEvento, typeof(byte[]));
        }

        public SqlOperation GetRetriveByName(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO"
            };
            var evento = (Evento)entity;
            operation.AddVarcharParam(DbColNombreEvento, evento.NombreEvento);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveByName);

            return operation;
        }


        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }

    }
}
