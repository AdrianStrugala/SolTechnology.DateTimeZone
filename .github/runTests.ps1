ForEach ($folder in (Get-ChildItem -Path tests -Directory)) { dotnet test --no-build $folder.FullName }