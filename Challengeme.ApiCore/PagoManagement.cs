using Challengeme.DataAccess.Crud;
using Challengeme.Entities;
using System;
using System.Collections.Generic;

namespace Challengeme.ApiCore
{
    public class PagoManagement : BaseManagement
    {
        public PagoManagement()
        {
            _factory = new CrudPago();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreatePago(Ruta pago)
        {
            try
            {
                _factory.Create(pago);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }

        }

        public Ruta RetrievePago(Ruta pago)
        {

            var list = _factory.Retrieve<Ruta>(pago);

            return list;

        }

        public List<T> RetrieveAllPagos<T>()
        {

            var lst = new List<T>();
            var lista = _factory.RetrieveAll<Ruta>();



            if (lista.Count > 0)
            {


                foreach (var obj in lista)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));

                }
            }
            return lst;
        }

        public void DeletePago(Ruta pago)
        {
            _factory.Delete(pago);
        }

        public void UpdatePago(Ruta pago)
        {
            _factory.Update(pago);
        }
    }
}
