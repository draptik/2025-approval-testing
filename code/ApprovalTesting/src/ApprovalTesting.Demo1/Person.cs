namespace ApprovalTesting.Demo1;

public record Person(
    string FirstName,
    string LastName,
    int Age,
    Guid Id,              // 👈
    DateTime? AquiredAt,  // 👈
    DateTime CreatedAt,   // 👈
    DateTime? UpdatedAt); // 👈