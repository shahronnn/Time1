namespace task2;

public class Account
{
    private int _number;
    private decimal _balance;
    public Account(int num)
    {
        _number=num;
    }
    public Account(int num, decimal balance)
    {
        _number=num;
        _balance=balance;
    }
    public int GetNumber { get{return _number;}}
    public decimal GetBalace { get{return _balance;}}
    
    public string ToString()
    {
        return $"Account[number={_number},balance=${_balance}]";
    }
    public void Credit(decimal amount)
    
    {
        _balance+=amount;
    }
    public void Debit(decimal amount)
    {
        if (_balance>=amount)
        {
            _balance-=amount;
        }
        else
        {
            System.Console.WriteLine("Amount exceeded");
        }
    }

    public void TransferTo(decimal amount, Account another)
    {
        if (_balance>=amount)
        {
            _balance-=amount;
            another.Credit(amount);
        }
        else
        {
            System.Console.WriteLine("Amount exceeded");
        }
    }
}
