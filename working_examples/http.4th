include unix/socket.fs

s" yahoo.com" 80 open-socket constant FD

s\" GET /index.html HTTP/1.1\nHost: www.w3.org\n\n" FD write-socket

FD pad 100 read-socket

FD close-socket

pad 150 dump

bye