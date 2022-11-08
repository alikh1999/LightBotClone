using LogiBotClone.Runtime.World;
using NUnit.Framework;
using UnityEngine;

namespace LogiBotClone.Runtime.Tests
{
    public class GameTest
    {
        [Test]
        public void Game_Will_End_If_All_All_Tile_Goal_HighLighted()
        {
            var gameGameObject = new GameObject("Game");
            gameGameObject.AddComponent<Game>();
            var tileGameObject = new GameObject("Tile Goal");
            tileGameObject.AddComponent<TileGoal>();
            var game = gameGameObject.GetComponent<Game>();
            var tileGoal = tileGameObject.GetComponent<TileGoal>();
            game.AddTileGoal(tileGoal);
            bool wasGameEnded = false;
            game.GameEnded += () => { wasGameEnded = true; };
            
            tileGoal.HighLight();
            
            Assert.True(wasGameEnded);
        }
    }
}