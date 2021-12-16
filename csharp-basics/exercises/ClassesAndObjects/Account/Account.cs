namespace Account
{
    public class Account
    {
        private string _name;
        private decimal _money;

        public Account(string name, decimal money)
        {
            _name = name;
            _money = money;
        }

        public decimal Withdrawal(decimal amount)
        {
            return _money -= amount;
        }

        public void Deposit(decimal amount)
        {
            _money += amount;
        }

        public decimal Balance()
        {
            return _money;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public static void Transfer(Account from, Account to, decimal howMuch)
        {
            from._money -= howMuch;
            to._money += howMuch;
        }
    }
}
