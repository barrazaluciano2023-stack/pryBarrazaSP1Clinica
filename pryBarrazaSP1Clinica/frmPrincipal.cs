using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarrazaSP1Clinica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            cargarEspecialidad();
            cmbEspecialidad.SelectedIndex = -1;
        }

        private void cargarEspecialidad()
        {
            CConexion objetoConeccionBaseDatos = new CConexion();
            objetoConeccionBaseDatos.ConectarBaseDatos();
            string query = "SELECT  Nombre,nroEspecialidad FROM Especialidad";

            OleDbDataAdapter da = new OleDbDataAdapter(query, objetoConeccionBaseDatos.conectorBaseDatos);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbEspecialidad.DataSource = dt;
            cmbEspecialidad.DisplayMember = "Nombre";
            cmbEspecialidad.ValueMember = "nroEspecialidad";
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidad.SelectedValue == null)
                return;

            int idEspecialidad;

            if (!int.TryParse(cmbEspecialidad.SelectedValue.ToString(), out idEspecialidad))
                return;

            CargarMedicos(idEspecialidad);
        }
        private void CargarMedicos(int idEspecialidad)
        {
            CConexion objetoConeccionBaseDatos = new CConexion();
            try
            {
                objetoConeccionBaseDatos.mostrarMedicos(dgvInfo, idEspecialidad);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //string query = "SELECT Nombre , Matricula FROM Medico WHERE nroEspecialidad = ?";

            //OleDbDataAdapter da = new OleDbDataAdapter(query, objetoConeccionBaseDatos.conectorBaseDatos);
            //da.SelectCommand.Parameters.AddWithValue("@Id", idEspecialidad);

            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //dgvInfo.DataSource = dt;
        }
        private void btnRegistrarEspecialidad_Click(object sender, EventArgs e)
        {
            CConexion objetoConeccionBaseDatos = new CConexion();
            objetoConeccionBaseDatos.cargarEspecialidad(txtNombreEspecialidad.Text , txtNroIdentificacion.Text);

            txtNroIdentificacion.Clear();
            txtNombreEspecialidad.Clear();
            //string query = "INSERT INTO Especialidad (Nombre,nroEspecialidad) VALUES (?,?)";

            //using (OleDbCommand cmd = new OleDbCommand(query, objetoConeccionBaseDatos.conectorBaseDatos))
            //    try
            //    {
            //        cmd.Parameters.AddWithValue("@Nombre", txtNombreEspecialidad.Text);
            //        cmd.Parameters.AddWithValue("@nroEspecialidad", txtNroIdentificacion.Text);
            //        cmd.ExecuteNonQuery();
            //        txtNroIdentificacion.Clear();
            //        txtNombreEspecialidad.Clear();
            //        MessageBox.Show("Especialidad registrada con Exito!");


            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error al ejecutar comando: " + ex.Message);
            //    }

            //    finally
            //    {
            //        objetoConeccionBaseDatos.conectorBaseDatos.Close();
            //    }

        }

        private void btnRegistrarMedico_Click(object sender, EventArgs e)
            
        {
            //objetoConeccionBaseDatos.ConectarBaseDatos();
            //string query = "INSERT INTO Medico (Nombre,Matricula,nroEspecialidad) VALUES (?,?,?)";

            //using (OleDbCommand cmd = new OleDbCommand(query, objetoConeccionBaseDatos.conectorBaseDatos))
            //    try
            //    {
            //        cmd.Parameters.AddWithValue("@Nombre", txtNombreMedico.Text);
            //        cmd.Parameters.AddWithValue("@Matricula", txtMatricula.Text);
            //        cmd.Parameters.AddWithValue("@nroIdentificacion", txtEspecialidadMedico.Text);
            //        cmd.ExecuteNonQuery();
                    //txtNombreMedico.Clear();
                    //txtMatricula.Clear();
                    //txtEspecialidadMedico.Clear();
                    //MessageBox.Show("Medico registrado con Exito!");

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error al ejecutar comando: " + ex.Message);
                //}

                //finally
                //{
                //    objetoConeccionBaseDatos.conectorBaseDatos.Close();
                //}


        }

        private void txtNroIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidacion.SoloNumeros(e);
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidacion.SoloNumeros(e);
        }

        private void txtEspecialidadMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidacion.SoloNumeros(e);
        }

        private void btnCancelarEspecialidad_Click(object sender, EventArgs e)
        {
            txtNombreEspecialidad.Clear();
            txtNroIdentificacion.Clear();
            txtNombreEspecialidad.Focus();
        }

        private void btnCancelarMedico_Click(object sender, EventArgs e)
        {
            txtNombreMedico.Clear();
            txtMatricula.Clear();
            txtEspecialidadMedico.Clear();
            txtNombreMedico.Focus();

        }

        private void btnRegistrarMedico_Click_1(object sender, EventArgs e)
        {

            try
            {

                CConexion objetoConeccionBaseDatos = new CConexion();
                objetoConeccionBaseDatos.cargarMedico(txtNombreMedico.Text, txtMatricula.Text, txtEspecialidadMedico.Text);
                txtNombreMedico.Clear();
                txtMatricula.Clear();
                txtEspecialidadMedico.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar medico: " + ex.Message);
            }
        }
    }
}
