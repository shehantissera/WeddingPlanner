using CommonLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingPlanner.Model;

namespace WeddingPlanner.ViewModel
{
    public class App_ViewModel : INotifyPropertyChanged
    {
        public App_ViewModel(WebInvoker _webinvoker, LocalSecurity _security)
        {
            Model = new App_Model(this, _webinvoker, _security);
        }

        #region Important
        private App_Model _Model;
        public App_Model Model
        {
            get { return _Model; }
            set
            {
                _Model = value;
                RaisePropertyChangedEvent("Model");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
