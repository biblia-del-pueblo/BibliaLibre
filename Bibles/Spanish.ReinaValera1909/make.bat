chcp 65001
bibmark

cd tex
xelatex Biblia11ptB5 -output-directory=..\out\pdf

cd ..\out\pdf
move Biblia11ptB5.pdf ReinaValera1909.11pt.B5.pdf

cd ..\..\