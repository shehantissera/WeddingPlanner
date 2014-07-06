using CommonLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingPlanner.Contracts;
using WeddingPlanner.Model;

namespace WeddingPlanner.ViewModel
{
    public class App_ViewModel : INotifyPropertyChanged
    {
        private bool _IsBusy;
        public bool IsBusy
        {
            get { return _IsBusy; }
            set
            {
                _IsBusy = value;
                RaisePropertyChangedEvent("IsBusy");
            }
        }

        private bool _BusyContent;
        public bool BusyContent
        {
            get { return _BusyContent; }
            set
            {
                _BusyContent = value;
                RaisePropertyChangedEvent("BusyContent");
            }
        }


        private ObservableCollection<string> _SidesList;
        public ObservableCollection<string> SidesList
        {
            get { return _SidesList; }
            set
            {
                _SidesList = value;
                RaisePropertyChangedEvent("SidesList");
            }
        }


        private ObservableCollection<Expense> _ExpensesList;
        public ObservableCollection<Expense> ExpensesList
        {
            get { return _ExpensesList; }
            set
            {
                _ExpensesList = value;
                RaisePropertyChangedEvent("ExpensesList");
            }
        }
        public App_ViewModel(WebInvoker _webinvoker, LocalSecurity _security)
        {
            Model = new App_Model(this, _webinvoker, _security);
            SidesList = new ObservableCollection<string>();
            ExpensesList = new ObservableCollection<Expense>();

            LoadInitialData();
        }

        private void LoadInitialData()
        {
            Model.LoadSides();
            Model.LoadEmptyRows();
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
