# Roslyn Analyzers in .NET Core

This repository contains a sample project that shows how to create a Roslyn analyzer in .NET Core.
Repo intentionally contains crappy code to demonstrate how analyzers work and can be used to improve code quality.

## Useful Analyzers

- [.NET Code Analysis - overview and configuration](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview)
    - [Rule Reference](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/categories)
    - [dotnet/roslyn-analyzers](https://github.com/dotnet/roslyn-analyzers)
- [Platform compatibility analyzer](https://learn.microsoft.com/en-us/dotnet/standard/analyzers/platform-compat-analyzer)
- [SonarLint](https://rules.sonarsource.com/csharp)
- [PumaScan](https://pumascan.com/rules/)
- [Security Code Analyzers](https://security-code-scan.github.io/)
- [Roslynator](https://github.com/josefpihrt/roslynator)
- [AsyncFixer](https://www.nuget.org/packages/AsyncFixer)
- [Microsoft.VisualStudio.Threading.Analyzers](https://github.com/Microsoft/vs-threading)
    - [More info](https://github.com/microsoft/vs-threading/blob/main/src/Microsoft.VisualStudio.Threading/README.md)
- [Meziantou.Analyzer](https://www.nuget.org/packages/Meziantou.Analyzer)
- [IDisposableAnalyzers](https://github.com/DotNetAnalyzers/IDisposableAnalyzers)
- [StyleCop Analyzers](https://github.com/DotNetAnalyzers/StyleCopAnalyzers)

Even more analyzers can be found [here](https://github.com/cybermaxs/awesome-analyzers).

Enabling .NET Code Analysis in a project is as simple as adding the following to the project (*.csproj) file:

```xml
    <PropertyGroup>
      <EnableNETAnalyzers>true</EnableNETAnalyzers>
      <AnalysisLevel>latest-all</AnalysisLevel>
    </PropertyGroup>
```

```xml
  <PropertyGroup>
    <AnalysisLevel>latest</AnalysisLevel>
    <EnforceCodeStyleInBuild>true</EnforceCodeStyleInBuild>
    <RunAnalyzersDuringBuild>true</RunAnalyzersDuringBuild>
    <EnableNETAnalyzers>true</EnableNETAnalyzers>
    <CodeAnalysisTreatWarningsAsErrors>false</CodeAnalysisTreatWarningsAsErrors>
  </PropertyGroup>
```

## Code style and EditorConfig file
- [.NET Framework design guidelines](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/)
    - [Naming Guidelines](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)
    - [StyleCop Rules](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/DOCUMENTATION.md)
- [dotnet/runtime C# Coding Style](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md)
- [C# at Google Style Guide](https://google.github.io/styleguide/csharp-style.html)
- [Code style preferences](https://learn.microsoft.com/en-us/visualstudio/ide/code-styles-and-code-cleanup?toc=%2Fvisualstudio%2Fcode-quality%2Ftoc.json&view=vs-2022)
- [EditorConfig](https://editorconfig.org/)
  - [EditorConfig for code style](https://learn.microsoft.com/en-us/visualstudio/ide/create-portable-custom-editor-options)
  - [Code-style rule options](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/code-style-rule-options?view=vs-2022)
- Editorconfig samples:
    - [Semantic Kernel](https://github.com/microsoft/semantic-kernel/blob/main/.editorconfig)
    - [ASP.NET Core](https://github.com/dotnet/aspnetcore/blob/main/.editorconfig)
    - [dotnet](https://github.com/dotnet/runtime/blob/main/.editorconfig)
- [dotnet format tool](https://github.com/dotnet/format)

## Code Analysis and Code Metrics in Azure Pipelines (CI/CD)
- [Code Metrics](https://ecanarys.com/code-analysis-code-metrics-integration-in-azure-pipelines/)
- [Microsoft Security DevOps Azure DevOps extension](https://learn.microsoft.com/en-us/azure/defender-for-cloud/azure-devops-extension)
- [Link 1](https://learn.microsoft.com/en-us/previous-versions/azure/security/develop/security-code-analysis-onboard)
- [Link 2](https://secdevtools.azurewebsites.net/)
- [Link 3](https://devblogs.microsoft.com/premier-developer/microsoft-security-code-analysis/)

## Reference repositories

- [dotnet runtime](https://github.com/dotnet/runtime)
- [aspnet core](https://github.com/dotnet/aspnetcore)

Tip: use **GitHub Code Search** to find examples of code conventions and analyzers in the wild.

### Random notes

- **FXCopAnalyzers are depracated** in favor of **.NET Code Analysis**. See Migration Guide [here](https://learn.microsoft.com/en-us/visualstudio/code-quality/migrate-from-fxcop-analyzers-to-net-analyzers?view=vs-2022).
- [RoslynClrHeapAllocationAnalyzer](https://github.com/microsoft/RoslynClrHeapAllocationAnalyzer) is also no longer maintained. he high impact analyzers from this repository are being merged with [dotnet/roslyn-analyzers](https://github.com/dotnet/roslyn-analyzers).
- [To underscore or to not to underscore, that is the question](https://stackoverflow.com/questions/450238/to-underscore-or-to-not-to-underscore-that-is-the-question)
