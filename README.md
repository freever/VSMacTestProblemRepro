# VSMacTestProblemRepro

This repo contains 2 solutions that were set up to reporoduce the issue described here:
https://stackoverflow.com/questions/48709958/nunit-framework-not-found-running-nunit-against-net-standard-1-4-xamarin-projec#48709958

And here:
https://developercommunity.visualstudio.com/content/problem/196706/running-nunit-tests-against-net-standard-assembly.html

TestSolution.TestProject was set up in Visual Studio for Windows as a .NET Core class library.
TestSolution2 was set up in Visual Studio for Windows as a .NET Core Unit Test library.

Running the tests in both solutions with Resharper on VS Windows works. 
Running the tests in both solutions with VS Mac causes the nunit.framework FileNotFoundError described in the issue. 

I'm using VS Mac 7.4 Preview (build 985):

=== Visual Studio Community 2017 for Mac (Preview) ===

Version 7.4 Preview (7.4 build 985)
Installation UUID: 60680359-6e03-485d-b0af-f7e27ea999fc
Runtime:
	Mono 5.8.0.123 (2017-10/38502063cac) (64-bit)
	GTK+ 2.24.23 (Raleigh theme)

	Package version: 508000123

=== NuGet ===

Version: 4.3.1.4445

=== .NET Core ===

Runtime: /usr/local/share/dotnet/dotnet
Runtime Version: 2.0.0
SDK: /usr/local/share/dotnet/sdk/2.0.0/Sdks
SDK Version: 2.0.0
MSBuild SDKs: /Library/Frameworks/Mono.framework/Versions/5.8.0/lib/mono/msbuild/15.0/bin/Sdks

=== Xamarin.Profiler ===

'/Applications/Xamarin Profiler.app' not found

=== Xamarin.Android ===

Version: 8.2.0.12 (Visual Studio Community)
Android SDK: /Users/adrianfrielinghaus/Library/Developer/Xamarin/android-sdk-macosx
	Supported Android versions:
		7.0 (API level 24)
		7.1 (API level 25)
		8.0 (API level 26)
		8.1 (API level 27)

SDK Tools Version: 25.2.5
SDK Platform Tools Version: 27.0.1
SDK Build Tools Version: 27.0.3

Java SDK: /Library/Java/JavaVirtualMachines/jdk1.8.0_121.jdk/Contents/Home
java version "1.8.0_121"
Java(TM) SE Runtime Environment (build 1.8.0_121-b13)
Java HotSpot(TM) 64-Bit Server VM (build 25.121-b13, mixed mode)

Android Designer EPL code available here:
https://github.com/xamarin/AndroidDesigner.EPL

=== Apple Developer Tools ===

Xcode 9.2 (13772)
Build 9C40b

=== Xamarin.Mac ===

Version: 4.2.0.19 (Visual Studio Community)

=== Xamarin.iOS ===

Version: 11.8.0.19 (Visual Studio Community)
Hash: 5b1f7168
Branch: d15-6
Build date: 2018-02-01 18:50:51-0500

=== Xamarin Inspector ===

Version: 1.4.0
Hash: b3f92f9
Branch: master
Build date: Fri, 19 Jan 2018 22:00:34 GMT
Client compatibility: 1

=== Build Information ===

Release ID: 704000985
Git revision: 0bed5a3380dbe82009f80c895623208d6c0df152
Build date: 2018-02-02 20:00:14-05
Xamarin addins: 612453baa9a0faea49aa554be49c01c2e0542bf3
Build lane: monodevelop-lion-d15-6

=== Operating System ===

Mac OS X 10.13.3
Darwin 17.4.0 Darwin Kernel Version 17.4.0
    Sun Dec 17 09:19:54 PST 2017
    root:xnu-4570.41.2~1/RELEASE_X86_64 x86_64

=== Enabled user installed addins ===

NuGet Package Explorer 0.2
NuGet Package Management Extensions 0.12.2
Internet of Things (IoT) development (Preview) 7.1


