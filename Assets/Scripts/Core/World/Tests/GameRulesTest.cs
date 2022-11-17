using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.World.Tests
{
    public class GameTest
    {
        private Game _game;
        
        [SetUp]
        public void SetUp()
        {
            var gameObject = new GameObject();
            _game = gameObject.AddComponent<Game>();
        }

        [TearDown]
        public void TearDown()
        {
            _game = null;
        }
        
        [Test]
        public void Game_Will_End_If_All_All_Tile_Goal_HighLighted()
        {
            var tileGoal = new GameObject().AddComponent<TileGoal>();
            _game.Init(new List<TileGoal>{tileGoal}, new List<IGameRule>{new AllGoalTileHighLighted()});
            bool wasGameEnded = false;
            _game.GameEnded += () => { wasGameEnded = true; };
            
            tileGoal.HighLight();
            
            Assert.True(wasGameEnded);
        }
    }
}