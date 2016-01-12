\ A struct with all the relevant data for an MQTT connection.
BEGIN-STRUCTURE mqtt-server
   CFIELD: ->reconnect
    FIELD: ->host-length
    FIELD: ->host-addr
    FIELD: ->host-port
    FIELD: ->user-id-length
    FIELD: ->user-id
    FIELD: ->keep-alive
    FIELD: ->reconnect
END-STRUCTURE

\ Set the "current-server" pointer to "default-server".
CREATE current-server 1 cells allot
variable default-server mqtt-server

mqtt-server
\ Define a new word/variable and point the current-server pointer at it.
: mqtt-server:
  CREATE mqtt-server allot
  current-server ! ;

: mqtt-server;
  current-server default-server ! ;

\ The server pointer has to point to *something*. It will point to
\ default-server if no address is given.
mqtt-server: default-server

: host! ( u-hostname-ptr u-hostname-len -- )
 ;

\ =STOPPED HERE====================================
: host: ( "host" --- )
 parse-name host! ;


mqtt-server: central-hub
  host: localhost
  port: 8883
  user-id: ForthyMcForthster
  keep-alive: 10 \ seconds
  reconnect: yes
mqtt-server;

central-hub connect

10 second interval ping

variable temp

23 temp !

temp 1 chars publish temperature/warehouse/a1b

: process-temperature ( addr lenth --)
 \ Theoretical
;

subscribe temperature/waiting_room process-temperature
