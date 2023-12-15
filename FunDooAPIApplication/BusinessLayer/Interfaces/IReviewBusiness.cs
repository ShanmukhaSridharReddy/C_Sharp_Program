using ModelLayer.Models;
using RepositoryLayer.EntitIes;

namespace BusinessLayer.Interfaces
{
    public interface IReviewBusiness
    {
        ReviewEntity AddReview(ReviewModel addReview);
    }
}