using System.Collections.Generic;
using System.Threading.Tasks;
using ERCPNow.Models;
using SQLite;

namespace ERCPNow.Data
{
    public class CalcDatabase
    {
        readonly SQLiteAsyncConnection database;

        public CalcDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<CalcModel>().Wait();
        }

        public Task<List<CalcModel>> GetCalcsAsync()
        {
            //Get all notes.
            return database.Table<CalcModel>().OrderByDescending(x => x.Id).ToListAsync();
        }
        
        public Task<CalcModel> GetNoteAsync(int id)
        {
            // Get a specific note.
            return database.Table<CalcModel>()
                .Where(i => i.Id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(CalcModel calc)
        {
            if (calc.Id != 0)
            {
                // Update an existing note.
                return database.UpdateAsync(calc);
            }
            else
            {
                // Save a new note.
                return database.InsertAsync(calc);
            }
        }

        public Task<int> DeleteNoteAsync(CalcModel calc)
        {
            // Delete a note.
            return database.DeleteAsync(calc);
        }
    }
}