using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace XamarinKofteciYusufClone.Models
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
