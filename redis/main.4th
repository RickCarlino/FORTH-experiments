include unix/socket.fs

\ Create a TCP socket and store the socket file ID.
6379 CONSTANT REDIS_PORT
s" localhost" REDIS_PORT open-socket CONSTANT REDIS_FD

\ Send a string to REDIS_FD
: REDIS! ( string-addr string-len --- )
  REDIS_FD write-socket ;

: .REDIS
  REDIS_FD pad 8092 read-socket type ;
\ REDIS_FD 100 read-socket
 