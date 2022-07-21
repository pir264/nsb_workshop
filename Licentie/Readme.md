## Instructies
To install your license, save it to disk, then copy the file to the correct location as shown below, based on your platform, starting in the directory containing the downloaded license file:


For Windows cmd.exe:
```csharp
mkdir %LocalAppData%\ParticularSoftware 2> NUL
copy /Y license.xml %LocalAppData%\ParticularSoftware
```

For Windows PowerShell:
```csharp
mkdir -Force $Env:LocalAppData\ParticularSoftware
copy license.xml $Env:LocalAppData\ParticularSoftware
```

For Linux/macOS:
```csharp
mkdir -p ${XDG_DATA_HOME:-$HOME/.local/share}/ParticularSoftware
cp license.xml ${XDG_DATA_HOME:-$HOME/.local/share}/ParticularSoftware
```
