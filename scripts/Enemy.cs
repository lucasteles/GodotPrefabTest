using System;

namespace BetterPrefabs;

public partial class Enemy : Node
{
    public string EnemyName { get; set; }

    public override void _Ready()
    {
        var labelName = GetNode<Label>("%labelName");
        ArgumentNullException.ThrowIfNull(labelName);

        ArgumentNullException.ThrowIfNull(EnemyName);
        labelName.Text = EnemyName;
    }
}