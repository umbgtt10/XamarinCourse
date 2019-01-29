using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using XamarinCourse.DataAccess.Sqlite;
using XamarinCourse.Droid.Persistence;

[assembly: Dependency(typeof(DroidSqlLiteDb))]

namespace XamarinCourse.Droid.Persistence
{
	public class DroidSqlLiteDb : SqlLiteDb
	{
		public SQLiteAsyncConnection GetConnection()
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var path = Path.Combine(documentsPath, "MySQLite.db3");

			return new SQLiteAsyncConnection(path);
		}
	}
}

