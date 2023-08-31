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

        public void RetrieveAllRecordsWithCondition(List<Product> list)
        {
            var result = list.Where(x => x.Rating > 3 && (x.ProductID == 1 || x.ProductID == 4 || x.ProductID == 9));
            Display(result.ToList());
        }

        public void UsingGroupBy(List<Product> list)
        {
            var result = list.GroupBy(x => x.ProductID).Select(x => new(ProductId = x.Key, Count = x.Count()));
            foreach(var data in result)
            {
                Console.WriteLine(data.ProductId+" "+data.Count);
            }
        }

        public void RetrieveProductIdAndReview(List<Product> list)
        {
            var result = list.Skip(5);
            Display(result.ToList());
        }

         public void RetrieveRecordsFromDataTable()
        {
            var result = table.AsEnumerable().Where(x => x.Field<bool>("isLike").Equals(true));
            foreach(var item in result.AsEnumerable())
            {
                Console.WriteLine(item.Field<int>("ProductId"));
            }
        }

        public void AvgRating(List<Product> list)
        {
            var result = list.Average(x => x.Rating);
            Console.WriteLine(result);
        }

        public void RetreieUsingReview(List<Product> list)
        {
            var result = list.Where(x => x.Review.Equals("Good"));
            Display(result.ToList());
        }

        public void RetreiveUsingRating(List<Product> list)
        {
            var result = list.Where(x => x.UserID.Equals(10)).OrderBy(x => x.Rating);
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
