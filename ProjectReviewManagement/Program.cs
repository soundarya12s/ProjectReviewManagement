using System;
namespace ProjectReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();
            List<Product> list= new List<Product>();
            list.Add(new Product()
            {
                ProductID = 1,
                UserID = 1,
                Rating=5,
                Review="Good",
                isLike=true
            });
            list.Add(new Product()
            {
                ProductID = 2,
                UserID = 2,
                Rating = 3,
                Review = "Avg",
                isLike = true
            });
            list.Add(new Product()
            {
                ProductID = 3,
                UserID = 3,
                Rating = 1,
                Review = "Bad",
                isLike = false
            });
            list.Add(new Product()
            {
                ProductID = 4,
                UserID = 4,
                Rating = 5,
                Review = "Very good",
                isLike = true
            });

            list.Add(new Product()
            {
                ProductID = 5,
                UserID = 5,
                Rating = 1,
                Review = "Very Bad",
                isLike = false
            });
            list.Add(new Product()
            {
                ProductID = 6,
                UserID = 6,
                Rating = 2,
                Review = "Bad",
                isLike = false
            });
            list.Add(new Product()
            {
                ProductID = 7,
                UserID = 7,
                Rating = 4,
                Review = "good",
                isLike = true
            });
            list.Add(new Product()
            {
                ProductID = 8,
                UserID = 8,
                Rating = 4,
                Review = "Good",
                isLike = true
            });
            list.Add(new Product()
            {
                ProductID = 9,
                UserID = 9,
                Rating = 3,
                Review = "Avg",
                isLike = true
            });
            list.Add(new Product()
            {
                ProductID = 10,
                UserID = 10,
                Rating = 4,
                Review = "Good",
                isLike = true
            });
            list.Add(new Product()
            {
                ProductID = 11,
                UserID = 11,
                Rating = 2,
                Review = "Bad",
                isLike = false
            });
            list.Add(new Product()
            {
                ProductID = 12,
                UserID = 12,
                Rating = 2,
                Review = "Bad",
                isLike = false
            });
            list.Add(new Product()
            {
                ProductID = 13,
                UserID = 13,
                Rating = 3,
                Review = "Avg",
                isLike = false
            });
            list.Add(new Product()
            {
                ProductID = 14,
                UserID = 14,
                Rating = 3,
                Review = "Avg",
                isLike = false
            });
            list.Add(new Product()
            {
                ProductID = 15,
                UserID = 15,
                Rating = 3,
                Review = "Avg",
                isLike = false
            });

            op.RetrieveTopRecords(list);
            op.RetrieveAllRecordsWithCondition(list);
            
        }
    }
}