using System.ComponentModel.DataAnnotations;

namespace WebApplication_RegexTest.Models;

public class RegisterUserDto
{
    //[RegularExpression(@"^[\u0600-\u06FF\u200C\s]{2,}$")] // Persian
    [RegularExpression(@"^[a-zA-Z\s]{2,}$")] // English
    public required string FullName { get; set; }

    //[RegularExpression(@"^[a-zA-Z0-9._]{2,}@[a-zA-Z]{2,10}\.[a-zA-Z]{2,4}$")]
    [RegularExpression(@"^\w{2,}(\.[a-zA-Z0-9]+)?@[a-zA-Z]{2,10}\.[a-zA-Z]{2,4}$")]
    public required string Email { get; set; }

    [RegularExpression(@"^(09|\+989|00989)\d{9}$")]
    public required string PhoneNumber { get; set; }

    [RegularExpression(@"^\d{10}$")]
    public required string NationalId { get; set; }

    [RegularExpression(@"^\d{4}/(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])$")]
    public required string DateOfBirth { get; set; }
}