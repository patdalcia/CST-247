using BenchmarkBibleVerseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenchmarkBibleVerseApp.Service
{
    public class SecurityService
    {
        public SecurityDAO security;

        public SecurityService() { }

        public bool AddEntry(VerseEntryModel model)
        {
            security = new SecurityDAO();
            return security.AddEntryToDb(model);
        }

        public VerseEntryModel SearchEntry(VerseSearchModel search)
        {
            security = new SecurityDAO();
            return security.SearchEntryFromDb(search);            
        }
    }
}