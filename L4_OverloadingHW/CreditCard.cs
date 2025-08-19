internal class CreditCard
{
    public string? cardNumber { get; private set; }
    private decimal _balance;

  public decimal Balance
    {
        get { return _balance; }
        set
        {
            if (value >= 0)
            {
                _balance = value;
            }
            else
            {
                throw new ArgumentException("Balance cannot be negative.");
            }
        }
    }
    public CreditCard(string cardNumber, decimal initialBalance)
    {
        this.cardNumber = cardNumber;
        Balance = initialBalance;
    }
    public static CreditCard operator +(CreditCard card, decimal amount)
    {
        card.Balance += amount;
        return card;
    }

    public static CreditCard operator -(CreditCard card, decimal amount)
    {
        if (card.Balance - amount < 0)
        {
            throw new ArgumentException("Resulting balance cannot be negative.");
        }
        card.Balance -= amount;
        return card;
    }

    public static bool operator >(CreditCard card1, CreditCard card2)
    {
        return card1.Balance > card2.Balance;
    }

    public static bool operator <(CreditCard card1, CreditCard card2)
    {
        return card1.Balance < card2.Balance;
    }

    public override string ToString()
    {
        return $"Card Number: {cardNumber}, Balance: {Balance:C}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is CreditCard otherCard)
        {
            return cardNumber == otherCard.cardNumber && Balance == otherCard.Balance;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(cardNumber, Balance);
    }

    public static bool operator ==(CreditCard card1, CreditCard card2)
    {
        if (ReferenceEquals(card1, card2))
        {
            return true;
        }
        if (ReferenceEquals(card1, null) || ReferenceEquals(card2, null))
        {
            return false;
        }
        return card1.Equals(card2);
    }

    public static bool operator !=(CreditCard card1, CreditCard card2)
    {
        return !(card1 == card2);
    }


}