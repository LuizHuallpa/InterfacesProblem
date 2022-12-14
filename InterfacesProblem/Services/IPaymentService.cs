using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesProblem.Services
{
    interface IPaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
