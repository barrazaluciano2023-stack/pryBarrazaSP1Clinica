using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarrazaSP1Clinica
{
    internal class CConexion
    {
        public OleDbConnection conectorBaseDatos;
        OleDbConnection comandosBaseDatos;
        public string estadoConexion = "sin conexion";
        //metodos para abrir la base
        public void ConectarBaseDatos()
        {
            try
            {
                conectorBaseDatos = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\DATABASE\Clinica.accdb;Persist Security Info=False;");
                conectorBaseDatos.Open();
                estadoConexion = conectorBaseDatos.State.ToString();
            }
            catch (Exception error)
            {
                estadoConexion = "error: " + error.Message;
                throw;
            }
        }
        public void cargarEspecialidad(string nombre, string nroEspecialidad)
        {
            ConectarBaseDatos();
            string query = "INSERT INTO Especialidad (Nombre,nroEspecialidad) VALUES (?,?)";

            using (OleDbCommand cmd = new OleDbCommand(query, conectorBaseDatos))
                try
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@nroEspecialidad", nroEspecialidad);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Especialidad registrada con Exito!");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar comando: " + ex.Message);
                }

                finally
                {
                    conectorBaseDatos.Close();
                }
        }
        public void cargarMedico(string nombre, string matricula, string especialidad)
        {
            ConectarBaseDatos();
            string query = "INSERT INTO Medico (Nombre,Matricula,nroEspecialidad) VALUES (?,?,?)";

            using (OleDbCommand cmd = new OleDbCommand(query, conectorBaseDatos))
                try
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Matricula", matricula);
                    cmd.Parameters.AddWithValue("@nroIdentificacion", especialidad);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Especialidad registrada con Exito!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar comando: " + ex.Message);
                }

                finally
                {
                    conectorBaseDatos.Close();
                }
        }
        public void mostrarMedicos(DataGridView dgvInfo, int especialidad)
        {
            ConectarBaseDatos();
            string query = "SELECT Nombre , Matricula FROM Medico WHERE nroEspecialidad = ?";

            OleDbDataAdapter da = new OleDbDataAdapter(query,conectorBaseDatos);
            da.SelectCommand.Parameters.AddWithValue("@Id", especialidad);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvInfo.DataSource = dt;
        }
    }
}
