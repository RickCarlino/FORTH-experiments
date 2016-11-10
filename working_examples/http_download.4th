include unix/socket.fs

s" rickcarlino.com" 80 open-socket CONSTANT SOCK_FD

s\" GET / HTTP/1.0\n\n" SOCK_FD write-socket

SOCK_FD pad 8092 read-socket type

SOCK_FD close-socket
