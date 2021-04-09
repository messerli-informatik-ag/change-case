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
var camelCase = "snake_case".ToCamelCase() // => snakeCase
```

### Use as Method Group

```csharp
IEnumerable<string> names = new[] { "PascalCase", "camelCase", "snake_case", "UPPER_SNAKE_CASE" };

var namesInPascalCase = names
    .Select(StringCaseExtensions.ToPascalCase);
```

### ToPascalCase()

[Pascal Case](https://en.wikipedia.org/wiki/Camel_case)

```csharp
"PascalCase".ToPascalCase(); // => PascalCase
"camelCase".ToPascalCase(); // => CamelCase
"snake_case".ToPascalCase(); // => SnakeCase
"UPPER_SNAKE_CASE".ToPascalCase(); // => UpperSnakeCase
"HTTPConnection".ToPascalCase(); // => HttpConnection
"HTML".ToPascalCase(); // => Html
```

### ToCamelCase()

[Camel case](https://en.wikipedia.org/wiki/Camel_case)

```csharp
"PascalCase".ToCamelCase(); // => pascalCase
"camelCase".ToCamelCase(); // => camelCase
"snake_case".ToCamelCase(); // => snakeCase
"UPPER_SNAKE_CASE".ToCamelCase(); // => upperSnakeCase
"HTTPConnection".ToCamelCase(); // => httpConnection
"HTML".ToCamelCase(); // => html
```

### ToSnakeCase()

[Snake case](https://en.wikipedia.org/wiki/Snake_case)

```csharp
"PascalCase".ToSnakeCase(); // => pascal_case
"camelCase".ToSnakeCase(); // => camel_case
"snake_case".ToSnakeCase(); // => snake_case
"UPPER_SNAKE_CASE".ToSnakeCase(); // => upper_snake_case
"HTTPConnection".ToSnakeCase(); // => http_connection
"HTML".ToSnakeCase(); // => html
```

### ToUpperSnakeCase()

[Upper Snake case](https://en.wikipedia.org/wiki/Snake_case)

```csharp
"PascalCase".ToUpperSnakeCase(); // => PASCAL_CASE
"camelCase".ToUpperSnakeCase(); // => CAMEL_CASE
"snake_case".ToUpperSnakeCase(); // => SNAKE_CASE
"UPPER_SNAKE_CASE".ToUpperSnakeCase(); // => UPPER_SNAKE_CASE
"HTTPConnection".ToUpperSnakeCase(); // => HTTP_CONNECTION
"HTML".ToUpperSnakeCase(); // => HTML
```

### ToKebabCase()

[Kebab case](https://en.wikipedia.org/wiki/Kebab_case)

```csharp
"PascalCase".ToKebabCase(); // => pascal-case
"camelCase".ToKebabCase(); // => camel-case
"snake_case".ToKebabCase(); // => snake-case
"UPPER_SNAKE_CASE".ToKebabCase(); // => upper-snake-case
"HTTPConnection".ToKebabCase(); // => http-connection
"HTML".ToKebabCase(); // => html
```
