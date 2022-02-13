using Game.DataAccess;
using Game.DataAccess.Entities;
using Game.DataAccess.Entities.Storage;
using System.Drawing;
using System.Text.Json.Nodes;

namespace Game.Api
{
    public class DataInitializatitor
    {
        private readonly GameContext _gameContext;

        public DataInitializatitor(GameContext gameContext)
        {
            _gameContext = gameContext;
        }

        public void Init()
        {
            var akItem = new ItemEntity
            {
                Id = "AK_74",
                Name = "AK sdafds",
                Description = "fsdfsd",
                Schema = "",
                Widht = 5,
                Height = 2
            };

            var itemInstance = new ItemInstanceEntity { Id = Guid.NewGuid(), ItemId = "AK_74", Data = new JsonObject() };
            var storageInst = new StorageEntity { Id = Guid.Parse("d3176b73-6223-481f-a560-81549cc579df"), Height = 30, Width = 10, Name = "Main" };
            storageInst.Items.Add(new StorageItem { InstId = itemInstance.Id, Pos = new Point { X = 0, Y = 0 } });

            if (!_gameContext.Items.Any())
                _gameContext.Items.Add(akItem);

            if (!_gameContext.ItemInstances.Any())
                _gameContext.ItemInstances.Add(itemInstance);

            if (!_gameContext.StorageInstances.Any())
                _gameContext.StorageInstances.Add(storageInst);

            _gameContext.SaveChanges();
        }
    }
}
