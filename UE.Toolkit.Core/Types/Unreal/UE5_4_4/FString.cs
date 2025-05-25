using System.Runtime.InteropServices;

namespace UE.Toolkit.Core.Types.Unreal.UE5_4_4;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct FString
{
    public TArray<char> Data;

    public override string ToString() => new(Data.AllocatorInstance, 0, Data.ArrayNum - 1);
}