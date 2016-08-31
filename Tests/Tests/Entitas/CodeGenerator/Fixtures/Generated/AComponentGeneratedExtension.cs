//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        static readonly AComponent aComponent = new AComponent();

        public bool isA {
            get { return HasComponent(PoolAComponentIds.A); }
            set {
                if (value != isA) {
                    if (value) {
                        AddComponent(PoolAComponentIds.A, aComponent);
                    } else {
                        RemoveComponent(PoolAComponentIds.A);
                    }
                }
            }
        }

        public Entity IsA(bool value) {
            isA = value;
            return this;
        }
    }
}

    public partial class PoolAMatcher {

        static IMatcher _matcherA;

        public static IMatcher A {
            get {
                if (_matcherA == null) {
                    var matcher = (Matcher)Matcher.AllOf(PoolAComponentIds.A);
                    matcher.componentNames = PoolAComponentIds.componentNames;
                    _matcherA = matcher;
                }

                return _matcherA;
            }
        }
    }
