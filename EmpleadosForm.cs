using Oracle.ManagedDataAccess.Client;
using Sistema_de_nomina;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Nomina
{
    public partial class EmpleadosForm : Form
    {
        public OracleConnection conexion;
        public string cadenaConexion = "Data Source=localhost:1521/xe;User Id=NominaUser;Password=Yuniel1120;";
        
        public void DvgCargarDatos(string tabla, DataGridView dgv)
        {
           
            try
            {
                // Establecer la conexión
                conexion = new OracleConnection(cadenaConexion);
                conexion.Open();

                // Consulta SQL para seleccionar los datos
                string consulta = "SELECT * FROM " + tabla;

                // Crear un adaptador de datos
                OracleDataAdapter adaptador = new OracleDataAdapter(consulta, conexion);

                // Crear un DataSet para almacenar los datos
                DataSet datos = new DataSet();

                // Llenar el DataSet con los datos obtenidos de la consulta
                adaptador.Fill(datos);

                // Asignar el DataSet como origen de datos para el DataGridView
                dgv.DataSource = datos.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }
        
        public EmpleadosForm()
        {
            InitializeComponent();
            DvgCargarDatos("empleados", dgvAgregar);
            DvgCargarDatos("empleados", dgvActualizar);
            CargarDepartamentos(txtDepartamento);
            CargarDepartamentos(txtDepartamentoEliminar);
            CargarDepartamentos(comboBoxDepartamentos);

        }
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
           
                string sueldo = txtSalario.Text;
                if (decimal.TryParse(sueldo, out decimal NumeroSueldo))
                {
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string direccion = txtDireccion.Text;
                    string cedula = txtCedula.Text;
                    string telefono = txtTelefono.Text;
                    string cargo = txtCargo.Text;
                    string departamento = comboBoxDepartamentos.Text;

                    // Crear la cadena de conexión
                    string connectionString = "Data Source=localhost:1521/xe;User Id=NominaUser;Password=Yuniel1120;";

                    // Crear la consulta de inserción
                    string consulta = @"INSERT INTO empleados (nombre, apellido, direccion, cedula, telefono, cargo, salario, departamento) 
                            VALUES (:nombre, :apellido, :direccion, :cedula, :telefono, :cargo, :sueldo, :departamento)";

                    // Crear la conexión y el comando
                    using (OracleConnection conexion = new OracleConnection(connectionString))
                    using (OracleCommand comando = new OracleCommand(consulta, conexion))
                    {
                        // Agregar parámetros
                        comando.Parameters.Add(new OracleParameter("nombre", nombre));
                        comando.Parameters.Add(new OracleParameter("apellido", apellido));
                        comando.Parameters.Add(new OracleParameter("direccion", direccion));
                        comando.Parameters.Add(new OracleParameter("cedula", cedula));
                        comando.Parameters.Add(new OracleParameter("cargo", cargo));
                        comando.Parameters.Add(new OracleParameter("telefono", telefono));
                        comando.Parameters.Add(new OracleParameter("sueldo", NumeroSueldo));
                        comando.Parameters.Add(new OracleParameter("departamento", departamento));

                    try
                        {
                            // Abrir la conexión
                            conexion.Open();

                            // Ejecutar la consulta de inserción
                            int filasInsertadas = comando.ExecuteNonQuery();

                            // Verificar si se insertaron filas
                            if (filasInsertadas > 0)
                            {
                                MessageBox.Show("Empleado insertado correctamente.");
                                DvgCargarDatos("empleados", dgvAgregar);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo insertar el empleado.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al insertar el empleado: " + ex.Message);
                        }
                    }
                }  
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEmpleado.Text;
            string cedula = txtIdEmpleado.Text;
            string departamento = txtDepartamento.Text;

            MostrarDatosEmpleado(nombre, cedula, departamento, dgvConsulta);
        }
        private void MostrarDatosEmpleado(string nombre, string cedula, string departamento, DataGridView tabla)
        {
            try
            {
                using (OracleConnection conexion = new OracleConnection(cadenaConexion))
                {
                    // Verificar si la conexión está abierta
                    if (conexion.State != ConnectionState.Open)
                        conexion.Open();

                    string consulta = "SELECT idempleado, nombre, apellido, cedula, departamento, direccion, telefono, cargo, salario " +
                                      "FROM empleados " +
                                      "WHERE nombre = :nombre AND cedula = :cedula AND departamento = :departamento";

                    using (OracleCommand comando = new OracleCommand(consulta, conexion))
                    {
                        comando.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nombre;
                        comando.Parameters.Add(":cedula", OracleDbType.Varchar2).Value = cedula;
                        comando.Parameters.Add(":departamento", OracleDbType.Varchar2).Value = departamento;

                        using (OracleDataAdapter adaptador = new OracleDataAdapter(comando))
                        {
                            DataTable tablaEmpleado = new DataTable();
                            adaptador.Fill(tablaEmpleado);

                            // Verificar si se devolvieron filas
                            if (tablaEmpleado.Rows.Count > 0)
                                tabla.DataSource = tablaEmpleado;
                            else
                                MessageBox.Show("No se encontraron empleados con los criterios especificados.");
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }


        private bool EliminarEmpleado(int idEmpleado)
        {
            try
            {
                // Establecer la conexión
                using (OracleConnection conexion = new OracleConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Consulta SQL para eliminar el empleado por su ID
                    string consulta = "DELETE FROM empleados WHERE idempleado = :idEmpleado";

                    // Crear un comando con la consulta SQL y la conexión
                    using (OracleCommand comando = new OracleCommand(consulta, conexion))
                    {
                        // Asignar el valor del parámetro de la consulta
                        comando.Parameters.Add(":idEmpleado", OracleDbType.Int32).Value = idEmpleado;

                        // Ejecutar la consulta
                        int filasAfectadas = comando.ExecuteNonQuery();

                        // Verificar si se eliminó correctamente
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el empleado: " + ex.Message);
                return false;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvEliminar.SelectedRows.Count > 0)
            {
                // Obtener el valor de la clave primaria (ID) de la fila seleccionada
                int idEmpleado = Convert.ToInt32(dgvEliminar.SelectedRows[0].Cells["IDEMPLEADO"].Value); // Reemplaza "IDEMPLEADO" con el nombre de la columna que contiene la clave primaria en tu DataGridView

                // Mostrar un mensaje de confirmación al usuario
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (resultado == DialogResult.Yes)
                {
                    // Eliminar la fila de la base de datos
                    if (EliminarEmpleado(idEmpleado))
                    {
                        // Eliminar la fila seleccionada del DataGridView
                        dgvEliminar.Rows.RemoveAt(dgvEliminar.SelectedRows[0].Index);
                        MessageBox.Show("Empleado eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el empleado.");
                    }
                }
                // Si el usuario selecciona "No" o cierra el mensaje de confirmación, no se realiza ninguna acción
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }

        }
        private void CargarDepartamentos(System.Windows.Forms.ComboBox wombocombo)
        {
            Login login = new Login();
            try
            {
                // Crea una conexión a la base de datos
                using (OracleConnection connection = new OracleConnection(cadenaConexion))
                {
                    // Abre la conexión
                    connection.Open();

                    // Crea un comando SQL para ejecutar la consulta
                    string query = "SELECT nombre FROM departamentos";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        // Ejecuta la consulta y obtén los resultados
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            // Limpia los elementos existentes en el ComboBox
                            wombocombo.Items.Clear();

                            // Agrega cada nombre de departamento al ComboBox
                            while (reader.Read())
                            {
                                string nombreDepartamento = reader.GetString(0);
                                wombocombo.Items.Add(nombreDepartamento);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier error que pueda ocurrir
                MessageBox.Show("Error al cargar departamentos: " + ex.Message);
            }
        }


        private void btnConsultarEliminar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEliminar.Text;
            string cedula = txtIdEmpleadoEliminar.Text;
            string departamento = txtDepartamentoEliminar.Text;
            MostrarDatosEmpleado(nombre, cedula, departamento, dgvEliminar);
        }
        private void EmpleadosForm_Load(object sender, EventArgs e)
        {

        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            
        }

        //metodos actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection conexion = new OracleConnection(cadenaConexion))
                {
                    // Verificar si la conexión está abierta
                    if (conexion.State != ConnectionState.Open)
                        conexion.Open();

                    string consulta = "SELECT idempleado, nombre, apellido, cedula, departamento, direccion, telefono, cargo, salario " +
                                      "FROM empleados " +
                                      "WHERE nombre = :nombre AND cedula = :cedula";

                    using (OracleCommand comando = new OracleCommand(consulta, conexion))
                    {
                        comando.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = txtNombreActualizar.Text;
                        comando.Parameters.Add(":cedula", OracleDbType.Varchar2).Value = txtCedulaActualizar.Text;
                        
                        using (OracleDataAdapter adaptador = new OracleDataAdapter(comando))
                        {
                            DataTable tablaEmpleado = new DataTable();
                            adaptador.Fill(tablaEmpleado);

                            // Verificar si se devolvieron filas
                            if (tablaEmpleado.Rows.Count > 0)
                                dgvActualizar.DataSource = tablaEmpleado;
                            else
                                MessageBox.Show("No se encontraron empleados con los criterios especificados.");
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }
        

        private void actEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreActualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void dgvActualizar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) // Verifica que no sea el encabezado de la fila
            {
                // Obtiene la fila modificada
                DataGridViewRow filaModificada = dgvActualizar.Rows[e.RowIndex];

                // Obtiene los nuevos valores de las celdas
                string nuevoNombre = filaModificada.Cells["nombre"].Value.ToString();
                string nuevoApellido = filaModificada.Cells["apellido"].Value.ToString();
                string nuevaDireccion = filaModificada.Cells["direccion"].Value.ToString();
                string nuevoTelefono = filaModificada.Cells["telefono"].Value.ToString();
                string nuevoCargo = filaModificada.Cells["cargo"].Value.ToString();
                decimal nuevoSalario = Convert.ToDecimal(filaModificada.Cells["salario"].Value); // Asegúrate de que el tipo de datos sea el correcto
                string nuevoDepartamento = filaModificada.Cells["departamento"].Value.ToString();
                string cedula = filaModificada.Cells["cedula"].Value.ToString(); // La cédula se utiliza como condición WHERE

                // Consulta SQL de actualización
                string consulta = @"UPDATE empleados 
                            SET nombre = :nombre,
                                apellido = :apellido,
                                direccion = :direccion,
                                telefono = :telefono,
                                cargo = :cargo,
                                salario = :salario,
                                departamento = :departamento 
                            WHERE cedula = :cedula";

                // Crear la conexión y el comando
                using (OracleConnection conexion = new OracleConnection(cadenaConexion))
                using (OracleCommand comando = new OracleCommand(consulta, conexion))
                {
                    // Agregar parámetros
                    comando.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nuevoNombre;
                    comando.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = nuevoApellido;
                    comando.Parameters.Add(":direccion", OracleDbType.Varchar2).Value = nuevaDireccion;
                    comando.Parameters.Add(":telefono", OracleDbType.Varchar2).Value = nuevoTelefono;
                    comando.Parameters.Add(":cargo", OracleDbType.Varchar2).Value = nuevoCargo;
                    comando.Parameters.Add(":salario", OracleDbType.Decimal).Value = nuevoSalario;
                    comando.Parameters.Add(":departamento", OracleDbType.Varchar2).Value = nuevoDepartamento;
                    comando.Parameters.Add(":cedula", OracleDbType.Varchar2).Value = cedula;

                    try
                    {
                        // Abrir la conexión
                        conexion.Open();

                        // Ejecutar la consulta de actualización
                        int filasActualizadas = comando.ExecuteNonQuery();

                        // Verificar si se actualizó la fila
                        if (filasActualizadas > 0)
                        {
                            MessageBox.Show("Datos actualizados correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar los datos.");
                        }
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Error de base de datos: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inesperado: " + ex.Message);
                    }
                }
            }
        }
        private Size originalSize;
        private Point originalLocation;
      
        private void aggEmpleado_SizeChanged(object sender, EventArgs e)
        {
           
           
        }
        public void RestoreAggEmpleadoSize()
        {
            // Restaura el tamaño y posición originales
            aggEmpleado.Size = originalSize;
            aggEmpleado.Location = originalLocation;
            this.Dock = DockStyle.None;
        }
    }
}
    



