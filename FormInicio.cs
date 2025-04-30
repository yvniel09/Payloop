using CustomControls.RJControls;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Nomina
{
    
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            
        }
        private string cadenaConexion = "Data Source=localhost:1521/xe;User Id=NominaUser;Password=Yuniel1120;";
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string keyword = rjTextBox1.Texts.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                using (OracleConnection connection = new OracleConnection(cadenaConexion))
                {
                    using (OracleCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "search_empleados";
                        cmd.CommandType = CommandType.StoredProcedure;

                        OracleParameter searchKeywordParam = new OracleParameter();
                        searchKeywordParam.ParameterName = "search_keyword";
                        searchKeywordParam.OracleDbType = OracleDbType.Varchar2;
                        searchKeywordParam.Direction = ParameterDirection.Input;
                        searchKeywordParam.Value = keyword;

                        OracleParameter searchResultsParam = new OracleParameter();
                        searchResultsParam.ParameterName = "search_results";
                        searchResultsParam.OracleDbType = OracleDbType.RefCursor;
                        searchResultsParam.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(searchKeywordParam);
                        cmd.Parameters.Add(searchResultsParam);

                        try
                        {
                            connection.Open();
                            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a search keyword.");
            }
        }
    }
}

    

