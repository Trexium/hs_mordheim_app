
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexedSceneryMordheimApp.ViewModels
{
    public partial class CountExampleViewModel : ObservableObject
    {
        
        [ObservableProperty]
        private int _count;

        [ObservableProperty]
        private string _buttonText;

        public CountExampleViewModel()
        {
            _buttonText = "Click me!";
        }

        [RelayCommand]
        private void CountUp()
        {
            Count++;
            if (Count == 1)
                ButtonText = $"Clicked {Count} time";
            else
                ButtonText = $"Clicked {Count} times";

        }

    }
}
