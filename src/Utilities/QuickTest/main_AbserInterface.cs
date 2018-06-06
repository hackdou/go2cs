﻿//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace go
{
    public static unsafe partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        public struct Abser<T> : Abser
        {
            private T m_target;

            private delegate double AbsByVal(T value);
            private delegate double AbsByRef(ref T value);

            private static readonly AbsByVal s_AbsByVal;
            private static readonly AbsByRef s_AbsByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public double Abs() => s_AbsByRef?.Invoke(ref m_target) ?? s_AbsByVal(m_target);

            [DebuggerStepperBoundary]
            static Abser()
            {
                Type targetType = typeof(T);
                Delegate extensionMethod;
                bool isByRef;

                extensionMethod = targetType.GetExtensionDelegate("Abs", out isByRef);

                // This run-time exception is a compile time error in Go, so it's not an expected exception if Go code compiles
                if ((object)extensionMethod == null)
                    throw new NotImplementedException($"{targetType.Name} does not implement Abser.Abs function");

                if (isByRef)
                    s_AbsByRef = extensionMethod as AbsByRef;
                else
                    s_AbsByVal = extensionMethod as AbsByVal;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Abser<T>(T target) => new Abser<T> { m_target = target };

            // Enable comparisons between nil and Abser<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Abser<T> value, NilType nil) => (object)value == null || Activator.CreateInstance<Abser<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Abser<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Abser<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Abser<T> value) => value != nil;
        }

        [GeneratedCode("go2cs", "0.1.1.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static Abser Abser_cast<T>(T target) => (Abser<T>)target;
    }
}

namespace go
{
    public partial class NilType
    {
        // Enable comparisons between nil and Abser interface
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(go.main_package.Abser value, NilType nil) => (object)value == null || Activator.CreateInstance(value.GetType()).Equals(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(go.main_package.Abser value, NilType nil) => !(value == nil);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(NilType nil, go.main_package.Abser value) => value == nil;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(NilType nil, go.main_package.Abser value) => value != nil;
    }
}