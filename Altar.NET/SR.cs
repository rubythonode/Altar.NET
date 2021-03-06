﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Altar
{
    static class SR
    {
        internal readonly static string
            SPACE_S   = " " ,
            COLON     = ":" ,
            COLON_S   = ": ",
            ASTERISK  = "*" ,
            HASH      = "#" ,
            C_BRACE   = "}" ,
            COMMA_S   = ", ",
            C_BRACKET = "]" ,
            O_BRACKET = "[" ,
            DOT       = "." ,
            C_PAREN   = ")" ,
            O_PAREN   = "(" ,
            TILDE     = "~" ,
            DASH      = "-" ,
            PLUS      = "+" ,
            AMP       = "&" ,
            SLASH     = "/" ,
            EQUAL     = "==",
            GT        = ">" ,
            GTE       = ">=",
            NEQUAL    = "!=",
            LT        = "<" ,
            LTE       = "<=",
            MOD       = "%" ,
            VBAR      = "|" ,
            RIGHTSH   = ">>",
            LEFTSH    = "<<",
            XOR       = "^" ,

            INDENT4 = "    ",

            EQ_S = " = ",

            BRACKETS  = "[]",
            EMPTY_OBJ = "{}",
            HEX_PRE   = "0x",
            HEX_FM8   = "X8",
            HEX_FM6   = "X6",

            DOUBLE_L = "d",
            SINGLE_L = "f",
            SHORT_L  = "s",
            LONG_L   = "L",

            TRUE  = "true"  ,
            FALSE = "false" ,
            NULL  = "<null>",

            DATA_WIN = "data.win",

            EXT_TXT     = ".txt" ,
            EXT_JSON    = ".json",
            EXT_PNG     = ".png" ,
            EXT_WAV     = ".wav" ,
            EXT_GML_ASM = ".gml.asm",
            EXT_GML_LSP = ".gml.lsp",

            FILE_STR = "strings.json",
            FILE_VAR = "vars.json"   ,
            FILE_FNS = "funcs.json"  ,

            DIR_TEX  = "texture/",
            DIR_TXP  = "texpage/",
            DIR_WAV  = "audio/"  ,
            DIR_SND  = "sound/"  ,
            DIR_ROOM = "room/"   ,
            DIR_OBJ  = "object/" ,
            DIR_BG   = "bg/"     ,
            DIR_CODE = "code/"   ,
            DIR_SCR  = "script/" ,
            DIR_SPR  = "sprite/" ,
            DIR_FNT  = "font/"   ,
            DIR_PATH = "path/"   ,

            VAR  = "var" ,
            INST = "inst",
            BOOL = "bool",
            STOG = "stog",

            CALL  = "call "  ,
            IFF   = "if !"   ,
            IFT   = "if "    ,
            GOTO  = "goto "  ,
            PUSHE = "pushenv",
            POPE  = "popenv" ,
            PUSH  = "push "  ,
            POP   = "pop"    ,
            DUP   = "dup"    ,
            BREAK = "break " ,
            RET_S = "ret "   ,
            EXIT  = "exit"   ,

            REMAIN = "rem"        ,
            ASSERT = "assert_neq:",

            ERR_NO_FORM   = "No 'FORM' header.",
            ERR_FILE_NF_1 = "File \""          ,
            ERR_FILE_NF_2 = "\" not found."    ;
    }
}
