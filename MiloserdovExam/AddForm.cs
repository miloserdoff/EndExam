using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MiloserdovExam
{
    public partial class AddForm : Form
    {
        DataBase dataBase = new DataBase();

        public AddForm()
        {
            InitializeComponent();
        }

        private void SaveNewFormButton_Click(object sender, EventArgs e)
        {

            try
            {
                dataBase.OpenConnection();

                var stringBuilder = new StringBuilder();
                var getManufacturerId = $"SELECT Id FROM Manufacturer WHERE ManufacturerName = '{ManufacturerComboBox.SelectedItem}'";
                var getCarBrandIdQuery = $"SELECT Id From CarBrand WHERE CarBrandName = '{CarBrandComboBox.SelectedItem}'";
                var getManufacturerIdCommand = new SqlCommand(getManufacturerId, dataBase.GetConnection());
                var getCarBrandIdCommand = new SqlCommand(getCarBrandIdQuery, dataBase.GetConnection());

                object manufacturerId = getManufacturerIdCommand.ExecuteScalar();
                var manufacturer = Convert.ToInt32(manufacturerId);

                object brandId = getCarBrandIdCommand.ExecuteScalar();
                var brand = Convert.ToInt32(brandId);

                var query = $"INSERT INTO Car (ManufacturerId, CarBrandId, CarColor, CarEngine, CarTransmisson, CarDriveType) VALUES ({manufacturer}, {brand}, '{ColorComboBox.SelectedItem}', {CarEngineTextBox.Text}, '{CarTransmisson.SelectedItem}', '{CarDriveTypeComboBox.SelectedItem}')";
                var insertCommand = new SqlCommand(query, dataBase.GetConnection());

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            CreateManufacturerComboBoxItems();
            CreateCarBrandComboBoxItems();
        }


        /// <summary>
        /// Создать элементы ComboBox производителя авто.
        /// </summary>
        private void CreateManufacturerComboBoxItems()
        {
            try
            {
                dataBase.OpenConnection();

                var query = "SELECT ManufacturerName FROM Manufacturer";
                var command = new SqlCommand(query, dataBase.GetConnection());
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ManufacturerComboBox.Items.Add(reader[0]);
                }

                dataBase.CloseConnection();
            }

            catch
            {
                MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Создать элементы ComboBox марки авто.
        /// </summary>
        private void CreateCarBrandComboBoxItems()
        {
            try
            {
                dataBase.OpenConnection();

                var query = "SELECT CarBrandName FROM CarBrand";
                var command = new SqlCommand(query, dataBase.GetConnection());
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CarBrandComboBox.Items.Add(reader[0]);
                }

                dataBase.CloseConnection();
            }

            catch
            {
                MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CreatedYearTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
