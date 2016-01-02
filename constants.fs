1  CONSTANT MQ:CONNECT       \ Client request to connect to Server
2  CONSTANT MQ:CONNACK       \ Connect Acknowledgment
3  CONSTANT MQ:PUBLISH       \ Publish message
4  CONSTANT MQ:PUBACK        \ Publish Acknowledgment
5  CONSTANT MQ:PUBREC        \ Publish Received (assured delivery part 1)
6  CONSTANT MQ:PUBREL        \ Publish Release (assured delivery part 2)
7  CONSTANT MQ:PUBCOMP       \ Publish Complete (assured delivery part 3)
8  CONSTANT MQ:SUBSCRIBE     \ Client Subscribe request
9  CONSTANT MQ:SUBACK        \ Subscribe Acknowledgment
10 CONSTANT MQ:UNSUBSCRIBE   \ Client Unsubscribe request
11 CONSTANT MQ:UNSUBACK      \ Unsubscribe Acknowledgment
12 CONSTANT MQ:PINGREQ       \ PING Request
13 CONSTANT MQ:PINGRESP      \ PING Response
14 CONSTANT MQ:DISCONNECT    \ Client is Disconnecting

\ Quailty of Servive (QOS) levels

0 CONSTANT MQ:AT-MOST-ONCE
1 CONSTANT MQ:AT-LEAST-ONCE
2 CONSTANT MQ:ONCE

\ DUP flag bit (for readability)
-1 CONSTANT MQ:DUP
0  CONSTANT MQ:NO-DUP

\ RETAIN flag bit (for readability)
-1 CONSTANT MQ:RETAIN
0  CONSTANT MQ:NO-RETAIN
