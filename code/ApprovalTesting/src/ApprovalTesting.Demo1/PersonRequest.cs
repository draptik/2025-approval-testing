namespace ApprovalTesting.Demo1;

public record PersonRequest(
    string FirstName,
    string LastName,
    int Age,
    Guid Id,
    DateTime CreatedAt,
    DateTime? UpdatedAt);