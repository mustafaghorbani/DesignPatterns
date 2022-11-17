
namespace ChainOfResponsibility
{
    /// <summary>
    /// Class holding request details
    /// </summary>
    public class Purchase
    {
        private int number;
        private double amount;
        private string purpose;

        // Ctor
        public Purchase(int number, double amount, string purpose)
        {
            this.number = number;
            this.amount = amount;
            this.purpose = purpose;
        }

        /// <summary>
        /// Gets or sets purchase Number
        /// </summary>
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        /// <summary>
        /// Gets or sets purchase Amount
        /// </summary>
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        /// <summary>
        /// Gets or sets purchase Purpose
        /// </summary>
        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
    }
}
