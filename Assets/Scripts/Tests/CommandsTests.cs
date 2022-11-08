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
            var tileOwner = _executorAgent.AddComponent<TileOwner>();
            _executor = _executorAgent.AddComponent<Executor>();
            _executor.Init(tileOwner);
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
        public void Should_Move_To_Neighbor_Tile_Same_Height_With_Move_Command(NeighborTile targetTitle)
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

            _executor.TileOwner.OwnTile(currentTileTile);
            _executor.Execute(new Move());

            Assert.IsTrue(_executor.TileOwner.Tile.gameObject.name == "0");
        }

        [Test]
        [TestCase(NeighborTile.Up)]
        [TestCase( NeighborTile.Down)]
        [TestCase( NeighborTile.Right)]
        [TestCase( NeighborTile.Left)]
        public void Should_Not_Move_To_Neighbor_Tile_With_Different_Height_With_Move_Command(NeighborTile targetTitle)
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

            _executor.TileOwner.OwnTile(currentTileTile);
            _executor.Execute(new Move());

            Assert.IsTrue(_executor.TileOwner.Tile.gameObject.name == "currentTileGameObject");
        }

        [Test]
        [TestCase(NeighborTile.Up)]
        [TestCase(NeighborTile.Down)]
        [TestCase(NeighborTile.Right)]
        [TestCase(NeighborTile.Left)]
        public void Should_Not_Move_To_Neighbor_Tile_Does_Not_Exist_With_Move_Command(NeighborTile targetTitle)
        {
            var currentTileGameObject = new GameObject("currentTileGameObject");
            var currentTileTile = currentTileGameObject.AddComponent<Tile>();

            switch (targetTitle)
            {
                case NeighborTile.Up:
                    _executorAgent.transform.Rotate(Vector3.forward, 90);
                    break;
                case NeighborTile.Down:
                    _executorAgent.transform.Rotate(Vector3.forward, 270);
                    break;
                case NeighborTile.Right:
                    break;
                case NeighborTile.Left:
                    _executorAgent.transform.Rotate(Vector3.forward, 180);
                    break;
            }
            
            currentTileTile.SetUp(null, null, null, null);

            _executor.TileOwner.OwnTile(currentTileTile);
            _executor.Execute(new Move());

            Assert.IsTrue(_executor.TileOwner.Tile.gameObject.name == "currentTileGameObject");
        }
        
        [Test]
        [TestCase(NeighborTile.Up)]
        [TestCase( NeighborTile.Down)]
        [TestCase( NeighborTile.Right)]
        [TestCase( NeighborTile.Left)]
        public void Should_Move_To_Neighbor_Tile_Different_Height_With_Jump_Command(NeighborTile targetTitle)
        {
            var currentTileGameObject = new GameObject("currentTileGameObject");
            var currentTileTile = currentTileGameObject.AddComponent<Tile>();
            currentTileTile.SetHeight(0);
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

            _executor.TileOwner.OwnTile(currentTileTile);
            _executor.Execute(new Jump());

            Assert.IsTrue(_executor.TileOwner.Tile.gameObject.name == "0");
        }
        
        [Test]
        [TestCase(NeighborTile.Up)]
        [TestCase( NeighborTile.Down)]
        [TestCase( NeighborTile.Right)]
        [TestCase( NeighborTile.Left)]
        public void Should_Not_Move_To_Neighbor_Tile_Same_Height_With_Jump_Command(NeighborTile targetTitle)
        {
            var currentTileGameObject = new GameObject("currentTileGameObject");
            var currentTileTile = currentTileGameObject.AddComponent<Tile>();
            currentTileTile.SetHeight(0);
            switch (targetTitle)
            {
                case NeighborTile.Up:
                    _executorAgent.transform.Rotate(Vector3.forward, 90);
                    var tileGameObject1 = new GameObject("0");
                    var tileNorth = tileGameObject1.AddComponent<Tile>();
                    tileNorth.SetHeight(0);
                    currentTileTile.SetUp(tileNorth, null, null, null);
                    break;
                case NeighborTile.Down:
                    _executorAgent.transform.Rotate(Vector3.forward, 270);
                    var tileGameObject2 = new GameObject("0");
                    var tileDown = tileGameObject2.AddComponent<Tile>();
                    tileDown.SetHeight(0);
                    currentTileTile.SetUp(null, tileDown, null, null);
                    break;
                case NeighborTile.Right:
                    var tileGameObject3 = new GameObject("0");
                    var tileRight = tileGameObject3.AddComponent<Tile>();
                    tileRight.SetHeight(0);
                    currentTileTile.SetUp(null, null, tileRight, null);
                    break;
                case NeighborTile.Left:
                    _executorAgent.transform.Rotate(Vector3.forward, 180);
                    var tileGameObject = new GameObject("0");
                    var tileLeft = tileGameObject.AddComponent<Tile>();
                    tileLeft.SetHeight(0);
                    currentTileTile.SetUp(null, null, null, tileLeft);
                    break;
            }

            _executor.TileOwner.OwnTile(currentTileTile);
            _executor.Execute(new Jump());

            Assert.IsTrue(_executor.TileOwner.Tile.gameObject.name == "currentTileGameObject");
        }
        
        [Test]
        [TestCase(NeighborTile.Up)]
        [TestCase( NeighborTile.Down)]
        [TestCase( NeighborTile.Right)]
        [TestCase( NeighborTile.Left)]
        public void Should_Not_Move_To_Neighbor_Tile_Does_Not_Exist_With_Jump_Command(NeighborTile targetTitle)
        {
            var currentTileGameObject = new GameObject("currentTileGameObject");
            var currentTileTile = currentTileGameObject.AddComponent<Tile>();
            currentTileTile.SetHeight(0);
            switch (targetTitle)
            {
                case NeighborTile.Up:
                    _executorAgent.transform.Rotate(Vector3.forward, 90);
                    break;
                case NeighborTile.Down:
                    _executorAgent.transform.Rotate(Vector3.forward, 270);
                    break;
                case NeighborTile.Right:
                    break;
                case NeighborTile.Left:
                    _executorAgent.transform.Rotate(Vector3.forward, 180);
                    
                    break;
            }
            currentTileTile.SetUp(null, null, null, null);
            
            
            _executor.TileOwner.OwnTile(currentTileTile);
            _executor.Execute(new Jump());

            Assert.IsTrue(_executor.TileOwner.Tile.gameObject.name == "currentTileGameObject");
        }
        
        [Test]
        [TestCase(0)]
        [TestCase(90)]
        [TestCase(180)]
        [TestCase(270)]
        public void Should_Rotate_90_Degree_To_Left_With_Rotate_To_Left_Command(float angle)
        {
            _executorAgent.transform.Rotate(Vector3.forward, angle);
            
            _executor.Execute(new RotateToLeft());
            
            Assert.IsTrue(_executorAgent.transform.eulerAngles.z == (angle != 270 ? angle  + 90 : 0));
        }
        
        [Test]
        [TestCase(0)]
        [TestCase(90)]
        [TestCase(180)]
        [TestCase(270)]
        public void Should_Rotate_90_Degree_To_Right_With_Rotate_To_Right_Command(float angle)
        {
            _executorAgent.transform.Rotate(Vector3.forward, angle);
            
            _executor.Execute(new RotateToRight());
            
            Assert.IsTrue(_executorAgent.transform.eulerAngles.z == (angle == 0 ? 270 : angle - 90));
        }
    }
}