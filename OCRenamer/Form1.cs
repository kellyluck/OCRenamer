using OCRenamer.Models;
using System.Text;
using System.Text.RegularExpressions;

namespace OCRenamer;

/* TODO:
 * multi-column log
 * Filter by file extension
 */

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtRulesetFilename.Text))
        {
            MessageBox.Show("Please select a ruleset file first.");
            return;
        }

        if (String.IsNullOrEmpty(txtDirectory.Text))
        {
            MessageBox.Show("Please select a directory first.");
        }

        if (rbCopy.Checked && String.IsNullOrEmpty(txtCopyDirectory.Text)) {
            MessageBox.Show("Please select the directory you want to copy to.");
        }

        string destination = rbCopy.Checked ? txtCopyDirectory.Text : txtDirectory.Text;

        Go(txtRulesetFilename.Text, txtDirectory.Text,destination,chkOverwrite.Checked,chkDryRun.Checked);
        //Go("F:\\Documents\\Source\\Repos\\kellyluck\\OCRenamer\\OCRenamer\\MatineeBnR.json",
        //   "I:\\Radio Programs\\Bob & Ray\\Matinee With Bob Ray\\*.mp3",
        //   "I:\\Radio Programs\\Bob & Ray\\Matinee With Bob Ray\\RenameUs\\",
        //   true);

    }

    public void Go(string ruleSetPath, string filesPath, string destinationPath, bool overwriteExisting,bool dryRun)
    {
        RuleSet ruleSet = RuleLoader.LoadRulesFromJson(ruleSetPath);
        List<FilenameInfo> files = FileFinder.GetFilesFromPattern(filesPath + "\\*.*");
        lstLog.Items.Clear();

        foreach (FilenameInfo file in files)
        {
            string baseName = file.FileNameWithoutExtension;

            foreach (RenameRule renameRule in ruleSet.Rules)
            {
                foreach (string match in renameRule.Find)
                {
                    baseName = Regex.Replace(baseName, match, renameRule.Replace);
                }
            }

            string log=($"'{file.FileNameWithoutExtension}' is now '{baseName}'.");
            lstLog.Items.Add(log);
            lstLog.SelectedIndex =lstLog.Items.Count - 1;
            lstLog.Invalidate();

            string newPath = Path.Combine(destinationPath, $"{baseName}.{file.Extension}");

            if (!dryRun)
            {
                if (file.DirectoryPath.Equals(destinationPath))
                {
                    // direct rename
                    if ((!File.Exists(newPath)) || (File.Exists(newPath) && overwriteExisting))
                        File.Copy(file.FullPath, newPath, overwriteExisting);
                }
                else
                {
                    // copy to different directory
                    if (!Directory.Exists(destinationPath))
                        Directory.CreateDirectory(destinationPath);

                    if ((!File.Exists(newPath)) || (File.Exists(newPath) && overwriteExisting))
                        File.Copy(file.FullPath, newPath, overwriteExisting);
                }
            }
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnLoadRuleset_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            DefaultExt = "json",
            InitialDirectory = AppDomain.CurrentDomain.BaseDirectory
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string fileName = openFileDialog.FileName;
            StringBuilder rulesetText = new StringBuilder();
            txtRulesetFilename.Text = fileName;

            if (File.Exists(fileName))
            {
                using (StreamReader streamReader = new StreamReader(fileName))
                {
                    txtRulesetPreview.Text = streamReader.ReadToEnd();
                }
            }

        }
    }

    private void btnDirSelect_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog dialog = new FolderBrowserDialog()
        {
            InitialDirectory = AppDomain.CurrentDomain.BaseDirectory
        };

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            txtDirectory.Text = dialog.SelectedPath;
        }
    }

    private void btnSelectCopyDirectory_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog dialog = new FolderBrowserDialog()
        {
            InitialDirectory = AppDomain.CurrentDomain.BaseDirectory
        };

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            txtCopyDirectory.Text = dialog.SelectedPath;
        }
    }
}
