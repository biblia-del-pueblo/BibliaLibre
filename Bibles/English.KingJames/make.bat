chcp 65001
bibmark.exe
cd tex
xelatex Biblia11ptB5 -output-directory ..\out\pdf
xelatex Biblia11ptB5 -output-directory ..\out\pdf
cd ..\out\pdf
del KingJamesB5.pdf
ren Biblia11ptB5.pdf KingJamesB5.pdf

cd ..\..