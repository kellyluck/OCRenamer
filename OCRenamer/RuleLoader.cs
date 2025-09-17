using OCRenamer.Models;
using System.Data;
using System.Text.Json;

namespace OCRenamer;

public static class RuleLoader
{
    public static RuleSet LoadRulesFromJson(string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath))
            throw new ArgumentException("File path must not be null or empty.", nameof(filePath));

        if (!File.Exists(filePath))
            throw new FileNotFoundException("The specified JSON file could not be found.", filePath);

        // Read the JSON content
        string json = File.ReadAllText(filePath);

        // Deserialize into a RuleSet object
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        RuleSet ruleSet = JsonSerializer.Deserialize<RuleSet>(json, options);

        // Return the list of rules (or empty list if null)
        return ruleSet ?? new RuleSet();
    }
}
