using System;

namespace BetterPrefabs;

public partial class Enemy : Node
{
    public string FirstName { get; set; }
    public string LastName { get; private set; } = "";

    public override void _Ready()
    {
        var labelName = GetNode<Label>("%labelName");
        ArgumentNullException.ThrowIfNull(labelName);
        ArgumentNullException.ThrowIfNull(FirstName);

        labelName.Text = $"{FirstName}{LastName}";
    }

    // fake constructor, only way to ser last-name
    public static Enemy Instantiate(string firstName, string lastName = "")
    {
        var instance = Prefab.Instantiate<Enemy>("enemy");
        instance.FirstName = firstName;
        instance.LastName = lastName;

        return instance;
    }
}
