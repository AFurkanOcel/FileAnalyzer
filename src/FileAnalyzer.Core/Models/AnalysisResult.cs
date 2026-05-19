using System.Collections.Generic;

namespace FileAnalyzer.Core.Models
{
    public class AnalysisResult
    {
        public int CharacterCount { get; set; }
        public int LineCount { get; set; }
        public int UniqueWordCount { get; set; }
        public Dictionary<string, int> RepeatedWords { get; set; }
        public Dictionary<string, int> PunctuationCounts { get; set; }

        public AnalysisResult()
        {
            RepeatedWords = new Dictionary<string, int>();
            PunctuationCounts = new Dictionary<string, int>();
        }
    }
}
