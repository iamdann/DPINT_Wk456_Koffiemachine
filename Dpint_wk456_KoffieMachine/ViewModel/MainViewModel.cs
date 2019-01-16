using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using KoffieMachineDomain;
using KoffieMachineDomain.Decorator;
using KoffieMachineDomain.Enums;
using KoffieMachineDomain.Factory;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;

namespace Dpint_wk456_KoffieMachine.ViewModel
{
    public class MainViewModel : ViewModelBase, IObserver<PaymentCard>, IObserver<PaymentCash>
    { 
        #region Variables
        public ObservableCollection<string> LogText { get; private set; }
        public DrinkFactory DrinkFactory { get; set; }
        public UserFactory UserFactory { get; set; }

        private IDrink _selectedDrink;
        private Strength _coffeeStrength;
        public Strength CoffeeStrength
        {
            get { return _coffeeStrength; }
            set { _coffeeStrength = value; RaisePropertyChanged(() => CoffeeStrength); }
        }
        private Amount _sugarAmount;
        public Amount SugarAmount
        {
            get { return _sugarAmount; }
            set { _sugarAmount = value; RaisePropertyChanged(() => SugarAmount); }
        }
        private Amount _milkAmount;
        public Amount MilkAmount
        {
            get { return _milkAmount; }
            set { _milkAmount = value; RaisePropertyChanged(() => MilkAmount); }
        }
        private Blend _teaBlend;
        public Blend TeaBlend
        {
            get { return _teaBlend; }
            set { _teaBlend = value; RaisePropertyChanged(() => TeaBlend); }
        }
        public double PaymentCardRemainingAmount => UserFactory.Users.ContainsKey(SelectedPaymentCardUsername ?? "") ? UserFactory.GetUser(SelectedPaymentCardUsername).Balance : 0;
        public ObservableCollection<string> PaymentCardUsernames { get; set; }
        private string _selectedPaymentCardUsername;
        public string SelectedPaymentCardUsername
        {
            get { return _selectedPaymentCardUsername; }
            set
            {
                _selectedPaymentCardUsername = value;
                RaisePropertyChanged(() => SelectedPaymentCardUsername);
                RaisePropertyChanged(() => PaymentCardRemainingAmount);
            }
        }
        private double _remainingPriceToPay;
        public double RemainingPriceToPay
        {
            get { return _remainingPriceToPay; }
            set { _remainingPriceToPay = value; RaisePropertyChanged(() => RemainingPriceToPay); }
        }
        #endregion

        public MainViewModel()
        {
            DrinkFactory = new DrinkFactory();
            UserFactory = new UserFactory();

            _coffeeStrength = Strength.Normal;
            _sugarAmount = Amount.Normal;
            _milkAmount = Amount.Normal;
            _teaBlend = Blend.GreenTea;

            LogText = new ObservableCollection<string>();
            LogText.Add("Starting up...");
            LogText.Add("Done, what would you like to drink?");

            PaymentCardUsernames = new ObservableCollection<string>(UserFactory.Usernames);
            SelectedPaymentCardUsername = PaymentCardUsernames[0];
        }

        #region Commands (payment and buttons)
        public ICommand PayByCardCommand => new RelayCommand(() =>
        {
            var payment = new PaymentCard(UserFactory.GetUser(SelectedPaymentCardUsername), RemainingPriceToPay, LogText);
            payment.Subscribe(this);
            payment.Pay(RemainingPriceToPay);
        });

        public ICommand PayByCoinCommand => new RelayCommand<double>(coinValue =>
        {
            var payement = new PaymentCash(RemainingPriceToPay, LogText);
            payement.Subscribe(this);
            payement.Pay(inserted: coinValue);
        });

        public ICommand DrinkCommand => new RelayCommand<string>((drinkName) =>
        {
            _selectedDrink = DrinkFactory.MakeDrink(drinkName, CoffeeStrength, SugarAmount, MilkAmount, TeaBlend);

            SendDrinkUpdate();
        });

        public ICommand DrinkWithSugarCommand => new RelayCommand<string>((drinkName) =>
        {
            IDrink drink = DrinkFactory.MakeDrink(drinkName, CoffeeStrength, SugarAmount, MilkAmount, TeaBlend);
            _selectedDrink = DrinkFactory.AddSugar(drink);

            SendDrinkUpdate();
        });

        public ICommand DrinkWithMilkCommand => new RelayCommand<string>((drinkName) =>
        {
            IDrink drink = DrinkFactory.MakeDrink(drinkName, CoffeeStrength, SugarAmount, MilkAmount, TeaBlend);
            _selectedDrink = DrinkFactory.AddMilk(drink);

            SendDrinkUpdate();
        });

        public ICommand DrinkWithSugarAndMilkCommand => new RelayCommand<string>((drinkName) =>
        {
            IDrink drink = DrinkFactory.MakeDrink(drinkName, CoffeeStrength, SugarAmount, MilkAmount, TeaBlend);
            _selectedDrink = DrinkFactory.AddSugarAndMilk(drink);

            SendDrinkUpdate();
        });
        #endregion

        #region Updaters (Observables)
        public void OnNext(PaymentCard value)
        {
            RaisePropertyChanged("PaymentCardRemainingAmount");
            RemainingPriceToPay = value.RemainingPriceToPay;
            if (RemainingPriceToPay == 0)
                FinishMakingDrink();
        }
        public void OnNext(PaymentCash value)
        {
            RemainingPriceToPay = value.RemainingPriceToPay;
            if (RemainingPriceToPay == 0)
                FinishMakingDrink();
        }

        private void FinishMakingDrink()
        {
            if (_selectedDrink != null)
            {
                _selectedDrink.LogText(LogText);
                LogText.Add($"Finished making {_selectedDrink.Name}");
                LogText.Add("------------------");
                _selectedDrink = null;
            }
        }

        private void SendDrinkUpdate()
        {
            RemainingPriceToPay = _selectedDrink.Price;
            LogText.Add($"Selected {_selectedDrink.Name}, price: {RemainingPriceToPay.ToString("C", CultureInfo.CurrentCulture)}");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error.StackTrace);
        }

        public void OnCompleted()
        {
            
        }
        #endregion
    }
}