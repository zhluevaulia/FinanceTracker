using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace FinanceTracker_Lab1  // ← ВАЖНО: совпадает с Program.cs!
{
    public partial class Form1 : Form  // ← : Form обязательно!
    {
        public class Transaction
        {
            public string Type { get; set; }
            public decimal Amount { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }

            public Transaction(string type, decimal amount, string desc)
            {
                Type = type;
                Amount = amount;
                Description = desc;
                Date = DateTime.Now;
            }

            public override string ToString()
            {
                return $"[{Date.ToShortTimeString()}] {Type}: {Amount} руб. ({Description})";
            }
        }

        private List<Transaction> history = new List<Transaction>();
        private decimal balance = 0;

        public Form1()
        {
            InitializeComponent();
            UpdateBalanceLabel();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            AddTransaction("Доход");
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            AddTransaction("Расход");
        }

        private void AddTransaction(string type)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount) && amount > 0)
            {
                string desc = string.IsNullOrWhiteSpace(txtDesc.Text) ? "Без описания" : txtDesc.Text;

                history.Add(new Transaction(type, amount, desc));
                lstHistory.Items.Add(new Transaction(type, amount, desc));

                if (type == "Доход") balance += amount;
                else balance -= amount;

                UpdateBalanceLabel();
                txtAmount.Clear();
                txtDesc.Clear();
            }
            else
            {
                MessageBox.Show("Введите корректную сумму!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateBalanceLabel()
        {
            lblBalance.Text = $"Баланс: {balance} руб.";
        }

        private void lblFIO_Click(object sender, EventArgs e)
        {

        }
    }
}