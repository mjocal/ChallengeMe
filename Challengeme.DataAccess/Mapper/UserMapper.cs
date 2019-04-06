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
    public class UserMapper : EntityMapper, IObjectMapper, ISqlStaments
    {

        private const string DbColIdUsuario = "ID_USUARIO";
        private const string DbColNombre_Usuario = "NOMBRE_USUARIO";
        private const string DbColDireccion_Usuario = "DIRECCION_USUARIO";
        private const string DbColProvincia_Usuario = "PROVINCIA_USUARIO";
        private const string DbColCanton_Usuario = "CANTON_USUARIO";
        private const string DbColDistrito_Usuario = "DISTRITO_USUARIO";
        private const string DbColCorreo_Usuario = "CORREO_USUARIO";
        private const string DbColContrasenia_Usuario = "CONTRASENIA_USUARIO";
        private const string DbColFecha_Nacimiento = "FECHA_NACIMIENTO_USUARIO";
        private const string DbColImagen_Usuario = "IMAGEN_USUARIO";
        private const string DbColFecha_Creacion = "FECHA_CREACION";
        private const string DbColIdRole = "ID_ROLE";
        private const string DbColIdEntidad = "ID_ENTIDAD";
        private const string DbCrudAction = "ACTION";

        private ImageConverter imageConverter = new ImageConverter();
        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_USUARIOS"
        };

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var user = BuildObject(row);
                lstResults.Add(user);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            byte[] byteArrayImage = GetByteValue(row, DbColImagen_Usuario);
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


            var user = new User()
            {
                IdUsuario = GetStringValue(row, DbColIdUsuario),
                NombreUsuario = GetStringValue(row, DbColNombre_Usuario),
                DirUsuario = GetStringValue(row, DbColDireccion_Usuario),
                Prov_Usuario = GetStringValue(row, DbColProvincia_Usuario),
                Cant_Usuario = GetStringValue(row, DbColCanton_Usuario),
                Dist_Usuario = GetStringValue(row, DbColDistrito_Usuario),
                Correo_Usuario = GetStringValue(row, DbColCorreo_Usuario),
                Pass_Usuario = GetStringValue(row, DbColContrasenia_Usuario),
                FNac_Usuario = GetDateValue(row, DbColFecha_Nacimiento),
                Imagen_Usuario = image,
                FCreacion_Usuario = GetDateValue(row, DbColFecha_Creacion),
                IdRole = GetIntValue(row, DbColIdRole),
                IdEntidad = GetStringValue(row, DbColIdEntidad),

            };

            return user;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_USUARIOS"
            };

            var user = (User)entity;
            operation.AddVarcharParam(DbColIdUsuario, user.IdUsuario);
            operation.AddVarcharParam(DbColNombre_Usuario, user.NombreUsuario);
            operation.AddVarcharParam(DbColDireccion_Usuario, user.DirUsuario);
            operation.AddVarcharParam(DbColProvincia_Usuario, user.Prov_Usuario);
            operation.AddVarcharParam(DbColCanton_Usuario, user.Cant_Usuario);
            operation.AddVarcharParam(DbColDistrito_Usuario, user.Dist_Usuario);
            operation.AddVarcharParam(DbColCorreo_Usuario, user.Correo_Usuario);
            operation.AddVarcharParam(DbColContrasenia_Usuario, user.Pass_Usuario);
            operation.AddDateParam(DbColFecha_Nacimiento, user.FNac_Usuario);
            operation.AddByteParam(DbColImagen_Usuario, ConvertImageToByteArray(user.Imagen_Usuario));
            operation.AddDateParam(DbColFecha_Creacion, user.FCreacion_Usuario);
            operation.AddIntParam(DbColIdRole, user.IdRole);
            operation.AddVarcharParam(DbColIdEntidad, user.IdEntidad);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);


            return operation;
        }

        public SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }


        public SqlOperation GetRetriveAllByIdRol(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_USUARIOS"
            };
            var user = (User)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdEntidad, user.IdRole);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAllById);

            return operation;
        }



        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_USUARIOS"
            };

            var user = (User)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddVarcharParam(DbColIdUsuario, user.IdUsuario);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveStatementByEmail(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_USUARIOS"
            };

            var user = (User)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddVarcharParam(DbColCorreo_Usuario, user.Correo_Usuario);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveByEmail);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_USUARIOS"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_USUARIOS"
            };
            var user = (User)entity;
            operation.AddVarcharParam(DbColIdUsuario, user.IdUsuario);
            operation.AddVarcharParam(DbColNombre_Usuario, user.NombreUsuario);
            operation.AddVarcharParam(DbColDireccion_Usuario, user.DirUsuario);
            operation.AddVarcharParam(DbColProvincia_Usuario, user.Prov_Usuario);
            operation.AddVarcharParam(DbColCanton_Usuario, user.Cant_Usuario);
            operation.AddVarcharParam(DbColDistrito_Usuario, user.Dist_Usuario);
            operation.AddVarcharParam(DbColCorreo_Usuario, user.Correo_Usuario);
            operation.AddVarcharParam(DbColContrasenia_Usuario, user.Pass_Usuario);
            operation.AddDateParam(DbColFecha_Nacimiento, user.FNac_Usuario);
            operation.AddByteParam(DbColImagen_Usuario, ConvertImageToByteArray(user.Imagen_Usuario));
            operation.AddDateParam(DbColFecha_Creacion, user.FCreacion_Usuario);
            operation.AddIntParam(DbColIdRole, user.IdRole);
            operation.AddVarcharParam(DbColIdEntidad, user.IdEntidad);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_USUARIOS"
            };
            var user = (User)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddVarcharParam(DbColIdEntidad, user.IdUsuario);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);

            return operation;
        }
       

        private byte[] ConvertImageToByteArray(Image Imagen_Usuario)
        {
            if (Imagen_Usuario == null)
            {
                return null;
            }else
            {
                return (byte[])imageConverter.ConvertTo(Imagen_Usuario, typeof(byte[]));
            }
           
        }
        public SqlOperation GetRetriveStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_USUARIOS"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;
        }

        public SqlOperation GetRetriveByName(BaseEntity entity)
        {

            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_USUARIOS"
            };

            var user = (User)entity;
            operation.AddVarcharParam(DbColNombre_Usuario, user.NombreUsuario);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveByName);
            return operation;
        }
    }


}

