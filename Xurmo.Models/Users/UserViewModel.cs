﻿using System.ComponentModel.DataAnnotations;

namespace Xurmo.Models.Users;

public class UserViewModel
{
    public long Id { get; set; }    

    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string Email { get; set; }
    
    public string Phone { get; set; }
    
    public string Password { get; set; }
}
