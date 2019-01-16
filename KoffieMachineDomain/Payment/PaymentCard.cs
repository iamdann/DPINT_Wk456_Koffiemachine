using KoffieMachineDomain.Observable;
using KoffieMachineDomain.Users;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    public class PaymentCard : Observable<PaymentCard>, IPayment
    {
        public double RemainingPriceToPay { get; set; }
        public User User { get; set; }
        public ICollection<string> LogText { get; set; }

        public PaymentCard(User user, double remainingPriceToPay, ICollection<string> log)
        {
            User = user;
            RemainingPriceToPay = remainingPriceToPay;
            LogText = log;
        }

        public void Pay(double inserted)
        {
            if (User.Balance >= RemainingPriceToPay)
            {
                User.Balance -= inserted;
                RemainingPriceToPay = 0;
                LogText.Add($"Inserted {inserted.ToString("C", CultureInfo.CurrentCulture)}, Remaining: {RemainingPriceToPay.ToString("C", CultureInfo.CurrentCulture)}.");
            }
            else
            {
                double moneyLeft = User.Balance;
                User.Balance = 0;

                RemainingPriceToPay -= moneyLeft;
                LogText.Add($"Inserted {moneyLeft.ToString("C", CultureInfo.CurrentCulture)}, Remaining: {RemainingPriceToPay.ToString("C", CultureInfo.CurrentCulture)}.");
            }

            Notify(this);
        }
    }
}
