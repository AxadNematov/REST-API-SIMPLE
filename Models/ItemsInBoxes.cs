using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAPIDemo.Controllers;

namespace WebAPIDemo.Models
{
    [Table("items_in_boxes")]
    public class itemsInBoxes
    {
        [Key]
        public int id { get; set; }
        public int box_numb { get; set; }
        public string part_name { get; set; }
        public string part_code { get; set; }
        public string amount { get; set; }
        public string net { get; set; }
        public string gross { get; set; }
        public string id_order { get; set; }
        public string black_id { get; set; }
        public string pl_id { get; set; }
        public string pl_date { get; set; }
        public string invoice_id { get; set; }
        public string invoice_date { get; set; }
    }
}