# A simple C++\CLI wrapper project

## Native C++ lib consumed by Managed C# app via. C++/CLI wrapper dll

This project demonstrates how to bridge a **Native C++ Library** with a **Managed C# Application** using a **C++/CLI wrapper**. The native C++ library provides core mathematical utilities, while the C++/CLI wrapper acts as a bridge, allowing the managed C# application to consume these utilities seamlessly.

## Overview

The project is composed of three main components:

### 1. **Native C++ Library (MathUtils.lib)**
   - A static library written in native C++.
   - Contains core mathematical operations implemented in unmanaged C++.
   - Provides a set of mathematical utilities such as arithmetic operations, trigonometry functions, and more.

### 2. **C++/CLI Wrapper (MathUtilsWrap.dll)**
   - A dynamic-link library (DLL) that wraps around the native `MathUtils.lib`.
   - Acts as a bridge between the unmanaged C++ library and the managed C# application.
   - Exposes the unmanaged functions in a way that .NET applications can consume.
   - Allows seamless integration of native code into the managed environment using C++/CLI.

### 3. **Managed C# TestApp Application**
   - A .NET 8.0 application that consumes the `MathUtils.lib` via the `MathUtilsWrap.dll`.
   - Demonstrates the usage of the native C++ functions through the wrapper.
   - Aimed at showcasing the integration of native code into a managed environment.

## How It Works

### C++/CLI Wrapper Explanation
The **C++/CLI wrapper** (`MathUtilsWrap.dll`) acts as a middle layer between the unmanaged C++ library and the managed C# application:

- The wrapper exposes public `ref` classes and methods that are accessible to C#.
- These classes internally use `#include` directives to access the `MathUtils.lib` headers.
- Managed code in the wrapper interacts with the native code through C++ interop, allowing the C# app to utilize native functions without dealing with complex P/Invoke declarations.

