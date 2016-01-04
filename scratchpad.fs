include unix/socket.fs

\ Create a TCP socket and store the socket file ID.
s" localhost" 8883 open-socket CONSTANT SOCK_FD

\ Now create a raw block of memory to send down the pipe.
\ FUN FACT: In forth, % is binary, # is decimal and '' is ASCII char.
create connect-packet
  %00010000 c, \ Header
  #18       c, \ Length - fixed header length of 2
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

connect-packet 20 SOCK_FD write-socket
\ ping-packet    2  SOCK_FD write-socket
\ SOCK_FD close-socket
\ bye
\ SOCK_FD s" @@@@@@@@@@@@@@@@@@@@@" read-socket
