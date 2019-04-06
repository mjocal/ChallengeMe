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
    public class ProductoMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdProducto = "ID_PRODUCTO";
        private const string DbColNombreProducto = "NOMBRE_PRODUCTO";
        private const string DbColCostoProducto = "COSTO_PRODUCTO";
        private const string DbColLogoProducto = "LOGO_PRODUCTO";
        private const string DbColEstado_Producto = "ESTADO_PRODUCTO";
 
        private const string DbCrudAction = "ACTION";

        private ImageConverter imageConverter = new ImageConverter();

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_PRODUCTO"
        };

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            byte[] byteArrayImage = GetByteValue(row, DbColLogoProducto);
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

            var producto = new Producto()
            {
                IdProducto = GetIntValue(row, DbColIdProducto),
                NombreProducto = GetStringValue(row, DbColNombreProducto),
                CostoProducto = GetDecimalValue(row, DbColCostoProducto),
                LogoProducto = image,
                Estado_Producto = GetStringValue(row, DbColEstado_Producto),
            };
            return producto;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var producto = BuildObject(row);
                lstResults.Add(producto);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PRODUCTO"
            };
            var producto = (Producto)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdProducto, producto.IdProducto);
            operation.AddVarcharParam(DbColNombreProducto, producto.NombreProducto);
            operation.AddDecimalParam(DbColCostoProducto, producto.CostoProducto);
            operation.AddByteParam(DbColLogoProducto, ConvertImageToByteArray(producto.LogoProducto));
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);
            return operation;
        }
        private byte[] ConvertImageToByteArray(Image logoProducto)
        {
            return (byte[])imageConverter.ConvertTo(logoProducto, typeof(byte[]));
        }
        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PRODUCTO"
            };
            var producto = (Producto)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdProducto, producto.IdProducto);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);
            return operation;
        }
        public SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PRODUCTO"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);
            return operation;
        }
        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PRODUCTO"
            };
            var producto = (Producto)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdProducto, producto.IdProducto);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);
            return operation;
        }
        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PRODUCTO"
            };
            var producto = (Producto)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdProducto, producto.IdProducto);
            operation.AddVarcharParam(DbColNombreProducto, producto.NombreProducto);
            operation.AddDecimalParam(DbColCostoProducto, producto.CostoProducto);
            operation.AddByteParam(DbColLogoProducto, ConvertImageToByteArray(producto.LogoProducto));
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);
            return operation;
        }
        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }
        public SqlOperation GetRetriveByName(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PRODUCTO"
            };


            var producto = (Producto)entity;
            operation.AddVarcharParam(DbColNombreProducto, producto.NombreProducto);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveByName);
            return operation;
        }

        public SqlOperation GetRetriveAllByIdProducto(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PRODUCTO"
            };
            var producto = (Producto)entity;
            operation.AddIntParam(DbColIdProducto, producto.IdProducto);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAllById);
            return operation;
        }

        //public SqlOperation GetRetriveByPatrocinador(BaseEntity entity)
        //{
        //    var operation = new SqlOperation()
        //    {
        //        ProcedureName = "CRUD_PRODUCTO"
        //    };
        //    var producto = (Producto)entity;
        //    operation.AddIntParam(DbColIdPatrocinador, producto.IdPatrocinador);
        //    operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveByPatrocinador);
        //    return operation;
        //}

    }
}
