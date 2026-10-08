namespace G26W06WFCounter
{
    public partial class Form1 : Form
    {
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }

        private void OnAdd(object sender, EventArgs e)
        {
            // labelCount.Text = "눌렸습니다";
            labelCount.Text = $"{++count}";
        }
    }
}
