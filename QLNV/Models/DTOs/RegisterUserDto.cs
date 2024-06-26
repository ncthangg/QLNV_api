﻿namespace QLNV.Models.DTOs
{
    public class RegisterUserDto
    {

        public string UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Sex { get; set; }

        public DateOnly BirthDay { get; set; }

        public string Address { get; set; }

    }

}
