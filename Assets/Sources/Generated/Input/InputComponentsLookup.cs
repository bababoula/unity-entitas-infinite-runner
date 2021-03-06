//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentsLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class InputComponentsLookup {

    public const int Collision = 0;
    public const int Death = 1;
    public const int Destroyable = 2;
    public const int Jump = 3;

    public const int TotalComponents = 4;

    public static readonly string[] componentNames = {
        "Collision",
        "Death",
        "Destroyable",
        "Jump"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(CollisionComponent),
        typeof(DeathComponent),
        typeof(DestroyableComponent),
        typeof(JumpComponent)
    };
}
