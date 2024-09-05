using System.Collections.Generic;
using System.Linq;
using BetterPrefabs;

public partial class EnemyManager : Node
{
    [Export] int enemyCount;

    public override void _Ready()
    {
        Enemy[] enemies =
        [
            ..DefaultWay(),
            ..NotALotBetterWay(),
            ..MaybeBetter(),
        ];

        foreach (var enemy in enemies)
            AddChild(enemy);
    }

    IEnumerable<Enemy> DefaultWay()
    {
        var prefab = Prefab.Find("enemy");

        for (var i = 0; i < enemyCount; i++)
        {
            var instance = prefab.Instantiate<Enemy>();
            instance.FirstName = $"A{i:D2}";
            // instance.LastName = "?"; // can't access

            yield return instance;
        }
    }

    IEnumerable<Enemy> NotALotBetterWay()
    {
        for (var i = 0; i < enemyCount; i++)
        {
            var instance = Prefab.Instantiate<Enemy>("enemy");
            instance.FirstName = $"B{i:D2}";
            // instance.LastName = "?"; // can't access

            yield return instance;
        }
    }

    IEnumerable<Enemy> MaybeBetter() =>
        Enumerable
            .Range(0, enemyCount)
            .Select(i => Enemy.Instantiate($"C{i:D2}", "!"));
}
