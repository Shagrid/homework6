using System;

namespace homework6
{
    public abstract class Worker
    {
        private bool _canSign;
        private Worker _nextWorker;

        protected Worker(bool canSign, Worker nextWorker)
        {
            _canSign = canSign;
            _nextWorker = nextWorker;
        }

        public virtual Statement SignIn(Statement statement)
        {
            if  (!_canSign && _nextWorker == null)
            {
                throw new Exception("Сотрудник должен иметь либо право на подпись, либо начальника!");
            }
            if (!_canSign && _nextWorker != null)
            {
                return _nextWorker.SignIn(statement);
            }
            
            statement.SignIn(this);
            return statement;

        }
        
        
        
    }
}