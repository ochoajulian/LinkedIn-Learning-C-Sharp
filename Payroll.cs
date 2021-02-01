using System.Collections.Generic;

namespace LinkedIn_Learning_C_Sharp
{
    interface IPayee
    {
        void Pay();
    }
    class Payroll
    {

        private List<IPayee> payees = new List<IPayee>();

        public Payroll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
            
            Logger.Log("PayRoll Started", "Payroll");
        }
        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }
            
            Logger.Log("PayAll completed", "Payroll", 2);
        }   
    }
}