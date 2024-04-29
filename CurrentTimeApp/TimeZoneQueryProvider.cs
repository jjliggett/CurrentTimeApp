using CurrentTimeApp.Abstractions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;

namespace CurrentTimeApp;

public class TimeZoneQueryProvider : ITimeZoneQueryProvider
{
    public NavigationManager NavManager;

    public TimeZoneQueryProvider(NavigationManager navManager)
    {
        NavManager = navManager;
    }

    public IEnumerable<String> GetTimeZones()
    {
        var uri = NavManager.ToAbsoluteUri(NavManager.Uri);

        var queryValues = QueryHelpers.ParseQuery(uri.Query);

        if (queryValues.TryGetValue("timeZone", out var timeZoneStringValues))
        {
            return (ICollection<string>) timeZoneStringValues.AsEnumerable();
        }

        return [];
    }
}
