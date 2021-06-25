﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using SurveyUP.Data;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SurveyUP.Tables
{
    public partial class VtsTbSurvey
    {
        public VtsTbSurvey()
        {
            VtsTbQuestion = new HashSet<VtsTbQuestion>();
            VtsTbUserSurvey = new HashSet<VtsTbUserSurvey>();
        }

        public int SurveyId { get; set; }
        [Display(Name = "Data utworzenia")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        
        [Display(Name = "Data otwarcia")]
        [DataType(DataType.Date)]
        public DateTime? OpenDate { get; set; }
        
        [Display(Name = "Data zamknięcia")]
        [DataType(DataType.Date)]
        [DateGreaterThan("OpenDate", "Data końcowa musi być późniejsza niż data otwarcia")]
        public DateTime? CloseDate { get; set; }

        [Required(ErrorMessage ="Podaj {0}")]
        [StringLength(250, ErrorMessage = "Pole {0} może mieć maksymalnie {1} znaków.")]
        [Display(Name = "Tytuł ankiety")]
        public string Title { get; set; }

        [Display(Name = "Tekst podziękowania")]
        public string ThankYouMessage { get; set; }
        [Display(Name = "Ilość wyświetleń")]
        public int SurveyDisplayTimes { get; set; }
        [Display(Name = "Archiwalna")]
        public bool Archive { get; set; }
        [Display(Name = "Aktywowana")]
        public bool Activated { get; set; }
        [Display(Name = "Wynik")]
        public bool? Scored { get; set; }
        public Guid? SurveyGuid { get; set; }

        public virtual ICollection<VtsTbQuestion> VtsTbQuestion { get; set; }
        public virtual ICollection<VtsTbUserSurvey> VtsTbUserSurvey { get; set; }
    }
}