: ** \ ( n m -- n^m )
  #1 swap #0 ?do over * loop  nip ;

: bits-wide \ ( n-bit-width -- u )
  #2 swap ** #1 - ;

: truncate-to-one-byte
  #8 bits-wide and ;

: left \ ( u-target u-times -- u )
  lshift truncate-to-one-byte ;

: right \ ( u-target u-length -- u )
  rshift truncate-to-one-byte ;

: left-right { target left right -- n-slice }
  right target left left swap right
;
