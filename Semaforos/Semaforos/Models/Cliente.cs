using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Semaforos.Models
{
    class Cliente : INotifyPropertyChanged
    {

        private String nameInnerField;

        public String Name
        {
            get { return nameInnerField; }
            set { nameInnerField = value;
                OnPropertyChanged("Name");
                OnPropertyChanged("FullName");
            }
        }

        private String lastNameInner;

        public String LastName
        {
            get { return lastNameInner; }
            set { lastNameInner = value;
                OnPropertyChanged("LastName");
                OnPropertyChanged("FullName");
            }
        }

        private String fullNammeInner;

        public String FullName
        {
            get { return Name + " " + LastName; }
            set { fullNammeInner = value;
                OnPropertyChanged("FullName");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public Cliente()
        {
            Name = "Fabián";
            LastName = "Barón";
        }

        private void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
