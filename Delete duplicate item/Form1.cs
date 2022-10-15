namespace Delete_duplicate_item
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string[] arrayInput = txtInput.Lines;
            string[] arrayDuplicate = txtDuplicate.Lines;
            File.WriteAllLines("Result.txt", arrayInput.Except(arrayDuplicate));
        }
    }
}