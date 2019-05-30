using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_v3
{
    public interface IView
    {
        event SetCurrentQuestionIndexDelegate OnSetCurrentQuestionIndex;
        event Action OnAddNewQuestion;
        event Action OnRemoveCurrentQuestion;

        event SetCurrentQuestionTextDelegate OnSetCurrentQuestionText;
        event SetCurrentQuestionAnswerTextDelegate OnSetCurrentQuestionAnswerText;
        event SetCurrentQuestionAnswerIsCorrectDelegate OnSetCurrentQuestionAnswerIsCorrect;
        event SetCurrentQuestionAnswerPointsDelegate OnSetCurrentQuestionAnswerPoints;
        event SetOutputFileNameDelegate OnSetOutputFileName;

        event Action OnSaveToJson;
        void ShowMessage(string msg);
        void SetCurrentQuestionNumber(int newQuestionNumber);
        void SetQuestionsData(Question currentQuestion);

        string OutputFileName { get; }
    }
}
