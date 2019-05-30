using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_v3
{
    public class Presenter
    {
        IView view;
        Model model;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.OnSetCurrentQuestionIndex += View_OnSetCurrentQuestionIndex;
            this.view.OnRemoveCurrentQuestion += View_OnRemoveCurrentQuestion;
            this.view.OnAddNewQuestion += View_OnAddNewQuestion;

            this.view.OnSetCurrentQuestionText += View_OnSetCurrentQuestionText;
            this.view.OnSetCurrentQuestionAnswerText += View_OnSetCurrentQuestionAnswerText;
            this.view.OnSetCurrentQuestionAnswerIsCorrect += View_OnSetCurrentQuestionAnswerIsCorrect;
            this.view.OnSetCurrentQuestionAnswerPoints += View_OnSetCurrentQuestionAnswerPoints;

            this.view.OnSetOutputFileName += View_OnSetOutputFileName;
            this.view.OnSaveToJson += View_OnSaveToJson;

            this.model.SetOutputFileName(this.view.OutputFileName);
        }

        private void View_OnSetCurrentQuestionIndex(int newIndex)
        {
            Question currentQuestion = this.model.SetCurrentQuestionIndex(newIndex);
            this.view.SetCurrentQuestionNumber(this.model.CurrentQuestionIndex + 1);
            this.view.SetQuestionsData(currentQuestion);
        }

        private void View_OnAddNewQuestion()
        {
            int newQuestionIndex = this.model.AddNewQuestion();
            this.view.SetCurrentQuestionNumber(newQuestionIndex + 1);
        }

        private void View_OnRemoveCurrentQuestion()
        {
            this.model.RemoveCurrentQuestion();
            this.view.SetCurrentQuestionNumber(this.model.CurrentQuestionIndex + 1);
            Question currentQuestion = this.model.GetCurrentQuestionData();
            this.view.SetQuestionsData(currentQuestion);
        }

        private void View_OnSetCurrentQuestionText(string text)
        {
            this.model.SetCurrentQuestionText(text);
        }

        private void View_OnSetCurrentQuestionAnswerText(int answerIndex, string text)
        {
            this.model.SetCurrentQuestionAnswerText(answerIndex, text);
        }

        private void View_OnSetCurrentQuestionAnswerIsCorrect(int answerIndex, AnswerKind isCorrect)
        {
            this.model.SetCurrentQuestionAnswerIsCorrect(answerIndex, isCorrect);
        }

        private void View_OnSetCurrentQuestionAnswerPoints(int answerIndex, int points)
        {
            this.model.SetCurrentQuestionAnswerPoints(answerIndex, points);
        }

        private void View_OnSetOutputFileName(string fileName)
        {
            this.model.SetOutputFileName(fileName);
        }
        private void View_OnSaveToJson()
        {
            try
            {
                this.model.SaveToJson();
            }
            catch (Exception ex)
            {
                this.view.ShowMessage(ex.Message);
            }
        }
    }
}
