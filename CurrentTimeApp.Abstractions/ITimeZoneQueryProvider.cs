namespace CurrentTimeApp.Abstractions;

public interface ITimeZoneQueryProvider
{
    public IEnumerable<String> GetTimeZones();
}
