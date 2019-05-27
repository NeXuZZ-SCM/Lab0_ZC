using System;
using System.Collections.Generic;
using System.Windows.Forms;
using A_Entidades;

namespace VentanaPrincipal
{
    public partial class UI_Permisos : Form
    {
        List<string> lista;
        public UI_Permisos(int idUsuario, string nombre, string apellido)
        {
            InitializeComponent();
            lbl_nombre.Text = nombre;
            lbl_Apellido.Text = apellido;
            MostrarListaPermisosChkListBox();
            //CompletarChkbox_Permisos(idUsuario);
            AgregarChequeos(idUsuario);
        }

        private void MostrarListaPermisosChkListBox()
        {
            var tabla = Servicios.S_Permisos.CompletarchklistBoxPermisos();
            chkboxList_Permisos.DataSource = tabla;
            chkboxList_Permisos.DisplayMember = "descripcion";
        }

        private void CompletarChkbox_Permisos(int idUsuario)
        {
            var tabla = Servicios.S_Permisos.MostrarPermisos(idUsuario);
            chkboxList_Permisos.DataSource = tabla;
            chkboxList_Permisos.DisplayMember = "id_permisos";
        }
        private void AgregarChequeos(int idUsuario)
        {

            List<E_PermisosChequeados> listado = new List<E_PermisosChequeados>();

            var dt = Servicios.S_Permisos.ConsultarChequeados(idUsuario);
            chkboxList_Permisos.DataSource = dt;
            chkboxList_Permisos.DisplayMember = "descripcion";
            chkboxList_Permisos.ValueMember = "id";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dt.Rows[i]["ch"]))
                {
                    chkboxList_Permisos.SetItemChecked(i, true);
                }
            }



        }
    }
}
