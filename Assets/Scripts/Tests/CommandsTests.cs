using System;
using NUnit.Framework;
using UnityEngine;

namespace LogiBotClone.Runtime.Tests
{
    public class CommandsTests
    {
        public Executor _executor;
        public GameObject _executorAgent;

        [SetUp]
        public void SetUp()
        {
            _executorAgent = new GameObject();
            _executor = _executorAgent.AddComponent<Executor>();
        }

        [TearDown]
        public void TearDown()
        {
            _executor = null;
        }

        [Test]
        [TestCase(NeighborTile.Up)]
        [TestCase( NeighborTile.Down)]
        [TestCase( NeighborTile.Right)]
        [TestCase( NeighborTile.Left)]
        public void Should_Move_To_Neighbor_Tile_Similar_Height(NeighborTile targetTitle)
        {
            var currentTileGameObject = new GameObject("currentTileGameObject");
            var currentTileTile = currentTileGameObject.AddComponent<Tile>();
            switch (targetTitle)
            {
                case NeighborTile.Up:
                    _executorAgent.transform.Rotate(Vector3.forward, 90);
                    var tileGameObject1 = new GameObject("0");
                    var tileNorth = tileGameObject1.AddComponent<Tile>();
                    currentTileTile.SetUp(tileNorth, null, null, null);
                    break;
                case NeighborTile.Down:
                    _executorAgent.transform.Rotate(Vector3.forward, 270);
                    var tileGameObject2 = new GameObject("0");
                    var tileDown = tileGameObject2.AddComponent<Tile>();
                    currentTileTile.SetUp(null, tileDown, null, null);
                    break;
                case NeighborTile.Right:
                    var tileGameObject3 = new GameObject("0");
                    var tileRight = tileGameObject3.AddComponent<Tile>();
                    currentTileTile.SetUp(null, null, tileRight, null);
                    break;
                case NeighborTile.Left:
                    _executorAgent.transform.Rotate(Vector3.forward, 180);
                    var tileGameObject = new GameObject("0");
                    var tileLeft = tileGameObject.AddComponent<Tile>();
                    currentTileTile.SetUp(null, null, null, tileLeft);
                    break;
            }

            _executor.OwnTile(currentTileTile);
            _executor.Execute(new Move());

            Assert.IsTrue(_executor.Tile.gameObject.name == "0");
        }

        [Test]
        [TestCase(NeighborTile.Up)]
        [TestCase( NeighborTile.Down)]
        [TestCase( NeighborTile.Right)]
        [TestCase( NeighborTile.Left)]
        public void Should_Not_Move_To_Neighbor_Tile_With_Different_Height(NeighborTile targetTitle)
        {
            var currentTileGameObject = new GameObject("currentTileGameObject");
            var currentTileTile = currentTileGameObject.AddComponent<Tile>();

            switch (targetTitle)
            {
                case NeighborTile.Up:
                    _executorAgent.transform.Rotate(Vector3.forward, 90);
                    var tileGameObject1 = new GameObject("0");
                    var tileNorth = tileGameObject1.AddComponent<Tile>();
                    tileNorth.SetHeight(1);
                    currentTileTile.SetUp(tileNorth, null, null, null);
                    break;
                case NeighborTile.Down:
                    _executorAgent.transform.Rotate(Vector3.forward, 270);
                    var tileGameObject2 = new GameObject("0");
                    var tileDown = tileGameObject2.AddComponent<Tile>();
                    tileDown.SetHeight(1);
                    currentTileTile.SetUp(null, tileDown, null, null);
                    break;
                case NeighborTile.Right:
                    var tileGameObject3 = new GameObject("0");
                    var tileRight = tileGameObject3.AddComponent<Tile>();
                    tileRight.SetHeight(1);
                    currentTileTile.SetUp(null, null, tileRight, null);
                    break;
                case NeighborTile.Left:
                    _executorAgent.transform.Rotate(Vector3.forward, 180);
                    var tileGameObject = new GameObject("0");
                    var tileLeft = tileGameObject.AddComponent<Tile>();
                    tileLeft.SetHeight(1);
                    currentTileTile.SetUp(null, null, null, tileLeft);
                    break;
            }

            _executor.OwnTile(currentTileTile);
            Debug.Log(_executor.Tile.gameObject.name);
            _executor.Execute(new Move());
            Debug.Log(_executor.Tile.gameObject.name);
            
            Assert.IsTrue(_executor.Tile.gameObject.name == "currentTileGameObject");
        }
    }
}