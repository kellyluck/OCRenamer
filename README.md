# OCRenamer

Basically, a tool for doing mass renaming of files using a JSON-based ruleset.

I like old-time radio (OTR) shows, but collecting them can be a bit of a pill sometimes because you dig them up from different sources, all of whom have their own ideas of how to name files. This tool is designed to take files from disparate sources and reformat them according to the rule file.

Every rule is basically one or more regular expressions to match, followed by another regular expression describing how it should be modified. It can be as simple as basic string substitution or as complex as slicing a date into its individual components and putting them together differently. The sample json file included in this project has some good starter rules that you can use to make your own.

Some use notes:
* If you check "Dry run only", it'll do everything but won't actually rename/copy files. This is chiefly so you can make sure the rules are going to do what you think they're going to do.
* You can't edit the ruleset inside the program. I may add that later, but as of now, that's outside the scope. I suggest Notepad++ or a similar program to set your json file up.

Any bugs/suggestions for improvement/etc, drop me an issue. Thanks and enjoy.
