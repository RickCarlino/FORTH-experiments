include unix/socket.fs

s" localhost" 8883 open-socket CONSTANT SOCK_FD

create my-message
    %00010000 c, \ === FIXED HEADER Message Type (CONNECT)
    #12       c, \ Remaining Length
    #0        c, \ == VARIABLE HEADER Protocol Name Length MSB
    #6        c, \ Length LSB
    'M'       c, \
    'Q'       c,
    'I'       c,
    's'       c,
    'd'       c,
    'p'       c,
    #3        c, \ Protocol Version Number
    #0        c, \ Connect Flags - Nothing special for now.
    #0        c, \ Keep Alive Timer MSB
    #10       c, \ LSB
    'Q'       c, \ === Payload - Just a client ID
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    'Q'       c,
    #0        c,

SOCK_FD my-message 40 SOCK_FD write-socket
close-socket
bye
