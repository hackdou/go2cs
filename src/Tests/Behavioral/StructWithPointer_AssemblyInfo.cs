using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

// Assembly identity attributes.
[assembly: AssemblyVersion("0.1.*")]

// Informational attributes.
[assembly: AssemblyCompany("")]
[assembly: AssemblyCopyright("Copyright (c) 2018")]
[assembly: AssemblyProduct("https://git.io/vhJqw")]

// Assembly manifest attributes.
#if DEBUG
[assembly: AssemblyConfiguration("Debug Build")]
#else
[assembly: AssemblyConfiguration("Release Build")]
#endif

[assembly: AssemblyTitle("StructWithPointer")]
[assembly: AssemblyDescription("StructWithPointer - auto-converted with go2cs")]

// Other configuration attributes.
[assembly: ComVisible(false)]
[assembly: CLSCompliant(false)]
[assembly: Guid("844214d8-096d-408a-b148-6b847445cd68")]
[assembly: NeutralResourcesLanguage("en-US")]