namespace ApprovalTesting.Demo1.Tests;

public class PersonResponseTests
{
    [Fact]
    public Task PersonRequest_homer_produces_valid_response()
    {
        // Arrange
        var now = DateTime.Now;
        var homer = new PersonRequest(
            "Homer",
            "Simpson",
            39,
            Guid.NewGuid(),
            now,
            now);

        // Act
        var actual = PersonResponse.FromRequest(homer);

        // Assert
        return Verify(actual);
    }
}