.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword
.code
main proc
    mov EAX,0
    mov al,5
    mov ah,-6
    add ah,al
    mov sum,ah
    movsx,eax,sum
    call writeInt

    invoke ExitProcess,0

main endp
end main