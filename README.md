# Messerli.ChangeCase

Transform a string between [different casing styles](https://en.wikipedia.org/wiki/Naming_convention_%28programming%29#Multiple-word_identifiers) like: camelCase, PascalCase, CONSTANT_CASE and others handling old style abbrevations correctly 

[![Build](https://github.com/messerli-informatik-ag/change-case/workflows/Build/badge.svg)](https://github.com/messerli-informatik-ag/change-case/actions?query=workflow%3ABuild)
[![Licence: MIT](https://img.shields.io/badge/licence-MIT-green)](https://raw.githubusercontent.com/messerli-informatik-ag/change-case/main/LICENSE-MIT)
[![Licence: Apache](https://img.shields.io/badge/licence-Apache-green)](https://raw.githubusercontent.com/messerli-informatik-ag/change-case/main/LICENSE-Apache)

## Packages

[![NuGet package](https://buildstats.info/nuget/Messerli.ChangeCase)](https://www.nuget.org/packages/Messerli.ChangeCase)



## Usage

```csharp
using Messerli.ChangeCase
```

Sample usage:
```csharp
var camelCase = "snake_case".CamelCase() // => snakeCase
```

### Use as Method Group

```csharp
IEnumerable<string> names = new[] { "PascalCase", "camelCase", "snake_case", "UPPER_SNAKE_CASE" };

var namesInPascalCase = names
    .Select(StringCaseExtensions.PascalCase);
```

### PascalCase()

[Pascal Case](https://en.wikipedia.org/wiki/Camel_case)

```csharp
"PascalCase".PascalCase(); // => PascalCase
"camelCase".PascalCase(); // => CamelCase
"snake_case".PascalCase(); // => SnakeCase
"UPPER_SNAKE_CASE".PascalCase(); // => UpperSnakeCase
"HTTPConnection".PascalCase(); // => HttpConnection
"HTML".PascalCase(); // => Html
```

### CamelCase()

[Camel case](https://en.wikipedia.org/wiki/Camel_case)

```csharp
"PascalCase".CamelCase(); // => pascalCase
"camelCase".CamelCase(); // => camelCase
"snake_case".CamelCase(); // => snakeCase
"UPPER_SNAKE_CASE".CamelCase(); // => upperSnakeCase
"HTTPConnection".CamelCase(); // => httpConnection
"HTML".CamelCase(); // => html
```

### SnakeCase()

[Snake case](https://en.wikipedia.org/wiki/Snake_case)

```csharp
"PascalCase".SnakeCase(); // => pascal_case
"camelCase".SnakeCase(); // => camel_case
"snake_case".SnakeCase(); // => snake_case
"UPPER_SNAKE_CASE".SnakeCase(); // => upper_snake_case
"HTTPConnection".SnakeCase(); // => http_connection
"HTML".SnakeCase(); // => html
```

### UpperSnakeCase()

[Upper Snake case](https://en.wikipedia.org/wiki/Snake_case)

```csharp
"PascalCase".UpperSnakeCase(); // => PASCAL_CASE
"camelCase".UpperSnakeCase(); // => CAMEL_CASE
"snake_case".UpperSnakeCase(); // => SNAKE_CASE
"UPPER_SNAKE_CASE".UpperSnakeCase(); // => UPPER_SNAKE_CASE
"HTTPConnection".UpperSnakeCase(); // => HTTP_CONNECTION
"HTML".UpperSnakeCase(); // => HTML
```

### KebabCase()

[Kebab case](https://en.wikipedia.org/wiki/Kebab_case)

```csharp
"PascalCase".UpperSnakeCase(); // => pascal-case
"camelCase".UpperSnakeCase(); // => camel-case
"snake_case".UpperSnakeCase(); // => snake-case
"UPPER_SNAKE_CASE".UpperSnakeCase(); // => upper-snake-case
"HTTPConnection".UpperSnakeCase(); // => http-connection
"HTML".UpperSnakeCase(); // => html
```
