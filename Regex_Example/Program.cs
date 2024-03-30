using System.Globalization;
using System.Text.RegularExpressions;

//Console.WriteLine(Regex.IsMatch("view", @"views?"));
//Console.WriteLine(Regex.IsMatch("views", @"views?"));

//Console.WriteLine("----------------------------------------");

//var pattern = @"views?";
//var text = "I have two words: view for 1 and views for multiple check";
//Console.WriteLine(text);

//var match = Regex.Match(text, pattern);
//Console.WriteLine(match.Success);
//Console.WriteLine(match.Index);
//Console.WriteLine(match.Length);
//Console.WriteLine(match.Value);

//Console.WriteLine("----------------Next----------------");

//var nextMatch = match.NextMatch();
//Console.WriteLine(nextMatch.Success);
//Console.WriteLine(nextMatch.Index);
//Console.WriteLine(nextMatch.Length);
//Console.WriteLine(nextMatch.Value);

// *********************************************************************************

//var pattern = @"program(ming|mer|s)?";
//Console.WriteLine(Regex.IsMatch("program", pattern));
//Console.WriteLine(Regex.IsMatch("programd", pattern));
//var m = Regex.Match("programd", pattern);
//Console.WriteLine(Regex.IsMatch("programs", pattern));
//Console.WriteLine(Regex.IsMatch("programmer", pattern));
//Console.WriteLine(Regex.IsMatch("programming", pattern));
//Console.WriteLine(Regex.IsMatch("my prog", pattern));

// *********************************************************************************

//Console.WriteLine("----------------[abcd][^abcd]----------------");

//Console.WriteLine(Regex.IsMatch("cat", @"[ab]"));
//var matches1 = Regex.Matches("cat", @"[ab]");

//Console.WriteLine(Regex.IsMatch("cat", @"[^ab]"));
//var matches2 = Regex.Matches("cat", @"[^ab]");

//Console.WriteLine("----------------[a-z][^a-z]----------------");

//Console.WriteLine(Regex.IsMatch("067286639H", @"[^0-9]"));
//Console.WriteLine(Regex.IsMatch("yaxrzbiadx", @"[a-x]?[^x-z]"));
//var matches3 = Regex.Matches("yaxrzbiadx", @"[a-x]?[^x-z]");

//Console.WriteLine(@"----------------\p{category} -- \P{category}----------------");

//Console.WriteLine(Regex.IsMatch("Google.com $R", @"\p{Sc}\p{Lu}"));
//var matches4 = Regex.Matches("Google.com $R", @"\p{Sc}\p{Lu}");

//Console.WriteLine(Regex.IsMatch("MOHSEn", @"\p{Lu}"));
//var matches5 = Regex.Matches("MOHSEn", @"\p{Lu}");

//Console.WriteLine(@"----------------\d -- \D----------------"); // 0-9

//Console.WriteLine(Regex.IsMatch("1 hour", @"\d"));
//var matches6 = Regex.Matches("1 hour", @"\d");

//Console.WriteLine(Regex.IsMatch("1mm", @"\D"));
//var matches7 = Regex.Matches("1mm", @"\D");

//Console.WriteLine(@"----------------\w -- \W----------------"); // a-z A-Z 0-9 _

//Console.WriteLine(Regex.IsMatch("hello world", @"\w"));
//var matches8 = Regex.Matches("hello world", @"\w");

//Console.WriteLine(Regex.IsMatch("hello123_^", @"\W"));
//var matches9 = Regex.Matches("hello123_^", @"\W");

//Console.WriteLine(@"----------------\s -- \S----------------");

//Console.WriteLine(Regex.IsMatch("  ", @"\s"));
//var matches10 = Regex.Matches("  ", @"\s");

//Console.WriteLine(Regex.IsMatch(" m126_ ", @"\S"));
//var matches11 = Regex.Matches(" m126_ ", @"\S");

//Console.WriteLine(@"----------------\n -- .----------------");

//Console.WriteLine(Regex.IsMatch("\n ali \n", @"\n"));
//var matches12 = Regex.Matches("\n ali \n", @"\n");

//Console.WriteLine(Regex.IsMatch("\n\nl d", @".?\w"));
//var matches13 = Regex.Matches("\n\nl d", @".?\w");

// *********************************************************************************

//Console.WriteLine("---------------Quantifiers---------------"); // ? * + {n} {n,} {n,n}

//Console.WriteLine(Regex.IsMatch("apple", @"apple(s)?")); // ? for 0 or 1 rep
//Console.WriteLine(Regex.IsMatch("apples", @"apple(s)?"));
//var matches1 = Regex.Matches("applessss", @"apple(s)?");

//Console.WriteLine(Regex.IsMatch("bnan", @"bnan(a)*")); // * for 0 or more reps
//Console.WriteLine(Regex.IsMatch("bnana", @"bnan(a)*"));
//var matches2 = Regex.Matches("bnanaaaa", @"bnan(a)*");

//Console.WriteLine(Regex.IsMatch("bnan", @"bnan(a)+")); // + for 1 or more reps
//Console.WriteLine(Regex.IsMatch("bnanaaaa", @"bnan(a)+"));
//var matches3 = Regex.Matches("bnanaaaa", @"bnan(a)+");

//Console.WriteLine(Regex.IsMatch("apple", @"e{1}")); // {n} for exactly n reps
//Console.WriteLine(Regex.IsMatch("appleeee", @"e{2}"));
//Console.WriteLine(Regex.IsMatch("programmming", @"progra(m){3}ing"));

//Console.WriteLine(Regex.IsMatch("committ", @"t{2,}")); // {n,} for at least n reps
//var matches4 = Regex.Matches("committt", @"commi(t){2}");
//var matches5 = Regex.Matches("committt", @"\w*t{2,}");
//var matches6 = Regex.Matches("committt", @".*t{2,}");
//var matches7 = Regex.Matches("committt", @"\S*t{2,}");

//Console.WriteLine(Regex.IsMatch("acommitttttttt", @"[a-z]{2}(m){1,2}[a-z]{1}(t){3,4}")); // {n,n} for between n and n reps
//Console.WriteLine(Regex.IsMatch("programmming", @"progra(m){1,2}ing"));
//var matches8 = Regex.Matches("acommitttttttt", @"[a-z]{2}(m){1,2}[a-z]{1}(t){3,4}");

// *********************************************************************************

//Console.WriteLine("Please enter your email address:");

//var email = Console.ReadLine();
//if (IsEmailFormatValidationPassedForText(email))
//{
//    Console.WriteLine("Email format is correct.");
//}
//else
//{
//    Console.WriteLine("Incorrect email format!...");
//}

//bool IsEmailFormatValidationPassedForText(string email)
//{
//    var regex = new Regex(@"(\w[^_])+(@){1}.{1,6}(com){1}");
//    var matches = regex.Matches(email);
//    return matches.Count > 0;
//}

// *********************************************************************************

//var text = "<p>Hello Mohsen</p> <b>bold text</b> <p>Hello Ali</p>";

//var greedyPattern = @"<p>.*</p>";
//var greedyMatches = Regex.Matches(text, greedyPattern);
//Console.WriteLine($"Greedy matches: {greedyMatches[0]}");

//var lazyPattern = @"<p>.*?</p>";
//var lazyMatches = Regex.Matches(text, lazyPattern);
//Console.WriteLine($"Lazy matches: {lazyMatches[0]} {lazyMatches[1]}");

// *********************************************************************************

Console.WriteLine("---------------Word boundry assertion----------------"); // \b and \B

var text1 = "I have a cat.It acatches mouse and crow for eat.I have a acatalog.";
var matches1 = Regex.Matches(text1, @"\Bcat\B");

foreach (Match match in matches1)
{
    Console.WriteLine($"Found {match.Value} at position {match.Index} for word boundry assertion.");
}

Console.WriteLine("---------------Look ahead assertion----------------"); // (?=) for positive and (?!) for negative

var text2 = "I have applepie and apple juice at the apple farm.";
var matches2 = Regex.Matches(text2, @"apple(?=pie)");

foreach (Match match in matches2)
{
    Console.WriteLine($"Found {match.Value} at position {match.Index} for positive look ahead assertion.");
}

var matches3 = Regex.Matches(text2, @"apple(?!pie)");

foreach (Match match in matches3)
{
    Console.WriteLine($"Found {match.Value} at position {match.Index} for negative look ahead assertion.");
}

Console.WriteLine("---------------Look behind assertion----------------"); // (?<=) for positive and (?<!) for negative

var text3 = "The sky is blue and the grass is green.blue    color";
var matches4 = Regex.Matches(text3, @"(?<=blue\s+)\b\w+\b");

foreach (Match match in matches4)
{
    Console.WriteLine($"Found {match.Value} at position {match.Index} for positive look behind assertion.");
}

var matches5 = Regex.Matches(text3, @"(?<!blue\s+)\b\w+\b");

foreach (Match match in matches5)
{
    Console.WriteLine($"Found {match.Value} at position {match.Index} for negative look behind assertion.");
}

Console.ReadLine();