﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MvApp.Views
{
    public partial class LivrosView : ContentPage
    {
        public LivrosView()
        {
            InitializeComponent();

            this.BindingContext = new ViewModels.LivrosViewModel();

            this.Lista.ItemTapped += async(sender, e) =>{
                var  Livro = e.Item as Model.Livro;
                await App.Current.MainPage.Navigation.PushAsync(new Views.AutorView(Livro.Autor));
            };          
        }

   
    }
}
