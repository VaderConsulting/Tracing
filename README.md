# Tracing

VB.NET VS 2008 scratch for sending System.Diagnostics.Trace over UDP. Tester WinForms adds a UDP.TraceListener (sibling Historical Dev folder UDP) and writes Trace from a textbox plus a sample exception. The Tracing class library in this tree is an unused empty TraceListener stub not in the solution.

**Source last updated:** 2010-02-21 · **Language:** VB.NET · **Target:** .NET Framework 3.5 · **Output:** WinForms exe + unused class library

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `Tester` | VB.NET | WinForms exe | Adds `UDP.TraceListener`, writes `Trace` from a textbox, and traces a raised exception on load |
| `Tracing` | VB.NET | Class library (not in sln) | Empty `System.Diagnostics.TraceListener` stub (`Write` / `WriteLine` empty) |
| `UDP` | VB.NET | Class library (sibling, not in this tree) | Solution and Tester reference `..\UDP\UDP\UDP.vbproj` |

## How to open

Open `Tracing.sln` in Visual Studio 2008 (solution format 10.00). Tester and Tracing target .NET Framework 3.5. The solution includes sibling `UDP` at `..\UDP\UDP\UDP.vbproj` and `Tester`; it does not include `Tracing\Tracing.vbproj`. Place the UDP project (next import) beside this folder so that path resolves.

## Attribution and provenance

Working copy from Dave Robinson's OneDrive Historical Dev folder `Tracing`. `AssemblyCompany` / `AssemblyCopyright` are Microsoft 2010, the Visual Studio 2008 project template default, not Microsoft-owned sample code.

## License

MIT © 2026 VaderConsulting. See `LICENSE`.
