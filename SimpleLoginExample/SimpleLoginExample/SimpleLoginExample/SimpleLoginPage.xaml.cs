using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SimpleLoginExample
{
    public partial class SimpleLoginPage : ContentPage
    {
        private SimpleLoginViewModel simpleViewModel;
        
        public SimpleLoginPage(SimpleLoginViewModel simpleViewModel)
        {

            InitializeComponent();
            this.simpleViewModel = simpleViewModel;
            BindingContext = this.simpleViewModel;

        }
    }
}
