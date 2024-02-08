using System;

class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
      return derivedType.IsSubclassOf(baseType);
    }
}
