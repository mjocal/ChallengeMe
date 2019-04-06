using Challengeme.DataAccess.Crud;
using Challengeme.DataAccess.Dao;
using Challengeme.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.DataAccess.Mapper
{
   public  class InscripcionMapper : EntityMapper
    {
        private const string DbColIdInscripcion = "ID_INSCRIPCION";
        private const string DbColIdEvento = "ID_EVENTO";
        private const string DbColIdUsuario = "ID_USUARIO";
        private const string DbColFechaInscripcion = "FECHA_INSCRIPCION";
        private const string DbColTipoInscripcion = "TIPO_INSCRIPCION";
        private const string DbColQrInscripcion = "QR_INSCRIPCION";
        private const string DbColEstado_Inscripcion = "ESTADO_INSCRIPCION";
        private const string DbCrudAction = "ACTION";

        private ImageConverter imageConverter = new ImageConverter();
        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_INSCRIPCION"
        };

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var inscripcion = BuildObject(row);
                lstResults.Add(inscripcion);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            byte[] byteArrayImage = GetByteValue(row, DbColQrInscripcion);
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

            var inscripcion = new Inscripcion()
            {
                IdInscripcion = GetIntValue(row, DbColIdInscripcion),
                IdEvento = GetIntValue(row, DbColIdEvento),
                IdUsuario = GetStringValue(row, DbColIdUsuario),
                FechaInscripcion = GetDateValue(row,DbColFechaInscripcion),
                tipoInscripcion = GetStringValue(row, DbColTipoInscripcion),
                QRInscripcion = image,
                Estado_Inscripcion = GetStringValue(row, DbColEstado_Inscripcion),
                
            };

            return inscripcion;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_INSCRIPCION"
            };
            var inscripcion = (Inscripcion)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdInscripcion, inscripcion.IdInscripcion);
            operation.AddIntParam(DbColIdEvento, inscripcion.IdEvento);
            operation.AddVarcharParam(DbColIdUsuario, inscripcion.IdUsuario);
            operation.AddDateParam(DbColFechaInscripcion, inscripcion.FechaInscripcion);
            operation.AddVarcharParam(DbColTipoInscripcion, inscripcion.tipoInscripcion);
            operation.AddByteParam(DbColQrInscripcion, ConvertImageToByteArray(inscripcion.QRInscripcion));
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);

            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_INSCRIPCION"
            };
            var inscripcion = (Inscripcion)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdInscripcion, inscripcion.IdInscripcion);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_INSCRIPCION"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_INSCRIPCION"
            };
            var inscripcion = (Inscripcion)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdInscripcion, inscripcion.IdInscripcion);
            operation.AddIntParam(DbColIdEvento, inscripcion.IdEvento);
            operation.AddVarcharParam(DbColIdUsuario, inscripcion.IdUsuario);
            operation.AddDateParam(DbColFechaInscripcion, inscripcion.FechaInscripcion);
            operation.AddVarcharParam(DbColTipoInscripcion, inscripcion.tipoInscripcion);
            operation.AddByteParam(DbColQrInscripcion, ConvertImageToByteArray(inscripcion.QRInscripcion));
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_INSCRIPCION"
            };
            var inscripcion = (Inscripcion)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdInscripcion, inscripcion.IdInscripcion);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);

            return operation;
        }

        public SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

       

        public SqlOperation GetRetriveAllById(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_INSCRIPCION"
            };

            var inscripcion = (Inscripcion)entity;
            operation.AddIntParam(DbColIdInscripcion, inscripcion.IdInscripcion);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAllById);
            return operation;
        }
        private byte[] ConvertImageToByteArray(Image QrInscripcion)
        {
            return (byte[])imageConverter.ConvertTo(QrInscripcion, typeof(byte[]));
        }
    }
}
