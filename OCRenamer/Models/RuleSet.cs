namespace OCRenamer.Models;
public class RuleSet
{
    public List<RenameRule> Rules { get; set; }
}

public class RenameRule
{
    public List<string> Find { get; set; }
    public string Replace { get; set; }
}
