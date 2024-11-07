using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Cloud.Firestore;
namespace Homework2Library
{
    [FirestoreData]
    public class UserTransaction
    {
        [FirestoreProperty]
        public string TransactionReason { get; set; }
        [FirestoreProperty]
        public double amount { get; set; }
        [FirestoreProperty]
        public DateTime TransactionDate { get; set; }

        public UserTransaction() { }
        public UserTransaction (double a_amount, string a_transactionreason, DateTime a_datetime)
        {
            amount = a_amount;
            TransactionReason = a_transactionreason;
            TransactionDate = a_datetime;
        }

        public double getAmount()
        {
            return amount;
        }

        public string getTransactionReason ()
        {
            return TransactionReason;
        }

        public DateTime getTransactionDateTime ()
        {
            return TransactionDate;
        }

        public void DisplayTransactionDetails()
        {
            Console.WriteLine("Amount: {0} Date Time: {1} Reason: {2} ", amount, TransactionDate, TransactionReason);
        }
    }
}
