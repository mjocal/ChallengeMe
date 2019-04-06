using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Challengeme.ApiCore;
using Challengeme.Entities;
using ChallengeMe.UI.Web.Models.Controls;

namespace ChallengeMe.UI.Web.Controllers
{
    [AllowAnonymous]
    public class CategoriaController : Controller
    {
        public ActionResult Categoria()
        {
            return View();

        }

        public UiContainer GenerarId(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var mu = new CategoriaManagement();
            var Cod = 0;

            var listaId = mu.RetrieveAllCategorias<Categoria>();

            foreach (var estadoCategoria in listaId)
            {
                if (estadoCategoria.Estado_Categoria.Equals("INACTIVO"))
                {
                    Cod = estadoCategoria.IdCategoria;
                }
                else
                {
                    Cod = estadoCategoria.IdCategoria;
                }
            }

            txtId.Value = Convert.ToString(Cod + 1);
            txtId.Disabled = true;

            uiContainer.UpdateModel(txtId);
            return uiContainer;

        }

        public UiContainer CreateCategoria(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var Cod = 0;
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var tblCategorias = uiContainer.GetCtrlModel<CtrlTableModel>("tblCategorias");

            var mu = new CategoriaManagement();
            var categoria = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtId.Value),
                NombreCategoria = txtNombre.Value
            };

            mu.CreateCategoria(categoria);

            txtNombre.Value = "";

            var list = mu.RetrieveAllCategorias<Categoria>();

            tblCategorias.RowList.Clear();

            foreach (var act in list)
            {
                tblCategorias.RowList.Add(new List<string>()
                {
                    act.IdCategoria.ToString(), act.NombreCategoria
                });
            }

            var listaId = mu.RetrieveAllCategorias<Categoria>();

            foreach (var estadoCategoria in listaId)
            {
                if (estadoCategoria.Estado_Categoria.Equals("INACTIVO"))
                {
                    Cod = estadoCategoria.IdCategoria;
                }
                else
                {
                    Cod = estadoCategoria.IdCategoria;
                }
            }

            Cod = Cod + 1;

            txtId.Value = Convert.ToString(Cod);
            txtId.Disabled = true;

            uiContainer.UpdateModel(tblCategorias);
            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);

            return uiContainer;
        }

        public UiContainer RetrieveCategoria(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");

            var mu = new CategoriaManagement();
            var categoria = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtId.Value)
            };

            categoria = mu.RetrieveCategoria(categoria);

            if (categoria == null)
            {
                uiContainer.InformationMessage = "La categoría " + txtId.Value + " no existe";
                txtNombre.Value = "";
            }
            else
            {
                txtId.Value = categoria.IdCategoria.ToString();
                txtId.Disabled = true;
                txtNombre.Value = categoria.NombreCategoria;

                btnEliminar.Value = "Eliminar";
                btnEliminar.ButtonType = "danger";
                btnEliminar.Disabled = false;
                btnEliminar.EvtOnClick = "deleteCategoria()";

                btnActualizar.Value = "Actualizar";
                btnActualizar.ButtonType = "warning";
                btnActualizar.Disabled = false;
                btnActualizar.EvtOnClick = "updateCategoria()";
            }

            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(btnEliminar);
            uiContainer.UpdateModel(btnActualizar);

            return uiContainer;
        }

        public UiContainer RetrieveAll(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var tblCategorias = uiContainer.GetCtrlModel<CtrlTableModel>("tblCategorias");

            var mu = new CategoriaManagement();
            var list = mu.RetrieveAllCategorias<Categoria>();

            tblCategorias.RowList.Clear();

            foreach (var categoria in list)
            {
                if (categoria.Estado_Categoria.Equals("INACTIVO"))
                {

                }
                else
                {
                    tblCategorias.RowList.Add(new List<string>()
                    {
                        categoria.IdCategoria.ToString(), categoria.NombreCategoria
                    });
                }

            }

            uiContainer.UpdateModel(tblCategorias);

            return uiContainer;
        }

        public UiContainer BindFields(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var tblCategorias = uiContainer.GetCtrlModel<CtrlTableModel>("tblCategorias");
            var categ = new Categoria(tblCategorias.GetSelectedRow());
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var btnGuardar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnGuardar");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");

            txtId.Value = categ.IdCategoria.ToString();
            txtId.Disabled = true;
            txtNombre.Value = categ.NombreCategoria;

            btnGuardar.Value = "Guardar";
            btnGuardar.ButtonType = "info";
            btnGuardar.Disabled = true;
            btnGuardar.EvtOnClick = " ";

            btnEliminar.Value = "Eliminar";
            btnEliminar.ButtonType = "danger";
            btnEliminar.Disabled = false;
            btnEliminar.EvtOnClick = "deleteCategoria()";

            btnActualizar.Value = "Actualizar";
            btnActualizar.ButtonType = "warning";
            btnActualizar.Disabled = false;
            btnActualizar.EvtOnClick = "updateCategoria()";

            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(btnGuardar);
            uiContainer.UpdateModel(btnEliminar);
            uiContainer.UpdateModel(btnActualizar);

            return uiContainer;
        }


        public UiContainer UpdateCategoria(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var tblCategorias = uiContainer.GetCtrlModel<CtrlTableModel>("tblCategorias");

            //Creacion del usuario
            var mu = new CategoriaManagement();
            var categoria = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtId.Value),
                NombreCategoria = txtNombre.Value,
            };

            mu.UpdateCategoria(categoria);

            txtId.Disabled = true;

            var list = mu.RetrieveAllCategorias<Categoria>();

            tblCategorias.RowList.Clear();

            foreach (var act in list)
            {
                tblCategorias.RowList.Add(new List<string>()
                {
                    act.IdCategoria.ToString(), act.NombreCategoria
                });
            }

            uiContainer.UpdateModel(tblCategorias);
            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);

            return uiContainer;
        }


        public UiContainer DeleteCategoria(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var btnGuardar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnGuardar");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");
            var tblCategorias = uiContainer.GetCtrlModel<CtrlTableModel>("tblCategorias");

            var mu = new CategoriaManagement();
            var categoria = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtId.Value)
            };

            mu.DeleteCategoria(categoria);

            var list = mu.RetrieveAllCategorias<Categoria>();

            tblCategorias.RowList.Clear();

            foreach (var act in list)
            {
                tblCategorias.RowList.Add(new List<string>()
                {
                    act.IdCategoria.ToString(), act.NombreCategoria
                });
            }

            //LimpiarCampos
            txtId.Value = "";
            txtId.Disabled = true;
            txtNombre.Value = "";

            btnGuardar.Value = "Guardar";
            btnGuardar.ButtonType = "info";
            btnGuardar.Disabled = false;
            btnGuardar.EvtOnClick = "createCategoria()";

            btnEliminar.Value = "Eliminar";
            btnEliminar.ButtonType = "info";
            btnEliminar.Disabled = true;
            btnEliminar.EvtOnClick = " ";

            btnActualizar.Value = "Actualizar";
            btnActualizar.ButtonType = "info";
            btnActualizar.Disabled = true;
            btnActualizar.EvtOnClick = " ";

            uiContainer.UpdateModel(tblCategorias);
            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(btnGuardar);
            uiContainer.UpdateModel(btnEliminar);
            uiContainer.UpdateModel(btnActualizar);

            return uiContainer;
        }

        public UiContainer LimpiarCampos(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var btnGuardar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnGuardar");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");
            var Cod = 0;
            var mu = new CategoriaManagement();

            var list = mu.RetrieveAllCategorias<Categoria>();

            foreach (var estadoCategoria in list)
            {
                if (estadoCategoria.Estado_Categoria.Equals("INACTIVO"))
                {
                    Cod = estadoCategoria.IdCategoria;
                }
                else
                {
                    Cod = estadoCategoria.IdCategoria;
                }
            }

            Cod = Cod + 1;

            txtId.Value = Convert.ToString(Cod);
            txtId.Disabled = true;

            txtId.Disabled = true;
            txtNombre.Value = "";

            btnGuardar.Value = "Guardar";
            btnGuardar.ButtonType = "info";
            btnGuardar.Disabled = false;
            btnGuardar.EvtOnClick = "createCategoria()";

            btnEliminar.Value = "Eliminar";
            btnEliminar.ButtonType = "info";
            btnEliminar.Disabled = true;
            btnEliminar.EvtOnClick = " ";

            btnActualizar.Value = "Actualizar";
            btnActualizar.ButtonType = "info";
            btnActualizar.Disabled = true;
            btnActualizar.EvtOnClick = " ";

            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(btnGuardar);
            uiContainer.UpdateModel(btnEliminar);
            uiContainer.UpdateModel(btnActualizar);

            return uiContainer;
        }

        public UiContainer VolverAlInicio(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);

            uiContainer.RedirectTo = "/Home/Index";

            return uiContainer;
        }
    }
}