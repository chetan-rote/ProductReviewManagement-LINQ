using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReviewManagement
{
    class ProductReviewManagement
    {
        /// <summary>
        /// UC8 The data table
        /// </summary>
        public readonly DataTable dataTable = new DataTable();
        /// <summary>
        /// Top rated 3 products are selected from list.
        /// </summary>
        /// <param name="listProductReview">The list product review.</param>
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId: " + list.ProductID + " UserId: " + list.UserID + " Rating: " + list.Rating +
                    " Review: " + list.Review + " IsLike: " + list.isLike);
            }
        }
        /// <summary>
        /// UC3 Finds ratings greater than three of specific products.
        /// </summary>
        /// <param name="listProductReview">The list product review.</param>
        public void RatingsGreaterThanThreeOfSpecificProducts(List<ProductReview> listProductReview)
        {
            var recordedData = from productReview in listProductReview
                               where (productReview.ProductID == 1 || productReview.ProductID == 2 || productReview.ProductID == 4)
                               && productReview.Rating > 3
                               select productReview;
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId: " + list.ProductID + " UserId: " + list.UserID + " Rating: " + list.Rating +
                    " Review: " + list.Review + " IsLike: " + list.isLike);
            }
        }
        /// <summary>
        /// UC4 Gets review count for each ProductId.
        /// </summary>
        /// <param name="listProductReview"></param>
        public void GetReviewsCount(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + ": " + list.Count);
            }
        }
        /// <summary>
        /// UC5 Get only product id and reviews from the list
        /// </summary>
        /// <param name="listProductReview"></param>
        public void GetProductIdAndReview(List<ProductReview> listProductReview)
        {
            var recordedData = from productReview in listProductReview select new { productReview.ProductID, productReview.Review };

            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + ": " + list.Review);
            }
        }
        /// <summary>
        /// UC6 Skips the top five records.
        /// </summary>
        /// <param name="listProductReview">The list product review.</param>
        public void SkipTopFiveRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReview in listProductReview orderby productReview.Rating descending 
                                select productReview).Skip(5);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId: " + list.ProductID + " UserId: " + list.UserID + " Rating: " + list.Rating +
                    " Review: " + list.Review + " IsLike: " + list.isLike);
            }
        }
        /// <summary>
        /// UC8 Insert values in data table from list.
        /// </summary>
        /// <param name="listProductReview"></param>
        public void InsertValuesInDataTable(List<ProductReview> listProductReview)
        {
            dataTable.Columns.Add("ProductID", typeof(int));
            dataTable.Columns.Add("UserID", typeof(int));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("isLike", typeof(bool));

            dataTable.Rows.Add(1, 1, 3, "Nice", true);
            dataTable.Rows.Add(1, 2, 5, "Good", true);
            dataTable.Rows.Add(2, 1, 1, "Bad", false);
            dataTable.Rows.Add(4, 3, 3, "Nice", true);
            dataTable.Rows.Add(3, 4, 2, "Bad", false);
            dataTable.Rows.Add(5, 1, 5, "Good", true);
            dataTable.Rows.Add(6, 5, 3, "Nice", true);
            dataTable.Rows.Add(2, 6, 5, "Good", true);
            dataTable.Rows.Add(8, 5, 2, "Bad", false);
            dataTable.Rows.Add(6, 7, 3, "Nice", true);
            dataTable.Rows.Add(7, 6, 5, "Good", true);
            dataTable.Rows.Add(9, 9, 3, "Nice", true);
            dataTable.Rows.Add(10, 8, 4, "Good", true);
            dataTable.Rows.Add(9, 10, 1, "Bad", false);
            dataTable.Rows.Add(11, 11, 5, "Good", true);
        }
    }
}
