\ Initialize a "symbol counter"
variable symbol-counter
\ It starts at 0 and grows for every symbol created.
0 symbol-counter !


: increment-symbol-counter
  1 symbol-counter +! ;

: fetch-symbol-counter
  symbol-counter @ ;

\ Increment the symbol counter and fetch its value.
: next-symbol
  increment-symbol-counter
  fetch-symbol-counter ;

\ Create a named symbol. Example `symbol pizza`.
: symbol
  create next-symbol ,
  DOES> @ ;
