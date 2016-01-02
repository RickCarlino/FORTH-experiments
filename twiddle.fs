: ** ( n m -- n^m )
  1 swap  0 ?do over * loop  nip ;

: bits-wide ( n-bit-width -- u )
  2 swap ** 1 - ;

: minus-8 ( u-length -- u-minus-8 )
    8 swap - ;

: clear-left ( u-target u-length -- u )
  minus-8 lshift ;

: clear-right ( u-target u-length -- u )
  dup rot swap minus-8 rshift swap bits-wide and ;

2 base !
