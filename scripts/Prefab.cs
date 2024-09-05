namespace BetterPrefabs;

public static class Prefab
{
    public static PackedScene Find(string name)
        => GD.Load<PackedScene>($"res://prefabs/{name}.tscn");

    // public static T InstantiatePrefab<T>(string name) where T : Node
    // {
    //     var prefab = GD.Load<PackedScene>($"res://prefabs/{name}.tscn");
    // }
}