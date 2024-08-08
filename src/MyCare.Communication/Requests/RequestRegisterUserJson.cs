﻿using System.ComponentModel.DataAnnotations;

namespace MyCare.Communication.Requests
{
    public class RequestRegisterUserJson
    {
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
