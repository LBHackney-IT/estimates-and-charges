using EstimatesAndActuals.V1.Gateways;
using EstimatesAndActuals.V1.UseCase;
using Moq;
using NUnit.Framework;

namespace EstimatesAndActuals.Tests.V1.UseCase
{
    public class GetByIdUseCaseTests : LogCallAspectFixture
    {
        private Mock<IDynamoDbGateway> _mockGateway;
        private GetByIdUseCase _classUnderTest;

        [SetUp]
        public void SetUp()
        {
            _mockGateway = new Mock<IDynamoDbGateway>();
            _classUnderTest = new GetByIdUseCase(_mockGateway.Object);
        }

        //TODO: test to check that the use case retrieves the correct record from the database.
        //Guidance on unit testing and example of mocking can be found here https://github.com/LBHackney-IT/lbh-estimates-and-actuals/wiki/Writing-Unit-Tests
    }
}
