//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {

    public partial class Entity {

        public DefautPoolIndexKeyComponent defautPoolIndexKey { get { return (DefautPoolIndexKeyComponent)GetComponent(ComponentIds.DefautPoolIndexKey); } }

        public bool hasDefautPoolIndexKey { get { return HasComponent(ComponentIds.DefautPoolIndexKey); } }

        public Entity AddDefautPoolIndexKey(string newName) {
            var component = CreateComponent<DefautPoolIndexKeyComponent>(ComponentIds.DefautPoolIndexKey);
            component.name = newName;
            return AddComponent(ComponentIds.DefautPoolIndexKey, component);
        }

        public Entity ReplaceDefautPoolIndexKey(string newName) {
            var component = CreateComponent<DefautPoolIndexKeyComponent>(ComponentIds.DefautPoolIndexKey);
            component.name = newName;
            ReplaceComponent(ComponentIds.DefautPoolIndexKey, component);
            return this;
        }

        public Entity RemoveDefautPoolIndexKey() {
            return RemoveComponent(ComponentIds.DefautPoolIndexKey);
        }
    }

    public partial class Matcher {

        static IMatcher _matcherDefautPoolIndexKey;

        public static IMatcher DefautPoolIndexKey {
            get {
                if (_matcherDefautPoolIndexKey == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.DefautPoolIndexKey);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherDefautPoolIndexKey = matcher;
                }

                return _matcherDefautPoolIndexKey;
            }
        }
    }
}
