namespace homework6
{
    public class Director : Worker
    {
        public Director(bool canSign, Worker nextWorker) : base(canSign, nextWorker)
        {
        }
    }
}