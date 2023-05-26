using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MiloserdovExam
{
    /// <summary>
    /// Валидация входных данных.
    /// </summary>
    public static class Validator
    {

        /// <summary>
        /// Проверка на корректную дату.
        /// </summary>
        /// <param name="createdYear">Дата создания.</param>
        /// <param name="author">ФИО автора.</param>
        /// <returns>Результат (true / false).</returns>
        public static bool IsCorrectCreatedYear(int createdYear, string author)
        {

            var dataBase = new DataBase();
            dataBase.OpenConnection();

            var birthdayQuery = $"SELECT Birthday FROM Author WHERE Fullname = '{author}'";
            var deathdateQuery = $"SELECT Deathdate FROM Author WHERE Fullname = '{author}'";
            var birthdayQueryCommand = new SqlCommand(birthdayQuery, dataBase.GetConnection());
            var deathdateQueryCommand = new SqlCommand(deathdateQuery, dataBase.GetConnection());

            object deathdate = deathdateQueryCommand.ExecuteScalar();
            var deathdateDate = deathdate.ToString();
            var deathdateYear = Convert.ToInt32(deathdateDate.Split('.')[2]);

            object birthday = birthdayQueryCommand.ExecuteScalar();
            var birthdayDate = birthday.ToString();
            var birthdayYear = Convert.ToInt32(birthdayDate.Split('.')[2]);

            if (createdYear < birthdayYear || createdYear > deathdateYear)
            {
                return false;
            }

            return true;
        }
    }
}
