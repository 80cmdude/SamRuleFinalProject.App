﻿using FinalProjectApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PropertyChanged;

namespace FinalProjectApp.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	public abstract class BaseViewModel : IViewModel
	{
		public BaseViewModel()
		{

		}

		public INavigation Navigation { get; set; }

		public virtual void OnAppearing()
		{

		}

		public virtual void OnDisappearing()
		{

		}
	}
}
