using System;

namespace BetterPrefabs;

public static class Prefab
{
    public static PackedScene Find(string name)
        => GD.Load<PackedScene>($"res://prefabs/{name}.tscn");

    public static T Instantiate<T>(string name) where T : Node
    {
        var prefab = Find(name);
        ArgumentNullException.ThrowIfNull(prefab);
        return prefab.Instantiate<T>();
    }
}
