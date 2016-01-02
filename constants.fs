\ Message types

%00010000 CONSTANT MQ:CONNECT     \ Client request to connect to Server
%00100000 CONSTANT MQ:CONNACK     \ Connect Acknowledgment
%00110000 CONSTANT MQ:PUBLISH     \ Publish message
%01000000 CONSTANT MQ:PUBACK      \ Publish Acknowledgment
%01010000 CONSTANT MQ:PUBREC      \ Publish Received (assured delivery part 1)
%01100000 CONSTANT MQ:PUBREL      \ Publish Release (assured delivery part 2)
%01110000 CONSTANT MQ:PUBCOMP     \ Publish Complete (assured delivery part 3)
%10000000 CONSTANT MQ:SUBSCRIBE   \ Client Subscribe request
%10010000 CONSTANT MQ:SUBACK      \ Subscribe Acknowledgment
%10100000 CONSTANT MQ:UNSUBSCRIBE \ Client Unsubscribe request
%10110000 CONSTANT MQ:UNSUBACK    \ Unsubscribe Acknowledgment
%11000000 CONSTANT MQ:PINGREQ     \ PING Request
%11010000 CONSTANT MQ:PINGRESP    \ PING Response
%11100000 CONSTANT MQ:DISCONNECT  \ Client is Disconnecting

\ Quailty of Servive (QOS) levels

%000000000 CONSTANT MQ:AT-MOST-ONCE
%000000010 CONSTANT MQ:AT-LEAST-ONCE
%000000100 CONSTANT MQ:ONCE

\ DUP flag bit
%000001000 CONSTANT MQ:DUP
%000000000 CONSTANT MQ:NO-DUP

\ RETAIN flag bit (for readability)
%000000001 CONSTANT MQ:RETAIN
%000000000 CONSTANT MQ:NO-RETAIN
