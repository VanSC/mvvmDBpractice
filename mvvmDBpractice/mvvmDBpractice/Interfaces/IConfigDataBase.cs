using System;
using System.Collections.Generic;
using System.Text;

namespace mvvmDBpractice.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}
