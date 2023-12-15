using ModelLayer.Models;
using RepositoryLayer.EntitIes;

namespace RepositoryLayer.Interfaces
{
    public interface IReviewRepo
    {
        ReviewEntity AddReview(ReviewModel addReview);
    }
}