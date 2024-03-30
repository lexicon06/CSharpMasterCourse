namespace ExtensionMethodsOwn
{
    public class ATMBankModel : PersonModel
    {
        public decimal Balance { get; set; } // Changed from static to instance property
        public decimal Tax => Balance * 0.05m; // Calculate tax based on current balance

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            Balance -= amount - Tax;
        }
    }
}
