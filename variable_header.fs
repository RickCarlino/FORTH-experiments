INCLUDE object.fs
INCLUDE constants.fs

\ MQTT PACKET STRUCTURE
\ HTTP://PUBLIC.DHE.IBM.COM/SOFTWARE/DW/WEBSERVICES/WS-MQTT/MQTT-V3R1.HTML#MSG-FORMAT

MQ:OBJECT CLASS MQ:VARIABLE-HEADER
    METHOD TO-BINARY

    1 CHARS VAR WHATEVER

  HOW:

    : INIT ( MESSAGE-TYPE DUP-FLAG QOS-LEVEL RETAIN LENGTH -- SELF )
      LENGTH C! OR OR OR FLAGS C! ;
CLASS;