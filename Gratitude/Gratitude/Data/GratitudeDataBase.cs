using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gratitude.Data
{
    public class GratitudeDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public GratitudeDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Gratitude.Models.Gratitude>().Wait();
        }

        public Task<List<Gratitude.Models.Gratitude>> GetGratitudesAsync()
        {
            return _database.Table<Gratitude.Models.Gratitude>().ToListAsync();
        }

        public Task<Gratitude.Models.Gratitude> GetGratitudesAsync(int id)
        {
            return _database.Table<Gratitude.Models.Gratitude>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveGratitudesAsync(Gratitude.Models.Gratitude gratitude)
        {
            if (gratitude.ID != 0)
            {
                return _database.UpdateAsync(gratitude);
            }
            else
            {
                return _database.InsertAsync(gratitude);
            }
        }

        public Task<int> DeleteGratitudesAsync(Gratitude.Models.Gratitude gratitude)
        {
            return _database.DeleteAsync(gratitude);
        }
    }
}