using System;
using System.Collections.Generic;
using System.Text;

namespace ItemCatalogService.Data
{
    public class Answer
    {
        public Guid Id { get; set; }
        public string AnswerText { get; set; }
        public User User { get; set; }
    }
}
