using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.rvCarrera.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                int anio = int.Parse(txtAño.Text);
                SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-0QHUI5R\SQLEXPRESS;Initial Catalog=TP_PROGII2;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MATERIAS_X_ANIO";
                cmd.Parameters.AddWithValue("@anio", anio);

                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());

                rvCarrera.LocalReport.DataSources.Clear();
                rvCarrera.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", table));
                rvCarrera.RefreshReport();

                cnn.Close();

            }
        }

        private bool validar()
        {
            if(txtAño.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un año", "Faltan campos");
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtAño.Text);
                    if (int.Parse(txtAño.Text)>= 1 && int.Parse(txtAño.Text)<= 5)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un año entre 1 y 5", "Error");
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un número", "Error");
                    return false;
                }
            }
        }

      
    }
}
