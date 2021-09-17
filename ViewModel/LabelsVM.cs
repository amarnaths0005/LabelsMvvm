
using Labels.Model;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Labels.ViewModel
{
    public class LabelsVM :INotifyPropertyChanged
    {
        private string _randomName;

        private RandomLabels _rand = new RandomLabels();

        public LabelsVM()
        {
            GetRandomName();
        }

        public string RandomName
        {
            get => _randomName;
            set
            {
                _randomName = value;
                RaisePropertyChangedEvent("RandomName");
            }
        }

        private void GetRandomName()
        {
            RandomName = _rand.SelectName();
        }

        public ICommand SelectNameCommand => new DelegateCommand(GetRandomName);

        public event PropertyChangedEventHandler PropertyChanged;


        protected void RaisePropertyChangedEvent(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            Console.WriteLine("PropertyChange raised for the " + propertyName + " property of an instance of " + this);
        }
    }
}
