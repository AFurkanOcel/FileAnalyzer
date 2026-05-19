using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileAnalyzer.Core.Models;

namespace FileAnalyzer.Core
{
    public class TextAnalyzer
    {
        private static readonly string[] Conjunctions = { "ve", "ile", "ama", "ancak" };
        private static readonly string[] Punctuation = { ".", ",", ";", ":", "-", "_", "|", "<", ">", "!", "?", "#", "%", "/", "=", "*", "+", "{", "[", "]", "}", "(", ")", "'" };

        public AnalysisResult Analyze(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("File is empty!", nameof(content));
            }

            var words = content.Split(' ', '\n', '\r');
            var filteredWords = new List<string>();
            var punctuationAndCounts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string lowercaseWord = word.ToLower().Trim();
                bool isNumber = int.TryParse(lowercaseWord, out _);

                if (!string.IsNullOrWhiteSpace(lowercaseWord) && !Conjunctions.Contains(lowercaseWord) && !isNumber && !Punctuation.Contains(lowercaseWord))
                {
                    filteredWords.Add(lowercaseWord);
                }

                foreach (var punctuation in Punctuation)
                {
                    if (lowercaseWord.Contains(punctuation))
                    {
                        if (punctuationAndCounts.ContainsKey(punctuation))
                        {
                            punctuationAndCounts[punctuation]++;
                        }
                        else
                        {
                            punctuationAndCounts[punctuation] = 1;
                        }
                    }
                }
            }

            var repeatedWords = filteredWords
                .GroupBy(word => word)
                .Where(group => group.Count() > 1)
                .OrderByDescending(group => group.Count())
                .ToDictionary(group => group.Key, group => group.Count());

            return new AnalysisResult
            {
                CharacterCount = content.Length,
                LineCount = content.Split('\n').Length,
                UniqueWordCount = filteredWords.Distinct().Count(),
                RepeatedWords = repeatedWords,
                PunctuationCounts = punctuationAndCounts.OrderByDescending(entry => entry.Value).ToDictionary(entry => entry.Key, entry => entry.Value)
            };
        }

        public string AnalyzeFile(string content)
        {
            return Format(Analyze(content));
        }

        public string Format(AnalysisResult result)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Character Count: {result.CharacterCount}");
            sb.AppendLine($"Line Count: {result.LineCount}");
            sb.AppendLine($"Unique Word Count: {result.UniqueWordCount}");
            sb.AppendLine();
            sb.AppendLine("Repetitive Words");
            sb.AppendLine("----------------");

            foreach (var word in result.RepeatedWords)
            {
                sb.AppendLine($"{word.Value}  {word.Key}");
            }

            sb.AppendLine();
            sb.AppendLine("Punctuation Counts");
            sb.AppendLine("------------------");

            foreach (var punctuation in result.PunctuationCounts)
            {
                sb.AppendLine($"{punctuation.Key} : {punctuation.Value}");
            }

            return sb.ToString();
        }
    }
}
