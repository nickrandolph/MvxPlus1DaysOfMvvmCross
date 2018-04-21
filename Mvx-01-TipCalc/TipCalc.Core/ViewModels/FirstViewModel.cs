using MvvmCross.Base;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TipCalc.Core.Services;

namespace TipCalc.Core.ViewModels
{
    public class FirstViewModel
     : MvxViewModel
    {
        private readonly ICalculationService _calculationService;
        public FirstViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
            Generosity = 20;
            SubTotal = 100;
        }

        public override async Task Initialize()
        {
            await Task.Delay(2000);
            await base.Initialize();
        }

        private double _generosity;
        public double Generosity
        {
            get { return _generosity; }
            set { SetProperty(ref _generosity, value); Recalc(); }
        }

        private double _subTotal;
        public double SubTotal
        {
            get { return _subTotal; }
            set { SetProperty(ref _subTotal, value); Recalc(); }
        }

        private double _tip;
        public double Tip
        {
            get { return _tip; }
            set { SetProperty(ref _tip, value); }
        }

        private double _total;
        public double Total
        {
            get { return _total; }
            set { SetProperty(ref _total, value); }
        }

        private void Recalc()
        {
            Tip = _calculationService.Tip(SubTotal, Generosity);
            Total = SubTotal + Tip;
        }
    }
}
