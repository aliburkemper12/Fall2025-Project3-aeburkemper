namespace Fall2025_Project3_aeburkemper.Models.ViewModels
{
    public class ActorDetailsViewModel
    {
        public Actor Actor { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public List<TweetsWithSentiment> Tweets { get; set; } = new List<TweetsWithSentiment>();
        public double AverageSentiment { get; set; }
    }
    public class TweetsWithSentiment
    {
        public string Text { get; set; }
        public double SentimentScore { get; set; }
    }
}
