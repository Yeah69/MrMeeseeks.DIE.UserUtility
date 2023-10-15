using System;

namespace MrMeeseeks.DIE.UserUtility;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public class InjectionKeyAttribute : Attribute
{
    public InjectionKeyAttribute(object key) => Key = key;

    public object Key { get; }
}

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class DecorationOrdinalAttribute : Attribute
{
    public DecorationOrdinalAttribute(int ordinal) => Ordinal = ordinal;

    public int Ordinal { get; }
}