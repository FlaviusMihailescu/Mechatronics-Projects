﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLoginApp.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}