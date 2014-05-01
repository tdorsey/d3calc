using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace Diablo3Calculator.Models
{

    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LogOnModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

     

    public class HeroModel
    {



        public class Passive
        {
            public String Slug { get; set; }
            public String Name { get; set; }
            public String Icon { get; set; }
            public String Tooltip { get; set; }
            public String Description { get; set; }
            public String FlavorText { get; set; }
            public Boolean Active { get; set; }
        }

        public class Skill
        {
            public String Slug { get; set; }
            public String Name { get; set; }
            public String Icon { get; set; }
            public String Tooltip { get; set; }
            public String Description { get; set; }
            public String SimpleDescription { get; set; }
            public Boolean Active { get; set; }
            public List<Rune> Runes { get; set; }


        }

        public class Rune
        {
            public String Slug { get; set; }
            public String Name { get; set; }
            public String Icon { get; set; }
            public String Tooltip { get; set; }
            public String Description { get; set; }
            public String SimpleDescription { get; set; }
            public Boolean Active { get; set; }
        }


        public enum HeroClass
        {
            Barbarian = 0,
            Crusader = 1,
            DemonHunter = 2,
            Monk = 3,
            WitchDoctor = 4,
            Wizard = 5

        }
        public enum HeroGender {
            Female = 0,
            Male = 1
        }
        
        public int ID { get; set; }
        public String Name { get; set; }
        public HeroClass Class {get; set;}
        public HeroGender Gender {get; set;}
        public int Level {get; set;}
        public Boolean Hardcore {get; set;}
        public List<Skill> Skills {get; set;}
        public List<Passive> Passives {get; set;}
    }

    public class BattleNetAccountModel
    {
        [Required]
        public string BattleTag { get; set; }
        public List<HeroModel> Heroes { get; set; }
   }
}