using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_het
{
    public class PlaneViewModel : ObservableRecipient, INotifyPropertyChanged
    {
        private string _name;
        private string _fault;
        private double _repairCost;
        private int _state; //zöld (0)- még repülni képes, sárga(1)
                              //- csak indokolt esetben repülhet, piros(2)
                              //- nem repülhet, minden egyéb - nincs szín

        public string Name
        {
            get => Name;
            set
            {
                 SetProperty(ref _name, value);
            }
        }

        public string Fault
        {
            get => Fault;
            set
            {
                SetProperty(ref _fault, value);
            }
        }

        public double RepairCost
        {
            get => RepairCost;
            set
            {
                SetProperty(ref _repairCost, value);
            }
        }

        public int State
        {
            get => State;
            set
            {
                SetProperty(ref _state, value);
            }
        }
    }
}
