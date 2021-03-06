(*** hide ***)
#I "../../out/lib/net40"
#r "MathNet.Numerics.dll"
#r "MathNet.Numerics.FSharp.dll"

(**
Getting Started
===============

Installation Instructions
-------------------------

The recommended way to get Math.NET Numerics is to use NuGet. The following packages are provided and maintained in the public [NuGet Gallery](https://nuget.org/profiles/mathnet/):

- **MathNet.Numerics** - core package, including .Net 4, .Net 3.5 and portable/PCL builds.
- **MathNet.Numerics.FSharp** - optional extensions for a better F# experience. BigRational.
- **MathNet.Numerics.Data.Text** - optional extensions for text-based matrix input/output.
- **MathNet.Numerics.Data.Matlab** - optional extensions for MATLAB matrix file input/output.
- **MathNet.Numerics.MKL.Win-x86** - optional Linear Algebra MKL native provider.
- **MathNet.Numerics.MKL.Win-x64** - optional Linear Algebra MKL native provider.
- **MathNet.Numerics.Signed** - strong-named version of the core package *(not recommended)*.
- **MathNet.Numerics.FSharp.Signed** - strong-named version of the F# package *(not recommended)*.

Alternatively you can also download the binaries in Zip packages, available on [CodePlex](http://mathnetnumerics.codeplex.com/releases):

- Binaries - core package and F# extensions, including .Net 4, .Net 3.5 and portable/PCL builds.
- Signed Binaries - strong-named version of the core package *(not recommended)*.

Supported Platforms:

- .Net 4.0, .Net 3.5 and Mono: Windows, Linux and Mac.
- PCL Portable Profiles 47 and 136: Silverlight 5, Windows Phone 8, .NET for Windows Store apps (Metro).
- PCL/Xamarin: Android, iOS  *(not verified due to lack of license and devices)*

Building Math.NET Numerics
--------------------------

If you do not want to use the official binaries, or if you like to modify, debug or contribute, you can compile Math.NET Numerics locally either using Visual Studio or manually with the build scripts.

* The Visual Studio solutions should build out of the box, without any preparation steps or package restores.
* Instead of a compatible IDE you can also build the solutions with `msbuild`, or on Mono with `xbuild`.
* The full build including unit tests, docs, NuGet and Zip packages is using [FAKE](http://fsharp.github.io/FAKE/).

### How to build with MSBuild/XBuild

    [lang=sh]
    msbuild MathNet.Numerics.sln            # only build for .Net 4 (main solution)
    msbuild MathNet.Numerics.Net35Only.sln  # only build for .Net 3.5
    msbuild MathNet.Numerics.Portable.sln   # full build with .Net 4, 3.5 and PCL profiles
    xbuild MathNet.Numerics.sln             # build with Mono, e.g. on Linux or Mac

### How to build with FAKE

    [lang=sh]
    build.cmd   # normal build (.Net 4.0), run unit tests
    ./build.sh  # normal build (.Net 4.0), run unit tests - on Linux or Mac
    
    build.cmd Build              # normal build (.Net 4.0)
    build.cmd Build incremental  # normal build, incremental (.Net 4.0)
    build.cmd Build full         # full build (.Net 3.5, 4.0, PCL)
    build.cmd Build net35        # compatibility build (.Net 3.5)
    
    build.cmd Test        # normal build (.Net 4.0), run unit tests
    build.cmd Test full   # full build (.Net 3.5, 4.0, PCL), run all unit tests
    build.cmd Test net35  # compatibility build (.Net 3.5), run unit tests
    
    build.cmd Clean  # cleanup build artifacts
    build.cmd Docs   # generate documentation, normal build
    build.cmd NuGet  # generate NuGet packages, full build

    build.cmd BuildNativex86   # build native providers 32bit/x86
    build.cmd BuildNativex64   # build native providers 64bit/x64
    build.cmd BuildNative      # build native providers for all platforms
    build.cmd TestNativex86    # test native providers 32bit/x86
    build.cmd TestNativex64    # test native providers 64bit/x64
    build.cmd TestNative       # test native providers for all platforms

FAKE itself is not included in the repository but it will download and bootstrap itself automatically when build.cmd is run the first time. Note that this step is *not* required when using Visual Studio or `msbuild` directly.
*)
