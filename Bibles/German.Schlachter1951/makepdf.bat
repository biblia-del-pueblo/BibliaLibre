chcp 65001
bibmark

cd tex
xelatex Bibel11ptB5 -output-directory=..\out\pdf

cd ..\out\pdf
move Bibel11ptB5.pdf Schlachter1951.11pt.B5.pdf

cd ..