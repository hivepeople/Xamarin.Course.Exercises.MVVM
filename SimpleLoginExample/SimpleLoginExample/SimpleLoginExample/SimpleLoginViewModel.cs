using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoginExample
{
    public class SimpleLoginViewModel : INotifyPropertyChanged
    {
        private string versionText = "1.2.4";
        private string code;
        private bool entryCodeOk;
        private string statusText = "Indtast telefonnummer";

        public event PropertyChangedEventHandler PropertyChanged;

        public string VersionText
        {
            get
            {
                return versionText;
            }

            set
            {
                versionText = value;
                NotifyPropertyChanged();
            }
        }

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
                NotifyPropertyChanged();
                if (Code!=null && Code.Length == 8)
                {
                    EntryCodeIsOk = true;
                }
                else
                {
                    EntryCodeIsOk = false;
                }
            }
        }

        public bool EntryCodeIsOk
        {
            get
            {
                return entryCodeOk;
            }

            set
            {
                entryCodeOk = value;
                NotifyPropertyChanged();
            }
        }

        public string StatusText
        {
            get
            {
                return statusText;
            }

            set
            {
                statusText = value;
                NotifyPropertyChanged();
            }
        }

        public virtual void NotifyPropertyChanged([CallerMemberName] string propertyName="")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}
