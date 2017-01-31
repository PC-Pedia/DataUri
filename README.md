# DataUri

[![Build status](https://ci.appveyor.com/api/projects/status/l0ii5t8tvsdsrmw5?svg=true)](https://ci.appveyor.com/project/EricNewton/datauri)
[![NuGet](https://img.shields.io/nuget/v/datauri.svg)](https://www.nuget.org/packages/datauri/)

Nuget
Install-Package DataUri

Parses Data Uris.

.cssclass
{
  url(data:base64,ABCDEFGHIJKLMNOPQRSTUVWXYZ==)
}

returns a DataUri class that has:
  ImageBytes property, the binary bytes
  
mainly built to support DataContractSerializer, used in WebApi for XML and JSON conversion to model objects.
  
