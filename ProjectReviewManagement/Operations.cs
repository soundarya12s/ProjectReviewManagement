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
      
        public void Display(List<Product> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ProductID + " " + item.UserID + " " + item.Rating + " " + item.Review + " " + item.isLike);
            }
        }
    }
}
