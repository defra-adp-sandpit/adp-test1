using Adp.Test1.Api.Config;

namespace Adp.Test1.Api.Tests.ConfigTests;
public class AppInsightsConfigTests
{
    [Fact]
    public void AppInsightsConfig_Should_BeDefined()
    {
        // Act
        var config = new AppInsightsConfig
        {
            ConnectionString = "your_connection_string",
            CloudRole = "your_cloud_role"
        };

        // Assert
        config.Should().NotBeNull();
        config.ConnectionString.Should().NotBeNullOrEmpty();
        config.CloudRole.Should().NotBeNullOrEmpty();
    }
}