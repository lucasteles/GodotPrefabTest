using BetterPrefabs;

public partial class EnemyManager : Node
{
	[Export] int enemyCount;

	public override void _Ready()
	{
		DefaultWay();
	}

	void DefaultWay()
	{
		var prefab = Prefab.Find("enemy");

		for (var i = 0; i < enemyCount; i++)
		{
			var instance = prefab.Instantiate<Enemy>();
			instance.EnemyName = $"E{i:D2}";
			AddChild(instance);
		}
	}
}
