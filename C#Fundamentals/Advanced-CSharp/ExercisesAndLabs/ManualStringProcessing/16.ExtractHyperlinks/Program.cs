using System;
using System.Collections.Generic;
using System.Text;

namespace _16.ExtractHyperlinks
{
    public class Program
    {
        public static void Main()
        {
            var links = new List<string>();

            var htmlSb = new StringBuilder();

            var inpulLine = Console.ReadLine();

            while (inpulLine != "END")
            {
                htmlSb.Append(inpulLine);
                inpulLine = Console.ReadLine();
            }

            var html = htmlSb.ToString()
                .Replace('\n', ' ')
                .Replace('\r', ' ')
                .Replace('\t', ' ');

            var startIndex = html.IndexOf(" href");
  
            while (startIndex >= 0)
            {
                if (!IsAnchorTag(startIndex, html))
                {
                    startIndex = html.IndexOf(" href", startIndex + 1);
                    continue;
                }

                startIndex = html.IndexOf('=', startIndex) + 1;

                if (startIndex <= 0 || startIndex > html.Length)
                {
                    continue;
                }

                var link = GetLink(startIndex, html);

                if (link != null)
                {
                    links.Add(link);
                }

                startIndex = html.IndexOf(" href", html.IndexOf("a>", startIndex));
            }

            if (links.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, links));
            }
        }


        private static string GetLink(int startIndex, string html)
        {
            var linkStarstAt = -1;
            for (int i = startIndex; i < html.Length; i++)
            {
                if (html[i] != ' ')
                {
                    linkStarstAt = i;
                    break;
                }
            }

            var linkEndsAt = -1;
            switch (html[linkStarstAt])
            {
                case '"':
                    linkEndsAt = html.IndexOf('"', linkStarstAt + 1);
                    break;
                case '\'':
                    linkEndsAt = html.IndexOf('\'', linkStarstAt + 1);
                    break;
                default:

                    for (int i = linkStarstAt; i < html.Length; i++)
                    {
                        if (html[i] == '>' || html[i] == ' ')
                        {
                            linkEndsAt = i;
                            break;
                        }
                    }

                    break;
            }

            if (linkStarstAt < 0 || linkEndsAt < 0)
            {
                return null;
            }

            return html
                .Substring(linkStarstAt, linkEndsAt - linkStarstAt)
                .Trim(new char[] { '"', '\'', ' ' });
        }

        private static bool IsAnchorTag(int startLinkIndex, string html)
        {
            var tagOpenIndex = html.LastIndexOf('<', startLinkIndex);
            return html[tagOpenIndex + 1] == 'a';
        }


    }
}

