namespace Server.Model

type AppConfig =
    {
    QuickFixConfigFile: string
    }

type PriceSide = | Bid | Ask

type Connection = interface end

type LogMsg = 
    | FixEvent of string 
    | FixMsgOutgoing of string
    | FixMsgIncoming of string

