using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using A_Entidades;

namespace VentanaPrincipal
{
    public partial class UI_Permisos : Form
    {
        int idUsuario;
        public UI_Permisos(int idUsuario, string nombre, string apellido)
        {
            InitializeComponent();
            lbl_nombre.Text = nombre;
            lbl_Apellido.Text = apellido;
            MostrarListaPermisosChkListBox();
            //CompletarChkbox_Permisos(idUsuario);
            AgregarChequeos(idUsuario);
            this.idUsuario = idUsuario;
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

        private void chkboxList_Permisos_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                var permisos = new List<int?>();
                for (int i = 0; i < chkboxList_Permisos.Items.Count; i++)
                {
                    if (chkboxList_Permisos.GetItemChecked(i))
                    {
                        //chkboxList_Permisos.GetItemText(i); metodo para obtener texto del item seleccionado y luego comparar via where like ......
                        //permisos.Add(chkboxList_Permisos.GetItemText(i));

                        var castedItem = (DataRowView)chkboxList_Permisos.Items[i];
                        int? id = Convert.ToInt32(castedItem["id"]);
                        permisos.Add(id);
                    }


                }

                Servicios.S_Permisos.EliminarPermisos(this.idUsuario);
                Servicios.S_Permisos.InsertarPermisos(permisos, this.idUsuario);
            }
            catch (Exception ex) {
                var mensaje = ex.Message;
                //TODO: Logger
            }
        }
    }
}
