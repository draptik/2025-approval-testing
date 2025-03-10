namespace ApprovalTesting.Demo1.Tests;

public class PersonTests
{
    [Fact]
    public Task Handle_randomness()
    {
        var now = DateTime.Now;
        var anotherDate = DateTime.Now;
        var homer = new Person(
            "Homer",
            "Simpson",
            39,
            Guid.NewGuid(),        // 👈
            anotherDate,    // 👈
            now,                      // 👈
            now);           // 👈

        return Verify(homer);
    }
}