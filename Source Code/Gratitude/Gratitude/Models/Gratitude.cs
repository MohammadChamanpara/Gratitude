using System;
using SQLite;

namespace Gratitude.Models
{
    public class Gratitude
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}