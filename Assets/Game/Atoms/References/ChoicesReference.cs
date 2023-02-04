using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Choices`. Inherits from `EquatableAtomReference&lt;Choices, ChoicesPair, ChoicesConstant, ChoicesVariable, ChoicesEvent, ChoicesPairEvent, ChoicesChoicesFunction, ChoicesVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ChoicesReference : EquatableAtomReference<
        Choices,
        ChoicesPair,
        ChoicesConstant,
        ChoicesVariable,
        ChoicesEvent,
        ChoicesPairEvent,
        ChoicesChoicesFunction,
        ChoicesVariableInstancer>, IEquatable<ChoicesReference>
    {
        public ChoicesReference() : base() { }
        public ChoicesReference(Choices value) : base(value) { }
        public bool Equals(ChoicesReference other) { return base.Equals(other); }
    }
}
