﻿# CData OData connector with LinqPad 6

## Instruction for Using CData Connector

https://www.cdata.com/kb/tech/odata-ado-linqpad.rst

https://cdn.cdata.com/help/RDG/ado/pg_efCoreConsoleApp.htm

https://cdn.cdata.com/help/RDG/ado/pg_efCoreScaffolding.htm

https://cdn.cdata.com/help/RDG/ado/pg_efCoreASPApp.htm

## Required Packages

### Microsoft

```
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Relational
Install-Package Microsoft.EntityFrameworkCore.Tools
```

### CData Assemblies (check the hint path on your installation)

```
  <Reference Include="CData.EntityFrameworkCore.OData">
    <HintPath>C:\Program Files\CData\CData ADO.NET Provider for OData 2021\lib\netstandard2.1\EFCORE50\CData.EntityFrameworkCore.OData.dll</HintPath>
  </Reference>
  <Reference Include="System.Data.CData.OData">
    <HintPath>C:\Program Files\CData\CData ADO.NET Provider for OData 2021\lib\netstandard2.0\System.Data.CData.OData.dll</HintPath>
  </Reference>

```

## Scaffolding Model Classes

Start Gain, make sure OData endpoint  is enabled.

```
Scaffold-DbContext "URL=http://localhost:8000/odata;" CData.EntityFrameworkCore.OData -OutputDir Models -Context ODataContext -Tables Event,Exchange,Holding,Institution,Instrument,Price -Force
```

## LinqPad Integration

1. Click on *Add Connection*
2. Select *Entity Framework Core (2.x, 3.x, 5.x)*
3. In the resulting dialog, select the project dll and then the DbContext class.

## Scaffold Controller Code

1. Right-click on Controllers folder and click *Add -> Controller...*
2. Choose *MVC Controller with views uning EF*
3. Select Model class \<Model Name\> and context ODataContext
4. Click *Add*
5. Run App
6. Navigate to /\<Model Name\> endpoint
