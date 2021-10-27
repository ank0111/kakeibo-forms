using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;
using WindowsFormsApp2.Database;
using System.Data.Entity;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private BindingList<Expense> _expenses;
        private BindingList<KeyValuePair<string, int>> _sums;
        public Form1()
        {
            InitializeComponent();
            year.Value = new decimal(DateTime.Today.Year);
            month.Value = new decimal(DateTime.Today.Month);
            initiateTable(DateTime.Today.Year, DateTime.Today.Month);
            _calcSum();
            sumary.DataSource = _sums;
        }

        private void 削除_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection src = detail.SelectedRows;
            List<Expense> targets = new List<Expense>();
            foreach (DataGridViewRow row in src)
            {
                targets.Add((Expense)row.DataBoundItem);
                detail.Rows.Remove(row);
            }
            using (var db = new MyDbContext())
            {
                targets.ForEach(i => db.Expenses.Attach(i));
                db.Expenses.RemoveRange(targets);
                db.SaveChanges();
            }
            _calcSum();
        }

        private void 更新_Click(object sender, EventArgs e)
        {
            initiateTable((int)year.Value, (int)month.Value);
            _calcSum();
        }

        private void 追加_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MyDbContext())
                {
                    Expense item = new Expense { Date = dateTimePicker1.Value.Date, Category = comboBox1.Text, Price = int.Parse(textBox1.Text), Memo = richTextBox1.Text, Sakamoto = checkBox1.Checked };
                    db.Expenses.Add(item);
                    db.SaveChanges();
                    _expenses.Add(item);
                }
                _calcSum();
            }
            catch
            {

            }
        }

        private void _calcSum()
        {
            _sums = new BindingList<KeyValuePair<string, int>>(_expenses.GroupBy(i => i.Category).Select(g => new KeyValuePair<string, int>(g.Key, g.Sum(i => i.Price))).ToList());
            int total = _sums.Sum(i => i.Value);
            int sakamoto = _expenses.Where(i => i.Sakamoto).Sum(i => i.Price);
            int seisan = total / 2 + 5000 - sakamoto;
            _sums.Add(new KeyValuePair<string, int>("total", total));
            _sums.Add(new KeyValuePair<string, int>("sakamoto", sakamoto));
            _sums.Add(new KeyValuePair<string, int>("s → k", seisan));
            sumary.DataSource = _sums;
        }

        private void initiateTable(int year,int month)
        {
            using (var db = new MyDbContext())
            {
                List<Expense> result = db.Expenses.Where(i => i.Date.Year == year && i.Date.Month == month).OrderBy(i=>i.Date).ToList();
                _expenses = new BindingList<Expense>(result);
            }
            detail.DataSource = _expenses;
        }

        private void detail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
