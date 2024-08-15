using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels;
using ViewModels.Library;

namespace SISTEMA_DE_INVENTARIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /****************************************
         *                                      *
         *         CODIGO DEL CLIENTE           *
         *                                      *
         ****************************************/
        #region
        private ClientesVM clientes;
        private void buttonCliente_Click(object sender, EventArgs e)
        {
            var textBoxCliente = new List<TextBox>();
            textBoxCliente.Add(textBoxCliente_Nid);
            textBoxCliente.Add(textBoxCliente_Nombre);
            textBoxCliente.Add(textBoxCliente_Apellido);
            textBoxCliente.Add(textBoxCliente_Email);
            textBoxCliente.Add(textBoxCliente_Telefono);
            textBoxCliente.Add(textBoxCliente_Direccion);


            var labelCliente = new List<Label>();
            labelCliente.Add(labelCliente_Nid);
            labelCliente.Add(labelCliente_Nombre);
            labelCliente.Add(labelCliente_Apellido);
            labelCliente.Add(labelCliente_Email);
            labelCliente.Add(labelCliente_Telefono);
            labelCliente.Add(labelCliente_Direccion);

            object[] objectos = {
                PictureBoxCliente,
                checkBoxCliente_Credito,
                Properties.Resources.perfil,
                dataGridView_Clientes
            };
            clientes = new ClientesVM(objectos, textBoxCliente, labelCliente);
            tabControlPrincipal.SelectedIndex = 1;
        }

        private void pictureBoxCliente_Click(object sender, EventArgs e)
        {
            Objects.uploadimage.CargarImagen(PictureBoxCliente);
        }

        private void textBoxCliente_Nid_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCliente_Nid.Text.Equals(""))
            {
                labelCliente_Nid.ForeColor = Color.Black;
            }
            else
            {
                labelCliente_Nid.Text = "CI";
                labelCliente_Nid.ForeColor = Color.Green;
            }
        }

        private void textBoxCliente_Nid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.eventos.numberKeyPress(e);
        }

        private void textBoxCliente_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCliente_Nombre.Text.Equals(""))
            {
                labelCliente_Nombre.ForeColor = Color.Black;
            }
            else
            {
                labelCliente_Nombre.Text = "Nombre";
                labelCliente_Nombre.ForeColor = Color.Green;
            }
        }

        private void textBoxCliente_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.eventos.textKeyPress(e);
        }

        private void textBoxCliente_Apellido_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCliente_Apellido.Text.Equals(""))
            {
                labelCliente_Apellido.ForeColor = Color.Black;
            }
            else
            {
                labelCliente_Apellido.Text = "Apellido";
                labelCliente_Apellido.ForeColor = Color.Green;
            }
        }

        private void textBoxCliente_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.eventos.textKeyPress(e);
        }

        private void textBoxCliente_Email_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCliente_Email.Text.Equals(""))
            {
                labelCliente_Email.ForeColor = Color.Black;
            }
            else
            {
                labelCliente_Email.Text = "Email";
                labelCliente_Email.ForeColor = Color.Green;
            }
        }

        private void textBoxCliente_Telefono_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCliente_Telefono.Text.Equals(""))
            {
                labelCliente_Telefono.ForeColor = Color.Black;
            }
            else
            {
                labelCliente_Telefono.Text = "Telefono";
                labelCliente_Telefono.ForeColor = Color.Green;
            }
        }

        private void textBoxCliente_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.eventos.numberKeyPress(e);
        }

        private void textBoxCliente_Direccion_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCliente_Direccion.Text.Equals(""))
            {
                labelCliente_Direccion.ForeColor = Color.Black;
            }
            else
            {
                labelCliente_Direccion.Text = "Direccion";
                labelCliente_Direccion.ForeColor = Color.Green;
            }
        }

        private void buttonCliente_Agregar_Click(object sender, EventArgs e)
        {
            clientes.guardarCliente();
        }

        private void buttonCliente_Cancelar_Click(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
