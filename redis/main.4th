include unix/socket.fs
marker --Redis

\ Stack Juggles ========================================================== \
    : 123->321 swap rot ;

\ STRINGS AND CONSTANTS ================================================== \

    : HOST ( -- Address Length ) s" localhost" ;
    6379                  constant PORT
    HOST PORT open-socket constant Redis

    \ Write to the Redis file descriptor.
    \ Example: `s" set foo 123" Redis!`
    : Redis! ( Address Length -- )
        Redis write-socket ;

    \ TODO: Fix this one.
    : Redis@ ( Address MaxLength -- )
        Redis 123->321 read-socket ;

\ TRY STUFF ============================================================== \

    s\" set foo 123\n" Redis!
    s\" get foo\n"     Redis!

    Redis pad 10 read-socket
    pad 10 dump

    bye
