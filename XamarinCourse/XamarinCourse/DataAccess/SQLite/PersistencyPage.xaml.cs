﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;

namespace XamarinCourse.DataAccess.Sqlite
{
	public partial class PersistencyPage : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe> _recipes;

		public PersistencyPage()
		{
			InitializeComponent();

            _connection = DependencyService.Get<SqlLiteDb>().GetConnection();
        }

        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<Recipe>();

            var recipes = await _connection.Table<Recipe>().ToListAsync();
            _recipes = new ObservableCollection<Recipe>(recipes);
            recipesListView.ItemsSource = _recipes;

            base.OnAppearing();
        }

        async void OnAdd(object sender, EventArgs e)
		{
            var recipe = new Recipe(){ Name="Recipe " + DateTime.Now.Ticks};

            await _connection.InsertAsync(recipe);

            _recipes.Add(recipe);
        }

		async void OnUpdate(object sender, EventArgs e)
		{
            var recipe = _recipes[0];
            recipe.Name += "Updated!";

            await _connection.UpdateAsync(recipe);
        }

		async void OnDelete(object sender, EventArgs e)
        {
            var recipe = _recipes[0];

            await _connection.DeleteAsync(recipe);

            _recipes.Remove(recipe);
        }
	}
}