using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiloserdovExam
{
    public partial class MainMenu : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            var date = DateTime.Today;
            toolStripMenuItem2.Text = date.ToString("dd/MM/yyyy");
            toolStripMenuItem2.Enabled = false;
            CreateColumn();
            RefreshDataGrid(CarDealership);
            CreateCarBrandComboBoxItems();
            CreateManufacturerComboBoxItems();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Прочитать строку.
        /// </summary>
        /// <param name="dataGridView">Таблица.</param>
        /// <param name="record">Запись.</param>
        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4), record.GetString(5));
        }

        /// <summary>
        /// Обновить таблицу.
        /// </summary>
        /// <param name="dataGridView">Таблица.</param>
        private void RefreshDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            var query = @"SELECT ManufacturerName, CarBrandName, CarColor, CarEngine, CarTransmisson, CarDriveType 
                        FROM Car
                        INNER JOIN [dbo].[CarBrand] as cb
                        ON Car.CarBrandId = cb.Id
                        INNER JOIN [dbo].[Manufacturer] as m
                        ON Car.ManufacturerId = m.Id
                        ";

            dataBase.OpenConnection();

            var command = new SqlCommand(query, dataBase.GetConnection());

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }

            dataBase.CloseConnection();
        }

        /// <summary>
        /// Закрыть формы.
        /// </summary>
        public void CloseForms(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Создать колонки таблицы.
        /// </summary>
        private void CreateColumn()
        {
            CarDealership.Columns.Add("ManufacurerId", "Производитель");
            CarDealership.Columns.Add("CarBrandId", "Марка");
            CarDealership.Columns.Add("CarColor", "Цвет");
            CarDealership.Columns.Add("CarEngine", "Мощность двигатель (л.с.)");
            CarDealership.Columns.Add("CarTransmisson", "Трансмиссия");
            CarDealership.Columns.Add("CarDriveType", "Привод");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var getManufacturerId = $"SELECT Id FROM Manufacturer WHERE ManufacturerName = '{ManufacturerComboBox.SelectedItem}'";
                var getCarBrandIdQuery = $"SELECT Id From CarBrand WHERE CarBrandName = '{CarBrandComboBox.SelectedItem}'";
                var getManufacturerIdCommand = new SqlCommand(getManufacturerId, dataBase.GetConnection());
                var getCarBrandIdCommand = new SqlCommand(getCarBrandIdQuery, dataBase.GetConnection());

                dataBase.OpenConnection();

                object manufacturerId = getManufacturerIdCommand.ExecuteScalar();
                var manufacturer = Convert.ToInt32(manufacturerId);

                object brandId = getCarBrandIdCommand.ExecuteScalar();
                var brand = Convert.ToInt32(brandId);

                var getIdQuery = $"SELECT * FROM Car WHERE ManufacturerId = {manufacturer} AND CarBrandId = {brand}";

                var getIdCommand = new SqlCommand(getIdQuery, dataBase.GetConnection());

                object carId = getIdCommand.ExecuteScalar();
                var id = Convert.ToInt32(carId);



                var deleteQuery = $"DELETE FROM Car WHERE Id = {id}";
                var deleteCommand = new SqlCommand(deleteQuery, dataBase.GetConnection());
                deleteCommand.ExecuteNonQuery();

                MessageBox.Show("Успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataBase.CloseConnection();
            }

            catch
            {
                MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        /// <summary>
        /// Создать элементы ComboBox производителя авто..
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

        private void Library_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                var row = CarDealership.Rows[selectedRow];

                ManufacturerComboBox.Text = row.Cells[0].Value.ToString();
                CarBrandComboBox.SelectedItem = row.Cells[1].Value.ToString();
                ColorComboBox.SelectedItem = row.Cells[2].Value.ToString();
                CarEngineTextBox.Text = row.Cells[3].Value.ToString();
                CarTransmisson.SelectedItem = row.Cells[4].Value.ToString();
                CarDriveTypeComboBox.SelectedItem = row.Cells[5].Value.ToString();

            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            try
            {
                dataBase.OpenConnection();

                var color = ColorComboBox.SelectedItem.ToString();
                var carEngine = CarEngineTextBox.Text;
                var carTransmisson = CarTransmisson.SelectedItem.ToString();
                var carDriveType = CarDriveTypeComboBox.SelectedItem.ToString();

                var getManufacturerId = $"SELECT Id FROM Manufacturer WHERE ManufacturerName = '{ManufacturerComboBox.SelectedItem}'";
                var getCarBrandIdQuery = $"SELECT Id From CarBrand WHERE CarBrandName = '{CarBrandComboBox.SelectedItem}'";
                var getManufacturerIdCommand = new SqlCommand(getManufacturerId, dataBase.GetConnection());
                var getCarBrandIdCommand = new SqlCommand(getCarBrandIdQuery, dataBase.GetConnection());


                object manufacturerId = getManufacturerIdCommand.ExecuteScalar();
                var manufacturer = Convert.ToInt32(manufacturerId);

                object brandId = getCarBrandIdCommand.ExecuteScalar();
                var brand = Convert.ToInt32(brandId);

                var getIdQuery = $"SELECT * FROM Car WHERE ManufacturerId = {manufacturer} AND CarBrandId = {brand}";

                var getIdCommand = new SqlCommand(getIdQuery, dataBase.GetConnection());

                object carId = getIdCommand.ExecuteScalar();
                var id = Convert.ToInt32(carId);


                var updateQuery = $"UPDATE Car SET ManufacturerId = {manufacturer}, CarBrandId = {brand}, CarColor = '{color}', CarEngine = {carEngine}, CarTransmisson = '{carTransmisson}', CarDriveType = '{carDriveType}' WHERE Id = {id}";
                var updateCommand = new SqlCommand(updateQuery, dataBase.GetConnection());
                updateCommand.ExecuteNonQuery();

                MessageBox.Show("Успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataBase.CloseConnection();
            }

            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(CarDealership);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(CarDealership);
        }

        /// <summary>
        /// Поиск по БД.
        /// </summary>
        /// <param name="dataGridView">Таблица.</param>
        private void Search(DataGridView dataGridView)
        {

            try
            {
                dataGridView.Rows.Clear();
                dataBase.OpenConnection();

                var searchQuery = @"SELECT ManufacturerName, CarBrandName, CarColor, CarEngine, CarTransmisson, CarDriveType 
                            FROM Car
                            INNER JOIN [dbo].[CarBrand] as cb
                            ON Car.CarBrandId = cb.Id
                            INNER JOIN [dbo].[Manufacturer] as m
                            ON Car.ManufacturerId = m.Id
                            WHERE CONCAT (ManufacturerName, CarBrandName, CarColor, CarEngine, CarTransmisson, CarDriveType)
                            LIKE '%" + textBox1.Text + "%'";

                var searchCommand = new SqlCommand(searchQuery, dataBase.GetConnection());
                var reader = searchCommand.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dataGridView, reader);
                }

                reader.Close();

                dataBase.CloseConnection();
            }

            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var creatorForm = new CreatorForm();
            creatorForm.Show();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            var startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }
    }
}
