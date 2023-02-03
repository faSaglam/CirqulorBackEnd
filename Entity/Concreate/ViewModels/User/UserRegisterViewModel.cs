﻿using Core.Entities;

namespace Entities.Concreate.ViewModels.User
{
    public class UserRegisterViewModel : IViewModel
    {
        //public string UserName { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
