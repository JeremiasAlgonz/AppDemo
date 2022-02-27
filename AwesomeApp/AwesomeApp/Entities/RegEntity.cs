using SQLite;
using System;

namespace AwesomeApp.Entities
{
    public class RegEntity
    {
        public RegEntity()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Username { get; set; }
        public DateTime BirthDate { get; set; }
        public int Phone { get; set; }
        public char Email { get; set; }
        public string Password { get; set; }

    }
}
