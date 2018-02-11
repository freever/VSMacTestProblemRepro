# VSMacTestProblemRepro

This repo contains 2 solutions that were set up to reporoduce the issue described here:
https://stackoverflow.com/questions/48709958/nunit-framework-not-found-running-nunit-against-net-standard-1-4-xamarin-projec#48709958

And here:
https://developercommunity.visualstudio.com/content/problem/196706/running-nunit-tests-against-net-standard-assembly.html

TestSolution.TestProject was set up in Visual Studio for Windows as a .NET Core class library.
TestSolution2 was set up in Visual Studio for Windows as a .NET Core Unit Test library.

Running the tests in both solutions with Resharper on VS Windows works. 
Running the tests in both solutions with VS Mac causes the nunit.framework FileNotFoundError described in the issue. 

I'm using VS Mac 7.4 Preview (build 985)
