﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * File : Error
 * Author : Filipe
 * Date : 06/02/2014 18:52:37
 * Description :
 * Error codes from uXinEmu emulator ! :) (Thanks)
 */

namespace Meteor.Source
{
    public enum Error
    {
        CERT_OK = 200,
        CERT_ERR = 511,
        CERT_NOBALANCE = 512,
        CERT_ACCBLOCKED = 422,
        CERT_IPBLOCKED = 410,
        ERR_SUCCESS = 1000,
        ERR_SERVER_BUSY = 1001,
        ERR_ACCOUNT_EXIST = 1002,
        ERR_PASSWORD = 1003,
        ERR_ACCOUNT = 1004,
        ERR_TIME_OUT = 1005,
        ERR_BLOCKED = 1006,
        ERR_VERSION_TOO_LOW = 1007,
        ERR_PLAYER_EXIST = 1009,
        ERR_PLAYER_NOT_EXIST = 1010,
        CHANGENAME_OK = 1011,
        ERR_MAINTAIN = 1012,
        ERR_NEEDECARD = 1013,
        ERR_IP_TIMEOUT = 1014,
        ERR_QUERY_IP = 1015,
        ERR_NEED_EKEY = 1016,
        ERR_VERSION_MAINTAIN = 1017,
        ERR_UNDEL_FORCEMEMBER = 1030,
        ERR_UNDEL_FAMILYMEMBER = 1031,
        ERR_UNDEL_APPLYING = 1032,
        ERR_UNDEL_CREDIT_ARREARAGE = 1033,
        ERR_SERVERREBOOT = 1034,
        ERR_RENAME_KICK = 1035,
        ERR_FAMILYNAME_EXIST = 1036,
        ERR_NO_SOCK = 1037,
        ERR_NOLOGIN = 1038,
        ERR_NOCREATE = 1039,
        ERR_MERGE_NOCREATE = 1040,
        ERR_CHEAT_NOTICE = 1041,
        ERR_NOCREATE_ALL = 1042,
        ERR_BF_STATE = 1045,
        ERR_SELF_DISCONNECT = 1100,
        ERR_QUIT_QUEUE = 1101,
        ERR_QUIT_LOGOUT = 1102,
        ERR_QUIT_CERTIFY = 1103,
        ERR_QUIT_SELECT_CHAR = 1104,
        ERR_QUIT_SEND_CERTIFY = 1105,
        ERR_QUIT_ANTI_ADDICTION = 1106,
        ERR_QUIT_EKEY = 1107,
        ERR_QUIT_ECARD = 1108,
        CERT_CHARGE_CERTIFY_FAILED = 401,
        CERT_CHARGE_DEBT = 402,
        CERT_CHARGE_FROZEN = 403,
        CERT_CHARGE_NOT_ACTIVATED = 404,
        CERT_CHARGE_EKEY = 410,
        CERT_CHARGE_SUCEED = 200,
        ERR_ECARD_LIST_FULL = 2001,
        ERR_EKEY_USER_INVALID = 2002,
        ERR_ECARD_CODE_INVALID = 2003,
        ERR_MOBILE_PHONE_LOCK = 2004,
        ERR_EKEY_NEED_LOGIN = 2005,

        // Custom error
        ERR_CERT_VERSION = 10000,
        ERR_CERT_BAD_USERNAME = 10001,
        ERR_CERT_BAD_PASSWORD = 10002
    }
}
