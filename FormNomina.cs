using CustomControls.RJControls;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Nomina
{
    public partial class FormNomina : Form
    {
        public FormNomina()
        {
            InitializeComponent();
            Utils.SoloNumeros(rjTextBox1);
            Utils.SoloNumeros(rjTextBox2);
            Utils.SoloNumeros(rjTextBox4);
            Utils.SoloNumeros(rjTextBox5);
            Utils.SoloNumeros(rjTextBox6);
            EmpleadosForm empleadosForm = new EmpleadosForm();
            empleadosForm.DvgCargarDatos("Nomina", dataGridViewNomina);
        }
        private string cadenaConexion = "Data Source=localhost:1521/xe;User Id=NominaUser;Password=Yuniel1120;";
        

        
        public void InsertarDatos(double bonificaciones, double ars, double afp, double comida, double pagoHorasExtras, double impuestos)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(cadenaConexion))
                {
                    connection.Open();

                    string query = "INSERT INTO Nomina (Bonificaciones, ARS, AFP, COMIDA, PAGOHORASEXTRAS, IMPUESTOS) " +
                                   "VALUES (:bonificaciones, :ars, :afp, :comida, :pagoHorasExtras, :impuestos)";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        // Parámetros
                        command.Parameters.Add(":bonificaciones", OracleDbType.Double).Value = bonificaciones;
                        command.Parameters.Add(":ars", OracleDbType.Double).Value = ars;
                        command.Parameters.Add(":afp", OracleDbType.Double).Value = afp;
                        command.Parameters.Add(":comida", OracleDbType.Double).Value = comida;
                        command.Parameters.Add(":pagoHorasExtras", OracleDbType.Double).Value = pagoHorasExtras;
                        command.Parameters.Add(":impuestos", OracleDbType.Double).Value = impuestos;
                        

                        // Ejecutar la consulta
                        int filasInsertadas = command.ExecuteNonQuery();

                        // Verificar si se insertaron registros
                        if (filasInsertadas > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar los datos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos en la tabla Nomina: " + ex.Message);
            }
        }
        private void rjButton2_Click(object sender, EventArgs e)
        {
            // Verifica si las textboxes están vacías antes de ejecutar el código
            if (!string.IsNullOrEmpty(rjTextBox1.Texts) &&
                !string.IsNullOrEmpty(rjTextBox2.Texts) &&
                !string.IsNullOrEmpty(rjTextBox3.Texts) &&
                !string.IsNullOrEmpty(rjTextBox4.Texts) &&
                !string.IsNullOrEmpty(rjTextBox5.Texts) &&
                !string.IsNullOrEmpty(rjTextBox6.Texts))
            {
                // Ejecuta el código si las textboxes no están vacías
                rjTextBox1.Enabled = false;
                rjTextBox2.Enabled = false;
                rjTextBox3.Enabled = false;
                rjTextBox4.Enabled = false;
                rjTextBox5.Enabled = false;
                rjTextBox6.Enabled = false;
               
                InsertarDatos(
                    Convert.ToDouble(rjTextBox3.Texts),
                    Convert.ToDouble(rjTextBox1.Texts),
                    Convert.ToDouble(rjTextBox2.Texts),
                    Convert.ToDouble(rjTextBox5.Texts),
                    Convert.ToDouble(rjTextBox6.Texts),
                    Convert.ToDouble(rjTextBox4.Texts)
                );

            }
            else
            {
                // Muestra un mensaje si las textboxes están vacías
                MessageBox.Show("Por favor, llene todos los campos para guardar los parámetros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            EmpleadosForm empleadosForm = new EmpleadosForm();
            empleadosForm.DvgCargarDatos("Nomina", dataGridViewNomina);
        }
        public void CargarDatosEnComboBox(string nombreColumna, string nombreTabla, ComboBox comboBox)
        {
            try
            {
                // Establecer la conexión a la base de datos
                using (OracleConnection connection = new OracleConnection(cadenaConexion))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear un comando SQL para seleccionar los datos de la columna especificada
                    string query = $"SELECT {nombreColumna} FROM {nombreTabla}";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        // Ejecutar el comando y obtener los resultados
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            // Limpiar los elementos existentes en el ComboBox
                            comboBox.Items.Clear();

                            // Agregar cada valor de la columna al ComboBox
                            while (reader.Read())
                            {
                                string valor = reader[nombreColumna].ToString();
                                comboBox.Items.Add(valor);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en el ComboBox: " + ex.Message);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtIdEmpleado.Text;
            
            // Consulta SQL para buscar la información de la nómina por el código de empleado
            string consulta = "SELECT NOMBRE, SALARIO, CARGO FROM empleados WHERE cedula = :cedula";

            using (OracleConnection conexion = new OracleConnection(cadenaConexion))
            using (OracleCommand comando = new OracleCommand(consulta, conexion))
            {
                // Agregar parámetros
                comando.Parameters.Add(new OracleParameter("cedula", cedula));

                try
                {
                    conexion.Open();
                    OracleDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        // Si se encontró información, mostrarla en los TextBox correspondientes
                        txtNombre.Text = reader["NOMBRE"].ToString();
                        txtCargo.Text = reader["CARGO"].ToString();
                        Int32 sueldo = reader.GetInt32(reader.GetOrdinal("SALARIO"));
                        txtSalario.Text = sueldo.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró información de nómina para el código de empleado especificado.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar en la nómina: " + ex.Message);
                }

            }
        }

        private void dataGridViewNomina_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada
            if (dataGridViewNomina.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridViewNomina.SelectedRows[0];

                // Recolectar los datos de las celdas de la fila seleccionada
                int idEmpleado = Convert.ToInt32(filaSeleccionada.Cells["IDEMPLEADO"].Value);
               
               decimal bonificaciones = Convert.ToDecimal(filaSeleccionada.Cells["BONIFICACIONES"].Value); 
                decimal ars = Convert.ToDecimal(filaSeleccionada.Cells["ARS"].Value);
                decimal afp = Convert.ToDecimal(filaSeleccionada.Cells["AFP"].Value);
                decimal comida = Convert.ToDecimal(filaSeleccionada.Cells["COMIDA"].Value);
                decimal pagoHorasExtras = Convert.ToDecimal(filaSeleccionada.Cells["PAGOHORASEXTRAS"].Value);
                decimal impuestos = Convert.ToDecimal(filaSeleccionada.Cells["IMPUESTOS"].Value);
                
                

                // Ahora puedes utilizar estas variables como desees
                // Por ejemplo, mostrarlas en TextBoxes o almacenarlas en otras variables
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

            // Verificar si hay al menos una fila seleccionada
            if (dataGridViewNomina.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridViewNomina.SelectedRows[0];

                // Recolectar los datos de las celdas de la fila seleccionada
                decimal bonificaciones = Convert.ToDecimal(filaSeleccionada.Cells["BONIFICACIONES"].Value);
                decimal ars = Convert.ToDecimal(filaSeleccionada.Cells["ARS"].Value);
                decimal afp = Convert.ToDecimal(filaSeleccionada.Cells["AFP"].Value);
                decimal comida = Convert.ToDecimal(filaSeleccionada.Cells["COMIDA"].Value);
                decimal pagoHorasExtras = Convert.ToDecimal(filaSeleccionada.Cells["PAGOHORASEXTRAS"].Value);
                decimal impuestos = Convert.ToDecimal(filaSeleccionada.Cells["IMPUESTOS"].Value);
                // Realizar el cálculo con los datos recolectados
                // Por ejemplo, calcular el sueldo neto:

                decimal hrsx = Convert.ToDecimal(txtHorasTrabajadas.Text) - 44;
                txtHorasExtras.Text = hrsx.ToString();
                txtBonoTransporte.Text = comida.ToString() + "%";
                txtTotalAsignaciones.Text = bonificaciones.ToString() + "%";
                decimal salario = Convert.ToDecimal(txtSalario.Text);
                decimal salarioTotal = salario + (salario * bonificaciones/100) + (salario * pagoHorasExtras/100) - ((salario * ars/100) + (salario * afp / 100) + (salario * impuestos / 100) + (salario * comida / 100));
                txtPagoTotal.Text = salarioTotal.ToString();

                
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila en el DataGridView.");
            }
        }

        private int ObtenerIdEmpleadoSeleccionado()
        {
            // Supongamos que estás utilizando un DataGridView no enlazado
            DataGridViewRow filaSeleccionada = dataGridViewNomina.SelectedRows[0];
            return Convert.ToInt32(filaSeleccionada.Cells["IDEMPLEADO"].Value);
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de las cajas de texto y del ComboBox
            decimal nuevoSalarioBase = Convert.ToDecimal(txtSalario.Text);
            
            decimal nuevoSueldoNeto = Convert.ToDecimal(txtPagoTotal.Text);
            int idEmpleado = ObtenerIdEmpleadoSeleccionado(); // Suponiendo que tienes una función para obtener el ID del empleado seleccionado

            // Conexión y comando para ejecutar la actualización
            string cadenaConexion = "Data Source=localhost:1521/xe;User Id=NominaUser;Password=Yuniel1120;";
        string query = @"UPDATE NOMINA
                     SET SALARIOBASE = :nuevoSalarioBase,
                         SUELDONETO = :nuevoSueldoNeto
                     WHERE IDEMPLEADO = :idEmpleado";

            using (OracleConnection connection = new OracleConnection(cadenaConexion))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    // Agregar parámetros
                    command.Parameters.Add(":nuevoSalarioBase", OracleDbType.Decimal).Value = nuevoSalarioBase;
                    command.Parameters.Add(":nuevoSueldoNeto", OracleDbType.Decimal).Value = nuevoSueldoNeto;
                    command.Parameters.Add(":idEmpleado", OracleDbType.Int32).Value = idEmpleado;

                    try
                    {
                        // Abrir la conexión y ejecutar el comando
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Actualización realizada correctamente. Filas afectadas: " + rowsAffected);
                        EmpleadosForm empleadosForm = new EmpleadosForm();
                        empleadosForm.DvgCargarDatos("Nomina", dataGridViewNomina);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar la tabla NOMINA: " + ex.Message);
                    }
                    
                }
            }
        }
    }
}
