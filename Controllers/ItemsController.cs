using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebAPIDemo.Models;


namespace WebAPIDemo.Controllers
{
    public class ItemsController : ApiController
    {
        //GET: api/Items
        public IHttpActionResult GetAllItems( string id_order)
        {
            var db = new Context();
            var query1 = (from orders in db.Orders
                          where orders.id_order == id_order
                          select new
                          {
                              id_order = orders.id_order,
                              items=(from items in db.ItemsInBoxes where items.id_order == orders.id_order select new {part_code=items.part_code, part_name=items.part_name, id_order=items.id_order})
                          });
            return Ok(query1);
        }
        // POST: api/Items
        [System.Web.Http.HttpPost]
        public void Post([FromBody] List<itemsInBoxes> items)
        {
            var db = new Context();
            for(int i =0; i<items.Count; i++)
            {
                db.ItemsInBoxes.Add(items[i]);
                db.SaveChanges();
            }
        }
        // PUT: api/items
        [System.Web.Http.HttpPut]
        public void Put([FromBody] itemsInBoxes item)
        {
            var db = new Context();
            List<itemsInBoxes> obj = db.ItemsInBoxes.Where(n => n.part_name == item.part_name).ToList();
            foreach(itemsInBoxes i in obj)
            {
                i.amount = "200";
            }
            db.SaveChanges();
        }
    }
}
