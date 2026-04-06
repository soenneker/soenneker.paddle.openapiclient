using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Paddle.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class PaddleOpenApiClientTests : FixturedUnitTest
{
    public PaddleOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
