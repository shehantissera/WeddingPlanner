using CommonLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingPlanner.ViewModel;

namespace WeddingPlanner.Model
{
    public class App_Model
    {
        WebInvoker Invoker { get; set; }
        LocalSecurity Security { get; set; }
        public App_ViewModel ViewModel { get; set; }
        public App_Model(App_ViewModel _viewmodel, WebInvoker _invoker, LocalSecurity _security)
        {
            this.ViewModel = _viewmodel;
            this.Invoker = _invoker;
            this.Security = _security;
        }
    }
}
