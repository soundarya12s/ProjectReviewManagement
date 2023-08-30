using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReviewManagement
{
    public class Operations
    {
       DataTable table= new DataTable();
        public void RetrieveTopRecords(List<Product> list)
        {
            var result = list.Where(x => x.Rating == 5).Take(3);
            Display(result.ToList());
        }
        public void Display(List<Product> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ProductID + " " + item.UserID + " " + item.Rating + " " + item.Review + " " + item.isLike);
            }
        }
    }
}
