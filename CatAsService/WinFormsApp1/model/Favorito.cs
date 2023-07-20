using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.model
{
    public class Favorito
    {
        public int id { get; set; }
        public string? user_id { get; set; }
        public string? image_id { get; set; }
        public string? sub_id { get; set; }
        public DateTime created_at { get; set; }

        public override string? ToString()
        {
            return $"id:{id}, sub_id:{sub_id}";
        }
    }
}
