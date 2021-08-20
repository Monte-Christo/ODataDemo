# CData OData connector with LinqPad 6

## Instructions

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

- Click on *Add Connection*
- In the resulting dialog, select the project dll and then the DbContext class.
