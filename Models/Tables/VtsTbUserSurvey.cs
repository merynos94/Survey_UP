// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SurveyUP.Tables
{
    public partial class VtsTbUserSurvey
    {
        public string UserId { get; set; }
        public int SurveyId { get; set; }

        public virtual VtsTbSurvey Survey { get; set; }
    }
}