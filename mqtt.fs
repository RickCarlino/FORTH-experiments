\ TODO : Looks like all the parse-name strings
\ will get overwritten at some point?

BEGIN-STRUCTURE mqtt-server
   CFIELD: ->reconnect
    FIELD: ->host-length
    FIELD: ->host-addr
    FIELD: ->host-port
    FIELD: ->user-id-length
    FIELD: ->user-id
    FIELD: ->keep-alive
END-STRUCTURE

CREATE current-server 1 cells allot
variable default-server mqtt-server

: mqtt-server:
  CREATE mqtt-server allot
  current-server ! ;

: mqtt-server;
  current-server default-server ! ;

: host-addr!
  current-server ->host-length !  ;

: host-length! ( u-hostname-len -- )
  current-server ->host-length !  ;

: host: ( "host" --- )
 parse-name host-length! host-addr! ;

: port: ( "host" --- )
 \ ================ WIP
  ;

mqtt-server: central-hub
  host: localhost
\  port: 8883
mqtt-server;

bye
\   user-id: ForthyMcForthster
\   keep-alive: 10 \ seconds
\   reconnect: yes
\ mqtt-server;

\ central-hub connect

\ 10 second interval ping

\ variable temp

\ 23 temp !

\ temp 1 chars publish temperature/warehouse/a1b

\ : process-temperature ( addr lenth --)
\  \ Theoretical
\ ;

\ subscribe temperature/waiting_room process-temperature
