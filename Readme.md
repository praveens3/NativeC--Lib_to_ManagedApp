# A C++\CLI wrapper project

## Native C++ lib consumed by Managed C# app via. C++/CLI wrapper dll

## projects
1. Native C++ lib
    MathUtils.lib - static library
    unmanaged

2. C++/CLI wrapper dll
    wrapper MathUtilsWrap.dll to MathUtils.lib

3. Managed C# app via.
    consume MathUtils.lib via. MathutilsWrap.dll