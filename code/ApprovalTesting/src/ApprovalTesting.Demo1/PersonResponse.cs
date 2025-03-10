namespace ApprovalTesting.Demo1;

public record PersonResponse(
    string FirstName,
    string LastName,
    int Age,
    Guid Id,
    DateTime CreatedAt,
    DateTime? UpdatedAt)
{
    public static PersonResponse FromRequest(PersonRequest request) =>
        new(
            request.FirstName,
            request.LastName,
            request.Age,
            request.Id,
            request.CreatedAt,
            request.UpdatedAt);
}