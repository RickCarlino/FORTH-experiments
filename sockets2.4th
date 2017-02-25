include unix/socket.fs

\ Create a TCP socket and store the socket file ID.
s" rickcarlino.com" 80 open-socket CONSTANT SOCK_FD

\ Send a string to SOCK_FD
: SOCK_FD! ( string-addr string-len --- )
  SOCK_FD write-socket ;

s" GET /index.html HTTP/1.0" SOCK_FD!
s\" \n" SOCK_FD!
s\" \n" SOCK_FD!

SOCK_FD PAD 100 read-socket
