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

        public decimal Deposit(decimal amount)
        {
            _money += amount;
            return _money;
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

        public decimal Money
        {
            get => _money;
            set => _money = value;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }
    }
}
