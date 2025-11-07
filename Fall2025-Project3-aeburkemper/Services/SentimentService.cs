using VaderSharp2;

namespace Fall2025_Project3_aeburkemper.Services
{
    public class SentimentService : ISentimentService
    {
        private readonly SentimentIntensityAnalyzer _analyzer;

        public SentimentService()
        {
            _analyzer = new SentimentIntensityAnalyzer();
        }

        public double AnalyzeSentiment(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0.0;
            }

            var results = _analyzer.PolarityScores(text);
            return results.Compound;
        }
    }
}
