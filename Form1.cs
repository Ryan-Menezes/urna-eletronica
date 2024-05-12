namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        private List<TextBox> inputs = new List<TextBox>();
        private List<Step> steps = new List<Step>();
        private List<Candidate> candidates = new List<Candidate>();
        private int indexStep = 0;
        private int indexDigit = 0;

        public Form1()
        {
            InitializeComponent();
            start();
        }

        private void startCandidates()
        {
            candidates.Add(new Candidate(4444, "Nikolas Ferreira", "PL", Position.DF));

            candidates.Add(new Candidate(22, "Bolsonaro", "PL", Position.PR));
            candidates.Add(new Candidate(13, "Lula", "PT", Position.PR));
        }

        private void startInputs()
        {
            inputs.Add(txt_1);
            inputs.Add(txt_2);
            inputs.Add(txt_3);
            inputs.Add(txt_4);
            inputs.Add(txt_5);
        }

        private void startSteps()
        {
            steps.Add(new Step(4, "Deputado Federal", Position.DF));
            steps.Add(new Step(5, "Deputado Estadual", Position.DE));
            steps.Add(new Step(3, "Senador", Position.SE));
            steps.Add(new Step(2, "Governador", Position.GO));
            steps.Add(new Step(2, "Presidente", Position.PR));
        }

        private void start()
        {
            startCandidates();
            startSteps();
            startInputs();

            Step step = getCurrentStep();

            showAndHideDigitsAndResetTitle(step);
        }

        private Step getCurrentStep()
        {
            return steps[indexStep];
        }

        private void goNextStep()
        {
            indexStep++;

            Step step = getCurrentStep();

            showAndHideDigitsAndResetTitle(step);
        }

        public void showAndHideDigitsAndResetTitle(Step step)
        {
            for (int i = 0; i < inputs.Count; i++)
            {
                inputs[i].Visible = true;
            }

            for (int i = step.digits; i < inputs.Count; i++)
            {
                inputs[i].Visible = false;
            }

            lbl_info.Text = step.title;
            lbl_nome.Text = "Nome: ";
            lbl_partido.Text = "Partido: ";

            resetDigits();
        }

        private void resetDigits()
        {
            indexDigit = 0;

            foreach(TextBox input in inputs)
            {
                input.Text = "";
            }
        }

        private void setDigit(int digit)
        {
            Step step = getCurrentStep();

            if (indexDigit == step.digits - 1)
            {
                lbl_nome.Text = "Teste";
            }

            if (indexDigit < 0 || indexDigit >= steps.Count) return;

            TextBox input = inputs[indexDigit];

            input.Text = digit.ToString();
            indexDigit++;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            setDigit(1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            setDigit(2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            setDigit(3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            setDigit(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            setDigit(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            setDigit(6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            setDigit(7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            setDigit(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            setDigit(9);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            setDigit(0);
        }

        private void btn_branco_Click(object sender, EventArgs e)
        {

        }

        private void btn_corrige_Click(object sender, EventArgs e)
        {
            resetDigits();
        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {
            goNextStep();
        }
    }
}