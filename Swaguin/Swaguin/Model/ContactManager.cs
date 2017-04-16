using SQLite;
using Swaguin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaguin.Model
{
    public class ContactManager
    {
        private readonly SQLiteAsyncConnection conn;

        public ContactManager ()
        {
            this.conn = new SQLiteAsyncConnection(App.dbPath);
            conn.CreateTableAsync<Contact>().Wait();
        }

        public async Task<List<Contact>> GetAllContactAsync()
        {
                //return a list of people saved to the Person table in the database
                return await conn.Table<Contact>().ToListAsync();
        }

        public async Task AddNewContactAsync(string firstname)
        {
            //insert a new contact into the Contact table
            var result = await conn.InsertAsync("Samuel");
        }
    }
}
