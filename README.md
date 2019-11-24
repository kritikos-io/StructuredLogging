# Structured Logging

[![Build Status](https://dev.azure.com/kritikos/DotNet%20Libaries/_apis/build/status/kritikos-io.StructuredLogging?branchName=master)](https://dev.azure.com/kritikos/DotNet%20Libaries/_build/latest?definitionId=6&branchName=master)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

![GitHub language count](https://img.shields.io/github/languages/count/kritikos-io/StructuredLogging)

Simple templates to enforce uniform structured logging across projects.

Use the static classes

- GenericLogTemplates
- AspNetCoreLogTemplates

to provide you with the message template and pass the rest of the placeholders in a Logger that supports structured logging. Extension method ```GetTemplateCode()``` can be used to get the hexadecimal number used by [Seq][1] complete with the $ prefix.

[1]: https://datalust.co/
