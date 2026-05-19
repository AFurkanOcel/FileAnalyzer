# File Analyzer

A .NET Framework file analysis tool with Console and Windows Forms interfaces, supporting TXT, DOCX, and PDF files.

## Overview

File Analyzer reads text-based document formats and produces practical statistics such as character count, line count, unique word count, repeated word frequency, and punctuation frequency. The solution includes a shared analysis library plus two user interfaces: a console application and a Windows Forms desktop application.

## Features

- Analyze `.txt`, `.docx`, and `.pdf` files
- Shared core library for file reading and text analysis
- Console interface for quick analysis workflows
- Windows Forms interface with file type filters, progress bar, and export options
- Repeated word frequency and punctuation frequency reports
- Export analysis results as `.txt` or `.json` from the WinForms app
- Error logging to a local `Logs/log.txt` file
- Optional login/signup screen in the WinForms app

## Project Structure

```text
FileAnalyzer/
├── src/
│   ├── FileAnalyzer.Core/
│   ├── FileAnalyzer.Console/
│   └── FileAnalyzer.WinForms/
├── screenshots/
├── README.md
├── LICENSE
├── .gitignore
└── FileAnalyzer.sln
```

## Technologies

- C#
- .NET Framework 4.8
- Windows Forms
- Open XML SDK
- PdfPig
- Newtonsoft.Json
- Visual Studio

## Screenshots

Screenshots are kept in the `screenshots/` directory. Recommended screenshots for the repository are:

- Console analysis output
- WinForms login/signup screen
- WinForms file analysis screen
- File selection dialog

## Installation

1. Clone the repository.
2. Open `FileAnalyzer.sln` in Visual Studio.
3. Restore NuGet packages when prompted.
4. Choose either `FileAnalyzer.Console` or `FileAnalyzer.WinForms` as the startup project.
5. Build and run the selected project.

## Usage

### Console

1. Run `FileAnalyzer.Console`.
2. Select a `.txt`, `.docx`, or `.pdf` file from the file dialog.
3. Review the analysis output in the console window.

### Windows Forms

1. Run `FileAnalyzer.WinForms`.
2. Log in, sign up, or continue as a guest.
3. Select the file types you want to allow.
4. Choose a file and click **Analyze**.
5. Export the result as `.txt` or `.json` when needed.

## Login Configuration

The WinForms app can be used as a guest without database setup. Login and signup are optional and use the `FileAnalyzerLoginDb` connection string in `src/FileAnalyzer.WinForms/App.config`. Configure that value only if you want to enable the database-backed login flow.

## Export Options

The Windows Forms application can export the current analysis result to:

- `AnalyzeResults/AnalyzeResult.txt`
- `AnalyzeResults/AnalyzeResult.json`

These generated files are intentionally ignored by Git.

## Error Logging

Runtime exceptions are written to `Logs/log.txt`. The `Logs/` directory is ignored by Git because it contains local runtime output.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.


