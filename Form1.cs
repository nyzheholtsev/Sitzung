namespace Sitzung
{
    public partial class Form1 : Form
    {
        private const string XmlFileName = "budget_items.xml";

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            List<string> categories = DataManager.LoadCategories(XmlFileName);

            cmbCategory.DataSource = categories;

            if (categories.Count == 0 || categories[0] == "Файл не знайдено")
            {
                MessageBox.Show("Файл budget_items.xml не знайдено!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Виберіть статтю бюджету!");
                return;
            }

            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Сума повинна бути більше нуля!");
                return;
            }

            string category = cmbCategory.SelectedItem.ToString();
            DateTime date = dtpDate.Value;
            decimal amount = numAmount.Value;

            DataManager.AddExpense(date, category, amount);
            string message = $"Записано:\n{category}\n{amount} грн.\n{date.ToShortDateString()}";
            MessageBox.Show(message, "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

            numAmount.Value = 0;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form2 reportForm = new Form2();
            reportForm.Show();
        }
    }
}