using OCRenamer.Models;

namespace OCRenamer;

public static class FileFinder
{
    public static List<FilenameInfo> GetFilesFromPattern(string pattern)
    {
        if (string.IsNullOrWhiteSpace(pattern))
            throw new ArgumentException("Pattern must not be null or empty.", nameof(pattern));

        // Split directory and pattern part
        string directory = Path.GetDirectoryName(pattern);
        string searchPattern = Path.GetFileName(pattern);

        if (string.IsNullOrEmpty(directory))
            directory = Directory.GetCurrentDirectory(); // fallback if no path specified

        if (string.IsNullOrEmpty(searchPattern))
            searchPattern = "*"; // default to all files

        var results = new List<FilenameInfo>();

        foreach (var file in Directory.GetFiles(directory, searchPattern))
        {
            string dir = Path.GetDirectoryName(file) ?? "";
            string fileNameNoExt = Path.GetFileNameWithoutExtension(file);
            string ext = Path.GetExtension(file).TrimStart('.');

            results.Add(new FilenameInfo
            {
                FullPath = file,
                DirectoryPath = dir + Path.DirectorySeparatorChar,
                FileNameWithoutExtension = fileNameNoExt,
                Extension = ext
            });
        }

        return results;
    }
}
