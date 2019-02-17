    global  _main
    extern  _printf

    section .text
_main:
    push    message
    call    _printf
    add     esp, 4
    ret
message:
    db  'Win32 Test GOAT File. GitHub.com/speedyplane2247/goat | 269 bytes.', 10, 0
; JUNK CODE
; CBT
; Sammy sucks
; Robbiecool
