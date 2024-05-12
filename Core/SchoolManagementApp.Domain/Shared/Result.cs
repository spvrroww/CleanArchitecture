namespace SchoolManagementApp.Domain.Shared;
public record Result(bool IsSuccessful, string Message);
public record SuccessResult():Result(true, "Successful");
public record FailureResult(string errorMessage):Result(false, errorMessage);
public record Result<TResponse>(TResponse Data, bool IsSuccessful, string Message) : Result(IsSuccessful, Message);