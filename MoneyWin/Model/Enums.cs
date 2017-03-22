using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyWin.Model
{
    public enum TransactionType
    {
        Deposit = 1,
        Withdrawal = 2,
        DepositIncludeTransfer =3,
        WithdrawalIncludeTransfer = 4,
        All = 5
    }

    public enum TransactionStatus
    {
        Open =1,
        Closed =2,
        Posted =3,
        All = 4
    }
}
