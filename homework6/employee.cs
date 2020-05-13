namespace homework6
{
    public sealed class Employee : Worker
    {
        public Statement Statement;
        public Employee(bool canSign, Worker nextWorker) : base(canSign, nextWorker)
        {
        }

        public void CreateStatement(int price)
        {
            Statement = new Statement(price, this);
        }
        
    }
}