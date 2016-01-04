include unix/socket.fs
s" materiamagica.com"
23
open-socket            \
dup                    \ SOCK_FD SOCK_FD
s" hello socket world" \ SOCK_FD SOCK_FD  DATA_LEN
rot                    \ SOCK_FD DATA_ADDR DATA_LEN SOCK_FD
write-socket           \ SOCK_FD
close-socket
bye
