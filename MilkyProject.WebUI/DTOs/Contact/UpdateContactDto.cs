﻿namespace MilkyProject.WebUI.DTOs.Contact
{
    public class UpdateContactDto
    {
        public int ContactID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
    }
}
