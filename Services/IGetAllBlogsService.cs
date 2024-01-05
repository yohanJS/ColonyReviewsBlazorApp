using ColonyReviewsBlazorApp.Models;

namespace ColonyReviewsBlazorApp.Services
{
    public interface IGetAllBlogsService
    {
        Task LoadDataAsync();
        List<BlogModel> GetData();
    }
}
