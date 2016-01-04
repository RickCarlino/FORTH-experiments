INCLUDE object.fs
INCLUDE constants.fs

\ MQTT PACKET STRUCTURE
\ HTTP://PUBLIC.DHE.IBM.COM/SOFTWARE/DW/WEBSERVICES/WS-MQTT/MQTT-V3R1.HTML#MSG-FORMAT

MQ:OBJECT CLASS MQ:FIXED-HEADER
    METHOD TO-BINARY

    1 CHARS VAR FLAGS
    1 CHARS VAR LENGTH \ TODO Method to calculate this.

  HOW:

    : INIT ( MESSAGE-TYPE DUP-FLAG QOS-LEVEL RETAIN LENGTH -- SELF )
      LENGTH C! OR OR OR FLAGS C! ;

    : TO-BINARY ( -- 16 bits )
      FLAGS C@ 8 LSHIFT LENGTH C@ OR ;
CLASS;
