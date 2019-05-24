# What are Type Providers?
* Compiler plugin + library to interact with data source
* Consists of Design-Time and Run-Time components
* Specialized per source type
* Parameterized for flexibility
* 2 flavours:
    * Erased Types
    * Generated Types

Notes:
.NET class implementing a specific interface
Returns generated types as .NET "Type" objects
Erased types can only be used from F#
Generated types can be used from any .NET language

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
* Macros

# Benefits
* Scalable
    * Only types that are actually used are persisted in the assembly
    * Supports massive data sources such as World Bank or Freebase
* Supports Evolving/Live Data Sources
    * Generated types change immediately when source schema changes

# Drawbacks
* Access to data source required during:
    * Development
    * Every build

Notes:
Every build agent requires access to data source
Complicates CI builds
Need to version data sources to match source for historical builds

# Demos
* Regex - Extract RGB values from hex string
* CSV - Simple 
* HTML - Parse Meetup page and extract attendees
* Swagger
* World Bank

# Building Your Own Type Provider
* 