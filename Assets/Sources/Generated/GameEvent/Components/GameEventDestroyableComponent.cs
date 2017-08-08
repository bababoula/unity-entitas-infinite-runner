//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEventEntity {

    static readonly DestroyableComponent destroyableComponent = new DestroyableComponent();

    public bool isDestroyable {
        get { return HasComponent(GameEventComponentsLookup.Destroyable); }
        set {
            if (value != isDestroyable) {
                if (value) {
                    AddComponent(GameEventComponentsLookup.Destroyable, destroyableComponent);
                } else {
                    RemoveComponent(GameEventComponentsLookup.Destroyable);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEventEntity : IDestroyable { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameEventMatcher {

    static Entitas.IMatcher<GameEventEntity> _matcherDestroyable;

    public static Entitas.IMatcher<GameEventEntity> Destroyable {
        get {
            if (_matcherDestroyable == null) {
                var matcher = (Entitas.Matcher<GameEventEntity>)Entitas.Matcher<GameEventEntity>.AllOf(GameEventComponentsLookup.Destroyable);
                matcher.componentNames = GameEventComponentsLookup.componentNames;
                _matcherDestroyable = matcher;
            }

            return _matcherDestroyable;
        }
    }
}
