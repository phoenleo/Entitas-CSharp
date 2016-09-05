//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public class CoolNameComponent : IComponent {
    public BadName value;
}

public partial class VisualDebugging : Entity {

    public CoolNameComponent coolName { get { return (CoolNameComponent)GetComponent(VisualDebuggingComponentIds.CoolName); } }

    public bool hasCoolName { get { return HasComponent(VisualDebuggingComponentIds.CoolName); } }

    public VisualDebugging AddCoolName(BadName newValue) {
        var component = CreateComponent<CoolNameComponent>(VisualDebuggingComponentIds.CoolName);
        component.value = newValue;
        AddComponent(VisualDebuggingComponentIds.CoolName, component);
        return this;
    }

    public VisualDebugging ReplaceCoolName(BadName newValue) {
        var component = CreateComponent<CoolNameComponent>(VisualDebuggingComponentIds.CoolName);
        component.value = newValue;
        ReplaceComponent(VisualDebuggingComponentIds.CoolName, component);
        return this;
    }

    public VisualDebugging RemoveCoolName() {
        RemoveComponent(VisualDebuggingComponentIds.CoolName);
        return this;
    }
}

public partial class VisualDebuggingMatcher {

    static IMatcher<VisualDebugging> _matcherCoolName;

    public static IMatcher<VisualDebugging> CoolName {
        get {
            if(_matcherCoolName == null) {
                var matcher = (Matcher<VisualDebugging>)Matcher<VisualDebugging>.AllOf(VisualDebuggingComponentIds.CoolName);
                matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                _matcherCoolName = matcher;
            }

            return _matcherCoolName;
        }
    }
}
