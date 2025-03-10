using System.Text.Json;

namespace ApprovalTesting.Demo2.Tests;

public class JsonTests
{
    private const string InvalidJson = """{ "FirstName": "Homer" """;

    [Fact(Skip = "This does not fail fast, because the input is an invalid JSON")]
    public Task Invalid_json_demo1() =>
        Verify(InvalidJson);

    [Fact(Skip = "This fails fast, because the input is an invalid JSON")]
    public Task Invalid_json_demo2() =>
        VerifyJson(InvalidJson);

    [Fact]
    public Task Person_serialization_demo()
    {
        var person = new Person(
            "Homer",
            "Simpson",
            39,
            Guid.NewGuid(),
            DateTime.UtcNow,
            null);

        var json = JsonSerializer.Serialize(person);
        return VerifyJson(json);
    }

    [Fact]
    public Task Valid_Json_using_language_injection() =>
        VerifyJson(SampleJson);

    [LanguageInjection(InjectedLanguage.JSON)]
    private const string SampleJson =
        """
        {
          "FirstName": "Homer",
          "LastName": "Simpson",
          "Age": 39,
          "Id": "00000000-0000-0000-0000-000000000000",
          "DateOfBirth": "2021-10-01T00:00:00",
          "Address": null
        }
        """;
}