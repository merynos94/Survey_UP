﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SurveyUP.Models
{

    public class UsetInputModelNoPass
    {
        [Required(ErrorMessage = "Pole email jest wymagane")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

      


        [Required(ErrorMessage = "Pole Imie jest wymagane")]
        [StringLength(250, ErrorMessage = "{0} must at max {1} characters long.")]
        [Display(Name = "Nazwisko")]
        public string Name { get; set; }
        //[Remote(action: "VerifyName", controller: "Users", AdditionalFields = nameof(LastName))]
        [Required(ErrorMessage = "Pole Imię jest wymagane")]
        [StringLength(250, ErrorMessage = "{0} must at max {1} characters long.")]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Display(Name = "Drugie imie")]
        //[Remote(action: "VerifyName", controller: "Users", AdditionalFields = nameof(FirstName))]
        [StringLength(250, ErrorMessage = "{0} must at max {1} characters long.")]
        public string MiddleName { get; set; }
        [Display(Name = "Numer indeksu")]
        public string AlbumNumber { get; set; }
        [Display(Name = "Wydział")]
        public string Department { get; set; }
        [Display(Name = "Kierunek")]
        public string UniversityDirection { get; set; }
        [Display(Name = "Stopień")]
        public string Degree { get; set; }
        [Display(Name = "Forma")]
        public string LearningForm { get; set; }
        [Display(Name = "Adres stały")]
        public string PermanentAddress { get; set; }
        [Display(Name = "Miasto")]
        public string PermanentCity { get; set; }
        [Display(Name = "Kod pocztowy")]
        public string PermanentPostalCode { get; set; }
        [Display(Name = "Adres do korespondencji")]
        public string CorrespondAddress { get; set; }
        [Display(Name = "Miasto")]
        public string CorrespondCity { get; set; }
        [Display(Name = "Kod pocztowy")]
        public string CorrespondPostalCode { get; set; }
        [Display(Name = "Imie Matki")]
        public string NameMother { get; set; }
        [Display(Name = "Imie Ojca")]
        public string NameFather { get; set; }
        [Required(ErrorMessage = "Pole Data jest wymagane")]
        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        [Display(Name = "PESEL")]
        public string Pesel { get; set; }
        [Display(Name = "Miejsce urodzenia")]
        public string BirthPlace { get; set; }

        [Required(ErrorMessage = "Pole Numer telefonu jest wymagane")]
        [Display(Name = "Numer telefonu")]
        public string PhoneNumber { get; set; }
    }

    public class UserInputModel   : UsetInputModelNoPass
    {

        [Required(ErrorMessage = "Pole Hasło jest wymagane")]
        [StringLength(100, ErrorMessage = " {0} musi mieć przynajmniej {2}, a maksymalnie {1} znaków", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Compare("Password", ErrorMessage = "Hasła nie są zgodne")]
        public string ConfirmPassword { get; set; }
    }
}
