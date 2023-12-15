using ModelLayer.Models;
using RepositoryLayer.Context;
using RepositoryLayer.EntitIes;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace RepositoryLayer.Sessions
{
    public class ReviewRepo : IReviewRepo
    {
        private readonly FunDooContext funDooContext;
        public ReviewRepo(FunDooContext funDooContext)
        {
            this.funDooContext = funDooContext;
        }
        public ReviewEntity AddReview(ReviewModel addreview)
        {
            ReviewEntity reviewEntity = new ReviewEntity();
            reviewEntity.Id = 1;
            reviewEntity.Comment = addreview.Comment;
            reviewEntity.Rating = addreview.Rating;
            funDooContext.Review.Add(reviewEntity);
            funDooContext.SaveChanges();
            return reviewEntity;
        }
    }
}
