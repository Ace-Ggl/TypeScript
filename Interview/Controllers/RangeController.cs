using Interview.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace Interview.Controllers
{
    public class RangeController : Controller, IRangeController
    {
        // GET /Range/List?name=manufacturer
        public ActionResult List(string name)
        {
            name = name ?? "BMW";
            var model = new List<RangeModel>();
            ViewBag.Manufacturer = name;

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (var command = new SqlCommand("dbo.GetRangeByManufacturerName", connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@manufacturerName", name);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        model.Add(new RangeModel
                        {
                            CarModelName = reader.GetString(1),
                            CarImageName = reader.IsDBNull(3) ? string.Empty : reader.GetString(3)
                        });
                    }
                }
            }

            return View(model);
        }
    }
}
