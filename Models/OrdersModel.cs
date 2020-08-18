using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    [Table("orders")]
    public class OrdersModel
    {
        [Key]
        public int id { get; set; }
        public string id_order { get; set; }
        public string customer_order_id { get; set; }
        public string dz_date { get; set; }
        public string c_date { get; set; }
        public string descr { get; set; }
        public string version { get; set; }
        public string com_proposal { get; set; }
        public string contract { get; set; }
        public string remarks { get; set; }
        public string com_proposal_date { get; set; }
        public string contract_date { get; set; }
        public itemsInBoxes items { get; set; }
    }
}