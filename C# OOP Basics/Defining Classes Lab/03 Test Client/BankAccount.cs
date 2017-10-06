using System;

    class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Insufficient balance");
                }
                this.balance = value;
            }
        }

        public void Deposit(Double amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(Double amount)
        {
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {this.id}, balance {this.balance}";
        }
        
    }

