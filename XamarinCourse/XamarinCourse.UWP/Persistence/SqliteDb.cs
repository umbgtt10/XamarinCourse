using System;
using System.IO;
using Windows.Storage;
using SQLite;
using Xamarin.Forms;
using XamarinCourse.DataAccess.Sqlite;
using XamarinCourse.UWP.Persistence;

[assembly: Dependency(typeof(WindowsSqlLiteDb))]

namespace XamarinCourse.UWP.Persistence
{
    public class WindowsSqlLiteDb : SqlLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
			var documentsPath = ApplicationData.Current.LocalFolder.Path;
        	var path = Path.Combine(documentsPath, "MySQLite.db3");
        	return new SQLiteAsyncConnection(path);
        }
    }
}

