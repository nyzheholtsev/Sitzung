using System.Data;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Sitzung
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            QuestPDF.Settings.License = LicenseType.Community;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FileName = $"Zvit_{DateTime.Now:yyyyMMdd}.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GeneratePdf(sfd.FileName);
                    MessageBox.Show("Звіт успішно збережено!", "Успіх");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}", "Помилка");
                }
            }
        }

        private void UpdateGrid()
        {
            var date = dtpReport.Value.Date;
            List<Expense> filteredExpenses = GetFilteredList(date);

            dgvReport.DataSource = null;
            dgvReport.DataSource = filteredExpenses;

            decimal total = filteredExpenses.Sum(x => x.Amount);
            MessageBox.Show($"Загальна сума: {total} грн");
        }

        private List<Expense> GetFilteredList(DateTime date)
        {
            if (rbDay.Checked)
            {
                return DataManager.Expenses
                    .Where(x => x.Date.Date == date)
                    .ToList();
            }
            else if (rbWeek.Checked)
            {
                var startOfWeek = date.AddDays(-(int)date.DayOfWeek + (int)DayOfWeek.Monday);
                var endOfWeek = startOfWeek.AddDays(7);

                return DataManager.Expenses
                    .Where(x => x.Date.Date >= startOfWeek && x.Date.Date < endOfWeek)
                    .ToList();
            }
            else
            {
                return DataManager.Expenses
                    .Where(x => x.Date.Month == date.Month && x.Date.Year == date.Year)
                    .ToList();
            }
        }

        private void GeneratePdf(string filePath)
        {
            var data = dgvReport.DataSource as List<Expense>;
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Немає даних для звіту!");
                return;
            }

            var reportDate = dtpReport.Value;
            string periodName = rbDay.Checked ? "за день" :
                                rbWeek.Checked ? "за тиждень" : "за місяць";

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(50);
                    page.Size(PageSizes.A4);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Header()
                        .Text($"Звіт по бюджету {periodName} ({reportDate.ToShortDateString()})")
                        .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .PaddingVertical(10)
                        .Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(100);
                                columns.RelativeColumn();
                                columns.ConstantColumn(100);
                            });

                            table.Header(header =>
                            {
                                header.Cell().Element(CellStyle).Text("Дата");
                                header.Cell().Element(CellStyle).Text("Категорія");
                                header.Cell().Element(CellStyle).Text("Сума (грн)");
                                static IContainer CellStyle(IContainer container) =>
                                    container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                            });

                            foreach (var item in data)
                            {
                                table.Cell().Element(CellStyle).Text(item.Date.ToShortDateString());
                                table.Cell().Element(CellStyle).Text(item.Category);
                                table.Cell().Element(CellStyle).AlignRight().Text(item.Amount.ToString("F2"));
                                static IContainer CellStyle(IContainer container) =>
                                    container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                            }
                        });

                    page.Footer()
                        .AlignRight()
                        .Text(x =>
                        {
                            x.Span("Всього: ");
                            x.Span($"{data.Sum(d => d.Amount):F2} грн").SemiBold();
                        });
                });
            })
            .GeneratePdf(filePath);
        }
    }
}