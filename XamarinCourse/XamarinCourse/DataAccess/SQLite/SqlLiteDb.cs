using SQLite;

namespace XamarinCourse.DataAccess.Sqlite
{
    public interface SqlLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}

