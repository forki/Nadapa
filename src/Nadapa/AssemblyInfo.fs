﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Nadapa")>]
[<assembly: AssemblyProductAttribute("Nadapa")>]
[<assembly: AssemblyDescriptionAttribute("Simple micro-library for human readable dates parsing.")>]
[<assembly: AssemblyVersionAttribute("0.0.3")>]
[<assembly: AssemblyFileVersionAttribute("0.0.3")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.3"
