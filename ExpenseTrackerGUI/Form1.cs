namespace ExpenseTrackerGUI
{
    public partial class Form1 : Form
    {
        // ✅ 이 한 줄 추가!
        private List<Expense> expenses = new List<Expense>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string desc = txtDesc.Text;
            bool valid = int.TryParse(txtAmount.Text, out int amount);

            if (string.IsNullOrWhiteSpace(desc) || !valid)
            {
                MessageBox.Show("❌ 입력이 올바르지 않습니다.");
                return;
            }

            var expense = new Expense
            {
                Description = desc,
                Amount = amount,
                Date = DateTime.Now
            };

            expenses.Add(expense);
            lstExpenses.Items.Add($"{expense.Date:yyyy-MM-dd} | {expense.Description} | ${expense.Amount}");

            txtDesc.Clear();
            txtAmount.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
