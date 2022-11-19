using Demo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Demo.ViewModel
{
    public class VN_Manager : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public List<BmwCargo> listBmwCargos { get; set; }
       
    }
}
