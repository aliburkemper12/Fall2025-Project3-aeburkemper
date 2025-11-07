namespace Fall2025_Project3_aeburkemper.Services
{
    public interface IAIService
    {
        Task<List<string>> GenerateMovieReviews(string movieTitle, int count = 10);
        Task<List<string>> GenerateActorTweets(string actorName, int count = 20);
    }
}
