using Challengeme.DataAccess.Crud;
using Challengeme.DataAccess.Dao;
using Challengeme.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Challengeme.DataAccess.Mapper
{
    public class PagoMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdPago = "ID_PAGO";
        private const string DbColIdUsuario = "ID_USUARIO";
        private const string DbColMetodoPago = "METODO_PAGO";
        private const string DbColEstadoPago = "ESTADO_PAGO";
        private const string DbColMontoPago = "MONTO_PAGO";
        private const string DbColImpuestoVentaPago = "IMPUESTO_VENTA_PAGO";
        private const string DbColDescuentoPago = "DESCUENTO_PAGO";
        private const string DbColTotalPago = "TOTAL_PAGO";
        private const string DbColDetallePago = "DETALLE_PAGO";
        private const string DbColFechaPago = "FECHA_PAGO";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_PAGO"
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
            var pago = new Ruta
            {
                IdPago = GetIntValue(row, DbColIdPago),
                IdUsuario = GetStringValue(row, DbColIdUsuario),
                MetodoDePago = GetStringValue(row, DbColMetodoPago),
                EstadoDePago = GetStringValue(row, DbColEstadoPago),
                MontoDePago = GetDecimalValue(row, DbColMontoPago),
                ImpuestoDePago = GetDecimalValue(row, DbColImpuestoVentaPago),
                DescuentoDePago = GetDecimalValue(row, DbColDescuentoPago),//
                TotalPago = GetDecimalValue(row, DbColTotalPago),
                DetalleDePago = GetStringValue(row, DbColDetallePago),
                FechaPago = GetDateValue(row, DbColFechaPago),
            };

            return pago;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PAGO"
            };
            var pago = (Ruta)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPago, pago.IdPago);
            operation.AddVarcharParam(DbColIdUsuario, pago.IdUsuario);
            operation.AddVarcharParam(DbColMetodoPago, pago.MetodoDePago);
            operation.AddVarcharParam(DbColEstadoPago, pago.EstadoDePago);
            operation.AddDecimalParam(DbColMontoPago, pago.MontoDePago);
            operation.AddDecimalParam(DbColImpuestoVentaPago, pago.ImpuestoDePago);
            operation.AddDecimalParam(DbColDescuentoPago, pago.DescuentoDePago);
            operation.AddDecimalParam(DbColTotalPago, pago.TotalPago);
            operation.AddVarcharParam(DbColDetallePago, pago.DetalleDePago);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PAGO"
            };
            var pago = (Ruta)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPago, pago.IdPago);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PAGO"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PAGO"
            };
            var pago = (Ruta)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPago, pago.IdPago);
            operation.AddVarcharParam(DbColIdUsuario, pago.IdUsuario);
            operation.AddVarcharParam(DbColMetodoPago, pago.MetodoDePago);
            operation.AddVarcharParam(DbColEstadoPago, pago.EstadoDePago);
            operation.AddDecimalParam(DbColMontoPago, pago.MontoDePago);
            operation.AddDecimalParam(DbColImpuestoVentaPago, pago.ImpuestoDePago);
            operation.AddDecimalParam(DbColDescuentoPago, pago.DescuentoDePago);
            operation.AddDecimalParam(DbColTotalPago, pago.TotalPago);
            operation.AddVarcharParam(DbColDetallePago, pago.DetalleDePago);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PAGO"
            };
            var pago = (Ruta)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPago, pago.IdPago);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);

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
