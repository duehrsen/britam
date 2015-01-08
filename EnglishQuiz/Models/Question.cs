using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnglishQuiz.Models
{
    public enum Game
    {
        Britam = 1, Korean, Japanese, Portuguese, Formal
    }

    public class Question
    {
        [Key]
        public int Id { get; set; }
        public int GameId { get; set; }
        public string Choice1 { get; set; }
        public string Choice2 { get; set; }
        public string Image { get; set; }
    }
}