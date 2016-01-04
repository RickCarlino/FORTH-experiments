%00010000 c, \ Header
#18       c, \ Length - fixed header length of 2
#0        c, \ Protocol Length byte 1
#6        c, \ Protocol Length byte 2
'M'       c, \ Protocol ID
'Q'       c,
'I'       c,
's'       c,
'd'       c,
'p'       c,
#3        c, \ Protocol Version
#0        c, \ Connect Flags
#0        c, \ Keep alive byte 1
#30       c, \ Keep alive byte 2
#0        c, \ Client ID Length byte 2
#4        c, \ Client ID length byte 1
'F'       c, \ Client ID string
'O'       c,
'R'       c,
'H'       c,
