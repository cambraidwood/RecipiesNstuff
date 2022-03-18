namespace RecipiesNstuff.Domain.Extentions
{
    public static class stringExtensions
    {

        public static string CreateUrl(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {

                if (!str.ToLower().StartsWith("http://") && !str.ToLower().StartsWith("https://")) {
                    str = "http://" + str;
                }

                var result = Uri.TryCreate(str, UriKind.Absolute, out var url);

                if (!result)
                {
                    return string.Empty;
                }

                return url != null ? url.ToString() : string.Empty;
            }

            return string.Empty;
        }
    }
}
