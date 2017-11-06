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

namespace DatabaseWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateGridView()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\student.SL228-03\\Source\\Repos\\DatabaseWF\\DatabaseWF\\MeasurementsDB.mdf;Integrated Security=True";
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand("select * from Measurements", conn);
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = sqlCmd;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dbdataset;
                    dataGridMeasurements.DataSource = dbdataset;
                    sda.Update(dbdataset);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error 2");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void loadList()
        {
            updateGridView();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\student.SL228-03\\Source\\Repos\\DatabaseWF\\DatabaseWF\\MeasurementsDB.mdf;Integrated Security=True";
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Measurements", conn);
                command.ExecuteNonQuery();

                listBoxId.Items.Clear();
                listBoxTime.Items.Clear();
                listBoxValue.Items.Clear();
                listBoxComment.Items.Clear();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // while there is another record present
                    while (reader.Read())
                    {
                        listBoxId.Items.Add(reader[0].ToString());
                        listBoxTime.Items.Add(reader[1].ToString());
                        listBoxValue.Items.Add(reader[2].ToString());
                        listBoxComment.Items.Add(reader[3].ToString());
                    }
                }
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string sValue = TextBoxValue.Text;
                string sComment = TextBoxComment.Text;
                DateTime dateTimeVariable = DateTime.Now;

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\student.SL228-03\\Source\\Repos\\DatabaseWF\\DatabaseWF\\MeasurementsDB.mdf;Integrated Security=True";
                    conn.Open();

                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandText = "INSERT INTO Measurements (value, comment, time) VALUES(" + sValue + ", (@comment), (@time))";                    sqlCmd.Parameters.AddWithValue("@time", dateTimeVariable);
                    sqlCmd.Parameters.AddWithValue("@comment", sComment);

                    sqlCmd.Connection = conn;
                    sqlCmd.ExecuteNonQuery();
                }                MessageBox.Show("Saved succesfully");
                loadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\student.SL228-03\\Source\\Repos\\DatabaseWF\\DatabaseWF\\MeasurementsDB.mdf;Integrated Security=True";
                    conn.Open();

                    string id = listBoxId.SelectedItem.ToString();

                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandText = "DELETE FROM Measurements WHERE Id=(@id)";                    sqlCmd.Parameters.AddWithValue("@id", id);

                    sqlCmd.Connection = conn;
                    sqlCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Deleted succesfully");
                loadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\student.SL228-03\\Source\\Repos\\DatabaseWF\\DatabaseWF\\MeasurementsDB.mdf;Integrated Security=True";
                    conn.Open();
                    SqlCommand sqlCmd = new SqlCommand();
                    string id = listBoxId.SelectedItem.ToString();
                    string value = TextBoxValue.Text;
                    string comment = TextBoxComment.Text;

                    sqlCmd.CommandText = "UPDATE Measurements SET time=(@time), comment=(@comment), value=(@value) WHERE Id=(@id)";
                    sqlCmd.Parameters.AddWithValue("@id", id);
                    sqlCmd.Parameters.AddWithValue("@comment", TextBoxComment.Text);
                    sqlCmd.Parameters.AddWithValue("@value", TextBoxValue.Text);
                    sqlCmd.Parameters.AddWithValue("@time", DateTime.Now.ToString());

                    sqlCmd.Connection = conn;
                    sqlCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Updated succesfully");
                loadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'measurementsDBDataSet.Measurements' . Możesz go przenieść lub usunąć.
            this.measurementsTableAdapter.Fill(this.measurementsDBDataSet.Measurements);

        }
    }
}
