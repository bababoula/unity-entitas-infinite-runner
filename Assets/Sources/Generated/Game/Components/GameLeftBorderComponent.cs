//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly LeftBorderComponent leftBorderComponent = new LeftBorderComponent();

    public bool isLeftBorder {
        get { return HasComponent(GameComponentsLookup.LeftBorder); }
        set {
            if (value != isLeftBorder) {
                if (value) {
                    AddComponent(GameComponentsLookup.LeftBorder, leftBorderComponent);
                } else {
                    RemoveComponent(GameComponentsLookup.LeftBorder);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherLeftBorder;

    public static Entitas.IMatcher<GameEntity> LeftBorder {
        get {
            if (_matcherLeftBorder == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.LeftBorder);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherLeftBorder = matcher;
            }

            return _matcherLeftBorder;
        }
    }
}
