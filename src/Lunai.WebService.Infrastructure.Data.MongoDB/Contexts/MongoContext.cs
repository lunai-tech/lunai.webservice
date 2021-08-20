using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lunai.WebService.Infrastructure.Data.MongoDB.Contexts
{
    public class MongoContext
    {
        private IMongoDatabase Database { get; set; }
        
        public MongoClient MongoClient { get; set; }
        
        private readonly List<Func<Task>> _commands;
        
        public IClientSessionHandle Session { get; set; }

        public MongoContext(IConfiguration configuration)
        {
            // Every command will be stored and it'll be processed at SaveChanges
            _commands = new List<Func<Task>>();

            // Configure mongo (You can inject the config, just to simplify)
            MongoClient = new MongoClient(Environment.GetEnvironmentVariable("MONGOCONNECTION") ?? configuration.GetSection("MongoSettings").GetSection("Connection").Value);

            Database = MongoClient.GetDatabase(Environment.GetEnvironmentVariable("DATABASENAME") ?? configuration.GetSection("MongoSettings").GetSection("DatabaseName").Value);

        }

        public async Task<int> SaveChanges()
        {
            using (Session = await MongoClient.StartSessionAsync())
            {
                Session.StartTransaction();

                var commandTasks = _commands.Select(c => c());

                await Task.WhenAll(commandTasks);

                await Session.CommitTransactionAsync();
            }

            return _commands.Count;
        }

        public IMongoCollection<T> GetCollection<T>(string name) => Database.GetCollection<T>(name);

        public void Dispose()
        {
            Session?.Dispose();
            GC.SuppressFinalize(this);
        }

        public void AddCommand(Func<Task> func) => _commands.Add(func);
    }
}
