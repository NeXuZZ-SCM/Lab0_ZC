using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class UI_Usuarios : Form
    {
        public UI_Usuarios()
        {
            InitializeComponent();
        }

        private void btn_AgregarUsuario_Click(object sender, EventArgs e)
        {
            Servicios.S_Usuarios.AgregarUsuario(RellenarUSuario());

        }
        private A_Entidades.E_Usuario RellenarUSuario()
        {
            A_Entidades.E_Usuario Usuario = new A_Entidades.E_Usuario();

            Usuario.Nombre = txt_NombreUsuario.Text;
            Usuario.Apellido = txt_ApellidoUsuario.Text;

            return Usuario; 
        }
    }
}
