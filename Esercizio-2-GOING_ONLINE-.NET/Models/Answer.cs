﻿namespace Esercizio_2_GOING_ONLINE_.NET.Models
{
    public class Answer
    {
        public string Author { get; set; }
        public string Description { get; set; }
        public bool IsAccepted { get; set; }
        public Question question { get; set; }
    }
}