using System;

namespace _04
{
    class Account
    {
        string cur;
        double summ;
        public Account()
        {
            SetName("");

            SetSumm(0.0);

        }
        public Account(string name, double summ)
        {
            SetName(name);
            SetSumm(summ);
        }

        public void SetName(string Cur)
        {
            this.cur = Cur;
        }
        public void SetSumm(double Summ)
        {
            this.summ = Summ;
        }
        public void AddAccount(string c,double s)
        {
            Account acc = new Account();
            acc.cur = c;
            acc.summ = s;
        }

        public string GetCur()
        {
            return this.cur;

        }
        public double GetSumm()
        {
            return this.summ;

        }
        public override string ToString()
        {
            return string.Format("Сумма {0} Валюта{1}", this.GetSumm(), this.GetCur());
        }
        public Account Sum(Account a, Account b)
        {
            Account acc = new Account();
            if (a.cur == b.cur)
            {
                acc.summ = a.summ + b.summ;
            }
            else return null;
            return acc;
        }   
        public Account Sub(Account a, Account b)
        {
            Account acc = new Account();
            if (a.cur == b.cur)
            {
                acc.summ = a.summ - b.summ;
            }
            else return null;
            return acc;
        }        
        public Account Add(Account a, double s)
        {
            Account acc = new Account();
            acc.summ = a.summ + s;
            return acc;

        }
        public Account Proc(Account a)
        {
            Account acc = new Account();
            acc.summ = a.summ + (a.summ * 0.05);
            return acc;
        }
        
        public static Account operator ++(Account a)
        {
            Account acc = new Account();
            return acc.Proc(a);
        }
        public static Account operator +(Account a, Account b)
        {
            Account acc = new Account();
            return acc.Sum(a, b);
        }
        public static bool operator <(Account a, Account b)
        {
            Account acc = new Account();
            if (a.cur == b.cur)
                return a.summ < b.summ;
            return false;
        }
        public static bool operator >(Account a, Account b)
        {
            Account acc = new Account();
            if (a.cur == b.cur)
                return a.summ > b.summ;
            return false;
        }
        public static Account operator +(Account a, double s)
        {
            Account acc = new Account();
            return acc.Add(a, s);
        }
        public static Account operator -(Account a, Account b)
        {
            Account acc = new Account();
            return acc.Sub(a, b);
        }



    }
}


