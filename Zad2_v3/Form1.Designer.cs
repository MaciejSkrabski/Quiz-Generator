namespace Zad2_v3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbOutputFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nbQuestionNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuestionText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAnswer1 = new System.Windows.Forms.TextBox();
            this.cbIsCorrect1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nbPoints1 = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveQuestion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nbPoints2 = new System.Windows.Forms.NumericUpDown();
            this.cbIsCorrect2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAnswer2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nbPoints3 = new System.Windows.Forms.NumericUpDown();
            this.cbIsCorrect3 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAnswer3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nbPoints4 = new System.Windows.Forms.NumericUpDown();
            this.cbIsCorrect4 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAnswer4 = new System.Windows.Forms.TextBox();
            this.btnSaveToJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbQuestionNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPoints1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPoints2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPoints3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPoints4)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutputFileName
            // 
            this.tbOutputFileName.Location = new System.Drawing.Point(202, 403);
            this.tbOutputFileName.Name = "tbOutputFileName";
            this.tbOutputFileName.Size = new System.Drawing.Size(227, 20);
            this.tbOutputFileName.TabIndex = 29;
            this.tbOutputFileName.Text = "output.json";
            this.tbOutputFileName.TextChanged += new System.EventHandler(this.tbOutputFileName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa pliku wyjsciowego";
            // 
            // nbQuestionNumber
            // 
            this.nbQuestionNumber.Location = new System.Drawing.Point(12, 35);
            this.nbQuestionNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbQuestionNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbQuestionNumber.Name = "nbQuestionNumber";
            this.nbQuestionNumber.Size = new System.Drawing.Size(87, 20);
            this.nbQuestionNumber.TabIndex = 2;
            this.nbQuestionNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbQuestionNumber.ValueChanged += new System.EventHandler(this.nbQuestionNumber_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numer pytania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Treść pytania";
            // 
            // tbQuestionText
            // 
            this.tbQuestionText.Location = new System.Drawing.Point(12, 101);
            this.tbQuestionText.Name = "tbQuestionText";
            this.tbQuestionText.Size = new System.Drawing.Size(465, 20);
            this.tbQuestionText.TabIndex = 0;
            this.tbQuestionText.TextChanged += new System.EventHandler(this.tbQuestionText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Odpowiedź 1";
            // 
            // tbAnswer1
            // 
            this.tbAnswer1.Location = new System.Drawing.Point(12, 161);
            this.tbAnswer1.Name = "tbAnswer1";
            this.tbAnswer1.Size = new System.Drawing.Size(465, 20);
            this.tbAnswer1.TabIndex = 6;
            this.tbAnswer1.TextChanged += new System.EventHandler(this.tbAnswer1_TextChanged);
            // 
            // cbIsCorrect1
            // 
            this.cbIsCorrect1.AutoSize = true;
            this.cbIsCorrect1.Location = new System.Drawing.Point(505, 163);
            this.cbIsCorrect1.Name = "cbIsCorrect1";
            this.cbIsCorrect1.Size = new System.Drawing.Size(74, 17);
            this.cbIsCorrect1.TabIndex = 8;
            this.cbIsCorrect1.Text = "Poprawna";
            this.cbIsCorrect1.UseVisualStyleBackColor = true;
            this.cbIsCorrect1.CheckedChanged += new System.EventHandler(this.cbIsCorrect1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Punkty";
            // 
            // nbPoints1
            // 
            this.nbPoints1.Location = new System.Drawing.Point(613, 163);
            this.nbPoints1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbPoints1.Name = "nbPoints1";
            this.nbPoints1.Size = new System.Drawing.Size(58, 20);
            this.nbPoints1.TabIndex = 9;
            this.nbPoints1.ValueChanged += new System.EventHandler(this.nbPoints1_ValueChanged);
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.Location = new System.Drawing.Point(505, 99);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(121, 23);
            this.btnRemoveQuestion.TabIndex = 11;
            this.btnRemoveQuestion.Text = "Usuń wybrane pytanie";
            this.btnRemoveQuestion.UseVisualStyleBackColor = true;
            this.btnRemoveQuestion.Click += new System.EventHandler(this.btnRemoveQuestion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dodaj nowe pytanie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Punkty";
            // 
            // nbPoints2
            // 
            this.nbPoints2.Location = new System.Drawing.Point(613, 221);
            this.nbPoints2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbPoints2.Name = "nbPoints2";
            this.nbPoints2.Size = new System.Drawing.Size(58, 20);
            this.nbPoints2.TabIndex = 16;
            this.nbPoints2.ValueChanged += new System.EventHandler(this.nbPoints2_ValueChanged);
            // 
            // cbIsCorrect2
            // 
            this.cbIsCorrect2.AutoSize = true;
            this.cbIsCorrect2.Location = new System.Drawing.Point(505, 221);
            this.cbIsCorrect2.Name = "cbIsCorrect2";
            this.cbIsCorrect2.Size = new System.Drawing.Size(74, 17);
            this.cbIsCorrect2.TabIndex = 15;
            this.cbIsCorrect2.Text = "Poprawna";
            this.cbIsCorrect2.UseVisualStyleBackColor = true;
            this.cbIsCorrect2.CheckedChanged += new System.EventHandler(this.cbIsCorrect2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Odpowiedź 2";
            // 
            // tbAnswer2
            // 
            this.tbAnswer2.Location = new System.Drawing.Point(12, 219);
            this.tbAnswer2.Name = "tbAnswer2";
            this.tbAnswer2.Size = new System.Drawing.Size(465, 20);
            this.tbAnswer2.TabIndex = 13;
            this.tbAnswer2.TextChanged += new System.EventHandler(this.tbAnswer2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Punkty";
            // 
            // nbPoints3
            // 
            this.nbPoints3.Location = new System.Drawing.Point(613, 277);
            this.nbPoints3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbPoints3.Name = "nbPoints3";
            this.nbPoints3.Size = new System.Drawing.Size(58, 20);
            this.nbPoints3.TabIndex = 21;
            this.nbPoints3.ValueChanged += new System.EventHandler(this.nbPoints3_ValueChanged);
            // 
            // cbIsCorrect3
            // 
            this.cbIsCorrect3.AutoSize = true;
            this.cbIsCorrect3.Location = new System.Drawing.Point(505, 277);
            this.cbIsCorrect3.Name = "cbIsCorrect3";
            this.cbIsCorrect3.Size = new System.Drawing.Size(74, 17);
            this.cbIsCorrect3.TabIndex = 20;
            this.cbIsCorrect3.Text = "Poprawna";
            this.cbIsCorrect3.UseVisualStyleBackColor = true;
            this.cbIsCorrect3.CheckedChanged += new System.EventHandler(this.cbIsCorrect3_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Odpowiedź 3";
            // 
            // tbAnswer3
            // 
            this.tbAnswer3.Location = new System.Drawing.Point(12, 275);
            this.tbAnswer3.Name = "tbAnswer3";
            this.tbAnswer3.Size = new System.Drawing.Size(465, 20);
            this.tbAnswer3.TabIndex = 18;
            this.tbAnswer3.TextChanged += new System.EventHandler(this.tbAnswer3_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(613, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Punkty";
            // 
            // nbPoints4
            // 
            this.nbPoints4.Location = new System.Drawing.Point(613, 335);
            this.nbPoints4.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbPoints4.Name = "nbPoints4";
            this.nbPoints4.Size = new System.Drawing.Size(58, 20);
            this.nbPoints4.TabIndex = 26;
            this.nbPoints4.ValueChanged += new System.EventHandler(this.nbPoints4_ValueChanged);
            // 
            // cbIsCorrect4
            // 
            this.cbIsCorrect4.AutoSize = true;
            this.cbIsCorrect4.Location = new System.Drawing.Point(505, 335);
            this.cbIsCorrect4.Name = "cbIsCorrect4";
            this.cbIsCorrect4.Size = new System.Drawing.Size(74, 17);
            this.cbIsCorrect4.TabIndex = 25;
            this.cbIsCorrect4.Text = "Poprawna";
            this.cbIsCorrect4.UseVisualStyleBackColor = true;
            this.cbIsCorrect4.CheckedChanged += new System.EventHandler(this.cbIsCorrect4_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Odpowiedź 4";
            // 
            // tbAnswer4
            // 
            this.tbAnswer4.Location = new System.Drawing.Point(12, 333);
            this.tbAnswer4.Name = "tbAnswer4";
            this.tbAnswer4.Size = new System.Drawing.Size(465, 20);
            this.tbAnswer4.TabIndex = 23;
            this.tbAnswer4.TextChanged += new System.EventHandler(this.tbAnswer4_TextChanged);
            // 
            // btnSaveToJson
            // 
            this.btnSaveToJson.Location = new System.Drawing.Point(435, 400);
            this.btnSaveToJson.Name = "btnSaveToJson";
            this.btnSaveToJson.Size = new System.Drawing.Size(164, 23);
            this.btnSaveToJson.TabIndex = 28;
            this.btnSaveToJson.Text = "Zapisz do .json";
            this.btnSaveToJson.UseVisualStyleBackColor = true;
            this.btnSaveToJson.Click += new System.EventHandler(this.btnSaveToJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnSaveToJson);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nbPoints4);
            this.Controls.Add(this.cbIsCorrect4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbAnswer4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nbPoints3);
            this.Controls.Add(this.cbIsCorrect3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbAnswer3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nbPoints2);
            this.Controls.Add(this.cbIsCorrect2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAnswer2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoveQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nbPoints1);
            this.Controls.Add(this.cbIsCorrect1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAnswer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbQuestionText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nbQuestionNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOutputFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generator pytań";
            ((System.ComponentModel.ISupportInitialize)(this.nbQuestionNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPoints1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPoints2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPoints3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPoints4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutputFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nbQuestionNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuestionText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAnswer1;
        private System.Windows.Forms.CheckBox cbIsCorrect1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nbPoints1;
        private System.Windows.Forms.Button btnRemoveQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nbPoints2;
        private System.Windows.Forms.CheckBox cbIsCorrect2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAnswer2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nbPoints3;
        private System.Windows.Forms.CheckBox cbIsCorrect3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAnswer3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nbPoints4;
        private System.Windows.Forms.CheckBox cbIsCorrect4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbAnswer4;
        private System.Windows.Forms.Button btnSaveToJson;
    }
}

