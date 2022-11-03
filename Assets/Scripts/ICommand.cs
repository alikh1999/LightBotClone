using UnityEngine;
using UnityEngine.Tilemaps;

public interface ICommand
{ 
    void Execute(Tile tile, Transform player);
}