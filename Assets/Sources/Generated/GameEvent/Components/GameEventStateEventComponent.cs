//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEventEntity {

    public StateEventComponent stateEvent { get { return (StateEventComponent)GetComponent(GameEventComponentsLookup.StateEvent); } }
    public bool hasStateEvent { get { return HasComponent(GameEventComponentsLookup.StateEvent); } }

    public void AddStateEvent(string newState) {
        var index = GameEventComponentsLookup.StateEvent;
        var component = CreateComponent<StateEventComponent>(index);
        component.state = newState;
        AddComponent(index, component);
    }

    public void ReplaceStateEvent(string newState) {
        var index = GameEventComponentsLookup.StateEvent;
        var component = CreateComponent<StateEventComponent>(index);
        component.state = newState;
        ReplaceComponent(index, component);
    }

    public void RemoveStateEvent() {
        RemoveComponent(GameEventComponentsLookup.StateEvent);
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
public sealed partial class GameEventMatcher {

    static Entitas.IMatcher<GameEventEntity> _matcherStateEvent;

    public static Entitas.IMatcher<GameEventEntity> StateEvent {
        get {
            if (_matcherStateEvent == null) {
                var matcher = (Entitas.Matcher<GameEventEntity>)Entitas.Matcher<GameEventEntity>.AllOf(GameEventComponentsLookup.StateEvent);
                matcher.componentNames = GameEventComponentsLookup.componentNames;
                _matcherStateEvent = matcher;
            }

            return _matcherStateEvent;
        }
    }
}