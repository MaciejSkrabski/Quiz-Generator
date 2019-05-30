using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad2_v3
{
    public delegate void SetCurrentQuestionIndexDelegate(int newIndex);
    public delegate void SetCurrentQuestionTextDelegate(string text);
    public delegate void SetCurrentQuestionAnswerTextDelegate(int answerIndex, string text);
    public delegate void SetCurrentQuestionAnswerIsCorrectDelegate(int answerIndex, AnswerKind isCorrect);
    public delegate void SetCurrentQuestionAnswerPointsDelegate(int answerIndex, int points);
    public delegate void SetOutputFileNameDelegate(string fileName);
    public partial class Form1 : Form, IView
    {
        public string OutputFileName { get { return this.tbOutputFileName.Text; } }

        public Form1()
        {
            InitializeComponent();
        }

        public event SetCurrentQuestionIndexDelegate OnSetCurrentQuestionIndex;
        public event Action OnAddNewQuestion;
        public event Action OnRemoveCurrentQuestion;
        public event SetCurrentQuestionTextDelegate OnSetCurrentQuestionText;
        public event SetCurrentQuestionAnswerTextDelegate OnSetCurrentQuestionAnswerText;
        public event SetCurrentQuestionAnswerIsCorrectDelegate OnSetCurrentQuestionAnswerIsCorrect;
        public event SetCurrentQuestionAnswerPointsDelegate OnSetCurrentQuestionAnswerPoints;
        public event SetOutputFileNameDelegate OnSetOutputFileName;
        public event Action OnSaveToJson;

        public void SetCurrentQuestionNumber(int newQuestionNumber)
        {
            this.nbQuestionNumber.Value = newQuestionNumber;
        }
        public void SetQuestionsData(Question currentQuestion)
        {
            this.tbQuestionText.Text = currentQuestion.Text;
            this.tbAnswer1.Text = currentQuestion.Answers[0].Text;
            this.tbAnswer2.Text = currentQuestion.Answers[1].Text;
            this.tbAnswer3.Text = currentQuestion.Answers[2].Text;
            this.tbAnswer4.Text = currentQuestion.Answers[3].Text;
            this.cbIsCorrect1.Checked = currentQuestion.Answers[0].AnswerKind == AnswerKind.Correct ? true : false;
            this.cbIsCorrect2.Checked = currentQuestion.Answers[1].AnswerKind == AnswerKind.Correct ? true : false;
            this.cbIsCorrect3.Checked = currentQuestion.Answers[2].AnswerKind == AnswerKind.Correct ? true : false;
            this.cbIsCorrect4.Checked = currentQuestion.Answers[3].AnswerKind == AnswerKind.Correct ? true : false;
            this.nbPoints1.Value = currentQuestion.Answers[0].Points;
            this.nbPoints2.Value = currentQuestion.Answers[1].Points;
            this.nbPoints3.Value = currentQuestion.Answers[2].Points;
            this.nbPoints4.Value = currentQuestion.Answers[3].Points;
        }

        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg, "Error");
        }

        private void nbQuestionNumber_ValueChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionIndex((int)this.nbQuestionNumber.Value - 1);
        }

        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            this.OnRemoveCurrentQuestion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OnAddNewQuestion();
        }

        private void tbQuestionText_TextChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionText(this.tbQuestionText.Text);
        }

        private void tbAnswer1_TextChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionAnswerText(0, this.tbAnswer1.Text);
        }

        private void tbAnswer2_TextChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionAnswerText(1, this.tbAnswer2.Text);
        }

        private void tbAnswer3_TextChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionAnswerText(2, this.tbAnswer3.Text);
        }

        private void tbAnswer4_TextChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionAnswerText(3, this.tbAnswer4.Text);
        }

        private void cbIsCorrect1_CheckedChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionAnswerIsCorrect(0, this.cbIsCorrect1.Checked ? AnswerKind.Correct : AnswerKind.Incorrect);
        }

        private void cbIsCorrect2_CheckedChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionAnswerIsCorrect(1, this.cbIsCorrect2.Checked ? AnswerKind.Correct : AnswerKind.Incorrect);
        }

        private void cbIsCorrect3_CheckedChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionAnswerIsCorrect(2, this.cbIsCorrect3.Checked ? AnswerKind.Correct : AnswerKind.Incorrect);
        }

        private void cbIsCorrect4_CheckedChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionAnswerIsCorrect(3, this.cbIsCorrect4.Checked ? AnswerKind.Correct : AnswerKind.Incorrect);
        }

        private void nbPoints1_ValueChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionAnswerPoints(0, (int)this.nbPoints1.Value);
        }

        private void nbPoints2_ValueChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionAnswerPoints(1, (int)this.nbPoints2.Value);
        }

        private void nbPoints3_ValueChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionAnswerPoints(2, (int)this.nbPoints3.Value);
        }

        private void nbPoints4_ValueChanged(object sender, EventArgs e)
        {
            this.OnSetCurrentQuestionAnswerPoints(3, (int)this.nbPoints4.Value);
        }

        private void tbOutputFileName_TextChanged(object sender, EventArgs e)
        {
            this.OnSetOutputFileName(this.tbOutputFileName.Text);
        }

        private void btnSaveToJson_Click(object sender, EventArgs e)
        {
            this.OnSaveToJson();
        }
    }
}
