# What are Type Providers?
* Compiler plugin + library to interact with data source
* Consists of Design-Time and Run-Time components
* Specialized per source type
* Parameterized for flexibility

> Notes:
> .NET class implementing a specific interface
> Uses quotations extensively
> Design-time component generates schema, run-time component allows you to consume the data source

# Generative vs Erased Type Providers
* Generative Types
    * Emits IL bytecode into assembly
    * Can be consumed by any .NET language
    * Restricted to .NET types
    * Useful if generated types will by consumed from other assemblies
* Erased Types
    * Produces metadata only consumable by F# compiler
    * No bytecode emitted
    * Can only be used in the assembly referencing the type provider
    * Useful for large data sources where only a small subset is used

# Examples
* General:
    * Regex
    * CSV
    * HTML
    * JSON
    * Swagger
    * XML
    * Database
* Specialized:
    * World Bank
    * Freebase
    * Yahoo Finance

# Alternatives
* Static Code Generation
    * Has to only be run when data source changes
    * Error-prone
* Macros
* [Idris Type Providers](http://www.davidchristiansen.dk/pubs/dependent-type-providers.pdf)
* [Java Type Manifolds](http://manifold.systems/docs.html#what-is-a-type-manifold)

# Benefits
* Scalable (only applies to Erasing Type Providers)
    * Only types that are actually used are persisted in the assembly
    * Supports massive data sources such as World Bank or Freebase
* Supports Evolving/Live Data Sources
    * Generated types change immediately when source schema changes

# Drawbacks
* Access to data source required during:
    * Development
    * Every build

> Notes:
> Every build agent requires access to data source
> Complicates CI builds
> Need to version data sources to match source for historical builds

# Demos
* Regex
* CSV
* HTML
* JSON
* Swagger
* Database

# Building a Type Provider
* Demo