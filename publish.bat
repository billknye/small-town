rd /s /q out
dotnet publish src\SmallTown.Blazor\SmallTown.Blazor.csproj -o out
butler push out billknye/smalltown:blazor-previewz
