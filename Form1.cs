using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace FinanceTracker_Lab1
{
    public partial class Form1 : Form
    {
        // Класс транзакции
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

        // Класс Кошелек
        public class Wallet
        {
            public string Name { get; set; }
            public List<Transaction> History { get; set; }
            public decimal Balance { get; set; }

            public Wallet(string name)
            {
                Name = name;
                History = new List<Transaction>();
                Balance = 0;
            }
        }

        private List<Wallet> wallets = new List<Wallet>();
        private Wallet currentWallet = null;

        public Form1()
        {
            InitializeComponent();

            // Инициализация кошельков
            wallets.Add(new Wallet("Наличные"));
            wallets.Add(new Wallet("Банковская карта"));

            // Заполнение выпадающего списка
            foreach (var w in wallets)
            {
                cmbWallets.Items.Add(w.Name);
            }

            // Выбор первого кошелька по умолчанию
            if (wallets.Count > 0)
            {
                cmbWallets.SelectedIndex = 0;
            }
        }

        // Событие выбора кошелька
        private void cmbWallets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWallets.SelectedIndex >= 0)
            {
                currentWallet = wallets[cmbWallets.SelectedIndex];
                lblWalletBalance.Text = $"Кошелек '{currentWallet.Name}': {currentWallet.Balance} руб.";

                // Обновление истории
                lstHistory.Items.Clear();
                foreach (var t in currentWallet.History)
                {
                    lstHistory.Items.Add(t);
                }

                UpdateTotalBalance();
            }
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            if (currentWallet != null) AddTransaction("Доход");
            else MessageBox.Show("Выберите кошелек!");
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            if (currentWallet != null) AddTransaction("Расход");
            else MessageBox.Show("Выберите кошелек!");
        }

        private void AddTransaction(string type)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount) && amount > 0)
            {
                string desc = string.IsNullOrWhiteSpace(txtDesc.Text) ? "Без описания" : txtDesc.Text;

                currentWallet.History.Add(new Transaction(type, amount, desc));
                lstHistory.Items.Add(new Transaction(type, amount, desc));

                if (type == "Доход") currentWallet.Balance += amount;
                else currentWallet.Balance -= amount;

                lblWalletBalance.Text = $"Кошелек '{currentWallet.Name}': {currentWallet.Balance} руб.";
                UpdateTotalBalance();

                txtAmount.Clear();
                txtDesc.Clear();
            }
            else
            {
                MessageBox.Show("Введите корректную сумму!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateTotalBalance()
        {
            decimal total = 0;
            foreach (var w in wallets)
            {
                total += w.Balance;
            }
            lblTotal.Text = $"Общее состояние: {total} руб.";
        }
    }
}