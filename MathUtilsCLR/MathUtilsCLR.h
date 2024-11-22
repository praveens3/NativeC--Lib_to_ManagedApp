#pragma once
#include "MathUtils.h"

using namespace System;

namespace MathutilCLR {

    public ref class MathWrapper
    {
    private:
        MathUtilsLib::MathUtils* nativeMathUtils; // Pointer to the native class

    public:
        MathWrapper(); // Constructor
        ~MathWrapper(); // Destructor
        !MathWrapper(); // Finalizer

        // Managed wrapper methods
        int Add(int a, int b);
        double Add(double a, double b);
        int Multiply(int a, int b);
        double Multiply(double a, double b);
    };
}
