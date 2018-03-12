# <img src="Installer\bluebox.ico" height="32" width="32"> Silverlight Unit Test Adapter

Visual Studio 2015 Unit Test adapter for Silverlight 5

[![Build status](https://ci.appveyor.com/api/projects/status/iwnuyva3s95ax25q/branch/master)](https://ci.appveyor.com/project/icnocop/silverlightunittestadapter/branch/master)

[Download this extension from the Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=RamiAbughazaleh.SilverlightUnitTestAdapter)

![Screenshot](Installer/Screenshot.png)

## Requirements

Visual Studio 2015

## Installation

The Visual Studio extension requires elevation during install and will be installed for all users in a subfolder in Visual Studio's extension directory.

For example, "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\Extensions\\{8.3}", where "{8.3}" is an arbitrary directory.

## Creating a Silverlight unit test project

1. Download and install [Silverlight 5 Toolkit (December 2011)](https://github.com/MicrosoftArchive/SilverlightToolkit/releases/download/5/Silverlight_5_Toolkit_December_2011.1.msi).  

2. Create a new `Silverlight Class Library` project in Visual Studio.

3. Add a project reference to `Microsoft.VisualStudio.QualityTools.UnitTesting.Silverlight.dll` from the Silverlight Toolkit installation directory.

   For example, `C:\Program Files (x86)\Microsoft SDKs\Silverlight\v5.0\Toolkit\dec11\Testing\Microsoft.VisualStudio.QualityTools.UnitTesting.Silverlight.dll`.

4. Create a new class for the unit test:
```
using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SilverlightUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            this.Log("Hello from Silverlight!");
            
            Assert.IsTrue(true, "Testing is fun!");
        }

        private void Log(string message)
        {
            // write message to the Debug window when run with the debugger
            Debug.WriteLine(message);

            // write message to the Tests output window when run without the debugger
            Console.WriteLine(message);
        }
    }
}
```
5. `Build` the project and notice the new test method appear in the `Test Explorer` window in Visual Studio.

## Configuration

The Silverlight unit test adapter reads configuration settings from `SilverlightUnitTestAdapter.json`.
This file must be placed in the same path as the test assembly.

### Unit Test Provider

By default the Silverlight unit test adapter will automatically detect the unit test provider to use.

You may explicitly set the unit test provider type by specifying it in the `UnitTestProvider` property.

| Value                    | Description |
|--------------------------|-------------|
| MSTest                   | [Microsoft's Silverlight Toolkit](https://github.com/MicrosoftArchive/SilverlightToolkit) |
| XUnit                    | [XUnit](https://xunit.github.io/) |
| XUnitLight               | [XUnitLight.Silverlight](https://github.com/staxmanade/StatLight/tree/master/src/TestingFrameworkAdapters/XunitLight.Silverlight) |
| NUnit                    | [NUnit](http://nunit.org/) |
| UnitDriven               | [UnitDriven](https://archive.codeplex.com/?p=unitdriven) |
| MSTestWithCustomProvider | Automatically searches your test assemblies for an IUnitTestProvider. |

###### Example
```
{
  "UnitTestProvider": "MSTestWithCustomProvider"
}
```

### Query String

Name-value pairs specified in the `QueryString` property can be retrieved using the `HtmlPage.Document.QueryString` property in the test assembly.
This allows you to pass arbitrary information to the assembly and methods under test.

###### Example
```
{
  "QueryString": {
    "name1": "value1",
    "name2": "value2"
  }
}
```

### Plugins

The Silverlight unit test adapter can be extended by using plugins.
Plugins can be used to manipulate the test results as a way to work-around some of the limitations when running unit tests in Silverlight.
Paths can be specified relative to the test assembly.

###### Example
```
{
  "Plugins": [
    "..\\..\\plugin1.dll",
    "..\\..\\plugin2.dll"
  ]
}
```

#### Creating a plugin

1. Create a new .NET 3.5+ Class Library project.
2. Install the `SilverlightUnitTestAdapter.Plugin` NuGet package.
3. Create the class that defines the plugin using the `IPlugin` interface.

```
using SilverlightUnitTestAdapter.Plugin;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;

public class Plugin : IPlugin
{
    public void TransformTestResult(IMessageLogger logger, TestResult testResult)
    {
        // write messages to Visual Studio's Test Output window
        logger.SendMessage(TestMessageLevel.Informational, "Transforming test result...");

        // get test assembly file path
        string testAssemblyFilePath = testResult.TestCase.Source;

        // get the test name
        string testName = result.TestCase.FullyQualifiedName;

        // get/set the test outcome (Passed, Failed, Skipped, etc.)
        Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome testOutcome = testResult.Outcome;

        // get/set the error message
        string errorMessage = testResult.ErrorMessage;

        // get/set the error stack trace
        string errorStackTrace = testResult.ErrorStackTrace;

        // add/remove attachments
        AttachmentSet attachmentSet = new AttachmentSet(new Uri("attachment://dummy"), "attachment");
        Uri testFile = new Uri(@"C:\file.txt", UriKind.Absolute);
        attachmentSet.Attachments.Add(new UriDataAttachment(testFile, "file.txt"));
        testResult.Attachments.Add(attachmentSet);

        // write messages to the test Output in the "Standard Output" category
        result.Messages.Add(new TestResultMessage(TestResultMessage.StandardOutCategory, "Standard Out"));

        // write messages to the test Output in the "Standard Error" category
        result.Messages.Add(new TestResultMessage(TestResultMessage.StandardErrorCategory, "Standard Error"));
    }
}

```
5. Add the path to the plugin dll in `SilverlightUnitTestAdapter.json`.

### Displaying exception stack trace with line numbers

1. Catch the exception in the unit test and generate an exception report using [Production Stack Trace PR#13](https://github.com/gimelfarb/ProductionStackTrace/pull/13).
2. Re-throw a new exception that contains the exception report in the new exception's stacktrace.
3. Create a plugin that uses [Production Stack Trace](https://github.com/gimelfarb/ProductionStackTrace) to translate the stacktrace in the `ErrorStackTrace` property of the `TestResult` parameter.

## Limitations

- Run with elevated permissions
- Run as a trusted application
- Parallel test execution
- Cancellation

## Troubleshooting

Detailed messages are written in the Output window's "Silverlight Unit Test Adapter" pane.

## Resources

[Silverlight Documentation and Downloads](https://msdn.microsoft.com/en-us/library/cc838158(v=vs.95).aspx)

[Silverlight Toolkit GitHub repository](https://github.com/MicrosoftArchive/SilverlightToolkit)

[Silverlight Discussion Forums](http://forums.silverlight.net/forums/35.aspx)

[Silverlight Toolkit CodePlex Archive](https://archive.codeplex.com/?p=silverlight)

## Credits

[Niels Hebling](https://nielshebling.de) for [Silverlight Unit Test Adapter for Visual Studio 2012](https://marketplace.visualstudio.com/items?itemName=nielshebling.SilverlightUnitTestAdapter)

[Jason Jarrett](https://github.com/staxmanade) and contributors for [Silverlight Testing Automation Tool (StatLight)](https://github.com/staxmanade/StatLight)

[Steven De Kock](https://twitter.com/sdekock) and [Matt Ellis](https://twitter.com/citizenmatt) for [AgUnit](https://github.com/sdekock/AgUnit)

[Lev Gimelfarb](http://www.lionhack.com/) for [Production Stack Trace](https://github.com/gimelfarb/ProductionStackTrace)

[PSD Graphics](http://www.psdgraphics.com/) for blue box icon

The Visual Studio logo is a trademark of Microsoft Corporation.
