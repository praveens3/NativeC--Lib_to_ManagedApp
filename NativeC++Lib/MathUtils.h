#ifndef MATHUTILS_H
#define MATHUTILS_H

namespace MathUtilsLib {

    class MathUtils
    {
    public:
        MathUtils() = default;
        ~MathUtils() = default;

        int Add(int a, int b);
        double Add(double a, double b);

        int Multiply(int a, int b);
        double Multiply(double a, double b);
    };
}
#endif // MATHUTILS_H
