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

: process-temperature (addr lenth --)
 \ Theoretical
;

subscribe temperature/waiting_room process-temperature
