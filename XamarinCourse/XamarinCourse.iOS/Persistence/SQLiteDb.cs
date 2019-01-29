using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using XamarinCourse.DataAccess.Sqlite;
using XamarinCourse.iOS.Persistence;

[assembly: Dependency(typeof(IosSqlLiteDb))]

namespace XamarinCourse.iOS.Persistence
{
    public class IosSqlLiteDb : SqlLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}

