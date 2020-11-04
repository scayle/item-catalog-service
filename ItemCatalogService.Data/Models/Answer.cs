using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItemCatalogService.Data
{
    public class Answer
    {
        public Guid Id { get; set; }

        [Required]
        public string AnswerText { get; set; }

        [Required]
        public User User { get; set; }
    }
}
