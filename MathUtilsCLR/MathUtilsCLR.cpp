// MathUtilsCLR.cpp (C++/CLI wrapper)

#include "pch.h"
#include "MathUtilsCLR.h"

using namespace System;
using namespace MathutilCLR;

MathWrapper::MathWrapper() {
	nativeMathUtils = new MathUtilsLib::MathUtils();
}

MathWrapper::~MathWrapper() {
	this->!MathWrapper();
}

MathWrapper::!MathWrapper() {
	delete nativeMathUtils;
}

int MathWrapper::Add(int a, int b) {
	return nativeMathUtils->Add(a, b);
}

double MathWrapper::Add(double a, double b) {
	return nativeMathUtils->Add(a, b);
}

int MathWrapper::Multiply(int a, int b) {
	return nativeMathUtils->Multiply(a, b);
}

double MathWrapper::Multiply(double a, double b) {
	return nativeMathUtils->Multiply(a, b);
}

