using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace UI.ExtensionMethod
{
    public static class StringExtensionMethod
    {
        public static string FixTags(this string inputHtml, string[] allowedTags, string[] allowProperties)
        {

            string fixedHtml = Regex.Replace(inputHtml, "(<.*?)",

                match => fixTag(match, allowedTags, allowProperties),

                RegexOptions.IgnoreCase);

            return fixedHtml;

        }



        private static string fixTag(Match tagMatch, string[] allowedTags, string[] allowProperties)

        {

            string tag = tagMatch.Value;

            Match m = Regex.Match(tag, @"</?(?<tagName>[^\s/]*)[>\s/]",

                RegexOptions.IgnoreCase);

            string tagName = m.Groups["tagName"].Value.ToLower();



            if (Array.IndexOf(allowedTags, tagName) < 0)

            {

                return "";

            }

            else

            {

                return Regex.Replace(tag,

                    @"\S+\s*=\s*[" + "\"|" + @" ']\S*\s*[" + "\"|']",

                    match => fixProperty(match, allowProperties), RegexOptions.IgnoreCase);

            }

        }



        private static string fixProperty(Match propertyMatch, string[] allowProperties)

        {

            string property = propertyMatch.Value;

            Match m = Regex.Match(property,

                @"(?<prop>\S*)(\s*)(?==\s*[" + "\"|'])",

                RegexOptions.IgnoreCase);

            string propertyName = m.Groups["prop"].Value.ToLower();

            if (Array.IndexOf(allowProperties, propertyName) < 0)

            {

                return "";

            }

            return property;

        }
    }
}