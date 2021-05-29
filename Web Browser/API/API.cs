using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebBrowser
{
    public class API
    {
        public static class SearchEngineBaseUrl
        {
            public const string Google = "https://www.google.com/search?q=";
        }

        public static bool IsValidUrl(string str)
        {
            return (Uri.IsWellFormedUriString(str, UriKind.Absolute));
        }

        public static string GetUrl(string str, string searchEngineBaseUrl = SearchEngineBaseUrl.Google)
        {
            if (Uri.IsWellFormedUriString(str, UriKind.Absolute))
            {
                return str;
            }
            else
            {
                return string.Format("{0}{1}", searchEngineBaseUrl, str);
            }
        }

        public static Uri GetUri(string str, string searchEngineBaseUrl = SearchEngineBaseUrl.Google)
        {
            return new Uri(GetUrl(str, searchEngineBaseUrl), UriKind.Absolute);
        }
    }
}
