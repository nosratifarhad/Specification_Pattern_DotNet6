﻿using Specification.Domain.User.Enums;

namespace Specification.Application.DTOs;

public class CreateUserDto
{
    public string UserName { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public UserStatus Status { get; set; }
}
