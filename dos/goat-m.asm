; if you are using debug.exe to assemble these, use goat-d.asm! These contains comments that don't work in debug.exe
int 21h
db "592 goat filE: MS-DOS", 1
db "goat-m.asm", 2
db "Fork: github.com/speedyplane2247/goat", 3
db "Master: github.com/speedyplane2247/goat", 4 ; Don't remove!
db "This file should not print out anything.", 5
db "Thanks for using this DOS GOAT file!", 6
db "END OF FILE", 10
int 21h
; super simple, does nothing but is 592 bytes!
