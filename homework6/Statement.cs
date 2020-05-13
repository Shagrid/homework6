namespace homework6
{
    public class Statement
    {
        private int _summ;
        private Worker _applicant;
        private Worker _signatory;

        public Statement(int summ, Worker applicant)
        {
            _summ = summ;
            _applicant = applicant;
        }

        public void SignIn(Worker signatory)
        {
            _signatory = signatory;
        }

        public override string ToString()
        {
            return $"Запрошенная сумма: {_summ}, проситель: {_applicant.ToString()}, подписал: {_signatory.ToString()}";
        }
    }
}