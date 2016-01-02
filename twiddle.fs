: ** \ ( n m -- n^m )
  1 swap  0 ?do over * loop  nip ;

: bits-wide \ ( n-bit-width -- u )
  #2 swap ** #1 - ;

: truncate-to-one-byte
  #8 bits-wide and ;

: push-left \ ( u-target u-times -- u )
  lshift truncate-to-one-byte ;

: push-right \ ( u-target u-length -- u )
  rshift truncate-to-one-byte ;

2 base !
cr

: bit-slice { target left right -- n-slice }
  right target left push-left swap push-right
;


00101000 #2 #5 bit-slice .
00101001 #2 #5 bit-slice .
00101010 #2 #5 bit-slice .
00101011 #2 #5 bit-slice .
00101100 #2 #5 bit-slice .
00101101 #2 #5 bit-slice .
00101111 #2 #5 bit-slice .
01101110 #2 #5 bit-slice .
10101010 #2 #5 bit-slice .
11101111 #2 #5 bit-slice .

bye
