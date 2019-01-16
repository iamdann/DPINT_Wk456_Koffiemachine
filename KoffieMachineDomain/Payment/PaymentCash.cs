using KoffieMachineDomain.Observable;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    public class PaymentCash : Observable<PaymentCash>, IPayment
    {
        public double RemainingPriceToPay { get; set; }
        public ICollection<string> LogText { get; set; }

        public PaymentCash(double remainingPriceToPay, ICollection<string> log)
        {
            RemainingPriceToPay = remainingPriceToPay;
            LogText = log;
        }

        public void Pay(double inserted)
        {
            RemainingPriceToPay = Math.Max(Math.Round(RemainingPriceToPay - inserted, 2), 0);
            LogText.Add($"Inserted {inserted.ToString("C", CultureInfo.CurrentCulture)}, Remaining: {RemainingPriceToPay.ToString("C", CultureInfo.CurrentCulture)}.");

            Notify(this);
        }
    }
}
