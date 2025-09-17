using OCRenamer.Models;
using System.Data;
using System.Text.RegularExpressions;

namespace OCRenamer;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Go("F:\\Documents\\Source\\Repos\\kellyluck\\OCRenamer\\OCRenamer\\MatineeBnR.json",
           "I:\\Radio Programs\\Bob & Ray\\Matinee With Bob Ray\\RenameUs\\*.mp3");

    }

    public void Go(string ruleSetPath, string filesPath)
    {
        RuleSet ruleSet = RuleLoader.LoadRulesFromJson(ruleSetPath);
        List<FilenameInfo> files = FileFinder.GetFilesFromPattern(filesPath);

        foreach (FilenameInfo file in files)
        {
            string baseName = file.FileNameWithoutExtension;

            foreach (RenameRule renameRule in ruleSet.Rules)
            {
                foreach(string match in renameRule.Find)
                {
                    baseName = Regex.Replace(baseName, match, renameRule.Replace);
                }
            }

            System.Diagnostics.Debug.WriteLine($"'{file.FileNameWithoutExtension}' is now '{baseName}'.");
        }
    }
}
