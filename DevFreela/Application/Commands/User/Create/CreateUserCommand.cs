﻿using MediatR;
using System;

namespace Application.Commands.User.Create
{
    public class CreateUserCommand : IRequest<int>
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
