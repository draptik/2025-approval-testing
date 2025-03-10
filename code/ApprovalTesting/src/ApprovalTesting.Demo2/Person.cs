namespace ApprovalTesting.Demo2;

public record Person(
    string FirstName,
    string LastName,
    int Age,
    Guid Id,
    DateTime CreatedAt,
    DateTime? UpdatedAt);