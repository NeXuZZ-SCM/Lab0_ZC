using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal
{
    public partial class UI_Usuarios : Form
    {
        public UI_Usuarios()
        {
            InitializeComponent();
            MostrarTabla();
            AgregarBotonColumna();
        }

        #region ABM

        #region BAJA
        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            Servicios.S_Usuarios.EliminarUsuario(RellenarUSuario());
            MostrarTabla();
        }
        #endregion

        #region ALTA
        /// <summary>
        /// INSERTA usuarios a origenes de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                txt_IDUsuario.Text = Servicios.S_Usuarios.AgregarUsuario(RellenarUSuario()).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INGRESAR DATO:" + ex.ToString());
            }

            this.MostrarTabla();


        }
        #endregion

        #region MODIFICACION
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            RellenarUSuario();
            Servicios.S_Usuarios.EditarUsuarios(RellenarUSuario());
            MostrarTabla();
        }

        #endregion

        #endregion

        #region SHOW TABLE

        /// <summary>
        /// Muetras tabla en FRM
        /// </summary>
        private void MostrarTabla()
        {
            dgv_Usuarios.DataSource = Servicios.S_Usuarios.obtenerTabla();
            this.dgv_Usuarios.Columns["Identificador"].Visible = false;
        }
        #endregion

        #region AGREGAR BOTON COLUMNA


        /// <summary>
        /// Agrega un boton en una columna, establece texto de cabecera en columna, tag name usado para conocer la celda tocada.
        /// </summary>
        private void AgregarBotonColumna()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Permisos";
            btn.Name = "boton";
            btn.Text = "Ver Permisos";
            btn.UseColumnTextForButtonValue = true;
            dgv_Usuarios.Columns.Add(btn);
        }

        #endregion

        #region RELLENAR USUARIO

        private A_Entidades.E_Usuario RellenarUSuario()
        {
            A_Entidades.E_Usuario Usuario = new A_Entidades.E_Usuario();

            Usuario.Nombre = txt_NombreUsuario.Text;
            Usuario.Apellido = txt_ApellidoUsuario.Text;

            try
            {
                Usuario.Id = (string.IsNullOrWhiteSpace(txt_IDUsuario.Text)) ? (int?)null : Convert.ToInt32(txt_IDUsuario.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Excepcion de formato " + ex.ToString());
            }

            return Usuario;
        }
        #endregion

        #region CELL EVENT SINGLE AND DOUBLE CLICK 

        /// <summary>
        /// Evento doble clic para DATAGRIDVIEW Usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_Usuarios.Rows[e.RowIndex];
            txt_IDUsuario.Text = Convert.ToString(row.Cells["Identificador"].Value);
            txt_NombreUsuario.Text = Convert.ToString(row.Cells["Nombre"].Value);
            txt_ApellidoUsuario.Text = Convert.ToString(row.Cells["Apellido"].Value);
        }
        /// <summary>
        /// Evento Clic simple para DataGridView Usuarios Obtiene el index de la columna referenciado por un tag para saber si estan tocando el boton 
        /// ver metodo AgregarBotonColumna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_Usuarios.Columns["boton"].Index)
            {
                DataGridViewRow row = dgv_Usuarios.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["Identificador"].Value);
                string nombre = Convert.ToString(row.Cells["Nombre"].Value);
                string apellido = Convert.ToString(row.Cells["Apellido"].Value);


                var frmPermisos = new UI_Permisos(id, nombre, apellido);
                frmPermisos.ShowDialog();
            }
        }
        #endregion


    }
}
