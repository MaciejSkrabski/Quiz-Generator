using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_v3
{
    public class Model
    {
        private List<Question> questions;
        private int currentQuestionIndex;
        public int CurrentQuestionIndex { get { return this.currentQuestionIndex; } }
        private string outputFileName;
        public Model()
        {
            this.questions = new List<Question>();
            AddNewQuestion();
            this.currentQuestionIndex = 0;
            this.outputFileName = string.Empty;
        }

        public Question GetCurrentQuestionData()
        {
            return this.questions[this.currentQuestionIndex];
        }

        public int AddNewQuestion()
        {
            this.questions.Add(new Question());
            this.currentQuestionIndex = this.questions.Count - 1;
            return this.currentQuestionIndex;
        }

        public void RemoveCurrentQuestion()
        {
            if (this.questions.Count > 1) 
            {
                this.questions.RemoveAt(this.currentQuestionIndex);
                if(this.currentQuestionIndex == this.questions.Count)
                {
                    this.currentQuestionIndex--;
                }
            }
        }

        public void SetCurrentQuestionText(string text)
        {
            this.questions[this.currentQuestionIndex].Text = text;
        }

        public void SetCurrentQuestionAnswerText(int answerIndex, string answerText)
        {
            this.questions[this.currentQuestionIndex].Answers[answerIndex].Text = answerText;
        }

        public void SetCurrentQuestionAnswerIsCorrect(int answerIndex, AnswerKind answerKind)
        {
            this.questions[this.currentQuestionIndex].Answers[answerIndex].AnswerKind = answerKind;
        }

        public void SetCurrentQuestionAnswerPoints(int answerIndex, int points)
        {
            this.questions[this.currentQuestionIndex].Answers[answerIndex].Points = points;
        }

        public Question SetCurrentQuestionIndex(int newIndex)
        {
            if (this.questions.Count > newIndex && newIndex >= 0)
            {
                this.currentQuestionIndex = newIndex;
            }
            return this.questions[this.currentQuestionIndex];
        }

        public void SetOutputFileName(string newOutputFileName)
        {
            this.outputFileName = newOutputFileName;
        }

        public void SaveToJson()
        {
            string outJson = JsonConvert.SerializeObject(this.questions);
            File.WriteAllText(this.outputFileName, outJson);
        }
    }
}
