﻿using System.ComponentModel.DataAnnotations;

namespace CoreBlog.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Lütfen ad soyad giriniz.")]
        public string nameSurname { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre giriniz.")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Compare("Password",ErrorMessage = "Şifreler Uyuşmuyor.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lütfen mail giriniz.")]
        public string Mail { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        public string UserName { get; set; }

        [Display(Name = "Profil Fotoğrafı")]
        [Required(ErrorMessage = "Lütfen profil fotoğrafı giriniz.")]
        public string ImageURL { get; set; }
    }
}