using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_v3
{
    public class Question
    {
        public Question()
        {
            this.Answers = new List<Answer>();
            this.Answers.Add(new Answer());
            this.Answers.Add(new Answer());
            this.Answers.Add(new Answer());
            this.Answers.Add(new Answer());
        }

        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
