﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    public class Question
    {
        [Key]
        public int QnId { get; set; }

        [Column(TypeName ="nvarchar(MAX)")]
        public string QnInWords { get; set; }
        public string? ImageName { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Option1 { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Option2 { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Option3 { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Option4 { get; set; }

        public int Answer { get; set; }
    }
}
