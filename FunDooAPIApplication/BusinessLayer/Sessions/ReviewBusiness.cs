using BusinessLayer.Interfaces;
using ModelLayer.Models;
using RepositoryLayer.EntitIes;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Sessions
{
    public class ReviewBusiness : IReviewBusiness
    {
        private readonly IReviewRepo reviewRepo;
        public ReviewBusiness(IReviewRepo reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }
        public ReviewEntity AddReview(ReviewModel addReview)
        {
            return reviewRepo.AddReview(addReview);
        }

    }
}
