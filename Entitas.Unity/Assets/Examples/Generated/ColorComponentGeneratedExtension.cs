//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public partial class VisualDebugging : Entity {

    public ColorComponent color { get { return (ColorComponent)GetComponent(VisualDebuggingComponentIds.Color); } }

    public bool hasColor { get { return HasComponent(VisualDebuggingComponentIds.Color); } }

    public VisualDebugging AddColor(UnityEngine.Color newColor) {
        var component = CreateComponent<ColorComponent>(VisualDebuggingComponentIds.Color);
        component.color = newColor;
        AddComponent(VisualDebuggingComponentIds.Color, component);
        return this;
    }

    public VisualDebugging ReplaceColor(UnityEngine.Color newColor) {
        var component = CreateComponent<ColorComponent>(VisualDebuggingComponentIds.Color);
        component.color = newColor;
        ReplaceComponent(VisualDebuggingComponentIds.Color, component);
        return this;
    }

    public VisualDebugging RemoveColor() {
        RemoveComponent(VisualDebuggingComponentIds.Color);
        return this;
    }
}

public partial class VisualDebuggingMatcher {

    static IMatcher<VisualDebugging> _matcherColor;

    public static IMatcher<VisualDebugging> Color {
        get {
            if(_matcherColor == null) {
                var matcher = (Matcher<VisualDebugging>)Matcher<VisualDebugging>.AllOf(VisualDebuggingComponentIds.Color);
                matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                _matcherColor = matcher;
            }

            return _matcherColor;
        }
    }
}
