using CurrentTimeApp.Abstractions;

namespace CurrentTimeApp.MauiBlazor;

internal class TimeZoneQueryProvider : ITimeZoneQueryProvider
{
    public IEnumerable<String> GetTimeZones()
    {
        return [];
    }
}
