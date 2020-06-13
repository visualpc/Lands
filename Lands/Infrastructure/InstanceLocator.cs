﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lands.Infrastructure
{
    using ViewModels;
    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        { 
            get; 
            set; 
        }
        #endregion

        #region Constructor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}