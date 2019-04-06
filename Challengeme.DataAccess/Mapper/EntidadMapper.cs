using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Challengeme.DataAccess.Crud;
using Challengeme.DataAccess.Dao;
using Challengeme.Entities;
using System.IO;
using System.Drawing;

namespace Challengeme.DataAccess.Mapper
{
    public class EntidadMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdEntidad = "ID_ENTIDAD";
        private const string DbColNombreEntidad = "NOMBRE_ENTIDAD";
        private const string DbColTipoEntidad = "TIPO_ENTIDAD";
        private const string DbColNombreComercialEntidad = "NOMBRE_COMERCIAL_ENTIDAD";
        private const string DbColDireccionEntidad = "DIRECCION_ENTIDAD";
        private const string DbColTelefonoEntidad = "TELEFONO_ENTIDAD";
        private const string DbColLogoEntidad = "LOGO_ENTIDAD";
        private const string DbColCorreoEntidad = "CORREO_ENTIDAD";
        private const string DbColEstado_Entidad = "ESTADO_ENTIDAD";
        private const string DbCrudAction = "ACTION";


        private ImageConverter imageConverter = new ImageConverter();

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_ENTIDAD"
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
            byte[] byteArrayImage = GetByteValue(row, DbColLogoEntidad);
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


            var entidad = new Entidad()
            {
                IdEntidad = GetStringValue(row, DbColIdEntidad),
                NombreEntidad = GetStringValue(row, DbColNombreEntidad),
                TipoEntidad = GetStringValue(row, DbColTipoEntidad),
                NombreComercialEntidad = GetStringValue(row, DbColNombreComercialEntidad),
                DireccionEntidad = GetStringValue(row, DbColDireccionEntidad),
                TelefonoEntidad = GetStringValue(row, DbColTelefonoEntidad),
                LogoEntidad = image,
                CorreoEntidad = GetStringValue(row, DbColCorreoEntidad),
                Estado_Entidad = GetStringValue(row,DbColEstado_Entidad),
            };

            return entidad;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ENTIDAD"
            };
            var entidad = (Entidad)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddVarcharParam(DbColIdEntidad, entidad.IdEntidad);
            operation.AddVarcharParam(DbColNombreEntidad, entidad.NombreEntidad);
            operation.AddVarcharParam(DbColTipoEntidad, entidad.TipoEntidad);
            operation.AddVarcharParam(DbColNombreComercialEntidad, entidad.NombreComercialEntidad);
            operation.AddVarcharParam(DbColDireccionEntidad, entidad.DireccionEntidad);
            operation.AddVarcharParam(DbColTelefonoEntidad, entidad.TelefonoEntidad);
            operation.AddByteParam(DbColLogoEntidad, ConvertImageToByteArray(entidad.LogoEntidad));
            operation.AddVarcharParam(DbColCorreoEntidad, entidad.CorreoEntidad);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);

            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ENTIDAD"
            };
            var entidad = (Entidad)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddVarcharParam(DbColIdEntidad, entidad.IdEntidad);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ENTIDAD"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ENTIDAD"
            };
            var entidad = (Entidad)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddVarcharParam(DbColIdEntidad, entidad.IdEntidad);
            operation.AddVarcharParam(DbColNombreEntidad, entidad.NombreEntidad);
            operation.AddVarcharParam(DbColTipoEntidad, entidad.TipoEntidad);
            operation.AddVarcharParam(DbColNombreComercialEntidad, entidad.NombreComercialEntidad);
            operation.AddVarcharParam(DbColDireccionEntidad, entidad.DireccionEntidad);
            operation.AddVarcharParam(DbColTelefonoEntidad, entidad.TelefonoEntidad);
            operation.AddByteParam(DbColLogoEntidad, ConvertImageToByteArray(entidad.LogoEntidad));
            operation.AddVarcharParam(DbColCorreoEntidad, entidad.CorreoEntidad);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ENTIDAD"
            };
            var entidad = (Entidad)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddVarcharParam(DbColIdEntidad, entidad.IdEntidad);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);

            return operation;
        }

        public SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
      


        private byte[] ConvertImageToByteArray(Image logoEntidad)
        {
           
                return (byte[])imageConverter.ConvertTo(logoEntidad, typeof(byte[]));
            

            
        }

        public SqlOperation GetRetriveByName(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ENTIDAD"
            };
            var entidad = (Entidad)entity;
            operation.AddVarcharParam(DbColNombreEntidad, entidad.NombreEntidad);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveByName);

            return operation;
        }
       

        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }


    }
}
