if not defined GitHubAction dotnet tool install -g BibleMarkdown

cd Bibles\English.WorldEnglishBibleGB
call make.bat
cd ..\..\Bibles\English.WorldEnglishBibleUS
call make.bat
cd ..\..\Bibles\German.Schlachter1951
call make.bat
cd ..\..\Bibles\Spanish.ReinaValera1909
call make.bat
cd ..\..
