# MSTestPlayground

When running the following command from bin\Debug folder: **vstest.console.exe MSTestPlayground.exe** I get the following results:
<blockquote>Microsoft (R) Test Execution Command Line Tool Version 16.11.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
[MSTest][Discovery][C:\Users\niboger\source\repos\MSTestPlayground\bin\Debug\MSTestPlayground.exe] Failed to discover tests from assembly C:\Users\niboger\source\repos\MSTestPlayground\bin\Debug\MSTestPlayground.exe. Reason:It is illegal to reflect on the custom attributes of a Type loaded via ReflectionOnlyGetType (see Assembly.ReflectionOnly) -- use CustomAttributeData instead.
No test is available in C:\Users\niboger\source\repos\MSTestPlayground\bin\Debug\MSTestPlayground.exe. Make sure that test discoverer & executors are registered and platform & framework version settings are appropriate and try again.

Additionally, path to test adapters can be specified using /TestAdapterPath command. Example  /TestAdapterPath:<pathToCustomAdapters>.</blockquote>

However if I change the csproj to be class library (or event rename the output assembly from exe to dll) it works
