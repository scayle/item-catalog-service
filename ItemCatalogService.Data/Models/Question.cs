using System;
using System.Collections.Generic;
using System.Text;

namespace ItemCatalogService
{
    public class Question
    {
        public Guid Id { get; set; }
        public string QuestionText { get; set; }
        public User User { get; set; }
    }
}
