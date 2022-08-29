using Dangl.Calculator;
using System.Windows.Input;

namespace MauiCalculator.ViewModel
{
    public class CalcViewModel : BaseViewModel
    {
        public string Formula { get; set; }
        public string Result { get; set; } = "0";

        public ICommand OperationCommand => new Command((number) => { Formula += number.ToString(); });
        public ICommand ResetCommand => new Command(() =>
        {
            Result = "0";
            Formula = string.Empty;
        });
        public ICommand BackspaceCommand => new Command(() =>
        {
            if (Formula.Length > 0)
            {
                var index = Formula.LastOrDefault() == ' ' ? 3 : 1;
                Formula = Formula.Remove(Formula.Length - index, index);
            }
        });
        public ICommand CalculateCommand => new Command(() =>
        {
            if (Formula.Length == 0)
                return;
            var calcualtion = Calculator.Calculate(Formula);
            Result = calcualtion.Result.ToString();
        });
    }
}
