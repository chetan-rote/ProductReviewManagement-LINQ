﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewManagement
{
    class ProductReviewManagement
    {
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
    }
}
