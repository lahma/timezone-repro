using Xunit;

namespace PrimeService.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
		var pacificTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
		Assert.Equal("Pacific Standard Time", pacificTimeZone.StandardName);
    }
}