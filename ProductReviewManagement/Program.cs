/**********************************************************************************
 *  Purpose: This problem will manage product reviews using Language Integrated 
 *  Query both with method and query syntax.
 *
 *
 *  @author  Chetan Rote
 *  @version 1.0
 *  @since   25-11-2020
 **********************************************************************************/
using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problem.");
            /// List for Products.
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=2,Review="Bad",isLike=false},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=2,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=1,UserID=2,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=3,Rating=2,Review="Nice",isLike=true},
                new ProductReview(){ProductID=2,UserID=4,Rating=1,Review="Bad",isLike=false},
                new ProductReview(){ProductID=4,UserID=3,Rating=1,Review="Bad",isLike=false},
                new ProductReview(){ProductID=6,UserID=5,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=6,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=5,UserID=2,Rating=3,Review="Nice",isLike=true}
            };
            /// UC1 Iterating the list and printing product ratings.
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductId: " + list.ProductID + " UserId: " + list.UserID + " Rating: " + list.Rating +
                    " Review: " + list.Review + " IsLike: " + list.isLike);
            }
            /// UC2
            Console.WriteLine("\n Top 3 rated products.");
            ProductReviewManagement product = new ProductReviewManagement();
            product.TopRecords(productReviewList);
            /// UC3
            Console.WriteLine("\n Ratings greater than three of specific products: ");
            product.RatingsGreaterThanThreeOfSpecificProducts(productReviewList);

            // UC4
            Console.WriteLine("\n Review count for each product Id.");
            product.GetReviewsCount(productReviewList);
        }
    }
}
