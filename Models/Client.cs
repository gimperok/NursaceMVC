namespace NursaceMVC.Models
{
    /// <summary>
    /// Класс описывающий клиента
    /// </summary>
    public class Client
    {
        public Client(int id, string name, string surname, string country, string city, string cargo, string tel)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Country = country;
            City = city;
            Cargo = cargo;
            Tel = tel;
        }
        /// <summary>
        /// id клиента
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string Surname { get; set; } = string.Empty;

        /// <summary>
        /// Страна клиента
        /// </summary>
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// Город клиента
        /// </summary>
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Транспортная компания клиента
        /// </summary>
        public string Cargo { get; set; } = string.Empty;

        /// <summary>
        /// Телефон клиента
        /// </summary>
        public string Tel { get; set; } = string.Empty;

    }
}
