TITLE ??_1 
;------------------------------------------------------------------------------
;??  ?1.1
;------------------------------------------------------------------------------
; ????????????? 3. ???????? ?????????????
; ????????:              ?????? ???????? ? ????????????
; ???:                  ???? "???"
; ?????????:    ????
; ????:                2
; ?????:       __ __ __
;------------------------------------------------------------------------------
; ?????:        __ __ __
; ????:         __/__/__
;---------------------------------
                ;I.????????? ????????
IDEAL           ; ????????? - ??? ????????? tasm 
MODEL small     ; ????????? - ??? ?????? ??????? 
STACK 256       ; ????????? - ?????? ????? 
                ;II.???????
                ;III.??????? ??? arr_rnd1????? ?????
DATASEG
exCode db 0
message db "Hello world!",10,13,'$';????? ???????? ??? ?????? ?? ?????
                ;VI. ??????? ???????? ????
CODESEG
Start:
;--------------------------------- 1. ????????????? DS ? ES---------------------------------------
    mov ax,@data    ; @data ?????????????, ?? ??????????? ?????????? model
    mov ds, ax  ; ???????????? ??????? ???????? ????? ? ??????? ds
    mov es, ax  ; ???????????? ??????? ???????? ????? ? ??????? es
;----------------------------------2. ???????? ?????? ?? ???????---------------------------------
            ; ??????????? ?????? ????? ???????? message ? ??????? dx
    mov dx, offset message
            ; ???????????? ????? 09h ?? ???????? ah
            ; (??????? DOS 9h - ??????? ?????? ?? ??????? ?????)
    mov ah,09h
    int 21h     ; ?????? ??????? DOS 9h
;----------------------------------3. ???????? ??????? ????????, ?????????? ?????????? ??????-----
    mov ah,01h
            ; ???????????? ????? 01h ?? ???????? ah
            ; (??????? DOS 1h - ??????? ?????????? ?????????? ???????...)
    int 21h     ; ?????? ??????? DOS 1h
            ; ???????????? ????? 4ch ?? ???????? ah
            ; (??????? DOS 4ch - ?????? ? ????????)
;---------------------------------4. ????? ? ????????---------------------------------------------
    mov ah,4ch
    mov al,[exCode] ; ????????? ???? ?????? 
    int 21h     ; ?????? ??????? DOS 4ch
    end Start