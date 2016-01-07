include unix/socket.fs

\ Create a TCP socket and store the socket file ID.
s" localhost" 8883 open-socket CONSTANT SOCK_FD

\ Now create a raw block of memory to send down the pipe.
\ FUN FACT: In forth, % is binary, # is decimal and '' is ASCII char.
create connect-packet
  %00010000 c, \ Header
  #18       c, \ Length minus fixed header length of 2 (20 - 2 = 18)
  #0        c, \ Protocol Length byte 1
  #6        c, \ Protocol Length byte 2
  'M'       c, \ Protocol ID
  'Q'       c,
  'I'       c,
  's'       c,
  'd'       c,
  'p'       c,
  #3        c, \ Protocol Version
  %00000010 c, \ Connect Flags
  #0        c, \ Keep alive byte 1
  #30       c, \ Keep alive byte 2
  #0        c, \ Client ID Length byte 2
  #4        c, \ Client ID length byte 1
  'F'       c, \ Client ID string
  'O'       c,
  'R'       c,
  'H'       c,

create pingreq-packet
  %11000000 c,
  %0        c,

create publish-packet \ Says "hi" on topic "a/b"
  %00110010 c,
  #9        c, \ Length of everything after this byte.
  #0        c, \ length msb
  #3        c, \ length lsb
  'a'       c, \ Topic name as a string.
  '/'       c,
  'b'       c,
  #0        c, \ msgid msb
  #10       c, \ msgid lsb
  'H'       c,
  'i'       c,

: ping
  pingreq-packet 2 SOCK_FD write-socket ;

: read
  SOCK_FD s" 12345678901234567890123456789012345678901234567890" read-socket typewhite ;

connect-packet 20 SOCK_FD write-socket
publish-packet 11 SOCK_FD write-socket
\ ping-packet    2  SOCK_FD write-socket
\ SOCK_FD close-socket
\ bye
