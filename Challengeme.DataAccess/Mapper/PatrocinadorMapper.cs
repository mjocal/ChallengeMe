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
    public class PatrocinadorMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdPatrocinador = "ID_PATROCINADOR";
        private const string DbColNombrePatrocinador = "NOMBRE_PATROCINADOR";
        private const string DbColLogoPatrocinio = "LOGO";
        private const string DbColEstado_Patrocinador = "ESTADO_PATROCINADOR";
        private const string DbCrudAction = "ACTION";


        private ImageConverter imageConverter = new ImageConverter();

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_PATROCINADOR"
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
            byte[] byteArrayImage = GetByteValue(row, DbColLogoPatrocinio);
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


            var patrocinador = new Patrocinador()
            {
                IdPatrocinador = GetIntValue(row, DbColIdPatrocinador),
                NombrePatrocinador= GetStringValue(row, DbColNombrePatrocinador),
                Estado_Patrocinador=GetStringValue(row,DbColEstado_Patrocinador),
              
                LogoPatrocinador = image
            };

            return patrocinador;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PATROCINADOR"
            };
            var patrocinador = (Patrocinador)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPatrocinador, patrocinador.IdPatrocinador);
            operation.AddVarcharParam(DbColNombrePatrocinador, patrocinador.NombrePatrocinador);
         
            operation.AddByteParam(DbColLogoPatrocinio, ConvertImageToByteArray(patrocinador.LogoPatrocinador));
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);

            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PATROCINADOR"
            };
            var patrocinador = (Patrocinador)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPatrocinador, patrocinador.IdPatrocinador);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PATROCINADOR"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PATROCINADOR"
            };
            var patrocinador = (Patrocinador)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPatrocinador, patrocinador.IdPatrocinador);
            operation.AddVarcharParam(DbColNombrePatrocinador, patrocinador.NombrePatrocinador);
          
            operation.AddByteParam(DbColLogoPatrocinio, ConvertImageToByteArray(patrocinador.LogoPatrocinador));
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PATROCINADOR"
            };
            var patrocinador = (Patrocinador)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPatrocinador, patrocinador.IdPatrocinador);
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
        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveByName(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PATROCINADOR"
            };

            var patrocinador = (Patrocinador)entity;
            operation.AddVarcharParam(DbColNombrePatrocinador, patrocinador.NombrePatrocinador);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveByName);
            return operation;
        }

        public SqlOperation GetRetriveAllByIdPatrocinador(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PATROCINADOR"
            };
            var patrocinador = (Patrocinador)entity;
            operation.AddIntParam(DbColIdPatrocinador, patrocinador.IdPatrocinador );
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAllById);

            return operation;

        }


    }
}
