include ttester.fs

: ** \ ( n m -- n^m )
  #1 swap #0 ?do over * loop nip ;

T{ 2 1 ** -> 2  }T
T{ 2 2 ** -> 4  }T
T{ 3 3 ** -> 27 }T

: bits-wide \ ( n-bit-width -- u )
  #2 swap ** #1 - ;

T{ #1 bits-wide -> %1       }T
T{ #3 bits-wide -> %111     }T
T{ #7 bits-wide -> %1111111 }T

: truncate-to-one-byte
  #8 bits-wide and ;

T{ %1         truncate-to-one-byte -> %1        }T
T{ %101010101 truncate-to-one-byte -> %1010101  }T
T{ %111111111 truncate-to-one-byte -> %11111111 }T

: left ( u-target u-times -- u )
  lshift truncate-to-one-byte ;

: right \ ( u-target u-length -- u )
  rshift truncate-to-one-byte ;

: left-right { target left right -- n-slice }
  right target left left swap right ;

bye
