namespace project_server
{
    public partial class Form1 : Form
    {
        List<KeyValuePair<string, int>> question_answers = new List<KeyValuePair<string, int>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.read_questions_answers();
        }


        private void read_questions_answers()
        {
            string[] lines = File.ReadAllLines("questions.txt");

            for (int i = 0; i < lines.Length; i+=2)
            {
                KeyValuePair<string, int> question_answer_pair = 
                    new KeyValuePair<string, int>(lines[i], Int32.Parse(lines[i+1]));

                this.question_answers.Add(question_answer_pair);
            }
        }
    }
}