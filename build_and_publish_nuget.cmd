dotnet pack --configuration Release
dotnet nuget push "%~dp0PowerCollections\bin\Release\kermito4ka.PowerCollections.*.nupkg" --api-key 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 --source "https://nuget.pkg.github.com/kermito4ka/index.json"