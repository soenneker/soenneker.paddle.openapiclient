using Soenneker.Tests.HostedUnit;

namespace Soenneker.Paddle.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PaddleOpenApiClientTests : HostedUnitTest
{
    public PaddleOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
