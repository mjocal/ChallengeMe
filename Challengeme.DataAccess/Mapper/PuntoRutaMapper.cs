using Challengeme.DataAccess.Crud;
using Challengeme.DataAccess.Dao;
using Challengeme.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.DataAccess.Mapper
{
    public class PuntoRutaMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdPuntoRuta = "ID_PUNTO_RUTA";
        private const string DbColIdRuta = "ID_RUTA";
        private const string DbColNombrePunto = "NOMBRE_PUNTO";
        private const string DbColLatitudRuta = "LATITUD_PUNTO_RUTA";
        private const string DbColLongitudRuta = "LONGITUD_PUNTO_RUTA";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_PUNTO_RUTA"
        };

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var entidad = BuildObject(row);
                lstResults.Add(entidad);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var puntoRuta = new PuntoRuta
            {
                idPuntoRuta = GetIntValue(row, DbColIdPuntoRuta),
                idRuta = GetIntValue(row, DbColIdRuta),
                nombrePunto = GetStringValue(row, DbColNombrePunto),
                latitudRuta = GetStringValue(row, DbColLatitudRuta),
                longitudRuta = GetStringValue(row, DbColLongitudRuta)
            };

            return puntoRuta;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var puntoRuta = (PuntoRuta)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPuntoRuta, puntoRuta.idPuntoRuta);
            operation.AddIntParam(DbColIdRuta, puntoRuta.idRuta);
            operation.AddVarcharParam(DbColNombrePunto, puntoRuta.nombrePunto);
            operation.AddVarcharParam(DbColLatitudRuta, puntoRuta.latitudRuta);
            operation.AddVarcharParam(DbColLongitudRuta, puntoRuta.longitudRuta);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var puntoRuta = (PuntoRuta)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdRuta, puntoRuta.idRuta);
            operation.AddVarcharParam(DbColNombrePunto, puntoRuta.nombrePunto);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var puntoRuta = (PuntoRuta)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPuntoRuta, puntoRuta.idPuntoRuta);
            operation.AddIntParam(DbColIdRuta, puntoRuta.idRuta);
            operation.AddVarcharParam(DbColNombrePunto, puntoRuta.nombrePunto);
            operation.AddVarcharParam(DbColLatitudRuta, puntoRuta.latitudRuta);
            operation.AddVarcharParam(DbColLongitudRuta, puntoRuta.longitudRuta);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var puntoRuta = (PuntoRuta)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdRuta, puntoRuta.idRuta);
            operation.AddIntParam(DbColIdPuntoRuta, puntoRuta.idPuntoRuta);
            operation.AddVarcharParam(DbColNombrePunto, puntoRuta.nombrePunto);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);

            return operation;
        }

        public SqlOperation GetRetrieveAllByIdRuta(BaseEntity entity)
        {
            var puntoRuta = (PuntoRuta)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdRuta, puntoRuta.idRuta);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;

        }

        public SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
        public SqlOperation GetRetrieveByName(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveByName(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveAllByIdRol(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }
    }
}
