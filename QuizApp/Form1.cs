using System;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {
       
        private string[] questions = new string[]
        {
            "1. C# dilində tam ədədləri saxlamaq üçün hansı tip istifadə olunur?",
            "2. Fayla mətn yazmaq üçün hansı sinifdən istifadə edilir?",
            "3. Sətri müəyyən simvola görə hissələrə bölmək üçün hansı metod işlədilir?",
            "4. Aşağıdakılardan hansı dövr operatorudur?",
            "5. Windows Forms-da bildiriş pəncərəsi çıxarmaq üçün hansı sinif işlədilir?"
        };

        private string[,] options = new string[,]
        {
            { "string", "int", "bool", "char" },
            { "StreamWriter", "StreamReader", "FileInfo", "Directory" },
            { "Trim()", "Replace()", "Split()", "Substring()" },
            { "if", "switch", "foreach", "return" },
            { "Console", "MessageBox", "Panel", "GroupBox" }
        };

        private int[] correctAnswers = new int[] { 1, 0, 2, 2, 1 };

        private int currentQuestion = 0;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();

            grpAnswers.Text = "Cavab variantları:";
            btnNext.Text = "Növbəti";

            progressBar1.Minimum = 0;
            progressBar1.Maximum = questions.Length;

            LoadQuestion();
        }

        private void LoadQuestion()
        {
            lblQuestion.Text = questions[currentQuestion];
            rbOption1.Text = options[currentQuestion, 0];
            rbOption2.Text = options[currentQuestion, 1];
            rbOption3.Text = options[currentQuestion, 2];
            rbOption4.Text = options[currentQuestion, 3];

          
            rbOption1.Checked = false;
            rbOption2.Checked = false;
            rbOption3.Checked = false;
            rbOption4.Checked = false;

        
            progressBar1.Value = currentQuestion;

           
            btnNext.Text = (currentQuestion == questions.Length - 1) ? "Bitir" : "Növbəti";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
     
            int selectedOption = -1;
            if (rbOption1.Checked) selectedOption = 0;
            else if (rbOption2.Checked) selectedOption = 1;
            else if (rbOption3.Checked) selectedOption = 2;
            else if (rbOption4.Checked) selectedOption = 3;

      
            if (selectedOption == -1)
            {
                MessageBox.Show("Zəhmət olmasa cavab variantlarından birini seçin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

    
            if (selectedOption == correctAnswers[currentQuestion])
            {
                score++;
            }

            currentQuestion++;

    
            if (currentQuestion < questions.Length)
            {
                LoadQuestion();
            }
            else
            {
       
                progressBar1.Value = questions.Length;

                DialogResult answer = MessageBox.Show(
                    $"Test bitdi!\nToplanmış bal: {score} / {questions.Length}\n\nYenidən başlamaq istəyirsiniz?",
                    "Nəticə",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (answer == DialogResult.Yes)
                {
                    currentQuestion = 0;
                    score = 0;
                    LoadQuestion();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}