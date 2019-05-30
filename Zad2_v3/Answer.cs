using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_v3
{
    public enum AnswerKind { Incorrect, Correct };
    
    public class Answer
    {
        public Answer()
        {
            this.Text = string.Empty;
            this.AnswerKind = AnswerKind.Incorrect;
            this.Points = 0;
        }

        public string Text { get; set; }
        public AnswerKind AnswerKind { get; set; }
        public int Points { get; set; }
    }
}
