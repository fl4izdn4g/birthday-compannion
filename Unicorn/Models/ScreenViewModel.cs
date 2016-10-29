using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unicorn.Models
{
    public class ScreenViewModel
    {
        public const string CIPHER_MODE = "Zaszyfruj";
        public const string DECIPHER_MODE = "Odszyfruj";

        public string ImageName { get; set; }
        public string PasswordPartialName { get; set; }
        public string PasswordSolution { get; set; }
        public string GivenPassword { get; set; }
        public string Mode { get; set; }
        public string Next { get; set; }

        public bool IsSuccess { get; set; }
        public bool IsError { get; set; }
        public bool IsLast { get; set; }
    }
}